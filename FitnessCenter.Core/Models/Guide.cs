using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Core.Models
{
    public enum EDomain { Pilatis, Erobi }
    public class Guide
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public EDomain Domain { get; set; }
    }
}
