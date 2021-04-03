using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Videogames.Item;

namespace Videogames.Admin.Models.Common.Videogames.Validator
{
    public interface IVideogameValidator
    {
        VideogameValidatorResult Validate(VideogameForm form);
    }
}
