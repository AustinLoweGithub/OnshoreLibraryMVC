using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCommon;
using LibraryDatabaseAccessLayer;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ConsoleLibrary.DataEntity;

namespace BusinessLogic
{
    public class AuthorBusinessLogic
    {

        private AuthorDataAccess _data;

        public AuthorBusinessLogic(string _conn)
        {

            _data = new AuthorDataAccess(_conn);

        }

        public AuthorBusinessLogic()
        {

            _data = new AuthorDataAccess();

        }

        public List<Author> GetAuthorPassThru()
        {


            List<Author> _list = _data.GetAuthor();
            return _list;


        }


        public void CreateAuthorPassThru(Author _auth)
        {

            _data.CreateAuthor(_auth);


        }

        public void UpdateAuthorPassThru(Author _auth)
        {

            _data.UpdateAuthor(_auth);


        }

        public void DeleteAuthorPassThru(Author _auth)
        {
            _data.DeleteAuthor(_auth);
        }
    }
}
