using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videogames.Admin.Models.Common.Videogames.CreateEdit;
using Videogames.Admin.Models.Common.Videogames.Item;
using Videogames.Admin.Models.Common.Videogames.List;

namespace Videogames.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideogamesController : ControllerBase
    {
        private readonly IVideogameFormHandler videogameFormHandler;
        private readonly IVideogameItemModelBuilder videogameItemModelBuilder;
        private readonly IVideogameListModelBuilder videogameListModelBuilder;
        public VideogamesController(IVideogameFormHandler videogameFormHandler, IVideogameItemModelBuilder videogameItemModelBuilder,
            IVideogameListModelBuilder videogameListModelBuilder)
        {
            this.videogameFormHandler = videogameFormHandler;
            this.videogameItemModelBuilder = videogameItemModelBuilder;
            this.videogameListModelBuilder = videogameListModelBuilder;
        }


        [HttpGet]
        public IActionResult List()
        {
            return Ok(videogameListModelBuilder.Build());
        }

        [HttpGet("{id}")]
        public IActionResult Item([FromRoute] int id)
        {
            return Ok(videogameItemModelBuilder.Build(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody]VideogameForm form)
        {
            videogameFormHandler.HandleCreate(form);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, [FromBody] VideogameForm form)
        {
            videogameFormHandler.HandleEdit(id, form);
            return Ok();
        }


    }
}
