using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;
using ShopDevmo2.Models;
using ShopDevmo2.Common;
using ShopDevmo2.Models.ViewModels;
using System.Configuration;

namespace ShopDevmo2.Areas.Admin.Controllers
{
    [Authorize]
    [CustomActionFilter]
    [ExceptionHandlerFilter]
    public class ProductsController : BaseController
    {
        private ShopDbContext db = new ShopDbContext();

        // GET: Admin/Products
        public async Task<ActionResult> Index()
        {
            var products = db.Products.Include(p => p.Category);
            return View(await products.ToListAsync());
        }

        // GET: Admin/Products/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public ActionResult Create()
        {
            ViewBag.Categories = new SelectList(db.Categories, "Id", "DisplayText");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductView viewModel)
        {
            Product product = new Product();
            if (ModelState.IsValid)
            {

                viewModel.CopyToProduct(ref product);
                product.FeatureImage = SaveFile(viewModel.UploadFile, product.FeatureImage);
                product.FeatureImage1 = SaveFile(viewModel.UploadFile1, product.FeatureImage1);
                product.FeatureImage2 = SaveFile(viewModel.UploadFile2, product.FeatureImage2);
                product.FeatureImage3 = SaveFile(viewModel.UploadFile3, product.FeatureImage3);
                product.FeatureImage4 = SaveFile(viewModel.UploadFile4, product.FeatureImage4);
                product.FeatureImage5 = SaveFile(viewModel.UploadFile5, product.FeatureImage5);
                db.Products.Add(product);
                await db.SaveChangesAsync();
                SetSuccessNotification();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "DisplayText", viewModel.CategoryId);
            return View(viewModel);
        }

        // GET: Admin/Products/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.Categories = new SelectList(db.Categories, "Id", "DisplayText", product.CategoryId);    // access from view without "ViewBag"
            var viewModel = new ProductView(product);
            return View(viewModel);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProductView viewModel)
        {
            if (ModelState.IsValid)
            {
                Product product = await db.Products.FindAsync(viewModel.Id);
                viewModel.CopyToProduct(ref product);
                product.FeatureImage = SaveFile(viewModel.UploadFile, product.FeatureImage);
                product.FeatureImage1 = SaveFile(viewModel.UploadFile1, product.FeatureImage1);
                product.FeatureImage2 = SaveFile(viewModel.UploadFile2, product.FeatureImage2);
                product.FeatureImage3 = SaveFile(viewModel.UploadFile3, product.FeatureImage3);
                product.FeatureImage4 = SaveFile(viewModel.UploadFile4, product.FeatureImage4);
                product.FeatureImage5 = SaveFile(viewModel.UploadFile5, product.FeatureImage5);

                db.Entry(product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                SetSuccessNotification();
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(db.Categories, "Id", "DisplayText", viewModel.CategoryId);
            return View(viewModel);
        }

        // GET: Admin/Products/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            Product product = await db.Products.FindAsync(id);
            db.Products.Remove(product);
            await db.SaveChangesAsync();
            SetSuccessNotification();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Replace previous file by new upload file.
        /// In case there is no upload file, keep previous file if existed.
        /// </summary>
        /// <param name="postedFile"></param>
        /// <param name="previousUrl"></param>
        /// <returns></returns>
        private string SaveFile(HttpPostedFileBase postedFile, string previousUrl = null)
        {
            if (postedFile == null)
            {
                return !string.IsNullOrEmpty(previousUrl) ? previousUrl : null;
            }
            string relativePath = ConfigurationManager.AppSettings.Get("shop:uploadsDir:products") ?? "/Uploads/Products";
            string physicFolderPath = Server.MapPath(relativePath);
            string previousFilePath = Server.MapPath(Server.UrlDecode(previousUrl));

            // Create upload folder if not exist
            if (!Directory.Exists(physicFolderPath))
            {
                Directory.CreateDirectory(physicFolderPath);
            }
            if (!string.IsNullOrEmpty(previousFilePath) && System.IO.File.Exists(previousFilePath))
            {
                System.IO.File.Delete(previousFilePath);
            }

            postedFile.SaveAs(Path.Combine(physicFolderPath, postedFile.FileName));
            return Server.UrlEncode(relativePath + "/" + postedFile.FileName);
        }
    }
}
