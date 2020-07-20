using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class RegistrationFormVariantExtensions
    {
        public static void SetEnumRequestHelpFormVariantExtensionsData(this EntityTypeBuilder<EnumRegistrationFormVariant> entity)
        {
            var formVariants = Enum.GetValues(typeof(RegistrationFormVariant)).Cast<RegistrationFormVariant>();

            foreach (var form in formVariants)
            {
                entity.HasData(new EnumRegistrationFormVariant { Id = (int)form, Name = form.ToString() });
            }
        }
    }
}
