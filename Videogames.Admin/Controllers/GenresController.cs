using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videogames.Admin.Models.Common.Genres.CreateEdit;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.Admin.Models.Common.Genres.List;

namespace Videogames.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreStructureFormHandler genreStructureFormHandler;
        private readonly IGenreListModelBuilder genreListModelBuilder;
        private readonly IGenreItemModelBuilder genreItemModelBuilder;
        public GenresController(IGenreStructureFormHandler genreStructureFormHandler, IGenreListModelBuilder genreListModelBuilder,
            IGenreItemModelBuilder genreItemModelBuilder)
        {
            this.genreStructureFormHandler = genreStructureFormHandler;
            this.genreListModelBuilder = genreListModelBuilder;
            this.genreItemModelBuilder = genreItemModelBuilder;
        }


        [HttpGet]
        public IActionResult List()
        {
            return Ok(genreListModelBuilder.Build());
        }

        
        [HttpGet("{id}")]
        public IActionResult Item([FromRoute] int id)
        {
            return Ok(genreItemModelBuilder.Build(id));
        }


        [HttpPost]
        public IActionResult Create([FromBody] GenreForm form)
        {
            if (form == null) return BadRequest("form is null");
            var createdId = genreStructureFormHandler.HandleCreate(form);

            return Ok(createdId);
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, [FromBody] GenreForm form)
        {
            genreStructureFormHandler.HandleEdit(id, form);
            return Ok();
        }


    }
}
