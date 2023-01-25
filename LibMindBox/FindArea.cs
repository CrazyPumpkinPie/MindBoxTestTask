using System;

namespace FindAreaLib
{
    public abstract class Shape
    {
        public abstract double FindArea();
        protected bool CheckNum(params double[] nums)
        {
            foreach(double num in nums)
            {
                if (double.IsNaN(num) || num <= 0)
                {
                    return false;
                    throw new ArgumentOutOfRangeException(nameof(num), "Check your input values");
                }
            }
            return true;
        }
    }
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            CheckNum(radius);
            this.radius = radius;
        }
        public override double FindArea() => Math.PI * radius * radius;
    }

    public class Triangle : Shape
    {
        private double ab, bc, ac;

        public Triangle(double ab, double bc, double ac)
        {
            CheckNum(ab, bc, ac);
            if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc))
                throw new ArgumentException("One of your sides is greater than summary of two another sides");
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
        }

        public override double FindArea()
        {
            double semiPerimeter = (ab + bc + ac) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - ab) * (semiPerimeter - bc) * (semiPerimeter - ac));
        }

        private bool isRectangular;
        public bool IsRectangular
        {
            get
            {
                if (ac < ab)
                    (ac, ab) = (ab, ac);
                if (ac < bc)
                    (ac, bc) = (bc, ab);

                isRectangular = ac * ac == ab * ab + bc * bc;
                return isRectangular;
            }
        }
    }
}
