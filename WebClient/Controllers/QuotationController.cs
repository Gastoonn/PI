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
    public class QuotationController : Controller
    {
        IQuotationService QuotationService = new QuotationService();
        // GET: Quotation
        public ActionResult Index()
        {
            List<QuotationViewModel> list = new List<QuotationViewModel>();
            foreach (var item in QuotationService.GetAll())
            {
                QuotationViewModel AVM = new QuotationViewModel();
                AVM.Id = item.Id;
                AVM.Date_expiration = item.Date_expiration;
                AVM.QuoteNo = item.QuoteNo;
                AVM.Total = item.Total;
                AVM.TVA = item.TVA;

                list.Add(AVM);
            }
            return View(list);
        }

        // GET: Quotation/Details/5
        public ActionResult Details(int id)
        {
            Quotation item = QuotationService.GetById(id);

            QuotationViewModel AVM = new QuotationViewModel();
            AVM.Id = item.Id;
            AVM.Date_expiration = item.Date_expiration;
            AVM.QuoteNo = item.QuoteNo;
            AVM.Total = item.Total;
            AVM.TVA = item.TVA;

            return View(AVM);
        }

        // GET: Quotation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quotation/Create
        [HttpPost]
        public ActionResult Create(Quotation item)
        {
            try
            {
                // TODO: Add insert logic here
                Quotation AVM = new Quotation();
                AVM.Id = item.Id;
                AVM.Date_expiration = item.Date_expiration;
                AVM.QuoteNo = item.QuoteNo;
                AVM.Total = item.Total;
                AVM.TVA = item.TVA;

                QuotationService.Add(AVM);
                QuotationService.Commit();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quotation/Edit/5
        public ActionResult Edit(int id)
        {
            Quotation item = QuotationService.GetById(id);

            QuotationViewModel AVM = new QuotationViewModel();
            AVM.Id = item.Id;
            AVM.Date_expiration = item.Date_expiration;
            AVM.QuoteNo = item.QuoteNo;
            AVM.Total = item.Total;
            AVM.TVA = item.TVA;

            return View(AVM);
        }

        // POST: Quotation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, QuotationViewModel item)
        {
            try
            {
                // TODO: Add update logic here
                Quotation AVM = new Quotation();
                AVM.Id = item.Id;
                AVM.Date_expiration = item.Date_expiration;
                AVM.QuoteNo = item.QuoteNo;
                AVM.Total = item.Total;
                AVM.TVA = item.TVA;

                QuotationService.Update(AVM);
                QuotationService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quotation/Delete/5
        public ActionResult Delete(int id)
        {
            Quotation item = QuotationService.GetById(id);

            QuotationViewModel AVM = new QuotationViewModel();
            AVM.Id = item.Id;
            AVM.Date_expiration = item.Date_expiration;
            AVM.QuoteNo = item.QuoteNo;
            AVM.Total = item.Total;
            AVM.TVA = item.TVA;

            return View(AVM);
        }

        // POST: Quotation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                QuotationService.Delete(QuotationService.GetById(id));
                QuotationService.Commit();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
