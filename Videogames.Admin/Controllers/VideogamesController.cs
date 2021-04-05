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

        /// <summary>
        /// Метод для вывода списка всех видеоигр
        /// </summary>
        /// <returns>Список видеоигр</returns>
        [HttpGet]
        public IActionResult List()
        {
            return Ok(videogameListModelBuilder.Build());
        }

        /// <summary>
        /// Метод для вывода конкретного элемента из списка игр
        /// </summary>
        /// <param name="id">Идентификатор видеоигры</param>
        /// <returns>Информация об одной видеоигре</returns>
        [HttpGet("{id}")]
        public IActionResult Item([FromRoute] int id)
        {
            return Ok(videogameItemModelBuilder.Build(id));
        }

        /// <summary>
        /// Метод для создания видеоигры
        /// </summary>
        /// <param name="form">Форма видеоигры</param>
        /// <returns>200 при успехе, 400 при ошибке валидации</returns>
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

        /// <summary>
        /// Метод для редактирования существующей видеоигры
        /// </summary>
        /// <param name="id">Идентификатор видеоигры</param>
        /// <param name="form">Форма видеоигры</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, [FromBody] VideogameForm form)
        {
            videogameFormHandler.HandleEdit(id, form);
            return Ok();
        }

        /// <summary>
        /// Метод для удаления видеоигры
        /// </summary>
        /// <param name="id">Идентификатор видеоигры</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            videogameDeleteHandler.HandleDelete(id);
            return Ok();
        }


    }
}
