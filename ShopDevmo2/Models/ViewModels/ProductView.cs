﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ShopDevmo2.Models.ViewModels
{
    public class ProductView
    {
        public ProductView()
        {
        }

        public ProductView(Product product)
        {
            if (product == null)
            {
                return;
            }

            Id = product.Id;
            Name = product.Name;
            CategoryId = product.CategoryId;
            Price = product.Price;
            Description = product.Description;
            Brand = product.Brand;
            Color = product.Color;
            Material = product.Material;
            FeatureImage = product.FeatureImage;
        }

        public void CopyToProduct(ref Product product)
        {
            product.Id = Id;
            product.Name = Name;
            product.CategoryId = CategoryId;
            product.Price = Price;
            product.Description = Description;
            product.Color = Color;
            product.Material = Material;
            product.Brand = Brand;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Category")]
        public long CategoryId { get; set; }

        [Display(Name = "Brand")]
        public string Brand { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "Material")]
        public string Material { get; set; }

        public decimal Price { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        //public PublishStatus Status { get; set; }

        //[Display(Name = "Publish status")]
        //public DateTime PublishDate { get; set; }

        [Display(Name = "Featured image")]
        public string FeatureImage { get; set; }

        public HttpPostedFileBase UploadFile { get; set; }
    }
}