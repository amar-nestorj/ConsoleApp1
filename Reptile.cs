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
}
