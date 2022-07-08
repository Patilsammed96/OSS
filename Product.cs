using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


// I have made chnges in his .cs file
namespace TFLWebApp.Models
{

    //POCO class
    //Entity Class
    //Data Annotations defined metadata for class or field, or property

    [Table("Product10")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDesc { get; set; }
       
        public int ProductQuantity { get; set; }



    }
}
