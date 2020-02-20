using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Data.Models;
using Forum.Models.Forum;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    public class AppForumController : Controller
    {

        private readonly IForum _forumService;

        public AppForumController(IForum forumService)
        {
            _forumService = forumService;
        }
        public IActionResult Index()
        {
            IEnumerable<ForumListingModel> forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel
                {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description
                });

            var model = new ForumIndexModel()
            {
                ForumList = forums
            };
            return View(model);
        }
    }

 
}