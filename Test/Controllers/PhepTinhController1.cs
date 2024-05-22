using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Controllers
{
    public class PhepTinhController1 : Controller
    {
        public IActionResult Index()

        {
            //double ketQua = 0;
            //switch (phepTinh)
            //{
            //    case "+":
            //        ketQua = So1 + So2;
            //        break;

            //    case "-":
            //        ketQua = So1 - So2;
            //        break;
            //    case "*":
            //        ketQua = So1 * So2;
            //        break;
            //    case "/":
            //        ketQua = So1 / So2;
            //        break;
            //        //default:
            //        //    break;
            //}
            //ViewData["K"] = ketQua;
            //ViewBag.KQ = ketQua;
            return View();
        }
        //public IActionResult XuLy(double So1,double So2,string phepTinh)
        //{
        //    double ketQua=0;
        //    switch (phepTinh)
        //    {
        //        case "+":ketQua = So1 + So2;
        //            break;

        //        case"-":ketQua = So1 - So2;
        //            break;
        //        case "*":
        //            ketQua = So1 * So2;
        //            break;
        //        case "/":
        //            ketQua = So1 / So2;
        //            break;
        //        //default:
                
        //        //    break;
        //    }
        //    ViewData["K"] = ketQua;
        //    ViewBag.KQ =ketQua;
        //    return View();
        //}
        public IActionResult XuLy(MayTinhModels mt)
        {
            double ketQua = 0;
            switch (mt.phepTinh)
            {
                case "+":
                    ketQua = mt.So1 + mt.So2;
                    break;

                case "-":
                    ketQua = mt.So1 - mt.So2;
                    break;
                case "*":
                    ketQua = mt.So1 * mt.So2;
                    break;
                case "/":
                    ketQua = mt.So1 / mt.So2;
                    break;
                    //default:

                    //    break;
            }
           // ViewData["K"] = ketQua;
            ViewBag.KQ = ketQua;
            return View("Index");
        }
    }
}
