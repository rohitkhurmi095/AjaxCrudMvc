using ClothBazar.Business.Interfaces;
using ClothBazar.Domain;
using ClothBazar.Web.Models.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ClothBazar.Web.Controllers
{
    public class CategoriesController : Controller
    {
        //DEPENDENCY INJECTION
        //====================
        //IF we have dependency on any object - pass it as a paramenter to constructor 
        //Instead of creating a new instance using new keyword
        //To use Dependency Injection in .net => Unity.MVC5 Package
        //Set service configuration in UnityConfig.cs in App_Start + use in Global.asax

        //Create CategoryService instance 
        //--------------------------------
        private ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }



        //Categories Page
        //----------------
        //Categories Table
        public ActionResult Index()
        {
            return View();
        }


        //===================
        //GET All Categories
        //===================
        //JSON Response - categoriesList()
        //To Solve Circular Dependency create Dto 
        public ActionResult GetCategories()
        {
            //Get Categories List
            var categories = _categoryService.GetAll().Select(c=> new CategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
            }).ToList();
            

            //return json response
            return Json(new { data=categories }, JsonRequestBehavior.AllowGet);
        }



        //================
        //CREATE Category
        //================
        //Create Category GET
        //--------------------
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        //Create Category POST
        //----------------------
        [HttpPost]
        public ActionResult Create(Category category)
        {
            //Check if ModelState is valid!
            //------------------------------
            if (ModelState.IsValid)
            {
                 //CREATE
                 _categoryService.Add(category);

                //return response
                return Json(new { success = true, message = "Create Successfully!" }, JsonRequestBehavior.AllowGet);
            }

            //If ModelState is not valid
            return Json(new { success = false, message = "Create Error!" }, JsonRequestBehavior.AllowGet);
        }


        //================
        //Update Category
        //================
        //Update Category GET
        //---------------------
        [HttpGet]
        public ActionResult Update(int Id)
        {
            var category = _categoryService.GetById(Id);
            
            if(category == null)
            {
                return HttpNotFound();
            }

            //Partial View
            return PartialView("_Update",category);
        }

        //Update Category POST
        //----------------------
        [HttpPost]
        public ActionResult Update(Category category)
        {
            //Check if ModelState is valid!
            //------------------------------
            if (ModelState.IsValid)
            {
                
                 //UPDATE
                 _categoryService.Update(category);
               
                //return response
                return Json(new { success = true, message = "Updated Successfully!" },JsonRequestBehavior.AllowGet);
            }

            //If ModelState is not valid
            return Json(new { success = false, message = "Update Error!" },JsonRequestBehavior.AllowGet);
        }

      

        //================
        //DELETE Category
        //================
        //POST Delete Category 
        //---------------------
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            try
            {
                //Delete Category
                _categoryService.Remove(Id);

                //return json response
                return Json(new { success = true, message = "Deleted Successfully" },JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { success = false, message = ex },JsonRequestBehavior.AllowGet);
            }
           
        }

    }
}