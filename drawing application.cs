using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawing_application
{
    class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing the shape");
        }
    }
    class circle : shape
    {
        public override void draw()
        {
            //.draw();
            Console.WriteLine("drawing a circle");
        }
    }
    class triangle : shape
    {
        public override void draw()
        {
            //base.draw();
            Console.WriteLine("drawing a triangle");
        }
    }
    class rectangle : shape
    {
        public override void draw()
        {
            //base.draw();
            Console.WriteLine("drawing a rectangle");
        }
    }
    class square : shape
    {
        public override void draw()
        {
            //base.draw();
            Console.WriteLine("drawing a square");
        }
    }
    /* class cyl : shape
     {
         public override void draw()
         {
             base.draw();
         }
     }*/
    class Program
    {

        public static void Main(string[] args)
        {
            shape s = null;
            int ui;
            do
            {

                Console.WriteLine("enter the option to choose");
                Console.WriteLine("1:circle 2:triangle 3:rectangle 4:square 5:exit");

                ui = Convert.ToInt32(Console.ReadLine());
                switch (ui)
                {
                    case 1:
                        s = new circle();
                        break;
                    case 2:
                        s = new triangle();
                        break;
                    case 3:
                        s = new rectangle();
                        break;
                    case 4:
                        s = new square();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("wrong option");
                        break;
                }
                s.draw();
            } while (ui >= 1 && ui <= 5);

            /* var drawobjects = new List<shape>
             {
             new circle(),
             new triangle(),
             new rectangle(),
             new square()
             };
             foreach(shape s in drawobjects)
             {
                 s.draw();
             }*/
            Console.ReadLine();
        }
    }
}
