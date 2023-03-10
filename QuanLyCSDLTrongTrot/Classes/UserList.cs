using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace QuanLyCSDLTrongTrot.Classes
{
    internal class UserList
    {
        public readonly List<User> users;

        public UserList(List<User> users)
        {
            this.users = users;
        }
        public UserList(DataTable dt)
        {
            List<User> users = new();
            foreach (DataRow row in dt.Rows)
            {
                User user = new(
                    id: row["ID"].ToString(),
                    firstname: row["FirstName"].ToString(),
                    lastname: row["LastName"].ToString(),
                    username: row["UserName"].ToString(),
                    password: row["Password"].ToString(),
                    gender: row["Gender"].ToString(),
                    country: row["Country"].ToString(),
                    GroupID: row["GroupID"].ToString(),
                    number: row["Number"].ToString(),
                    email: row["Email"].ToString(),
                    avatar: row["AvatarPath"].ToString(),
                    dob: row["DoB"].ToString(),
                    status: row["Status"].ToString()
                    );
                users.Add( user );
            }
        }
        public User GetUser(string username)
        {
            foreach(User user in users)
            {
                if (user.username == username) return user;
            }
            return new User();
        }
    }
}
