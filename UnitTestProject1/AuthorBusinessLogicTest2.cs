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


        
    }
}
