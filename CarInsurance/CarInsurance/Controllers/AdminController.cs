using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var users = db.Insurees;
                var userVms = new List<InsureeVm>();
                foreach (var user in users)
                {
                    var userVm = new InsureeVm();

                    userVm.FirstName = user.FirstName;
                    userVm.LastName = user.LastName;
                    userVm.EmailAddress = user.EmailAddress;
                    userVm.Quote = user.Quote;
                    userVms.Add(userVm);
                }
                return View(userVms);
            }
        }
    }
}