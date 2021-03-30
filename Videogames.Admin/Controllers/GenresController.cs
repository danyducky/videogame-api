using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videogames.Admin.Models.Common.Genres.CreateEdit;

namespace Videogames.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreStructureFormHandler genreStructureFormHandler;
        public GenresController(IGenreStructureFormHandler genreStructureFormHandler)
        {
            this.genreStructureFormHandler = genreStructureFormHandler;
        }


        [HttpGet]
        public IActionResult getGenresList()
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult createGenre([FromBody] GenreStructureForm form)
        {
            if (form == null) return BadRequest("form is null");
            var createdId = genreStructureFormHandler.HandleCreate(form);

            return Ok(createdId);
        }


    }
}
