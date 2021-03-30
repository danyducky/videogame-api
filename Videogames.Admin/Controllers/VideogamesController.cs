//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Videogames.Admin.Models.Common.Videogames.CreateEdit;

//namespace VideogamesWebApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class VideogamesController : ControllerBase
//    {
//        private readonly IVideogameModelHandler videoGameModelHandler;
//        public VideogamesController(IVideogameModelHandler videoGameModelHandler)
//        {
//            this.videoGameModelHandler = videoGameModelHandler;
//        }


//        [HttpGet]
//        public async Task<IActionResult> getVideogames([FromQuery(Name = "genre")] string genre)
//        {

//        }


//        [HttpGet("{id}")]
//        public IActionResult getVideogame([FromRoute] int Id)
//        {

//        }


//        [HttpPost]
//        public IActionResult createVideogame([FromBody]object json)
//        {
//            if (json == null) return BadRequest("Body is null");



//            return Ok("Success");
//        }

//        [HttpPut("{id}")]
//        public IActionResult updateVideogame([FromRoute] int Id, [FromBody] VideogameViewModel videogame)
//        {

//        }

//        [HttpDelete("{id}")]
//        public IActionResult deleteVideogame([FromRoute] int Id)
//        {

//        }

//    }
//}
