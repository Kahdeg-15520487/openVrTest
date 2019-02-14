using System;
using Valve.VR;

namespace openVrTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var error = EVRInitError.None;
            var vrSystem = OpenVR.Init(ref error, EVRApplicationType.VRApplication_Other);
            if (error != EVRInitError.None)
            {
                // handle init error
                Console.WriteLine(error);
            }
        }
    }
}
