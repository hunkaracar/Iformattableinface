using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee : IFormattable
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Title} {FirstName} {LastName}";


        public override string ToString()
        {
            return this.ToString("F",CultureInfo.CurrentCulture); 
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }



        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "F";

            }
            if(formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }

            switch (format.ToUpper())
            {
                case "F":
                    return $"{Id} {Title} {FirstName} {LastName}";
                case "FL":
                    return $"{FirstName} {LastName}";
                case "LF":
                    return $"{LastName} {FirstName}";
                case "S":
                    return $"{LastName} {FirstName[0]}";
                case "I":
                    return $"{Id}";
                default:
                    throw new FormatException(String.Format("The {0} is not supported",format));
                    break;
            }
        }
    }
}
