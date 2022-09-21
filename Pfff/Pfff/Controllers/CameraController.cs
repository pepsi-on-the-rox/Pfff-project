using Microsoft.AspNetCore.Mvc;
using Pfff.Data;

namespace Pfff.Controllers
{
    public class CameraController : Controller
    {
        private readonly AppDbContext database;

        public CameraController(AppDbContext database)
        {
            this.database = database;
        }

        //public IActionResult Index()
        //{
            
            //IEnumerable<Camera> objCameraList = database.cameras;
            //return View(objCameraList);
        //}
    }
}
