using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Products
    {
        [Key]
        public int Product_id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int Price { get; set; }

        [ForeignKey("Categories")]
        public int Category_id {get; set; }
        //public Categories Categories { get; set;}

        [ForeignKey("Brands")]
        public int Brand_id { get; set; }
        //public Brands Brands { get; set;}



    }
}
