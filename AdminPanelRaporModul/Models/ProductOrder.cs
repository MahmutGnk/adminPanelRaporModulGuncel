using AdminPanelRaporModul.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace AdminPanelRaporModul.Models
{
    public class ProductOrder : IEntity
    {
        [Key]
        public int product_id { get; set; }
        public string quantity { get; set; }
        public double price { get; set; }
        public double total { get; set; }
        public double tax { get; set; }
        public string currencyType { get; set; }
        public string? product_supplier { get; set; }
        public DateTime? date { get; set; }
        public string? musteri { get; set; }
        public int musteri_id { get; set; }
    }
}
