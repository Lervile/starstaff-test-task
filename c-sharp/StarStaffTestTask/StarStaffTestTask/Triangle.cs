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
        #region Private Fields

        private readonly double _ab;
        private readonly double _bc;
        private readonly double _ca;

        #endregion

        #region Public Properties

        public double Ab => _ab;

        public double Bc => _bc;

        public double Ca => _ca;
        

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
            var s = (_ab + _bc + _ca) / 2;

            return Math.Sqrt(s * (s - _ab) * (s - _bc) * (s - _ca));
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
                    return (ab * ab) - (ca * ca + bc * bc) < Double.Epsilon;
                }
                else
                {
                    return (ca * ca) - (ab * ab + bc * bc) < Double.Epsilon;

                }
            }
            else
            {
                if (bc > ca)
                {
                    return (bc * bc) - (ca * ca + ab * ab) < Double.Epsilon;
                }
                else
                {
                    return (ca * ca) - (ab * ab + bc * bc) < Double.Epsilon;
                }
            }
        }
    }
}
