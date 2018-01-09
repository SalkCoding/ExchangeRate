using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    static class Data
    {
        private static Double ExchangeRate = 0;
        public static Double Dollar
        {
            get
            {
                return ExchangeRate;
            }
            set
            {
                ExchangeRate = value;
            }
        }

        private static String RefreshTime = null;
        public static String RefreshDate
        {
            get
            {
                return RefreshTime;
            }
            set
            {
                RefreshTime = value;
            }
        }

        private static Double CompareRate = 0;
        public static Double ComparePercent
        {
            get
            {
                return CompareRate;
            }
            set
            {
                CompareRate = value;
            }
        }

        private static Boolean Up = false;
        public static Boolean isUp
        {
            get
            {
                return Up;
            }
            set
            {
                Up = value;
            }
        }

    }
}
