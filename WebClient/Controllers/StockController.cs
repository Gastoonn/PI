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
    public class StockController : Controller
    {
        IStockService StockService = new StockService();
        // GET: Stock
        public ActionResult Index()
        {
            List<StockViewModel> list = new List<StockViewModel>();
            foreach (var item in StockService.GetAll())
            {
                StockViewModel AVM = new StockViewModel();
                AVM.idProduct = item.idProduct;
                AVM.idStore = item.idStore;
                AVM.Quantity = item.Quantity;
                list.Add(AVM);
            }
            return View(list);
        }

        // GET: Stock/Details/5
        public ActionResult Details(int id)
        {
            Stock item = StockService.GetById(id);

            StockViewModel AVM = new StockViewModel();
            AVM.idProduct = item.idProduct;
            AVM.idStore = item.idStore;
            AVM.Quantity = item.Quantity;

            return View(AVM);
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(StockViewModel item)
        {
            try
            {
                // TODO: Add insert logic here
                Stock AVM = new Stock();
                AVM.idProduct = item.idProduct;
                AVM.idStore = item.idStore;
                AVM.Quantity = item.Quantity;


                StockService.Add(AVM);
                StockService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            Stock item = StockService.GetById(id);

            StockViewModel AVM = new StockViewModel();
            AVM.idProduct = item.idProduct;
            AVM.idStore = item.idStore;
            AVM.Quantity = item.Quantity;

            return View(AVM);
        }

        // POST: Stock/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StockViewModel item)
        {
            try
            {
                // TODO: Add update logic here
                Stock AVM = StockService.GetById(id);

                AVM.idProduct = item.idProduct;
                AVM.idStore = item.idStore;
                AVM.Quantity = item.Quantity;


                StockService.Update(AVM);
                StockService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            Stock item = StockService.GetById(id);

            StockViewModel AVM = new StockViewModel();
            AVM.idProduct = item.idProduct;
            AVM.idStore = item.idStore;
            AVM.Quantity = item.Quantity;

            return View(AVM);
        }

        // POST: Stock/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                StockService.Delete(StockService.GetById(id));
                StockService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
