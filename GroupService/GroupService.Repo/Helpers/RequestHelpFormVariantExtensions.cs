using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class RequestHelpFormVariantExtensions
    {
        public static void SetEnumRequestHelpFormVariantExtensionsData(this EntityTypeBuilder<EnumRequestHelpFormVariant> entity)
        {
            var formVariants = Enum.GetValues(typeof(RequestHelpFormVariant)).Cast<RequestHelpFormVariant>();

            foreach (var form in formVariants)
            {
                entity.HasData(new EnumRequestHelpFormVariant { Id = (int)form, Name = form.ToString() });
            }
        }
    }
}
