using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradoArmazem
{

    public class Produtos
    {
        public string ID_endereco { get; set; }
        public string nome_produto { get; set; }
        public string Codigo_Produto { get; set; }
        public string CodigoEAN { get; set; }
        public string Endereco_produto { get; set; }
        public string status_produto { get; set; }
        public string ID_fornecedeor { get; set; }
        public int quantidade { get; set; }
        public string lote { get; set; }

    }
}
