using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videogames.Admin.Models.Common.Videogames.CreateEdit;
using Videogames.Admin.Models.Common.Videogames.Item;

namespace Videogames.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideogamesController : ControllerBase
    {
        private readonly IVideogameFormHandler videogameFormHandler;
        private readonly IVideogameItemModelBuilder videogameItemModelBuilder;
        public VideogamesController(IVideogameFormHandler videogameFormHandler, IVideogameItemModelBuilder videogameItemModelBuilder)
        {
            this.videogameFormHandler = videogameFormHandler;
            this.videogameItemModelBuilder = videogameItemModelBuilder;
        }


        [HttpGet]
        public IActionResult List()
        {
            return Ok();
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
        public IActionResult Edit([FromRoute] int id)
        {
            return Ok();
        }


    }
}
