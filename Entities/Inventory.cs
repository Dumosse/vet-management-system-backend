using System.ComponentModel.DataAnnotations;

namespace backend.Entities{
    public class Inventory{
        [Key]
        public int ItemId {get; set;}
        public string ItemName {get; set;}
        public int Quantity {get; set;}
        public int RestockThreshold {get; set;}
        public DateTime LastUpdated {get; set;}
    }
}