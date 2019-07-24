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
    public class ShoppingCartController : Controller
    {
        IShoppingCartService ShoppingCartService = new ShoppingCartService();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            List<ShoppingCart> list = new List<ShoppingCart>();
            foreach (var item in ShoppingCartService.GetAll())
            {
                ShoppingCart AVM = new ShoppingCart();
                AVM.Id = item.Id;
                AVM.idQuotation = item.idQuotation;
                AVM.idCLient = item.idCLient;
                AVM.ListProduct = item.ListProduct;
                AVM.ListPack = item.ListPack;
                list.Add(AVM);
            }
            return View(list);
        }

        // GET: ShoppingCart/Details/5
        public ActionResult Details(int id)
        {
            ShoppingCart item = ShoppingCartService.GetById(id);

            ShoppingCart AVM = new ShoppingCart();
            AVM.Id = item.Id;
            AVM.idQuotation = item.idQuotation;
            AVM.idCLient = item.idCLient;
            AVM.ListProduct = item.ListProduct;
            AVM.ListPack = item.ListPack;

            return View(AVM);
        }

        // GET: ShoppingCart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingCart/Create
        [HttpPost]
        public ActionResult Create(ShoppingCartModel AVM)
        {
            try
            {
                // TODO: Add insert logic here
                ShoppingCart A = new ShoppingCart();
                A.Id = AVM.Id;
                A.idQuotation = AVM.idQuotation;
                A.idCLient = AVM.idCLient;
                A.ListProduct = AVM.ListProductModel;
                A.ListPack = AVM.ListPackModel; 


                ShoppingCartService.Add(A);
                ShoppingCartService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingCart/Edit/5
        public ActionResult Edit(int id)
        {
            ShoppingCart item = ShoppingCartService.GetById(id);

            ShoppingCart AVM = new ShoppingCart();
            AVM.Id = item.Id;
            AVM.idQuotation = item.idQuotation;
            AVM.idCLient = item.idCLient;
            AVM.ListProduct = item.ListProduct;
            AVM.ListPack = item.ListPack;

            return View(AVM);
        }

        // POST: ShoppingCart/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ShoppingCartModel AVM)
        {
            try
            {
                // TODO: Add update logic here

                ShoppingCart A = ShoppingCartService.GetById(id);

                A.Id = AVM.Id;
                A.idQuotation = AVM.idQuotation;
                A.idCLient = AVM.idCLient;
                A.ListProduct = AVM.ListProductModel;
                A.ListPack = AVM.ListPackModel;


                ShoppingCartService.Update(A);
                ShoppingCartService.Commit();



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingCart/Delete/5
        public ActionResult Delete(int id)
        {
            ShoppingCart item = ShoppingCartService.GetById(id);

            ShoppingCart AVM = new ShoppingCart();
            AVM.Id = item.Id;
            AVM.idQuotation = item.idQuotation;
            AVM.idCLient = item.idCLient;
            AVM.ListProduct = item.ListProduct;
            AVM.ListPack = item.ListPack;

            return View(AVM);
        }

        // POST: ShoppingCart/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ShoppingCartService.Delete(ShoppingCartService.GetById(id));
                ShoppingCartService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
