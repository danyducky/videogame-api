using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videogames.Admin.Models.Common.Videogames.Item;
using Videogames.DataLayer.Entities.Developers.Repositories;
using Videogames.DataLayer.Entities.Genres.Repositories;

namespace Videogames.Admin.Models.Common.Videogames.Validator
{
    public class VideogameValidator : IVideogameValidator
    {
        private readonly IDeveloperRepository developerRepository;
        public VideogameValidator(IDeveloperRepository developerRepository)
        {
            this.developerRepository = developerRepository;
        }

        public VideogameValidatorResult Validate(VideogameForm form)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(form.Name))
            {
                errors.Add("Name should not be empty");
            }
            else if (form.Name.Length < 5)
            {
                errors.Add("Name length must be more then 5 characters");
            } 
            else if (form.Name.Length > 20) {
                errors.Add("Name length must be less then 20 characters");
            }

            var developer = developerRepository.GetDeveloperById(form.DeveloperId);
            if (developer == null)
            {
                errors.Add($"Developer with id: [{form.DeveloperId}] not found");
            }

            return new VideogameValidatorResult { Errors = errors, isValid = errors.Count == 0 };


        }
    }
}
