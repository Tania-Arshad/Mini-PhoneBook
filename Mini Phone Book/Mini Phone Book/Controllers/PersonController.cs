using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mini_Phone_Book.Models;

namespace Mini_Phone_Book.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonViewModel obj)
        {
            try
            {
                Person s = new Person();
                s.DateOfBirth = obj.DateOfBirth;
                s.EmailId = obj.EmailId;
                s.FirstName = obj.FirstName;
                s.MiddleName = obj.MiddleName;
                s.LastName = obj.LastName;
                s.PersonId = obj.PersonId;
                s.AddedBy = obj.AddedBy;
                s.AddedOn = obj.AddedOn;
                s.HomeAddress = obj.HomeAddress;
                s.HomeCity = obj.HomeCity;
                s.FaceBookAccountId = obj.FaceBookAccountId;
                s.TwitterId = obj.TwitterId;
                s.LinkedInId = obj.LinkedInId;
                s.UpdateOn = obj.UpdateOn;
                s.ImagePath = obj.ImagePath;

                PhoneBookDbEntities1 db = new PhoneBookDbEntities1();
                db.People.Add(s);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
(System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
