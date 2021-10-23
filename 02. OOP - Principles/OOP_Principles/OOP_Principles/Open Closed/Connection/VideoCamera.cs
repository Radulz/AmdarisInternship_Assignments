using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Open_Closed.Connection
{
    class VideoCamera
    {
        public string name { get; set; }
        public int maxvideolength { get; set; }

        public VideoCamera(string name, int length)
        {
            this.name = name;
            this.maxvideolength = length;
        }
    }
}
