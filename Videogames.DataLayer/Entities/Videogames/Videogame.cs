using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Videogames.DataLayer.Entities.Genres;
using Videogames.DataLayer.Entities.Developers;

namespace Videogames.DataLayer.Entities.Videogames
{
    [Table("videogame")]
    public class Videogame : IVideogameEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();



    }
}
