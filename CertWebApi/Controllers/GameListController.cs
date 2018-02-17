using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CertWebApi.Command;
using Microsoft.AspNetCore.Mvc;

namespace CertWebApi.Controllers
{
    [Route("api/[controller]")]
    public class GameListController : Controller
    {
        [HttpGet]
        public IActionResult GetFirstGame()
        {
            return Json(new GameCommand { Name = "Bloodbourne", Price = 80.0f, NeedLevel = NeedLevel.OVER_EXITED});
        }

        [HttpPost]
        public IActionResult AddGame([FromBody] GameCommand newGame)
        {
            return Json($"Okay, I am going to add this new game {newGame.Name} to your list");
        }
    }
}
