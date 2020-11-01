using System;

namespace prelim_exam
{
    public class Bird : Animal
    {
        public bool Hasfeather { get; set; }
        public bool Istoothless { get; set; }
        public bool Hasbeakjaws { get; set; }
        public bool Islaying { get; set; }
        public bool HasfourchamberedHeart { get; set; }
        public bool ISlightweightSkeleton { get; set; }


        public override void GetClass()
        {
            Console.WriteLine("Class: Aves");
        }

        public override void GetType()
        {
            Console.WriteLine("Type: bird");
        }
    }
    
    public class Eagle : Bird,Ibird
    {
        public void eagle()
        {
            Bird eagle = new Bird();

            crow.Hasfeather = true;
            crow.Istoothless = true;
            crow.Hasbeakjaws = true;
            crow.Islaying = true;
            crow.HasfourchamberedHeart = true;
            crow.ISlightweightSkeleton = true;
            this._numberOfLegs = 2;
            this.CanSwim = false;
            this.Name = "Zeta";

            Console.WriteLine("Eagle");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "has feather: " + dove.Hasfeather);
            Console.WriteLine(this.Name + "is toothless: " + dove.Istoothless);
            Console.WriteLine(this.Name + "has beakjaws: " + dove.Hasbeakjaws);
            Console.WriteLine(this.Name + "is Laying: " + dove.Islaying);
            Console.WriteLine(this.Name + "has four chamberered heart: " + dove.HasfourchamberedHeart);
            Console.WriteLine(this.Name + "is Light weight Skeleton: " + dove.ISlightweightSkeleton);
            Console.WriteLine(this.Name + "legs: : " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can Swim: " + dove.CanSwim);
        }

        public void eagleInfo()
        {
            Eagle eagle = new Eagle();
            eagle.eagle();
        }

    
    public class Crow : Bird,Ibird
    {
        public void crow()
        {
            Bird crow = new Bird();

            crow.Hasfeather = true;
            crow.Istoothless = true;
            crow.Hasbeakjaws = true;
            crow.Islaying = true;
            crow.HasfourchamberedHeart = true;
            crow.ISlightweightSkeleton = true;
            this._numberOfLegs = 2;
            this.CanSwim = false;
            this.Name = "Karasu";

            Console.WriteLine("Crow");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "has feather: " + dove.Hasfeather);
            Console.WriteLine(this.Name + "is toothless: " + dove.Istoothless);
            Console.WriteLine(this.Name + "has beakjaws: " + dove.Hasbeakjaws);
            Console.WriteLine(this.Name + "is Laying: " + dove.Islaying);
            Console.WriteLine(this.Name + "has four chamberered heart: " + dove.HasfourchamberedHeart);
            Console.WriteLine(this.Name + "is Light weight Skeleton: " + dove.ISlightweightSkeleton);
            Console.WriteLine(this.Name + "legs: : " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can Swim: " + dove.CanSwim);
        }

        public void crowInfo()
        {
            Crow crow = new Crow();
            crow.crow();
        }
}
