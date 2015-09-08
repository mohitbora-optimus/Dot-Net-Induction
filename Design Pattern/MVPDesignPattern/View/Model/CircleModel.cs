using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace View.Model
{
    public class CircleModel
    {
        public Double GetArea(Double Radius)
        {
            return ((3.14) * Radius * Radius);
        }
    }
}