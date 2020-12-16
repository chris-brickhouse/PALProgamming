
namespace PALProgramming {

    // create an enum object with different bottle types
    public enum BottleType {
        Beer, Soda, Juice, Water
    }

    // parent class Bottle, is inherited by children below
    // create parent class Bottle. It has Number, Size, and Type of the new enum from above properties which will be shared by all of the child objects Beer, Soda, Juice, Water
    class Bottle {        
        public int? Number { get; set; }
        public decimal? Size { get; set; }
        public BottleType Type { get; set; }
    }

    // children classes Beer, Soda, Juice, Water
    // each type has it's own properties but also inherits Number, Size, Type from Bottle
    // syntax is class {Child} : {Parent} - colon is inheritance indicator
    // each child item also sets what type it is in the constructor.

    // beer has ABV property that is unique to it
    class Beer : Bottle {

        public Beer() {
            Type = BottleType.Beer;
        }

        public string ABV { get; set; }
    }

    // Soda has SugarGrams property that is unique to it
    class Soda : Bottle {
        public Soda() {
            Type = BottleType.Soda;
        }

        public int? SugarGrams { get; set; }
    }

    // Juice has VitaminCount property that is unique to it
    class Juice : Bottle {

        public Juice() {
            Type = BottleType.Juice;
        }
        public int? VitaminCAmount { get; set; }
    }

    // Water has Source property that is unique to it
    class Water : Bottle {
        public Water() {
            Type = BottleType.Water;
        }

        public string Source { get; set; }

    }


}
