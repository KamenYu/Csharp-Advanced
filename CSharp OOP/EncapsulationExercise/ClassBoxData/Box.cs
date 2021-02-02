using System;
namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Width { get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Height { get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public void SurfaceArea()   // really?
        {
            double res = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
            Console.WriteLine($"Surface Area - {res:f2}");
        }

        public void LateralSurfaceArea()
        {
            double res = 2 * Length * Height + 2 * Width * Height;
            Console.WriteLine($"Lateral Surface Area - {res:f2}");
        }

        public void Volume()
        {
            double res = Length * Height * Width;
            Console.WriteLine($"Volume - {res:f2}");
        }
    }
}
