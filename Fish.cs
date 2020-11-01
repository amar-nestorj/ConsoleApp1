using System;

namespace prelim_exam
{
    public class Fish : Animal
    {
        //Fishes are the aquatic animals within the class Anatidae that do not have limbs with digits.
        public int Limbs { get; set; }

        public override void GetClass()
        {
            this._class = "Anatidae";
            Console.WriteLine(this._class);
        }

        public override void GetType()
        {
            this._ofType = "Fish";
            Console.WriteLine(this._ofType);
        
    }
    
    public class Clown : Fish,Ifish
    {
        public void clown()
        {
            Fish clown = new Fish();
            this.Name = "Nemo";
            this._numberOfLegs = 0;
            this.CanSwim = true;

            Console.WriteLine("Clown Fish");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "Legs: " + _numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);

        }

        public void clownInfo()
        {
            Clown clown = new Clown();
            clown.clown();
        }
    }
    
    public class Bluetang : Fish,Ifish
    {
        public void bluetang()
        {
            Fish bluetang = new Fish();
            this.Name = "Dory";
            this._numberOfLegs = 0;
            this.CanSwim = true;

            Console.WriteLine("Blue Tang");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "Legs: " + _numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);

        }

        public void bluetangInfo()
        {
            Bluetang bluetang = new Bluetang();
            bluetang.bluetang();
        }
    }
}
