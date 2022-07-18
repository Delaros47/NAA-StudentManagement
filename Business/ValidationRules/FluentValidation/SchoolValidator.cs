using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SchoolValidator : AbstractValidator<School>
    {
        public SchoolValidator()
        {
            RuleFor(s => s.SchoolName).NotEmpty().WithMessage("School name cannot be empty");
            RuleFor(s => s.PrivateCode).NotEmpty().WithMessage("Private Code cannot be empty");
            RuleFor(s => s.CityId).NotEmpty().WithMessage("City name cannot be empty");
            RuleFor(s => s.DistrictId).NotEmpty().WithMessage("District name cannot be empty");
        }
    }
}
