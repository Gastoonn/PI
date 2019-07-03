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
    public class TheStoreController : Controller
    {
        IStoreService StoreService = new StoreService();
        // GET: Store
        public ActionResult Index()
        {
            List<StoreViewModel> list = new List<StoreViewModel>();
            foreach (var item in StoreService.GetAll())
            {
                StoreViewModel AVM = new StoreViewModel();
                AVM.Id = item.Id;
                AVM.Adresse = item.Adresse;
                AVM.Name = item.Name;
                AVM.Tel = item.Tel;
                AVM.Horaire_ouverture = item.Horaire_ouverture;
                AVM.Stock = item.Stock;


                list.Add(AVM);
            }
            return View(list);
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            Store item = StoreService.GetById(id);

            StoreViewModel AVM = new StoreViewModel();
            AVM.Id = item.Id;
            AVM.Adresse = item.Adresse;
            AVM.Name = item.Name;
            AVM.Tel = item.Tel;
            AVM.Horaire_ouverture = item.Horaire_ouverture;
            AVM.Stock = item.Stock;
            return View();
        }

        // GET: Store/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Store/Create

        [HttpPost]
        public ActionResult Create(StoreViewModel AVM)
        {
            try
            {
                // TODO: Add insert logic here
                Store A = new Store();
                A.Id = AVM.Id;
                A.Adresse = AVM.Adresse;
                A.Name = AVM.Name;
                A.Tel = AVM.Tel;
                A.Horaire_ouverture = AVM.Horaire_ouverture;
                A.Stock = AVM.Stock;

                StoreService.Add(A);
                StoreService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Store/Edit/5
        public ActionResult Edit(int id)
        {
            Store item = StoreService.GetById(id);
            StoreViewModel AVM = new StoreViewModel();
            AVM.Id = item.Id;
            AVM.Adresse = item.Adresse;
            AVM.Name = item.Name;
            AVM.Tel = item.Tel;
            AVM.Horaire_ouverture = item.Horaire_ouverture;
            AVM.Stock = item.Stock;

            return View();
        }

        // POST: Store/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StoreViewModel AVM)
        {
            try
            {
                // TODO: Add update logic here
                Store A = StoreService.GetById(id);
                A.Id = AVM.Id;
                A.Adresse = AVM.Adresse;
                A.Name = AVM.Name;
                A.Tel = AVM.Tel;
                A.Horaire_ouverture = AVM.Horaire_ouverture;
                A.Stock = AVM.Stock;

                StoreService.Update(A);
                StoreService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            Store item = StoreService.GetById(id);
            StoreViewModel AVM = new StoreViewModel();
            AVM.Id = item.Id;
            AVM.Adresse = item.Adresse;
            AVM.Name = item.Name;
            AVM.Tel = item.Tel;
            AVM.Horaire_ouverture = item.Horaire_ouverture;
            AVM.Stock = item.Stock;

            return View(AVM);
        }

        // POST: Store/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                StoreService.Delete(StoreService.GetById(id));
                StoreService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
