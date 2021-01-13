using System;

// to use List, you need to import this
using System.Collections.Generic;

// to use [Table] and [Key] attributes you need to import the below to every class.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PALProgramming.Models {

    // This is for the database table "Users", which has the fields FirstName, LastName, Email, Password, TimeStamp, DeleteFlag, IsTeacher
    // each field from the db matches up to the property by the same name and equivalent data type. 
    // every class used as a model should be like this.

    // ACTION: add the below code then go to UsersAttendance.cs

    [Table("Users")]
    class Users {

        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? TimeStamp { get; set; } = DateTime.Now;
        public bool? DeleteFlag { get; set; } = false;
        public bool? IsTeacher { get; set; }

        // this is a list of child objects of type UsersAttendance
        [ForeignKey("UserID")]
        public virtual List<UsersAttendance> UsersAttendance { get; set; }

        // this is a list of child objects of type UsersGRades
        [ForeignKey("UserID")]
        public virtual List<UsersGrades> UsersGrades { get; set; }

        // not mapped means it's not linked to the database. this function returns the name formated "FirstName LastName"
        [NotMapped]
        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }


    }
}
