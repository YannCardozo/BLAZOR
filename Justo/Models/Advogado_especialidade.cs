using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Justo.Models
{
    public class Advogado_especialidade
    {
        public int Id { get; set; }
        public string Nome_area_direito { get; set; }


        //chave estrangeira
        public int Advogado_especialidade_completo_Id { get; set; }


        public ICollection<Advogado_especialidade_completo> Advogados_Especialidades_Completos_ESPEC { get; set; }

    }
}
