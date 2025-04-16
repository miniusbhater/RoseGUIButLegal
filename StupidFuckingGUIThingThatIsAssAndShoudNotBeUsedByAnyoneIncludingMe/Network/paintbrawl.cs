using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Network
{
    internal class paintbrawl
    {
        public static void brawl()
        {
            GorillaComputer.instance.currentGameMode.Value = "PAINTBRAWL";
            Debug.Log("ROSEGUILEGAL|| GAMEMODE CHANGED TO PAINTBRAWL");
        }
    }
}
