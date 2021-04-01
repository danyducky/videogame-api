using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Videogames.DataLayer.Entities.Videogames;

namespace Videogames.DataLayer.Entities.Developers
{
    [Table("developer")]
    public class Developer : IVideogameEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Videogame> Videogames { get; set; } = new List<Videogame>();
    }

}
