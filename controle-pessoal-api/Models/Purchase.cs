using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controle_pessoal_api.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public PaymentType PaymentType { get; set; }
        public int CategoryId { get; set; }
        public int PaymentTypeId { get; set; }
    }
}
