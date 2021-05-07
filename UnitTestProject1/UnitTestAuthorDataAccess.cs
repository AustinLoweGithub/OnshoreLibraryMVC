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




        }




        [TestMethod]

        public void Add_Author()
        {




        }



    }
}
