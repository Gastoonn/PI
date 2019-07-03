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
    public class PackController : Controller
    {
        IPackService PackService = new PackService();
        // GET: Pack
        public ActionResult Index()
        {
            List<PackViewModel> list = new List<PackViewModel>();
            foreach (var item in PackService.GetAll())
            {
                PackViewModel AVM = new PackViewModel();
                AVM.Id = item.Id;
                AVM.date_deb = item.date_deb;
                    AVM.date_expiration = item.date_expiration;
                AVM.ListPanierModel = item.ListPanier;
                AVM.ListProduct = item.ListProduct;
                AVM.Price = item.Price;
                   

                list.Add(AVM);
            }
            return View(list);
        }

        // GET: Pack/Details/5
        public ActionResult Details(int id)
        {
            Pack item = PackService.GetById(id);

            PackViewModel AVM = new PackViewModel();
            AVM.Id = item.Id;
            AVM.date_deb = item.date_deb;
            AVM.date_expiration = item.date_expiration;
            AVM.ListPanierModel = item.ListPanier;
            AVM.ListProduct = item.ListProduct;
            AVM.Price = item.Price;

            return View(AVM);
        }

        // GET: Pack/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pack/Create
        [HttpPost]
        public ActionResult Create(PackViewModel AVM)
        {
            try
            {
                // TODO: Add insert logic here
                Pack A = new Pack();
                A.Id = AVM.Id;
                A.date_deb = AVM.date_deb;
                A.date_expiration = AVM.date_expiration;
                A.ListPanier = AVM.ListPanierModel;
                A.ListProduct = AVM.ListProduct;
                A.Price = AVM.Price;

                PackService.Add(A);
                PackService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pack/Edit/5
        public ActionResult Edit(int id)
        {
            Pack item = PackService.GetById(id);
            PackViewModel AVM = new PackViewModel();
            AVM.Id = item.Id;
            AVM.date_deb = item.date_deb;
            AVM.date_expiration = item.date_expiration;
            AVM.ListPanierModel = item.ListPanier;
            AVM.ListProduct = item.ListProduct;
            AVM.Price = item.Price;

            return View(AVM);
        }

        // POST: Pack/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PackViewModel AVM)
        {
            try
            {
                // TODO: Add update logic here
                Pack A = PackService.GetById(id);
                A.Id = AVM.Id;
                A.date_deb = AVM.date_deb;
                A.date_expiration = AVM.date_expiration;
                A.ListPanier = AVM.ListPanierModel;
                A.ListProduct = AVM.ListProduct;
                A.Price = AVM.Price;

                PackService.Update(A);
                PackService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pack/Delete/5
        public ActionResult Delete(int id)
        {
            Pack item = PackService.GetById(id);
            PackViewModel AVM = new PackViewModel();
            AVM.Id = item.Id;
            AVM.date_deb = item.date_deb;
            AVM.date_expiration = item.date_expiration;
            AVM.ListPanierModel = item.ListPanier;
            AVM.ListProduct = item.ListProduct;
            AVM.Price = item.Price;

            return View(AVM);
        }

        // POST: Pack/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                PackService.Delete(PackService.GetById(id));
                PackService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}