using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Admin.Models.Common.Videogames.Validator
{
    public class VideogameValidatorResult
    {
        public VideogameValidatorResult()
        {
            Errors = new List<string>();
        }
        public bool isValid { get; set; }
        public IList<string> Errors { get; set; }
    }
}
