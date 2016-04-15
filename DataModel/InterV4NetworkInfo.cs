using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    /// <summary>
    /// IPV4数据结构
    /// </summary>
    public class InterV4NetworkInfo
    {
        public string ProgrammeName
        { get; set; }

        public string IPAddress
        { get; set; }

        public string SubnetMask
        { get; set; }

        public string DefaultGetway
        { get; set; }

        public string DefaultDNS
        { get; set; }

        public string ReserveDNS
        { get; set; }
    }
}