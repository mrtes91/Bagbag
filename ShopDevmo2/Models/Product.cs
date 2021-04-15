using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ShopDevmo2.Models
{
    public class Product
    {
        public Product()
        {
            //this.OrderDetails = new HashSet<OrderDetail>();
            //this.Prices = new HashSet<Price>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // implicit PK, Identity field
        public long Id { get; set; }    

        [MaxLength(250)]
        [Display(Name = "Product name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Product ID")]
        public long CategoryId { get; set; }

        [Display(Name = "Gender")]
        public bool Gender { get; set; }

        [MaxLength(250)]
        [Display(Name = "Brand")]
        public string Brand { get; set; }

        [MaxLength(250)]
        [Display(Name = "Color")]
        public string Color { get; set; }

        [MaxLength(250)]
        [Display(Name = "Material")]
        public string Material { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [AllowHtml]
        [MaxLength(500, ErrorMessage = "Content is too length.")]
        public string Description { get; set; }

        //TODO: add product quantity
        public PublishStatus Status { get; set; }

        [Display(Name = "Publish on date")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd")]
        public DateTime PublishDate { get; set; }

        [MaxLength(250)]
        [Display(Name = "Featured image")]
        public string FeatureImage { get; set; }

        public virtual Category Category { get; set; }
        //public virtual ICollection<Price> Prices { get; set; }
    }
}