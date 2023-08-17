using HomeTaskMVC2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeTaskMVC2.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;

        public CarController()
        {
            _cars = new()
            {
            new(){Id=1,CarName="X7-2022-Mpacket",ModelId=1},
                 new(){Id=2,CarName="E300-2023",ModelId=2},
                      new(){Id=3,CarName="Camry-Electric",ModelId=3},
                           new(){Id=4,CarName="Mustang-Red",ModelId=4},
                                  new(){Id=5,CarName="E300-Brabus",ModelId=2},
            };
        }
        public IActionResult Index(int?id)
        {
            if (id == null) return BadRequest();
            if (_cars.Exists(m => m.ModelId == id))
            {
                return View(_cars.FindAll(m => m.ModelId == id));

            }
            return NotFound();
        }
    }
}
