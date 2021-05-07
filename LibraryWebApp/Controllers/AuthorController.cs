using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsoleLibrary.DataEntity;
using BusinessLogic;
using LibraryWebApp.Models;
using LibraryCommon;

namespace LibraryWebApp.Controllers
{
    public class AuthorController : Controller
    {


        private readonly string _dbConn;
        private AuthorBusinessLogic authBusLay;

        // GET: Author


        public AuthorController() : base()
        {

            _dbConn = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            authBusLay = new AuthorBusinessLogic(_dbConn);

        }


        public ActionResult Index()
        {


            return View();
        }




        [HttpGet]
        public ActionResult GetAuthors()
        {

            

            List<Author> list = authBusLay.GetAuthorPassThru();

            AuthorModelVM _curr = new AuthorModelVM(list);
          


            //List<Author> authlist = list; 




            //GetAuthors model = new AuthorListVM(authlist);


            // into business logic layer
            // to dataaccess layer

            return View(_curr);

        }





        [HttpGet]
        
        public ActionResult UpdateAuthor(AuthorModel model, int AuthorID)
        {
            
            AuthorModelVM list = new AuthorModelVM(authBusLay.GetAuthorPassThru());
            ViewBag.Author = new SelectList(list.ListOfAuthorModel, "AuthorID");
            model.AuthorID = AuthorID;


            return View(model);


            // df
        }




        [HttpPost]

        public ActionResult UpdateAuthor(AuthorModel _Update)
        {
             Author _auth = new Author();


            _auth.AuthorID = _Update.AuthorID;
            _auth.FirstName = _Update.FirstName;
            _auth.LastName = _Update.LastName;
            _auth.Bio = _Update.Bio;
            _auth.BirthLocation = _Update.BirthLocation;
            _auth.DateOfBirth = _Update.DateOfBirth;





            authBusLay.UpdateAuthorPassThru(_auth);

            return RedirectToAction("GetAuthors", "Author");


        }


        [HttpGet]

        public ActionResult CreateAuthor()
        {


            return View();
        }



        [HttpPost]

        public ActionResult CreateAuthor(AuthorModel _Create)
        {
            Author _auth = new Author();

            _auth.AuthorID = _Create.AuthorID;
            _auth.FirstName = _Create.FirstName;
            _auth.LastName = _Create.LastName;
            _auth.Bio = _Create.Bio;
            _auth.BirthLocation = _Create.BirthLocation;
            _auth.DateOfBirth = _Create.DateOfBirth;

            authBusLay.CreateAuthorPassThru(_auth);

            return RedirectToAction("GetAuthors", "Author");

        }


        [HttpPost]

        public ActionResult DeleteAuthor(int _id)
        {

            Author _auth = new Author();

            _auth.AuthorID = _id;

            authBusLay.DeleteAuthorPassThru(_auth);

            return RedirectToAction("GetAuthors", "Author");


        }



        //[HttpGet] //get user. createUser. //  return View(_curr);

        //[HttpPost] ///put info into the thing // return RedirectToAction("GetAuthors", "Author");





    }
}