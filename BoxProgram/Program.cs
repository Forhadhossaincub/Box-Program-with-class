using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box= new Box();

            box._length = 10;
            box._width = 20;

            Console.WriteLine($"Box Area is : {box.Area()}");

            Console.ReadKey();
            
        }

    }

    public class Box
    { 
        public Box(){ }

        public double _length { get; set; }
        public double _width {  get; set; }


        public double Area()
        {
            return _length* _width;
        }




    }

    


}
