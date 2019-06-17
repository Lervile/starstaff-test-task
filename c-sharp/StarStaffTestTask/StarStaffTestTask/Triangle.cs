using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarStaffTestTask
{
    public class Triangle : Figure
    {
        private readonly double _ab;
        private readonly double _bc;
        private readonly double _ca;

        #region Private Fields

        #endregion

        #region Public Properties

        public double Ab
        {
            get { return _ab; }
        }

        public double Bc
        {
            get { return _bc; }
        }

        public double Ca
        {
            get { return _ca; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ab"></param>
        /// <param name="bc"></param>
        /// <param name="ca"></param>
        public Triangle(double ab, double bc, double ca)
        {
            if (ab < 0)
                throw new ArgumentOutOfRangeException("ab");
            if (bc < 0)
                throw new ArgumentOutOfRangeException("bc");
            if (ca < 0)
                throw new ArgumentOutOfRangeException("ca");

            _ab = ab;
            _bc = bc;
            _ca = ca;
        }
        
        #endregion
        
        #region Abstract Method Implementation

        /// <summary>
        /// Can be cached of course
        /// </summary>
        /// <returns></returns>
        public override double CalcArea()
        {
            var s = (Ab + Bc + Ca) / 2;

            return Math.Sqrt(s * (s - Ab) * (s - Bc) * (s - Ca));
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// As example of alternative construction of the Triangle
        /// </summary>
        /// <param name="ab"></param>
        /// <param name="bc"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static Triangle TwoSides(double ab, double bc, double angle)
        {
            var ca = Math.Sqrt(ab * ab + bc * bc - 2 * ab * bc * Math.Cos(angle));

            return new Triangle(ab, bc, ca);
        }

        #endregion
    }

    public static class TriangleExtensions
    {
        public static bool IsRight(this Triangle triangle)
        {
            var ab = triangle.Ab;
            var bc = triangle.Bc;
            var ca = triangle.Ca;

            if (ab > bc)
            {
                if (ab > ca)
                {
                    return Math.Abs((ab * ab) - (ca * ca + bc * bc)) < Double.Epsilon;
                }
                else
                {
                    return Math.Abs((ca * ca) - (ab * ab + bc * bc)) < Double.Epsilon;

                }
            }
            else
            {
                if (bc > ca)
                {
                    return Math.Abs((bc * bc) - (ca * ca + ab * ab)) < Double.Epsilon;
                }
                else
                {
                    return Math.Abs((ca * ca) - (ab * ab + bc * bc)) < Double.Epsilon;
                }
            }
        }
    }
}
