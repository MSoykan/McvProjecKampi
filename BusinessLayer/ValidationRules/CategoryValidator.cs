﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules {
    public class CategoryValidator: AbstractValidator<Category>{
        public CategoryValidator() {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen isme en az 3 karakter girin.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen isme 20 karakterden fazla isim girişi yapmayın.");
        }
    }
}