using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideogamesWebApi.Interfaces;
using VideogamesWebApi.Models;
using VideogamesWebApi.Viewmodels;

namespace VideogamesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideogamesController : ControllerBase
    {
        ApplicationContext db;
        IVideogame Videogame;
        public VideogamesController(ApplicationContext _db, IVideogame _videogame)
        {
            db = _db;
            Videogame = _videogame;
        }


        [HttpGet]
        public async Task<IActionResult> getVideogames([FromQuery(Name = "genre")] string genre)
        {

            if (genre == null)
            {
                return Ok(await Videogame.GetVideogames());
            }

            List<Videogame> result = new List<Videogame>();
            List<Videogame> games = await Videogame.GetVideogames();
            foreach (Videogame game in games)
            {
                List<string> GenreList = JsonConvert.DeserializeObject<List<string>>(game.Genres);
                if (GenreList.Exists(g => g == genre))
                {
                    result.Add(game);
                }
            }

            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult getVideogame([FromRoute] int Id)
        {
            Videogame game = Videogame.GetVideogame(Id);
            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }
        

        [HttpPost]
        public IActionResult createVideogame(VideogameViewModel videogame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(videogame);
            }

            string GenreList = JsonConvert.SerializeObject(videogame.Genres);

            Videogame result = new Videogame
            {
                Name = videogame.Name,
                Developer = videogame.Developer,
                Genres = GenreList
            };

            Videogame.Create(result);
            Videogame.Save();


            return StatusCode(201); // Created
        }

        [HttpPut("{id}")]
        public IActionResult updateVideogame([FromRoute] int Id, [FromBody]VideogameViewModel videogame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(videogame);
            }

            string GenreList = JsonConvert.SerializeObject(videogame.Genres);

            Videogame result = new Videogame
            {
                Id = Id,
                Name = videogame.Name,
                Developer = videogame.Developer,
                Genres = GenreList
            };

            Videogame.Update(result);
            Videogame.Save();

            return Ok(); //Successfully
        }

        [HttpDelete("{id}")]
        public IActionResult deleteVideogame([FromRoute] int Id)
        {
            Videogame videogame = db.Videogames.Find(Id);
            if (videogame == null)
            {
                return NotFound();
            }

            Videogame.Delete(videogame);
            Videogame.Save();

            return Ok(); // Successfully
        }

    }
}
