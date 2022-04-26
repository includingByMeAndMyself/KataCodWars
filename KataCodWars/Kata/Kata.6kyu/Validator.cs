using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodWars.Kata.Kata6kyu
{
    public class Validator
    {

        //public static bool is_valid_IP(string IpAddres)
        //{
        //    IPAddress ip;
        //    bool validIp = IPAddress.TryParse(IpAddres, out ip);
        //    return validIp && ip.ToString() == IpAddres;
        //}


        //public static bool is_valid_IP(string IpAddres)
        //{
        //    var octet = "([1-9][0-9]{0,2})";
        //    var reg = $@"{octet}\.{octet}\.{octet}\.{octet}";
        //    return new Regex(reg).IsMatch(IpAddres);
        //}

        public static bool is_valid_IP(string ipAddres)
        {
            if(string.IsNullOrWhiteSpace(ipAddres))
                return false;

            var numbs = ipAddres.Split('.');

            if (numbs.Length != 4)
                return false;

            foreach (var num in numbs)
            {
                if (num.IndexOf(' ') >= 0)
                    return false;

                if (num.StartsWith("0") && num.Length > 1)
                    return false;

                if (!int.TryParse(num, out int obj))
                    return false;
                
                if (obj > 255 || obj < 0)
                    return false;
            }

            return true;
        }
    }
}
