using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videogames.Admin.Models.Common.Developers.CreateEdit;
using Videogames.Admin.Models.Common.Developers.Delete;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.Admin.Models.Common.Developers.List;

namespace Videogames.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        private readonly IDeveloperFormHandler developerFormHandler;
        private readonly IDeveloperItemModelBuilder developerItemModelBuilder;
        private readonly IDeveloperListModelBuilder developerListModelBuilder;
        private readonly IDeveloperDeleteHandler developerDeleteHandler;
        public DevelopersController(IDeveloperFormHandler developerFormHandler, IDeveloperItemModelBuilder developerItemModelBuilder,
            IDeveloperListModelBuilder developerListModelBuilder, IDeveloperDeleteHandler developerDeleteHandler)
        {
            this.developerFormHandler = developerFormHandler;
            this.developerItemModelBuilder = developerItemModelBuilder;
            this.developerListModelBuilder = developerListModelBuilder;
            this.developerDeleteHandler = developerDeleteHandler;
        }


        [HttpGet]
        public IActionResult List()
        {
            return Ok(developerListModelBuilder.Build());
        }

        [HttpGet("{Id}")]
        public IActionResult Item([FromRoute] int id)
        {
            return Ok(developerItemModelBuilder.Build(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] DeveloperForm form)
        {
            var id = developerFormHandler.HandleCreate(form);

            return Ok(id);
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, [FromBody] DeveloperForm form)
        {
            developerFormHandler.HandleEdit(id, form);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            developerDeleteHandler.HandleDelete(id);
            return Ok();
        }

    }
}
