using Estetika.Application.DataTransfer;
using Estetika.DataAccess;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Implementation.Validators
{
    public class UpdateJawJawSideTeethValidator : AbstractValidator<JawJawSideTeethDto>
    {
        private readonly EstetikaContext context;
        public UpdateJawJawSideTeethValidator(EstetikaContext context)
        {
            this.context = context;

            RuleFor(x => x.JawId).Must(JawExists).WithMessage("Jaw with id of {PropertyValue} doesn't exists.")
                .DependentRules(() =>
                {
                    RuleFor(x => x.ToothId).Must(TeethExists).WithMessage("Tooth with id of {PropertyValue} doesn't exists.")

                    .DependentRules(() =>
                    {
                        RuleFor(x => x.ToothId).Must(ToothIsAlreadyOnThisSide).WithMessage("ToothIsAlreadyOnThisSide")

                        .DependentRules(() =>
                        {
                            RuleFor(x => x.JawSideId).Must(JawSideIsNotPopulated).WithMessage("");
                        });
                    });
                });
           
        }

        private bool JawExists(int jawId)
        {
            return context.Jaws.Any(x => x.Id == jawId);
        }

        //private bool JawIdCount(JawJawSideTeethDto dto, int jawId)
        //{

        //    //return context.JawJawSideTeeth.Where(x => x.JawId == jawId && dto.ToothId != x.ToothId).Count() > 16;
        //}

        private bool JawSideExists(int JawSideId)
        {
            return context.JawSides.Any(x => x.Id == JawSideId);
        }

        private bool JawSideIdCount(int JawSideId)
        {
            return context.JawJawSideTeeth.Where(x => x.JawSideId == JawSideId).Count() > 16;
        }

        private bool TeethExists(int ToothId)
        {
            return context.Teeths.Any(x => x.Id == ToothId);
        }

        private bool ToothIdCount(int ToothId)
        {
            return context.JawJawSideTeeth.Where(x => x.ToothId == ToothId).Count() > 16;
        }

        private bool ToothIsAlreadyOnThisSide(JawJawSideTeethDto dto, int ToothId)
        {
            return context.JawJawSideTeeth.Where(x => x.ToothId == ToothId && x.JawSideId == dto.JawSideId).Any();
        }

        private bool JawSideIsNotPopulated(int JawSideId)
        {
            return context.JawSides.Include(x => x.JawJawSideTeeth).FirstOrDefault(x => x.Id == JawSideId).JawJawSideTeeth.Count() < 16;
        }
    }
}
