using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Open_Closed.ConnectionRefactored
{
    public class PhotoCameraRefactored : Device
    {
        public int maxphotos { get; set; }

        public PhotoCameraRefactored(string nume, int photos) : base(nume)
        {
            this.maxphotos = photos;
        }
    }
}
