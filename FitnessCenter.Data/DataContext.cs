using FitnessCenter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Data
{
    public class DataContext
    {
        public List<Secretary> secretaryList { get; set; }
        public List<Gymnast> gymnastList { get; set; }
        public List<Guide> guideList { get; set; }
        public DataContext()
        {
            secretaryList = new List<Secretary>();
            gymnastList = new List<Gymnast>();
            guideList = new List<Guide>();
        }
    }
}
