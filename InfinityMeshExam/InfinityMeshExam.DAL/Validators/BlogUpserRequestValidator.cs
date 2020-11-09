using FluentValidation;
using InfinityMeshExam.DAL.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfinityMeshExam.DAL.Validators
{
    public class BlogUpserRequestValidator:AbstractValidator<BlogUpsertRequest>
    {
        public BlogUpserRequestValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(64);
            RuleFor(x => x.Summary).NotEmpty().MaximumLength(350);
            RuleFor(x => x.Content).NotEmpty().MaximumLength(3500);
            RuleFor(x => x.Published).NotEmpty();



        }
    }
}
