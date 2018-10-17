using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string v)
        {
            double convertedNumber;
            if (double.TryParse(v, out convertedNumber))
            {
                return convertedNumber;
            }
            else
            {
                throw new ArgumentException("Please enter a numeric value.");
            }
        }
    }
}