using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_info.Models
{
    internal class Report
    {
        
        public Hardware Hardware_ { get; set; }
        public Antivirus Antivirus_ { get; set; }
        public Firewall Firewall_ { get; set; }
        public OS OS_ { get; set; }

        public class Hardware
        {
            public CPU CPU_ { get; set; }
            public RAM RAM_ { get; set; }
            public List<DISK> DISKs_ { get; set; }

            public class CPU
            {
                public string Name { get; set; }
                public int NumberOfCores { get; set; }
                public double LoadPercentage { get; set; }
            }

            public class RAM
            {
                public double TotalAmountGB { get; set; }
                public double LoadPercentage { get; set; }
            }

            public class DISK
            {
                public string Name { get; set; }
                public string Size { get; set; }
            }

        }

        public class Antivirus
        {
            public bool IsInstalled { get; set; }
            public string Name { get; set; }
            public string State { get; set; }
            public string GUID { get; set; }
        }

       public class Firewall
        {
            public string ProfileType { get; set; }
            public bool IsEnabled { get; set; }
            public List<Port> GloballyOpenPorts { get; set; }
            public List<Application> AuthorizedApplications { get; set; }

            public class Port
            {
                public string PortNumber { get; set; }
                public string IpVersion { get; set; }
            }

            public class Application
            { 
                public string Name { get; set; }
                public string IpVersion { get; set; }
            }

        }

        public class OS
        {
            public string Name { get; set; }
            public string Version { get; set; }
            public string Status { get; set; }
            public List<Update> SoftwareUpdates { get; set; }

            public class Update
            {
                public string Title { set; get; }
                public bool IsInstalled { get; set; }
                public bool isDownloaded { get; set; }
            }
        }
    }
}
