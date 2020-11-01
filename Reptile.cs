using System;

namespace prelim_exam
{
    public class Reptile : Animal
    {
        
        public override void GetClass()
        {
            this._class = "Reptilia";
            Console.WriteLine(this._class);
        }

        public override void GetType()
        {
            this._ofType = "Reptile";
            Console.WriteLine(this._ofType);
        }
    }
    
    public class Snake : Reptile,Ireptile
    {
        public void snake()
        {
            this._numberOfLegs = 4;
            this.Name = "Orochi";
            this.CanSwim = true;

            Console.WriteLine("Snake");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);
        }

        public void snakeInfo()
        {
            Snake snake = new Snake();
            snake.snake();
        }
        
    public class Croc : Reptile,Ireptile
    {
        public void croc()
        {
            this._numberOfLegs = 4;
            this.Name = "government";
            this.CanSwim = true;

            Console.WriteLine("Crocodile");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine(this.Name + "legs: " + this._numberOfLegs);
            Console.WriteLine(this.Name + "can swim: " + this.CanSwim);
        }

        public void crocInfo()
        {
            Croc croc = new Croc();
            croc.croc();
        }
}
