using Domain.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class InvoiceController : Controller
    {
        IInvoiceService InvoiceService = new InvoiceService();
        IShoppingCartService ShoppingCartService = new ShoppingCartService();
        // GET: Invoice
        public ActionResult Index()
        {
            // Debug.WriteLine("Ici =>");
            List<Invoice> list = new List<Invoice>();
            foreach (var item in InvoiceService.GetAll())
            {
                //   Debug.WriteLine(item.ToString());
                Invoice AVM = new Invoice();
                AVM.Id = item.Id;
                AVM.idClient = item.idClient;
                AVM.idProduit = item.idProduit;
                AVM.idQuotation = item.idQuotation;
                AVM.Quantite = item.Quantite;
                AVM.SumInvoice = item.SumInvoice;
                AVM.DateInvoice = item.DateInvoice;

                list.Add(AVM);
            }
            return View(list);
        }
        // GET: Invoice
        public ActionResult CommandList()
        {
            // Debug.WriteLine("Ici =>");
            List<ShoppingCart> list = new List<ShoppingCart>();
            foreach (var item in ShoppingCartService.GetAll())
            {
                //   Debug.WriteLine(item.ToString());
                ShoppingCart AVM = new ShoppingCart();
                AVM.Id = item.Id;
                AVM.idCLient = item.idCLient;
                AVM.idProduct = item.idProduct;
                AVM.idQuotation = item.idQuotation;
                AVM.Quantite = item.Quantite;
                AVM.IsAPack = item.IsAPack;

                list.Add(AVM);
            }
            return View(list);
        }

        // GET: Invoice/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Invoice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invoice/Create
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

        // GET: Invoice/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Invoice/Edit/5
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

        // GET: Invoice/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Invoice/Delete/5
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
