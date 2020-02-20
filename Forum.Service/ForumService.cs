﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.Service
{
    /* summary
     service layer to interact with the database. take data and serve it to the web project controllers.

     */

    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;

        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }
        public AppForum GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AppForum> GetAll()
        {
            return _context.Forums
                .Include(forum => forum.Posts);
        }

        public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Task Create(AppForum appForum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(AppForum appForum)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int appForumId, string newTitle)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumDescription(int appForumId, string newDescription)
        {
            throw new NotImplementedException();
        }
    }
}
