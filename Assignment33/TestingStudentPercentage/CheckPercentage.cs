using System;

namespace TestingStudentPercentage
{
    public class CheckPercentage
    {
        public bool IsString(string percentage)
        {
            foreach (Char c in percentage)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public bool IsNumber(string percentage)
        {
            foreach (Char i in percentage)
            {
                if (char.IsLetter(i))
                {
                    return false;
                }
            }
            return true;
        }

        public string CheckPercentageValidity(string percentage)
        {
            string message = null;
            try
            {
                if (IsString(percentage))
                {
                    message = "Please enter a Number ! you have entered a String";
                }

                else if (IsNumber(percentage))
                {
                    if ((Math.Round(Convert.ToDecimal(percentage), 2)) >= 0 &&
                       (Math.Round(Convert.ToDecimal(percentage), 2)) <= 100)
                    {
                        message = "Value Accepted : " + Math.Round(Convert.ToDecimal(percentage), 2);
                    }
                    else
                        message = "Enter valid percentage between (0-100) ";
                }
            }
            catch (Exception)
            {

            }
            return message;
        }
    }
}