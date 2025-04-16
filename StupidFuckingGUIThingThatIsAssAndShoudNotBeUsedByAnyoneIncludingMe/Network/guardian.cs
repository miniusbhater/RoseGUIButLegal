using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Network
{
    internal class guardian
    {
        public static void guard()
        {
            GorillaComputer.instance.currentGameMode.Value = "GUARDIAN";
            Debug.Log("ROSEGUILEGAL|| GAMEMODE CHANED TO GUARDIAN");
        }
    }
}
