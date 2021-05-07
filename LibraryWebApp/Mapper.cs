using ConsoleLibrary.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryWebApp.Models;
using LibraryCommon;

namespace LibraryWebApp.Mapping
{
    public class Mapper
    {
        internal static List<AuthorModel> AuthorListToAuthorModelList(List<Author> list)
        {
            //throw new NotImplementedException();

            List<AuthorModel> _returnedList = new List<AuthorModel>();


            foreach(Author item in list)
            {

                AuthorModel m = new AuthorModel();

                m.FirstName = item.FirstName;
                m.LastName = item.LastName;
                m.AuthorID = item.AuthorID;
                m.Bio = item.Bio;
                m.BirthLocation = item.BirthLocation;
                m.DateOfBirth = item.DateOfBirth;

                _returnedList.Add(m);


            }
            return _returnedList;
            
            // List of Authors from common layer 

        }

        public List<RoleModel> RoleListToRoleModels(List<Role> list)
        {
            List<RoleModel> toReturn = new List<RoleModel>();


            foreach (Role role in list)
            {
                RoleModel newModel = new RoleModel();
                newModel.RoleID = role.RoleID;
                newModel.RoleName = role.RoleName;

                toReturn.Add(newModel);
            }

            return toReturn;
        }

        internal List<UserModel> UserListToUserModels(List<User> list)
        {
            List<UserModel> toReturn = new List<UserModel>();


            foreach (User user in list)
            {
                UserModel newModel = new UserModel();

                newModel.UserID = user.UserID;
                newModel.FirstName = user.FirstName;
                newModel.LastName = user.LastName;
                newModel.UserName = user.UserName;
                newModel.Password = user.Password;
                newModel.RoleID_FK = user.RoleID_FK;
                newModel.Salt = user.Salt;

                toReturn.Add(newModel);
            }

            return toReturn;
        }


    }
}