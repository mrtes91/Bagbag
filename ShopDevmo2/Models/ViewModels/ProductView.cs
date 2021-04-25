using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ShopDevmo2.Models.ViewModels
{
    public class ProductView
    {
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

        public string Dimentions { get; set; }

        public decimal Price { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        //public PublishStatus Status { get; set; }

        //[Display(Name = "Publish status")]
        //public DateTime PublishDate { get; set; }

        [Display(Name = "Featured image")]
        public string FeatureImage { get; set; }

        [Display(Name = "Featured image 1")]
        public string FeatureImage1 { get; set; }

        [Display(Name = "Featured image 2")]
        public string FeatureImage2 { get; set; }

        [Display(Name = "Featured image 3")]
        public string FeatureImage3 { get; set; }

        [Display(Name = "Featured image 4")]
        public string FeatureImage4 { get; set; }

        [Display(Name = "Featured image 5")]
        public string FeatureImage5 { get; set; }

        public HttpPostedFileBase UploadFile { get; set; }
        public HttpPostedFileBase UploadFile1 { get; set; }
        public HttpPostedFileBase UploadFile2 { get; set; }
        public HttpPostedFileBase UploadFile3 { get; set; }
        public HttpPostedFileBase UploadFile4 { get; set; }
        public HttpPostedFileBase UploadFile5 { get; set; }

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
            Brand = product.Brand;
            Color = product.Color;
            Material = product.Material;
            Dimentions = product.Dimentions;
            Price = product.Price;
            Description = product.Description;
            //Status = product.Status;
            //PublishDate = product.PublishDate;
            FeatureImage = product.FeatureImage;
            FeatureImage1 = product.FeatureImage1;
            FeatureImage2 = product.FeatureImage2;
            FeatureImage3 = product.FeatureImage3;
            FeatureImage4 = product.FeatureImage4;
            FeatureImage5 = product.FeatureImage5;
        }

        public void CopyToProduct(ref Product product)
        {
            product.Id = Id;
            product.Name = Name;
            product.CategoryId = CategoryId;
            product.Brand = Brand;
            product.Color = Color;
            product.Material = Material;
            product.Dimentions = Dimentions;
            product.Price = Price;
            product.Description = Description;
            //product.Status = Status;
            //product.PublishDate = PublishDate;
            //product.FeatureImage = FeatureImage;
        }
    }
}