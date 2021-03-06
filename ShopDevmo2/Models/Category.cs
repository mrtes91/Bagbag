namespace Shop.Models
{
    using ShopDevmo2.Models;
    using System;
    using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Category
    {
        public Category()
        {
            //this.Products = new HashSet<Product>();
        }
    
        [Required(ErrorMessage = "Please input category name")]
        public string DisplayText { get; set; }
        public long Id { get; set; }   
        public long? ParentId { get; set; }

        public virtual ICollection<Product> Products { get; set; }    //TODO: remove
        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }
    }
}
