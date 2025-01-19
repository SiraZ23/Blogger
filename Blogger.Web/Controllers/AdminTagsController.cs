using Blogger.Web.Data;
using Blogger.Web.Models.Domain;
using Blogger.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Blogger.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BloggerDbContext dbContext;

        public AdminTagsController(BloggerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public async Task<IActionResult> Add(AddTagRequest addTagRequest)
        {
            //Mapping AddTagRequest To Tag Domain Model
            var tag = new Tag
            {
                Name=addTagRequest.Name,
                DisplayName=addTagRequest.DisplayName
            };
           await dbContext.Tags.AddAsync(tag);
            await dbContext.SaveChangesAsync(); 
            return View("Add");
        }
    }
}
