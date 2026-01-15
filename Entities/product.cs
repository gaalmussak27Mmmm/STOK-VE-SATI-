using System;

namespace StokTakipOtomasyonu.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal PurchasePrice { get; set; } // Alış Fiyatı
        public decimal SalePrice { get; set; }     // Satış Fiyatı
        public int StockQuantity { get; set; }     // Stok Adedi
        public int CriticalStock { get; set; }     // Kritik seviye
        public DateTime CreatedDate { get; set; }
    }
}