using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videogames.Admin.Models.Common.Videogames.CreateEdit;
using Videogames.Admin.Models.Common.Videogames.Delete;
using Videogames.Admin.Models.Common.Videogames.Item;
using Videogames.Admin.Models.Common.Videogames.List;
using Videogames.Admin.Models.Common.Videogames.Validator;

namespace Videogames.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideogamesController : ControllerBase
    {
        private readonly IVideogameFormHandler videogameFormHandler;
        private readonly IVideogameItemModelBuilder videogameItemModelBuilder;
        private readonly IVideogameListModelBuilder videogameListModelBuilder;
        private readonly IVideogameDeleteHandler videogameDeleteHandler;
        private readonly IVideogameValidator videogameValidator;
        public VideogamesController(IVideogameFormHandler videogameFormHandler, IVideogameItemModelBuilder videogameItemModelBuilder,
            IVideogameListModelBuilder videogameListModelBuilder, IVideogameDeleteHandler videogameDeleteHandler,
            IVideogameValidator videogameValidator)
        {
            this.videogameFormHandler = videogameFormHandler;
            this.videogameItemModelBuilder = videogameItemModelBuilder;
            this.videogameListModelBuilder = videogameListModelBuilder;
            this.videogameDeleteHandler = videogameDeleteHandler;
            this.videogameValidator = videogameValidator;
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
            var validatorResult = videogameValidator.Validate(form);

            if (validatorResult.isValid)
            {
                videogameFormHandler.HandleCreate(form);
                return Ok();
            } 
            else
            {
                return BadRequest(validatorResult.Errors);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, [FromBody] VideogameForm form)
        {
            videogameFormHandler.HandleEdit(id, form);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            videogameDeleteHandler.HandleDelete(id);
            return Ok();
        }


    }
}
