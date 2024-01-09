using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebLabNew.Entities;

namespace WebLabNew.Controllers
{
    public class ImageController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        IWebHostEnvironment _env;

        public ImageController(UserManager<ApplicationUser>
userManager, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _env = env;
        }

        public async Task<FileResult> GetAvatar()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user.AvatarImage != null)
                return File(user.AvatarImage, "image/...");
            else
            {
                var avatarPath = "/Images/anonymous.png";

                return File(_env.WebRootFileProvider.GetFileInfo(avatarPath)
                    .CreateReadStream(), "image/...");
            }
        }
    }

}
