using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Mods.useful
{
    internal class FPSCap
    {
        public static void Update()
        {
            Application.targetFrameRate = int.MaxValue;
        }

        public static void ReturnNorm()
        {
            Application.targetFrameRate = 144;
        }
    }
}
