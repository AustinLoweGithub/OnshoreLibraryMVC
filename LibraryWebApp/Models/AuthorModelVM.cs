using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryCommon;
using ConsoleLibrary.DataEntity;
using LibraryWebApp;
using LibraryWebApp.Mapping;

namespace LibraryWebApp.Models
{
    public class AuthorModelVM
    {
        public IEnumerable<AuthorModel> ListOfAuthorModel { get; set; }


        public AuthorModelVM (List<Author> list)
        {

            ListOfAuthorModel = Mapper.AuthorListToAuthorModelList(list);

           


        }



    }
}