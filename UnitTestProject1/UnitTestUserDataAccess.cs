using LibraryCommon;
using LibraryDatabaseAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTestUserDataAccess
    {
        public string _conn = @"Data Source = KILLAR\SQLEXPRESS;Initial Catalog = LibraryTest; Integrated Security = True";
        private UserDataAccess _data;
        User testUser = new User();

        public UnitTestUserDataAccess()
        {
            _data = new UserDataAccess(_conn);
        }

        [TestMethod]
        public void TestGetUser()
        {
            List<User> users = _data.GetUsers();

            Assert.AreEqual(6, users.Count);

        }

   
        
    }
}