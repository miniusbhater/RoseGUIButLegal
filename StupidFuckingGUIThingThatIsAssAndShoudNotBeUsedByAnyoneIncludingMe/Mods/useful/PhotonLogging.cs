using ExitGames.Client.Photon;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Mods.useful
{
    internal class PhotonLogging
    {
        public static void Ena()
        {
            PhotonNetwork.LogLevel = PunLogLevel.Full;
            PhotonNetwork.NetworkingClient.LoadBalancingPeer.DebugOut = DebugLevel.ALL;
        }

        public static void Dis()
        {
            PhotonNetwork.LogLevel = PunLogLevel.ErrorsOnly;
            PhotonNetwork.NetworkingClient.LoadBalancingPeer.DebugOut = DebugLevel.OFF;
        }

    }
}
