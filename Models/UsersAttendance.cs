using System;

// to use [Table] and [Key] attributes you need to import the below to every class.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PALProgramming.Models {

    // This is for the database table "UsersAttendance", which has the fields UsersAttendanceID, UserID, ClassID, AttendanceDate, TimeStamp, DeleteFlag, IsTeacher
    // it also has an object for the Class object which uses the ForeignKey ClassID to link with
    // each field from the db matches up to the property by the same name and equivalent data type. 
    // every class used as a model should be like this.
    
    // ACTION: after completing, return to UsersGrades.cs

    [Table("UsersAttendance")]
    class UsersAttendance {

        [Key]
        public int UserAttendanceID { get; set; }
        public int? UserID { get; set; }
        public int? ClassID { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public DateTime? TimeStamp { get; set; } = DateTime.Now;
        public bool? DeleteFlag { get; set; } = false;

        [ForeignKey("ClassID")]
        public virtual Classes Class { get; set; }

    }
}
