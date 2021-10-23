using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Open_Closed.Connection
{
    class ConnectionService
    {
        //this class tell us if the photo camera or video camera is connected to an usb port from our pc.
        public string isConnected(object camera)
        {
            if(camera is VideoCamera)
            {
                return "Video Camera is connected to the USB port.";
            }
            else if(camera is PhotoCamera)
            {
                return "Photo camera is connected to the USB port.";
            }
            return null;
        }
        //if we want to connect another device to the usb port, we can add another "else if" but this type of code
        //violated the open closed principle, in fact we should create a general class for all devices and each particular device should extend that class
        
    }
}
