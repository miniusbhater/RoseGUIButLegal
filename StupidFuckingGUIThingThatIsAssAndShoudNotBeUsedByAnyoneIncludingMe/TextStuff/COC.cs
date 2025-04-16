using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.TextStuff
{
    internal class COC
    {
        public static void COCText()
        {
            string name = PhotonNetwork.LocalPlayer.NickName;
            string uid = PhotonNetwork.LocalPlayer.UserId.ToString();
            string Roomin = "NOT IN ROOM";
            int players = 0;
            string time = DateTime.Now.ToString("HH:mm");
            if (PhotonNetwork.InRoom)
            {
                Roomin = PhotonNetwork.CurrentRoom.Name;
                players = (int)PhotonNetwork.CurrentRoom.PlayerCount;
            }
            GameObject.Find("/Environment Objects/LocalObjects_Prefab/TreeRoom/CodeOfConduct").GetComponent<TextMeshPro>().text = "HELLO, " + name + "\n" + time;
            GameObject.Find("/Environment Objects/LocalObjects_Prefab/TreeRoom/COC Text").GetComponent<TextMeshPro>().richText = true;
            GameObject.Find("/Environment Objects/LocalObjects_Prefab/TreeRoom/COC Text").GetComponent<TextMeshPro>().text = string.Format($"\nYOUR ID IS {uid}\nYOU ARE IN ROOM {Roomin} WITH {players} PLAYERS!\n\nGUI MADE BY ROSE (MINIUSBHATER)\nANY BANS YOU GET WHILE USING THIS MOD ARE YOUR FAULT!\n\n\n\n\n\n\nversion 1.1.4");


        }
    }
}
