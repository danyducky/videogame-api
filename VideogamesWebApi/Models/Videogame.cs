using System.ComponentModel.DataAnnotations.Schema;

namespace VideogamesWebApi.Models
{
    public class Videogame
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Genres { get; set; }

    }
}
