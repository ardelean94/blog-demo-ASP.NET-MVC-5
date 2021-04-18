using Blog_Demo.Models;
using Blog_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;

namespace Blog_Demo.Controllers
{
    public class PostsController : Controller
    {
        ApplicationDbContext _context;

        public PostsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Posts
        [AllowAnonymous]
        public ActionResult Index()
        {
            var posts = _context.Posts.Include(p => p.PostType).ToList();

            if (User.IsInRole(RoleName.CanManagePost))
            {    
                return View("Index", posts);
            }

            return View("ReadOnlyView", posts);

        }

        //GET: Posts/id
        [AllowAnonymous]
        public ActionResult ViewPost(int id)
        {
            var post = _context.Posts.Single(p => p.Id == id);

            if (post == null)
                return HttpNotFound();

            return View("ViewPost", post);
        }

        //New Post
        [Authorize(Roles = RoleName.CanManagePost)]
        public ActionResult New()
        {
            var postTypes = _context.PostTypes.ToList();
            var viewModel = new PostsTypesViewModel
            {
                PostTypes = postTypes,
                Posts = new Posts()
            };

            return View("PostForm", viewModel);
        }


        [HttpPost]
        public ActionResult Save(PostsTypesViewModel post)
        {
            //input validation
            if (!ModelState.IsValid)
            {
                var viewModel = new PostsTypesViewModel
                {
                    Posts = post.Posts,
                    PostTypes = _context.PostTypes.ToArray()
                };
                return View("PostForm", viewModel);
            }

            if (post.Posts.Id == 0)    //new post
            {
                post.Posts.PostType = _context.PostTypes.Single(t => t.Id == post.Posts.PostType.Id);
                _context.Posts.Add(post.Posts);
            }
                

            else
            {   //existing post
                var postInDb = _context.Posts.Include(p => p.PostType).Single(p => p.Id == post.Posts.Id);
                postInDb.PostType = _context.PostTypes.Single(t => t.Id == post.Posts.PostType.Id);

                postInDb.Name = post.Posts.Name;
                postInDb.PostType = postInDb.PostType;
                postInDb.Author = post.Posts.Author;
                postInDb.Description = post.Posts.Description;
                postInDb.NoOfLikes = 0;
                postInDb.IsPublished = false;
            }
            
            
            _context.SaveChanges();


            return RedirectToAction("Index", "Posts");
        }

        public ActionResult Edit(int id)
        {
            var postInDb = _context.Posts.Include(p => p.PostType).Single(p => p.Id == id);

            if (postInDb == null)
                return HttpNotFound();

            var viewModel = new PostsTypesViewModel
            {
                Posts = postInDb,
                PostTypes = _context.PostTypes
            };

            return View("PostForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var postInDb = _context.Posts.Single(p => p.Id == id);

            if (postInDb == null)
                return HttpNotFound();

            _context.Posts.Remove(postInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Posts");
        }
    }
}