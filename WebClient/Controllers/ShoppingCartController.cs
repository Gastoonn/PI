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
         

        // GET: ShoppingCart/Details/5
        public ActionResult Details(int id)
        {
            ShoppingCart item = ShoppingCartService.GetById(id);

            ShoppingCart AVM = new ShoppingCart();
            AVM.Id = item.Id;
            AVM.idCLient = item.idCLient;
            AVM.idProduct = item.idProduct;
            AVM.Quantite = item.Quantite;
            AVM.IsAPack = item.IsAPack;
            AVM.idQuotation = item.idQuotation;

            return View(AVM);
        }

        // GET: ShoppingCart/Create/{idProd}
        public ActionResult Create(int id)
        {
            ShoppingCart AVM = new ShoppingCart();
            AVM.idCLient = 1; //A.idCLient = AVM.idCLient;
            AVM.idProduct = id;
            

            return View(AVM);
        }

        // POST: ShoppingCart/Create/5
        [HttpPost]
        public ActionResult Create(ShoppingCartModel AVM,int idProd)
        {
            try
            {
                // TODO: Add insert logic here
                ShoppingCart A = new ShoppingCart();
                A.Id = AVM.Id;
                A.idCLient = 1; //A.idCLient = AVM.idCLient;
                A.idProduct = idProd;
                A.Quantite = AVM.Quantite;
                A.IsAPack = AVM.IsAPack;
                A.idQuotation = AVM.idQuotation;


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
            AVM.idCLient = item.idCLient;
            AVM.idProduct = item.idProduct;
            AVM.Quantite = item.Quantite;
            AVM.IsAPack = item.IsAPack;
            AVM.idQuotation = item.idQuotation;

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
                A.idCLient = AVM.idCLient;
                A.idProduct = AVM.idProduct;
                A.Quantite = AVM.Quantite;
                A.IsAPack = AVM.IsAPack;
                A.idQuotation = AVM.idQuotation;


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
            AVM.idCLient = item.idCLient;
            AVM.idProduct = item.idProduct;
            AVM.Quantite = item.Quantite;
            AVM.IsAPack = item.IsAPack;
            AVM.idQuotation = item.idQuotation;

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
