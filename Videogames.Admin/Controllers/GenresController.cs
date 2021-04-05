using Microsoft.AspNetCore.Mvc;
using Videogames.Admin.Models.Common.Genres.CreateEdit;
using Videogames.Admin.Models.Common.Genres.Delete;
using Videogames.Admin.Models.Common.Genres.Item;
using Videogames.Admin.Models.Common.Genres.List;

namespace Videogames.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreFormHandler genreFormHandler;
        private readonly IGenreListModelBuilder genreListModelBuilder;
        private readonly IGenreItemModelBuilder genreItemModelBuilder;
        private readonly IGenreDeleteHandler genreDeleteHandler;
        public GenresController(IGenreFormHandler genreFormHandler, IGenreListModelBuilder genreListModelBuilder,
            IGenreItemModelBuilder genreItemModelBuilder, IGenreDeleteHandler genreDeleteHandler)
        {
            this.genreFormHandler = genreFormHandler;
            this.genreListModelBuilder = genreListModelBuilder;
            this.genreItemModelBuilder = genreItemModelBuilder;
            this.genreDeleteHandler = genreDeleteHandler;
        }


        /// <summary>
        /// Метод для вывода списка жанров
        /// </summary>
        /// <returns>Список жанров</returns>
        [HttpGet]
        public IActionResult List()
        {
            return Ok(genreListModelBuilder.Build());
        }

        /// <summary>
        /// Метод для вывода элемента из списка жанров
        /// </summary>
        /// <param name="id">Идентификатор жанра</param>
        /// <returns>Информация об одном жанре</returns>
        [HttpGet("{id}")]
        public IActionResult Item([FromRoute] int id)
        {
            return Ok(genreItemModelBuilder.Build(id));
        }

        /// <summary>
        /// Метод для создания нового жанра
        /// </summary>
        /// <param name="form">Форма жанра</param>
        /// <returns>Идентификатор созданного жанра</returns>
        [HttpPost]
        public IActionResult Create([FromBody] GenreForm form)
        {
            if (form == null) return BadRequest("form is null");
            var createdId = genreFormHandler.HandleCreate(form);

            return Ok(createdId);
        }

        /// <summary>
        /// Метод для редактирования существующего жанра
        /// </summary>
        /// <param name="id">Идентификатор жанра</param>
        /// <param name="form">Форма жанра</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Edit([FromRoute] int id, [FromBody] GenreForm form)
        {
            genreFormHandler.HandleEdit(id, form);
            return Ok();
        }

        /// <summary>
        /// Метод для удаления конкретного жанра
        /// </summary>
        /// <param name="id">Идентификатор жанра</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            genreDeleteHandler.HandleDelete(id);
            return Ok();
        }


    }
}
