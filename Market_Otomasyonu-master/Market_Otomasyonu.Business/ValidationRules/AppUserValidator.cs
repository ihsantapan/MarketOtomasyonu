using FluentValidation;
using Market_Otomasyonu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyonu.Business.ValidationRules
{
	public class AppUserValidator : AbstractValidator<AppUser>
	{
		public AppUserValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Adınızı giriniz");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Lütfen Soyadınızı giriniz");
			RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir Ad giriniz");
			RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir Soyadı giriniz");
			RuleFor(x => x.Gender).NotEmpty().WithMessage("Lütfen cinsiyet için bir seçim yapınız");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen şifrenizi giriniz");
			RuleFor(x => x.WorkUnit).NotEmpty().WithMessage("Lütfen Çalışma Birimi Seçiniz");
			RuleFor(x => x.Password).MinimumLength(8)
			.Must(password => password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Count(c => "-_!:+*".Contains(c)) >= 1).WithMessage("Şifre en az 8 karakter uzunluğunda olmalı , en az bir büyük harf, bir küçük harf, bir sayı ve en az 1 özel karakter içermelidir");


		}
	}
}
