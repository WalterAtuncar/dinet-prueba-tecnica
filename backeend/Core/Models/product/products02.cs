using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.product
{
    public class products02
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
