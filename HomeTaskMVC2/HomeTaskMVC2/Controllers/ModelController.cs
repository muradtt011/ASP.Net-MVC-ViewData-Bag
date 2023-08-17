using HomeTaskMVC2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeTaskMVC2.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new()
            {
            new(){Id=1,ModelName="X7",MarkaId=1},
                 new(){Id=2,ModelName="E300",MarkaId=2},
                      new(){Id=3,ModelName="Camry",MarkaId=3},
                           new(){Id=4,ModelName="Mustang",MarkaId=4},
            };
        }




        public IActionResult Index(int?id)
        {
            if (id == null) return BadRequest();
            if(_models.Exists(m => m.MarkaId == id))
            {
                return View(_models.FindAll(m=> m.MarkaId == id));

            }
            return NotFound();
        }
    }
}
