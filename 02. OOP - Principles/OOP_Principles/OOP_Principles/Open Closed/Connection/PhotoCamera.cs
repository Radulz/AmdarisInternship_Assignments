using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Open_Closed.Connection
{
    public class PhotoCamera
    {
        public string name { get; set; }
        public int maxphotos { get; set; }

        public PhotoCamera(string name, int photos)
        {
            this.name = name;
            this.maxphotos = photos;
        }
    }
}
