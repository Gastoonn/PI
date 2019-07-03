using Domain.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class ProductController : Controller
    {
        IProductService ProductService = new ProductService();
        // GET: Product
        public ActionResult Index()
        {
            List<ProductViewModel> list = new List<ProductViewModel>();
            foreach (var item in ProductService.GetAll())
            {
                ProductViewModel AVM = new ProductViewModel();
                AVM.Id = item.Id;
                AVM.Model = item.Model;
                AVM.Category = item.Category;
                AVM.Quantity = item.Quantity;
                AVM.Price = item.Price;

                list.Add(AVM);
            }
            return View(list);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            Product item = ProductService.GetById(id);

            ProductViewModel AVM = new ProductViewModel();
            AVM.Id = item.Id;
            AVM.Model = item.Model;
            AVM.Category = item.Category;
            AVM.Quantity = item.Quantity;
            AVM.Price = item.Price;

            return View(AVM);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductViewModel AVM)
        {
            try
            {
                // TODO: Add insert logic here
                Product A = new Product();
                A.Id = AVM.Id;
                A.Model = AVM.Model;
                A.Category = AVM.Category;
                A.Quantity = AVM.Quantity;
                A.Price = AVM.Price;

                ProductService.Add(A);
                ProductService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product item = ProductService.GetById(id);
            ProductViewModel AVM = new ProductViewModel();
            AVM.Id = item.Id;
            AVM.Model = item.Model;
            AVM.Category = item.Category;
            AVM.Quantity = item.Quantity;
            AVM.Price = item.Price;

            return View(AVM);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductViewModel AVM)
        {
            try
            {
                // TODO: Add update logic here
                Product A = ProductService.GetById(id);
                A.Id = AVM.Id;
                A.Model = AVM.Model;
                A.Category = AVM.Category;
                A.Quantity = AVM.Quantity;
                A.Price = AVM.Price;

                ProductService.Update(A);
                ProductService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            Product item = ProductService.GetById(id);
            ProductViewModel AVM = new ProductViewModel();
            AVM.Id = item.Id;
            AVM.Model = item.Model;
            AVM.Category = item.Category;
            AVM.Quantity = item.Quantity;
            AVM.Price = item.Price;

            return View(AVM);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                ProductService.Delete(ProductService.GetById(id));
                ProductService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
