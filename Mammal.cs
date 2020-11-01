using System;

namespace prelim_exam
{
    public class Mammal : Animal
    {
        // Mammals are vertebrates within the class Mammalia which have a neocortex (i.e., higher brain functions), hair, three middle ear bones, and mammary glands.

        public bool IsVertebrate { get; set; }
        public bool HasNeocortex { get; set; }
        public bool HasHair { get; set; }
        public bool HasThreeMiddleEarBones { get; set; }
        public bool HasMammaryGland { get; set; }

        public override void GetClass()
        {
            this._class = "Mammalia";
            Console.WriteLine(this._class);
        }

        public override void GetType()
        {
            this._ofType = "Mammal";
            Console.WriteLine(this._ofType);
        }
    }
    
    public class Bear : Mammal,Imammal
    {
        public void bear()
        {
            Mammal bear = new Mammal();
            
            this.Name = "Kuma";
            bear.IsVertebrate = true;
            bear.HasNeocortex = true;
            bear.HasHair = true;
            bear.HasThreeMiddleEarBones = true;
            bear.HasMammaryGland = true;
            this._numberOfLegs = 4;
            this.CanSwim = true;

            Console.WriteLine("Bear");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "is Vertebrate: " + bear.IsVertebrate);
            Console.WriteLine(this.Name + "Has Neocortex: " + bear.HasNeocortex);
            Console.WriteLine(this.Name + "has hair: " + bear.HasHair);
            Console.WriteLine(this.Name + "has three middle ear bone: " + bear.HasThreeMiddleEarBones);
            Console.WriteLine(this.Name + "has mammarygland: " + bear.HasMammaryGland);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);
        }
        
        public void bearInfo()
        {
            Bear bear = new Bear();
            bear.bear();
        }
       
    }
        
    public class Monkey : Mammal, Imammal
    {
        public void monkey()
        {
            Mammal monkey = new Mammal();
            
            this.Name = "Luffy";
            monkey.IsVertebrate = true;
            monkey.HasNeocortex = true;
            monkey.HasHair = true;
            monkey.HasThreeMiddleEarBones = true;
            monkey.HasMammaryGland = true;
            this._numberOfLegs = 4;
            this.CanSwim = true;

            Console.WriteLine("Bear");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "is Vertebrate: " + monkey.IsVertebrate);
            Console.WriteLine(this.Name + "Has Neocortex: " + monkey.HasNeocortex);
            Console.WriteLine(this.Name + "has hair: " + monkey.HasHair);
            Console.WriteLine(this.Name + "has three middle ear bone: " + monkey.HasThreeMiddleEarBones);
            Console.WriteLine(this.Name + "has mammarygland: " + monkey.HasMammaryGland);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);
        }
        
        public void monkeyInfo()
        {
            Monkey monkey = new Monkey();
            monkey.monkey();
        }
    }
}
