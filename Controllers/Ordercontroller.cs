using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class Ordercontroller : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}
