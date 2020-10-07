using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;

namespace GroupService.Repo.Helpers
{
    public static class CredentialTypesExtensions
    {
        public static void SetEnumCredentialTypesExtensionsData(this EntityTypeBuilder<EnumCredentialTypes> entity)
        {
            var formVariants = Enum.GetValues(typeof(CredentialTypes)).Cast<CredentialTypes>();

            foreach (var form in formVariants)
            {
                entity.HasData(new EnumCredentialTypes { Id = (int)form, Name = form.ToString() });
            }
        }
    }
}
