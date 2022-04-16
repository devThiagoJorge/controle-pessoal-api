using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controle_pessoal_api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
    }
}
