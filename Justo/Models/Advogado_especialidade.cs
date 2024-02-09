using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Justo.Models
{
    public class Advogado_especialidade
    {
        public int Advogado_especialidade_Id { get; set; }
        public string Nome_area_direito { get; set; }


        //chave estrangeira
        public int Advogado_Id { get; set; }

        public Advogado Advogado { get; set; }

    }
}
