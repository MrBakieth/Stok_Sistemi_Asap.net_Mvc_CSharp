﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStock.Models.Entity;

namespace MvcStock.Controllers
{
    public class SatisController : Controller
    {
        MvcDbStokEntities db = new MvcDbStokEntities();
        // GET: SATIS
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YeniSatis() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");
        }


    }
}