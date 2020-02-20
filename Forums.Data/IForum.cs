using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Forum.Data.Models;

namespace Forum.Data
{
    public interface IForum
    {
        AppForum GetById(int id);
        IEnumerable<AppForum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(AppForum appForum);
        Task Delete(AppForum appForum);
        Task UpdateForumTitle(int appForumId, string newTitle);
        Task UpdateForumDescription(int appForumId, string newDescription);


    }
}
