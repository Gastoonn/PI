using Domain.Entities;
using Newtonsoft.Json.Linq;
using Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class ReclamationController : Controller
    {
        IReclamationService ReclamationService = new ReclamationService();
        IClientService ClientService = new ClientService();
        // GET: Reclamation
        public ActionResult Index()
        {
           // Debug.WriteLine("Ici =>");
            List<Reclamation> list = new List<Reclamation>();
            foreach (var item in ReclamationService.GetAll())
            {
                //   Debug.WriteLine(item.ToString());
                Reclamation AVM = new Reclamation();
                AVM.dateReclamation = item.dateReclamation;
                AVM.idClient = item.idClient;
                AVM.CategorieReclamation = item.CategorieReclamation;
                AVM.SujetReclamation = item.SujetReclamation;
                AVM.textReclamation = item.textReclamation;
                AVM.EtatReclamation = item.EtatReclamation;
                AVM.Id = item.Id;
               
                list.Add(AVM);
            }
            return View(list);
        }

        // GET: Reclamation/Details/5
        public ActionResult Details(int id)
        {
            Reclamation item = ReclamationService.GetById(id);

            Reclamation AVM = new Reclamation();
            AVM.dateReclamation = item.dateReclamation;
            AVM.idClient = item.idClient;
            AVM.CategorieReclamation = item.CategorieReclamation;
            AVM.SujetReclamation = item.SujetReclamation;
            AVM.textReclamation = item.textReclamation;
            AVM.EtatReclamation = item.EtatReclamation;
            AVM.Id = item.Id;

            return View(AVM);
        }

        // GET: Reclamation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reclamation/Create
        [HttpPost]
        public ActionResult Create(Reclamation item)
        {
            try
            {
                // TODO: Add insert logic here
                Reclamation AVM = new Reclamation();
                AVM.dateReclamation = item.dateReclamation;
                AVM.idClient = item.idClient;
                AVM.CategorieReclamation = item.CategorieReclamation;
                AVM.SujetReclamation = item.SujetReclamation;
                AVM.textReclamation = item.textReclamation;
                AVM.EtatReclamation = item.EtatReclamation;
                AVM.Id = item.Id;

                ReclamationService.Add(AVM);
                ReclamationService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reclamation/Edit/5
        public ActionResult Edit(int id)
        {
            Reclamation item = ReclamationService.GetById(id);

            Reclamation AVM = new Reclamation();
            AVM.dateReclamation = item.dateReclamation;
            AVM.idClient = item.idClient;
            AVM.CategorieReclamation = item.CategorieReclamation;
            AVM.SujetReclamation = item.SujetReclamation;
            AVM.textReclamation = item.textReclamation;
            AVM.EtatReclamation = item.EtatReclamation;
            AVM.Id = item.Id;

            return View(AVM);
        }

        // POST: Reclamation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Reclamation item)
        {
            try
            {
                // TODO: Add update logic here
                Reclamation AVM = ReclamationService.GetById(id);
                AVM.dateReclamation = item.dateReclamation;
                AVM.idClient = item.idClient;
                AVM.CategorieReclamation = item.CategorieReclamation;
                AVM.SujetReclamation = item.SujetReclamation;
                AVM.textReclamation = item.textReclamation;
                AVM.EtatReclamation = item.EtatReclamation;


                ReclamationService.Update(AVM);
                ReclamationService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reclamation/Delete/5
        public ActionResult Delete(int id)
        {
            Reclamation item = ReclamationService.GetById(id);

            Reclamation AVM = new Reclamation();
            AVM.dateReclamation = item.dateReclamation;
            AVM.idClient = item.idClient;
            AVM.CategorieReclamation = item.CategorieReclamation;
            AVM.SujetReclamation = item.SujetReclamation;
            AVM.textReclamation = item.textReclamation;
            AVM.EtatReclamation = item.EtatReclamation;
            AVM.Id = item.Id;

            return View(AVM);
        }

        // POST: Reclamation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ReclamationService.Delete(ReclamationService.GetById(id));
                ReclamationService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
