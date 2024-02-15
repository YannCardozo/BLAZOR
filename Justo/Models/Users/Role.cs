using System.ComponentModel.DataAnnotations;

namespace Justo.Models.Users
{
    public class Role
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="O nome do perfil é obrigatório", AllowEmptyStrings = false)]
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public Guid ConcurrencyStamp { get; set; }
    }
}
