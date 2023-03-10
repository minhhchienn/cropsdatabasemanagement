using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace QuanLyCSDLTrongTrot.Classes
{
    public class User
    {
        //private properties
        public readonly string? id;
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? email { get; set; }
        public string? number { get; set; }
        public string? dob { get; set; }
        public string? gender { get; set; }
        public string? country { get; set; }
        public string? status;
        public string? GroupID;
        public string? avatar;

        //Constructor Method
        public User()
        {
            
        }
        public User(string id, string firstname,string lastname, string username, string password, string email,
            string number, string dob, string gender, string country, string status, string GroupID, string avatar)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
            this.email = email;
            this.number = number;
            this.dob = dob;
            this.gender = gender;
            this.country = country;
            this.status = status;
            this.GroupID = GroupID;
            this.avatar = avatar;
        }

        //Method
        public void UpdateFirstName(string firstname) {this.firstname = firstname;}
        public void UpdateLastName(string lastname) { this.lastname = lastname;}
        public void UpdateUserName(string username) { this.username = username;}
        public void UpdatePassword(string password) { this.password = password;}
        public void UpdateEmail(string email) { this.email = email;}
        public void UpdateGender(string gender) { this.gender = gender;}
        public void UpdateNumber(string number) { this.number = number;}
        public void UpdateDoB(string dob) { this.dob = dob;}
        public void UpdateCountry(string country) { this.country = country;}
        public void UpdateStatus(string status) { this.status = status;}
        public void UpdateGroupID(string groupID) { GroupID = groupID;}
        public void UpdateAvatar(string avatar) { this.avatar = avatar;}
    }
}
