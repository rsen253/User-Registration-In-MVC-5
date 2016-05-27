using CascadeDropdown.DBContext;
using CascadeDropdown.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadeDropdown.Models
{
    public class AdminController : Controller
    {
        // GET: Admin

        User _User = new User();
        Country _Country = new Country();
        State _State = new State();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCountry()
        {
            List<Country> allCountry = new List<Country>();
            using (DatabaseContext dbcontext = new DatabaseContext())
            {
                allCountry = dbcontext.Country.OrderBy(a => a.CountryName).ToList();
            }
            ViewBag.CountryId = new SelectList(allCountry, "CountryId", "CountryName");
            return View();
        }

        [HttpPost]
        public ActionResult AddCountry(CountryViewModel countryStateViewModel)
        {

            using (DatabaseContext dbcontext = new DatabaseContext())
            {
                var checkCountry = (from s in dbcontext.Country where s.CountryName == countryStateViewModel.CountryName select s).FirstOrDefault();
                ViewBag.Check = "";
                if (checkCountry == null)
                {
                    _Country.CountryName = countryStateViewModel.CountryName;
                    dbcontext.Country.Add(_Country);
                    dbcontext.SaveChanges();
                    ViewBag.Message = "Country Added Successfully";
                    ViewBag.Check = "Not Null";
                }
                else
                {
                    if (ViewBag.Check == "")
                    {
                        ViewBag.Message = "Country is already in the database";
                    }
                    else
                    {
                        ViewBag.Message = "Please try again";
                    }

                }

            }
            return View("AddCountry");
        }

        public ActionResult CountryList()
        {
            using (DatabaseContext dbcontext = new DatabaseContext())
            {
                return View(dbcontext.Country.OrderBy(a => a.CountryName).ToList());
            }
        }

        public ActionResult EditCountry(int Id = 0)
        {
            if (Id > 0)
            {
                using (DatabaseContext dbcontext = new DatabaseContext())
                {
                    CountryViewModel countryViewodel = new CountryViewModel();
                    var details = (from m in dbcontext.Country.Where(m => m.CountryID == Id) select m).SingleOrDefault();
                    //countryViewodel.CountryName = details.CountryName;
                    ViewBag.Country = details.CountryName;
                    return View();
                } 
            }
            else
            {
                return RedirectToAction("CountryList","Admin");
            }
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCountry([Bind(Include = "CountryName")]CountryViewModel _country, int id)
        {
            using (DatabaseContext dbcontext = new DatabaseContext())
            {
                ViewBag.Message = "";
                var checkid = (from s in dbcontext.Country where s.CountryID == id select s).FirstOrDefault();
                if (checkid != null)
                {
                    _Country.CountryName = _country.CountryName;
                    dbcontext.Country.Attach(_Country);
                    dbcontext.Entry(_Country).State = EntityState.Modified;
                    dbcontext.SaveChanges();
                    ViewBag.Message = "Country Updated Successfully";
                }
                else
                {
                    ViewBag.Message = "";
                    //return Content("Redirect to error page.");
                }
            }

            return View();
        }

        public ActionResult AddState()
        {
            List<Country> allCountry = new List<Country>();
            
            using (DatabaseContext dbcontext = new DatabaseContext())
            {
                allCountry = dbcontext.Country.OrderBy(a => a.CountryName).ToList();
            }
            ViewBag.CountryID = new SelectList(allCountry, "CountryID", "CountryName");
            return View();
        }


    }
}