using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Network
{
    internal class freezetag
    {
        public static void freeze()
        {
            GorillaComputer.instance.currentGameMode.Value = "FREEZETAG";
            Debug.Log("ROSEGUILEGAL|| GAMEMODE CHANGED TO FREEZETAG");
        }
    }
}
