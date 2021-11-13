#define DEBUG
using System;
using Exceptions_Debugging.Models;
using Exceptions_Debugging.Services;
using Exceptions_Debugging.Exceptions;
using System.Collections.Generic;
using System.Diagnostics;

namespace Exceptions_Debugging
{
    class Program
    {
        private static void Log(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        public static void verifyArguments(CPU c, MOBO b)
        {
            if(c.chipsets == null || c.socket == null)
            {
                throw new ArgumentNullException("Invalid CPU input");
            }
            if(b.socket == null)
            {
                throw new ArgumentNullException("Invalid Motherboard input");
            }
        }


        static void Main(string[] args)
        {
#if DEBUG
           
Console.WriteLine("debugging");
            
#endif
            List<string> chip = new List<string>();
            List<string> chip1 = new List<string>();
            chip.Add("B450");
            chip.Add("B550");
            chip.Add("X570");
            chip1.Add("H410");
            chip1.Add("Z490");
            CPU c1, c2;
            MOBO m1, m2;
            c1 = new CPU("AMD", "AM4", 2.4, chip);
            c2 = new CPU("Intel", "LGA1200", 5, chip1);
            m1 = new MOBO();
            m2 = new MOBO("Gigabyte", "AM4", "A450");
            try
            {
                //verifyArguments(c1, m1); // this would crash the program
                verifyArguments(c1, m2);
                verifyArguments(c2, m2);
                //VerifySocketCompatibilityService.verifySocket(c2, m2); // this throws SocketIncompatibility exceptions
                VerifySocketCompatibilityService.verifySocket(c1, m2); //they have compatible sockets
                VerifySupportedChipsetService.chipsetCompatibility(c1, m2); //but the chipsets are not compatible

            }
            catch(ArgumentNullException e)
            {
                Log(e);
                Debug.WriteLine("Program crashed, null parameters found");
                throw new Exception("Program crashed, re-run it with valid parameters.", e);
            }
            catch(SocketIncompatibility e)
            {
                Log(e);
                Debug.WriteLine("Incompatible sockets");
                Console.WriteLine("Those components are incompatible!");
            }
            catch(UnsupportedChipset e)
            {
                Log(e);
                Debug.WriteLine("Incompatible chipsets");
                Console.WriteLine("Those components have incompatible chipsets!");
            }
            catch(Exception e)
            {
                Log(e);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Great! Now let's try the program with other parameters.");
            }

        }
    }
}
