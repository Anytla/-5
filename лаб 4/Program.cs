using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_1
{
    class Box
    {
        private double l { get; set; }
        private double w { get; set; }
        private double h { get; set; }

        public Box(double l, double w, double h)
        {
            this.Length = l;
            this.Width = w;
            this.Height = h;
        }
        public double Length
        {
            get => this.l;
            private set
            {

                this.l = value;
            }
        }

        public double Width
        {
            get => this.w;
            private set
            {

                this.w = value;
            }
        }
        public double Height
        {
            get => this.h;
            private set
            {

                this.h = value;
            }
        }

       

        public double SurfaceArea()  // Площа повної поверхні
        {
            return ((2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height));
        }

        public double LateralSurfaceArea() // Площа бічної поверхні
        {
            return ((2 * this.Length * this.Height) + (2 * this.Width * this.Height));
        }

        public double Volume()  // об'єм
        {
            return (this.Length * this.Width * this.Height);
        }
    }

     

    public class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put down length, width, height: ");
            var l = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            try
            {
                Box BIGbox = new Box(l, w, h);

                Console.WriteLine($"Surface Area: {BIGbox.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area: {BIGbox.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume: {BIGbox.Volume():f2}");
            }
            catch (ArgumentException x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadLine();
            Console.WriteLine();
        }
    }

}
