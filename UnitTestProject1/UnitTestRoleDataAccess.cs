using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryCommon;
using LibraryDatabaseAccessLayer;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



namespace UnitTestProject1
{

    
    [TestClass]
    public class UnitTestRoleDataAccess
    {

        public String _conn = @"Data Source=KILLAR\SQLEXPRESS;Initial Catalog=LibraryTest;Integrated Security=True";
        public RoleDataAccess _data;

        public UnitTestRoleDataAccess()
        {
            _data = new RoleDataAccess(_conn);

        }

        [TestMethod]

        public void ConnectionTestDB()
        {
            SqlConnection con = new SqlConnection(_conn);

            con.Open();

            string teststring = con.State.ToString();

            Console.WriteLine(teststring);
            
            con.Close();

          


        }



        [TestMethod]
        public void Add_One_Role()
        {
            // arrange
           
            List<Role> list = new List<Role>();

            // act

            list = _data.GetRoles();
            int _countBeforeAdd = list.Count;

            Role r = new Role { RoleName = "Testing Role" };
            _data.CreateRole(r);
            // assert
            // need to delete this one

            list = _data.GetRoles();
            int _countAfterAdd = list.Count;

            Assert.IsTrue(_countBeforeAdd + 1 == _countAfterAdd);
            // cleanup
            
        }


      



    }
}
