using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Network
{
    internal class Disconnect
    {
        public static void disc()
        {
            PhotonNetwork.Disconnect();
            Debug.Log("ROSEGUILEGAL|| DISCONNECTED FROM PHOTON");
        }
    }
}
