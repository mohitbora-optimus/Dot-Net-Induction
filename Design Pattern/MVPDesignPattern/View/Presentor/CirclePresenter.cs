using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using View.Model;
using View.View;

namespace View.Presentor
{
    public class CirclePresenter
    {
        ICircle circleDetails;

        public CirclePresenter(ICircle circle)
        {
            circleDetails = circle;
        }

        public void CalculateArea()
        {
            CircleModel model = new CircleModel();
            circleDetails.Result = model.GetArea(Convert.ToDouble(circleDetails.Radius)).ToString();

        }
    }
}