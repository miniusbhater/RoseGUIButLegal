using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Text;
using static Mono.Security.X509.X520;
using TMPro;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.TextStuff
{
    internal class MOTD
    {
        public static void MOTDText()
        {
            GameObject.Find("motd (1)").GetComponent<TextMeshPro>().text = "ROSE GUI NEWS";            
            GameObject.Find("motdtext").GetComponent<TextMeshPro>().text = "\nROSE GUI 1.1.3 ADDS :\nROOM JOINING [VERY VERY SLOW AND BUGGY]\nPHOTON LOGGING\nFIXED MOTD NEWS\nNO LONGER TRIES TO CONNECT TO PHOTON ON UPDATE\n(1.1.4) fixes crashing bug + removes utilla dependency\n\nrose gui made by rose (miniusbhater)";
        }
    }
}
