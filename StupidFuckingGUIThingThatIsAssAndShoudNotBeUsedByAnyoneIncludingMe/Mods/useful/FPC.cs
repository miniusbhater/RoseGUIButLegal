using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Mods.useful
{
    internal class FPC
    {

        public static void EnaFPC()
        {;
            GorillaTagger.Instance.thirdPersonCamera.GetComponentInChildren<Camera>().enabled = false;
            GorillaTagger.Instance.mainCamera.GetComponent<Camera>().fieldOfView = 90f;
        }

        public static void DisFPC()
        {
            GorillaTagger.Instance.thirdPersonCamera.GetComponentInChildren<Camera>().enabled = true;
        }
    }
}
