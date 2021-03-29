using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideogamesWebApi.Viewmodels
{
    public class VideogameViewModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5), MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MinLength(5), MaxLength(20)]
        public string Developer { get; set; }
        [Required]
        [MinLength(1), MaxLength(5)]
        public string[] Genres { get; set; }
    }
}
