using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain.Model
{
    public class ProdutoModel
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Description { get; set; } = "";

        public string Validade { get; set; } = "";
    }
}