using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MakerStore.Models;

namespace MakerStore.Controllers
{
    public class StoreController : Controller
    {
        MakerStoreEntities storeDB = new MakerStoreEntities();

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var categories = storeDB.Categories.ToList();

            return View(categories);
        }

        //
        // GET: /Store/Browse?category=robotics

        public ActionResult Browse(string category)
        {
            // Retrieve Category and its Associated Products from database
            var categoryModel = storeDB.Categories.Include("Products").Single(c => c.Name == category);

            return View(categoryModel);
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var product = storeDB.Products.Find(id);
            return View(product);
        }

        //
        // GET: /Store/CategoryMenu

        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();

            return PartialView(categories);
        }

    }
}
