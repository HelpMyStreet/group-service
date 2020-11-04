using System.ComponentModel.DataAnnotations.Schema;

namespace GroupService.Repo.EntityFramework.Entities
{
    public class EnumSupportActivity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
