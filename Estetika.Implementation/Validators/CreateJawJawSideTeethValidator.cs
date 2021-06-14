using Estetika.Application.DataTransfer;
using Estetika.DataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Validators
{
    public class CreateJawJawSideTeethValidator : AbstractValidator<JawJawSideTeethDto>
    {
        private readonly EstetikaContext context;
        public CreateJawJawSideTeethValidator(EstetikaContext context)
        {
            this.context = context;

            RuleFor(x => x.JawId).Must(JawExists).WithMessage("Jaw with id of {PropertyValue} doesn't exists.")
                .Must(JawIdCount).WithMessage("Jaw cannot be inserted more then 16 times.");
            RuleFor(x => x.JawSideId).Must(JawSideExists).WithMessage("JawSide with id of {PropertyValue} doesn't exists.")
                .Must(JawSideIdCount).WithMessage("JawSide cannot be inserted more then 16 times.");
            RuleFor(x => x.ToothId).Must(TeethExists).WithMessage("Tooth with id of {PropertyValue} doesn't exists.")
                .Must(ToothIdCount).WithMessage("Teeth cannot be inserted more then 8 times.");
        }

        private bool JawExists(int jawId)
        {
            return context.Jaws.Any(x => x.Id == jawId);
        }

        private bool JawIdCount(int jawId)
        {
            return context.Jaws.Where(x => x.Id == jawId).Count() > 16;
        }

        private bool JawSideExists(int JawSideId)
        {
            return context.JawSides.Any(x => x.Id == JawSideId);
        }

        private bool JawSideIdCount(int JawSideId)
        {
            return context.JawSides.Where(x => x.Id == JawSideId).Count() > 16;
        }

        private bool TeethExists(int ToothId)
        {
            return context.Teeths.Any(x => x.Id == ToothId);
        }

        private bool ToothIdCount(int ToothId)
        {
            return context.Teeths.Where(x => x.Id == ToothId).Count() > 16;
        }
    }
}
