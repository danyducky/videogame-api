using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Videogames.DataLayer.Entities.Videogames;

namespace Videogames.DataLayer.Entities.Genres
{
    [Table("genre")]
    public class Genre : IVideogameEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Videogame> Videogames { get; set; } = new List<Videogame>();
    }
}
