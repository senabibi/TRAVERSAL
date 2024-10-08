﻿using BusinessLayer.Concerete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRAVERSAL.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManger = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManger.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = destinationManger.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {

            return View();
        }
    }
}
