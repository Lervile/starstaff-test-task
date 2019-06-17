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
            _radius = radius;
        }

        #endregion

        #region Abstract Methods Implementation

        public override double CalcArea()
        {
            return _radius * Math.PI;
        }

        #endregion
    }
}
