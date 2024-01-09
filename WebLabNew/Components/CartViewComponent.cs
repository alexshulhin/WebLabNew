using Microsoft.AspNetCore.Mvc;

namespace WebLabNew.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
