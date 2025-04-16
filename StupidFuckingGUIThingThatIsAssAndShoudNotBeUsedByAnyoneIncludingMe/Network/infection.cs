using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Network
{
    internal class infection
    {
        public static void infect()
        {
            GorillaComputer.instance.currentGameMode.Value = "INFECTION";
            Debug.Log("ROSEGUILEGAL|| GAMEMODE CHANGED TO INFECTION");
        }
    }
}
