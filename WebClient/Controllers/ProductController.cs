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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
