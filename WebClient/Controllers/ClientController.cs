using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class ClientController : Controller
    {
        IClientService AS = new ClientService();
        IShoppingCartService ShoppServ = new ShoppingCartService();
        // GET: client      
        public ActionResult Index()
        {
            List<Client> list = new List<Client>();
            foreach (var item in AS.GetAll())
            {
                Client A = new Client();
                A.adresse = item.adresse;
                A.nom = item.nom;
                A.prenom = item.prenom;
                A.password = item.password;
                A.login = item.login;
                A.telephone = item.telephone;
                A.id = item.id;

                list.Add(A);
            }
            return View(list);
        }
        // GET: Auteur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(ClientViewModel AVM)
        {
            Client A = new Client();
            A.adresse = AVM.adresse;
            A.nom = AVM.nom;
            A.prenom = AVM.prenom;
            A.password = AVM.password;
            A.login = AVM.login;
            A.telephone = AVM.telephone;
            AS.Add(A);
            AS.Commit();

            ShoppServ.setIdPanier();

            return RedirectToAction("Index");

        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

    }
}