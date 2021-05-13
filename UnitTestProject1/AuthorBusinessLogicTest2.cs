using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryCommon;
using LibraryDatabaseAccessLayer;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ConsoleLibrary.DataEntity;
using BusinessLogic;

namespace UnitTestProject1
{
    [TestClass]
    public class AuthorBusinessLogicTest2
    { 

            public string _conn = @"Data Source=KILLAR\SQLEXPRESS;Initial Catalog=LibraryTest;Integrated Security=True";
            public AuthorBusinessLogic _businessLogic;


       

        public AuthorBusinessLogicTest2()
        {
            _businessLogic = new AuthorBusinessLogic(_conn);

        }



        [TestMethod]

            public void Get_Author_Thru_Business_Logic()
            {

                //AuthorBusinessLogic _businessLogic = new AuthorBusinessLogic();


                List<Author> _callOne = _businessLogic.GetAuthorPassThru();
                List<Author> _callTwo = _businessLogic.GetAuthorPassThru();


                Assert.AreEqual(_callOne.Count, _callTwo.Count);


            }


        [TestMethod]
        public void TestCreateAuthor()
        {
            Author test = new Author();

            test.AuthorID = 45;
            test.FirstName = "Greg";
            test.LastName = "Gregory";
            test.Bio = "biography";
            test.BirthLocation = "over there";
            test.DateOfBirth = new DateTime(2015,12,31,5,10,20);



            _businessLogic.CreateAuthorPassThru(test);

           List<Author> _auths = _businessLogic.GetAuthorPassThru();

            foreach (Author auth in _auths)
            {
                if (auth.FirstName.Equals("Greg"))
                {
                    Assert.AreEqual("Greg", auth.FirstName);
                    Assert.AreEqual("Gregory", auth.LastName);
                    Assert.AreEqual("biography", auth.Bio);
                    Assert.AreEqual("over there", auth.BirthLocation);
                }
            }
        }






  
       



    }
}
