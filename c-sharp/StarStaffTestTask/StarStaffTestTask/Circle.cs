using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStaffTestTask
{
    public class Circle : Figure
    {

        #region Private Fields

        private readonly double _radius;

        #endregion

        #region Constructors

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("radius");

            _radius = radius;
        }

        #endregion

        #region Abstract Methods Implementation

        /// <summary>
        /// Can be cached of course
        /// </summary>
        /// <returns></returns>
        public override double CalcArea()
        {
            return _radius * _radius * Math.PI;
        }

        #endregion
    }
}
