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
            this._class = "Aves";
            Console.WriteLine(this._class);
        }

        public override void GetType()
        {
            this._ofType = "Bird";
            Console.WriteLine(this._ofType);
        }
    }
    
    public class Eagle : Bird,Ibird
    {
        public void eagle()
        {
            Bird eagle = new Bird();

            eagle.Hasfeather = true;
            eagle.Istoothless = true;
            eagle.Hasbeakjaws = true;
            eagle.Islaying = true;
            eagle.HasfourchamberedHeart = true;
            eagle.ISlightweightSkeleton = true;
            this._numberOfLegs = 2;
            this.CanSwim = false;
            this.Name = "Zeta";

            Console.WriteLine("Eagle");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "has feather: " + eagle.Hasfeather);
            Console.WriteLine(this.Name + "is toothless: " + eagle.Istoothless);
            Console.WriteLine(this.Name + "has beakjaws: " + eagle.Hasbeakjaws);
            Console.WriteLine(this.Name + "is Laying: " + eagle.Islaying);
            Console.WriteLine(this.Name + "has four chamberered heart: " + eagle.HasfourchamberedHeart);
            Console.WriteLine(this.Name + "is Light weight Skeleton: " + eagle.ISlightweightSkeleton);
            Console.WriteLine(this.Name + "legs: : " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can Swim: " + eagle.CanSwim);
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
            Console.WriteLine(this.Name + "has feather: " + crow.Hasfeather);
            Console.WriteLine(this.Name + "is toothless: " + crow.Istoothless);
            Console.WriteLine(this.Name + "has beakjaws: " + crow.Hasbeakjaws);
            Console.WriteLine(this.Name + "is Laying: " + crow.Islaying);
            Console.WriteLine(this.Name + "has four chamberered heart: " + crow.HasfourchamberedHeart);
            Console.WriteLine(this.Name + "is Light weight Skeleton: " + crow.ISlightweightSkeleton);
            Console.WriteLine(this.Name + "legs: : " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can Swim: " + dove.CanSwim);
        }

        public void crowInfo()
        {
            Crow crow = new Crow();
            crow.crow();
        }
}
