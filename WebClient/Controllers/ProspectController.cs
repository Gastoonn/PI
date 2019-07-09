using Domain.Entities;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class ProspectController : Controller
    {
        IProspectService ProspectService = new ProspectService();
        // GET: Prospect
        public ActionResult Index()
        {
            List<Prospect> list = new List<Prospect>();
            foreach (var item in ProspectService.GetAll())
            {
                Prospect AVM = new Prospect();
                AVM.Address = item.Address;
                AVM.DateDebut = item.DateDebut;
                AVM.DateFin = item.DateFin;
                AVM.MatriculeAgents = item.MatriculeAgents;
                AVM.ProspectNumber = item.ProspectNumber;
                AVM.Vehicules = item.Vehicules;

                list.Add(AVM);
            }
            return View(list);
        }

        // GET: Prospect/Details/5
        public ActionResult Details(int id)
        {
            Prospect item = ProspectService.GetById(id);

            Prospect AVM = new Prospect();
            AVM.Address = item.Address;
            AVM.DateDebut = item.DateDebut;
            AVM.DateFin = item.DateFin;
            AVM.MatriculeAgents = item.MatriculeAgents;
            AVM.ProspectNumber = item.ProspectNumber;
            AVM.Vehicules = item.Vehicules;

            return View(AVM);
        }

        // GET: Prospect/Create
        public ActionResult Create()
        {
            return View();
        }

        
        // POST: Prospect/Create
        [HttpPost]
        public ActionResult Create(Prospect item)
        {
            try
            {
                // TODO: Add insert logic here
                Prospect AVM = new Prospect();
                AVM.Address = item.Address;
                AVM.DateDebut = item.DateDebut;
                AVM.DateFin = item.DateFin;
                AVM.MatriculeAgents = item.MatriculeAgents;
                AVM.ProspectNumber = item.ProspectNumber;
                AVM.Vehicules = item.Vehicules;

                ProspectService.Add(AVM);
                ProspectService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prospect/Edit/5
        public ActionResult Edit(int id)
        {
            Prospect item = ProspectService.GetById(id);

            Prospect AVM = new Prospect();
            AVM.Address = item.Address;
            AVM.DateDebut = item.DateDebut;
            AVM.DateFin = item.DateFin;
            AVM.MatriculeAgents = item.MatriculeAgents;
            AVM.ProspectNumber = item.ProspectNumber;
            AVM.Vehicules = item.Vehicules;

            return View(AVM);
        }

        // POST: Prospect/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Prospect item)
        {
            try
            {
                // TODO: Add update logic here
                Prospect AVM = ProspectService.GetById(id);
                AVM.Address = item.Address;
                AVM.DateDebut = item.DateDebut;
                AVM.DateFin = item.DateFin;
                AVM.MatriculeAgents = item.MatriculeAgents;
                AVM.Vehicules = item.Vehicules;

                ProspectService.Update(AVM);
                ProspectService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prospect/Delete/5
        public ActionResult Delete(int id)
        {
            Prospect item = ProspectService.GetById(id);

            Prospect AVM = new Prospect();
            AVM.Address = item.Address;
            AVM.DateDebut = item.DateDebut;
            AVM.DateFin = item.DateFin;
            AVM.MatriculeAgents = item.MatriculeAgents;
            AVM.ProspectNumber = item.ProspectNumber;
            AVM.Vehicules = item.Vehicules;

            return View(AVM);
        }

        // POST: Prospect/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ProspectService.Delete(ProspectService.GetById(id));
                ProspectService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
