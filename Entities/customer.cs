using System;

namespace StokTakipOtomasyonu.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string CustomerType { get; set; } // Toptan - Perakende
        public DateTime CreatedDate { get; set; }
    }
}