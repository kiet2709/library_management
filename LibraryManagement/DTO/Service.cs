using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    public static class Service
    {
        public static DateTime convertDateTime(object s)
        {
            try
            {
                return Convert.ToDateTime(s);
            }
            catch
            {
                return Convert.ToDateTime("1/1/1753");
            }
        }
    }
}
