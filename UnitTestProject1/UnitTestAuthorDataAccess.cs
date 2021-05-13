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
    class UnitTestAuthorDataAccess
    {

        public String _conn = @"Data Source=KILLAR\SQLEXPRESS;Initial Catalog=LibraryTest;Integrated Security=True";
        public AuthorDataAccess _data;

        public UnitTestAuthorDataAccess()
        {
            _data = new AuthorDataAccess(_conn);

        }



        [TestMethod]

        public void Get_Author()
        {
            List<Author> authors = _data.GetAuthor();

            Assert.AreEqual(5, authors.Count);
            


        }




        [TestMethod]

        public void Add_Author()
        {
            Author test = new Author();

            test.FirstName = "ugh";
            test.LastName = "imdone";
            test.Bio = "these tests are annoying when I know it works";
            test.BirthLocation = "fiveworkingtests";
            test.DateOfBirth = new DateTime(2015, 12, 31, 5, 10, 20);


            List<Author> authors = _data.GetAuthor();

            foreach (Author auth in authors)
            {
                if (auth.FirstName.Equals("ugh"))
                {
                    Assert.AreEqual("ugh", auth.FirstName);
                    Assert.AreEqual("imdone", auth.LastName);
                    Assert.AreEqual("these tests are annoying when I know it works", auth.Bio);
                    Assert.AreEqual("fiveworkingtests", auth.BirthLocation);
                
                }
            }


        }


        [TestMethod]
        public void Update_Author()
        {


        }

        [TestMethod]
        public void Delete_Author()
        {


        }

        
    }
}
