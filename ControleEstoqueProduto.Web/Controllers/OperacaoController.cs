﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoqueProduto.Web.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize] 
        public ActionResult EntradaProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult SaidaProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult LancPerdaProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult Inventario()
        {
            return View();
        }
    }
}