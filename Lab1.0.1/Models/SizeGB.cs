using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_info
{
    internal class SizeGB
    {
        public double Total { get; set; }
        public double Free { get; set; }

        public SizeGB(double total, double free) {
            Total = total;
            Free = free;
        }

        public override string ToString()
        {
            return $"{Free:0.00}/{Total:0.00} GB";
        }
    }
}