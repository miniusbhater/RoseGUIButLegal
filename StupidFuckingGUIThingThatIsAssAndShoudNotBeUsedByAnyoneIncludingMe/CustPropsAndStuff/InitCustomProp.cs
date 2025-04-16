using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using ExitGames.Client.Photon; // Add this!


namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.CustPropsAndStuff
{
    internal class InitCustomProp
    {
       public static void MakeCustomProp(string roseproplegal)
        {
            Hashtable customprop = new Hashtable
        {
            { "ROSE GUI LEGAL", roseproplegal }
        };
            PhotonNetwork.LocalPlayer.SetCustomProperties(customprop);
        }
    }
}
