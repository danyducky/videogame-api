using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videogames.Admin.Models.Common.Developers.CreateEdit;
using Videogames.Admin.Models.Common.Developers.Item;
using Videogames.Admin.Models.Common.Developers.List;

namespace Videogames.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        private readonly IDeveloperStructureFormHandler developerStructureFormHandler;
        private readonly IDeveloperItemModelBuilder developerItemModelBuilder;
        private readonly IDeveloperListModelBuilder developerListModelBuilder;
        public DevelopersController(IDeveloperStructureFormHandler developerStructureFormHandler, IDeveloperItemModelBuilder developerItemModelBuilder,
            IDeveloperListModelBuilder developerListModelBuilder)
        {
            this.developerStructureFormHandler = developerStructureFormHandler;
            this.developerItemModelBuilder = developerItemModelBuilder;
            this.developerListModelBuilder = developerListModelBuilder;
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
            var id = developerStructureFormHandler.HandleCreate(form);

            return Ok(id);
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, [FromBody] DeveloperForm form)
        {
            developerStructureFormHandler.HandleEdit(id, form);
            return Ok();
        }

    }
}
