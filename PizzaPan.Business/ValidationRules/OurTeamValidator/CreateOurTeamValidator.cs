using FluentValidation;
using PizzaPan.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.Business.ValidationRules.OurTeamValidator
{
    public class CreateOurTeamValidator : AbstractValidator<OurTeam>
    {
        public CreateOurTeamValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez!");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapınız");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Girişi Yapınız");
        }
    }
}
