using System;
using System.Collections.Generic;
using System.Text;

namespace EvernoteExporter
{
    static internal class Utility
    {
        static internal string FormatDateTime(string dateTime)
        {
            if (string.IsNullOrEmpty(dateTime)) return string.Empty;

            try
            {
                string dateTimeToReturn = DateTime.Parse(dateTime).ToString("d MMM, yyyy ");
                // military time
                dateTimeToReturn += DateTime.Parse(dateTime).ToString(
                    "t", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));
                return dateTimeToReturn;    
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
