using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;


namespace Test.Controllers
{
    public class DangKyController1 : Controller
    {
        // khai báo
        private IHostingEnvironment hosting;
        public DangKyController1(IHostingEnvironment _hosting)
        {
            hosting = _hosting;
        }
        public IActionResult Index()
        {
            return View();
        }
        //
        public IActionResult XuLyDangKy(DangKyModels m,IFormFile FHinh)
        {
            if (FHinh != null)
            {
                // Xử lý uploads
                string fileName = Guid.NewGuid().ToString()+ Path.GetExtension(FHinh.FileName);
                string path = Path.Combine(hosting.WebRootPath, "images");
                using (var filestream=new FileStream(Path.Combine(path,fileName), FileMode.Create))
                {
                    // sao chép lên server
                    FHinh.CopyTo(filestream);
                }
                m.Fhinh = fileName;
            }

            return View(m);
        }
    }
}
