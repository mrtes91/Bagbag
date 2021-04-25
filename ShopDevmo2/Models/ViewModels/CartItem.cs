using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopDevmo2.Models.ViewModels
{
	using System.ComponentModel.DataAnnotations;

	public class CartItem
	{
		public long ProductId { get; set; }

		[Display(Name = "Product name")]
		public string ProductName { get; set; }

		[Display(Name = "Product image")]
		public string ImageUrl { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }

		public CartItem(Product product, int quantity)
		{
			ProductId = product.Id;
			ProductName = product.Name;
			ImageUrl = product.FeatureImage;
			Quantity = quantity;
			Price = product.Price;
		}
	}
}