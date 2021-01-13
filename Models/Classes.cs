using System;

// to use [Table] and [Key] attributes you need to import the below to every class.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PALProgramming.Models {

    // This is for the database table "Classes", which has the fields Name, Description, Cost, Capacity, LocationID, TimeStamp, DeleteFlag. 
    // each field from the db matches up to the property by the same name and equivalent data type. 
    // every class used as a model should be like this.

    // ACTION: add all of the below code then go to Users.cs

    // every table has a [Table] attribute, which specifies the name of the table in the database.
    [Table("Classes")]
    class Classes {

        // key indicates that this is the unique ID for this table. it is an "int" datatype and not nullable
        [Key]
        public int ClassID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        // question marks after the data type indicate that the propert is nullable. strings do not need this.
        public decimal? Cost { get; set; }
        public int? Capacity { get; set; }
        public int? LocationID { get; set; }
        public DateTime? TimeStamp { get; set; } = DateTime.Now;
        public bool? DeleteFlag { get; set; } = false;

    }
}
