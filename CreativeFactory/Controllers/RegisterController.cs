using CreativeFactory.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using CreativeFactory.Models;

namespace CreativeFactory.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person p)
        {
            if (ModelState.IsValid)
            {
                string path = Server.MapPath(@"~\Data\data.csv");
                string formData = String.Empty;

                formData += string.Format("{0}, {1}, {2}, ", p.FirstName, p.LastName, p.Email);

                if (!string.IsNullOrWhiteSpace(p.Phone))
                    formData += string.Format("{0}, ", p.Phone);

                if (p.Sex != null)
                    formData += string.Format("{0}, ", p.Sex);

                try
                {
                    System.IO.File.AppendAllText(path, formData + Environment.NewLine);

                    //throw new IOException("testing error");

                    // This will clear whatever form items have been populated
                    ModelState.Clear();

                    ViewBag.Success = "Person added to csv file.";
                    return View();
                }
                catch (IOException ex)
                {
                    //ModelState.AddModelError("error_msg", ex.Message);

                    ViewBag.Error = ex.Message;
                    //return View(p);
                }
                catch (Exception ex)
                {
                    //ModelState.AddModelError("error_msg", ex);

                    ViewBag.Error = ex.Message;
                }

            }

            return View(p);
        }

    }
}