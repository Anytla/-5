using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
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
                this.ThrowIfInvalidSide(value, nameof(this.Length));
                this.l = value;
            }
        }

        public double Width
        {
            get => this.w;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Width));
                this.w = value;
            }
        }
        public double Height
        {
            get => this.h;
            private set
            {
                this.ThrowIfInvalidSide(value, nameof(this.Height));
                this.h = value;
            }
        }

        private void ThrowIfInvalidSide(double value, string propertyName)  //exit, якщо б хоча б 1 - невірнe, тобто 0 або від'ємний
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} cannot be zero or negative.");  // throw - для створення вийнятку
            }
        }

        public double Volume()  // об'єм
        {
            return (this.Length * this.Width * this.Height);
        }

        public double SurfaceArea()  // Площа повної поверхні
        {
            return ((2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height));
        }

        public double LateralSurfaceArea() // Площа бічної поверхні
        {
            return ((2 * this.Length * this.Height) + (2 * this.Width * this.Height));
        }
    }

    public class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put down length, width, height: ");
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            try
            {
                Box BIGbox = new Box(length, width, height);

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
