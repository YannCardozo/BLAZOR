using Justo.Models.Comuns;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Justo.Models
{
    public class Advogado_especialidade : EntidadeBase
    {
        public string Nome_area_direito { get; set; }

        //chave estrangeira
        public int AdvogadoId { get; set; }

        // Relacionamento com Advogado
        public Advogado Advogados_FK { get; set; }


    }
}
