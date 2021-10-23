using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Open_Closed.ConnectionRefactored
{
    public class VideoCameraRefactored : Device
    {
        public int maxlength { get; set; }
        public VideoCameraRefactored(string nume, int length) : base(nume)
        {
            this.maxlength = length;
        }
    }
}
