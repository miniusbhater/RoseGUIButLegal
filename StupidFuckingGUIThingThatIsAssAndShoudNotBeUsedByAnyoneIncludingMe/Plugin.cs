using System;
using BepInEx;
using BoingKit;
using GorillaGameModes;
using GorillaNetworking;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using Utilla;
using Utilla.Models;
using System.Collections;
using static NetworkSystem;
using TMPro;
using StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Mods.Visual;
using StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.TextStuff;
using System.Threading.Tasks;
using PlayFab.CloudScriptModels;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe
{
    [ModdedGamemode]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {

        bool inRoom;
        private Rect window;
        private bool drag = true;
        private Vector2 scroll = Vector2.zero;
        private string roomnam = "";
        public FullBright fullbright;
        private int selected = 0;
        private string[] tabs = { "Info", "Network", "Mods", "PC", "Game", "Useful", "Settings" };
        void Start()
        {
            fullbright = FindObjectOfType<FullBright>();
            if (fullbright == null)
            {
                GameObject fb = new GameObject("FullBright");
                fullbright = fb.AddComponent<FullBright>();
            }

            Debug.Log("ROSEGUILEGAL|| GUI INITIALIZED");
            int width = 600;
            int height = 400;
            window = new Rect(Screen.width - width - 10, 10, width, height);
            Debug.Log("ROSEGUILEGAL|| VERSION 1.1.4");
            Debug.Log("ROSEGUILEGAL|| CREATING GUI...");
            Utilla.Events.GameInitialized += OnGameInitialized;

        }



        void OnGUI()
        {
           
                window = GUI.Window(0, window, DrawWindow, "RoseGUI Legal 1.1.4");

            

        }

        void DrawWindow(int windowid)
        {

            selected = GUILayout.Toolbar(selected, tabs);

            GUILayout.Space(10);

            switch (selected)
            {
                case 0:

                    string name = GorillaComputer.instance.currentName;
                    string ver = GorillaComputer.instance.version;
                    string time = DateTime.Now.ToString("HH:mm:ss");
                    string date = DateTime.Now.ToString("dd/MM/yyyy");
                    string uid = PhotonNetwork.LocalPlayer.UserId;
                    string regeonorsomething = "NOT CONNECTED!";
                    float ping = 0;
                    GUILayout.Label($"{time} {date}");
                    GUILayout.Label($"Gorilla Tag {ver}");
                    GUILayout.Label($"{uid}");
                    if (PhotonNetwork.IsConnected)
                    {
                        regeonorsomething = PhotonNetwork.CloudRegion.ToUpper();
                        GUILayout.Label($"{regeonorsomething}");
                    }
                    if (PhotonNetwork.IsConnected)
                    {
                        ping = PhotonNetwork.GetPing();
                        GUILayout.Label($"Ping: {ping}");
                    }
                    GUILayout.Label($"Name: {name}");
                    if (PhotonNetwork.InRoom)
                    {
                        string roomcode = PhotonNetwork.CurrentRoom.ToString();
                        GUILayout.Label($"{roomcode}");
                    }


                    break;

                case 1: // Network
                    scroll = GUILayout.BeginScrollView(scroll, GUILayout.Width(565), GUILayout.Height(340));

                    roomnam = GUILayout.TextField(roomnam);

                    if (GUILayout.Button("Join"))
                    {
                        JoinRoom();
                    }
                    

                        GUILayout.Label("---ROOM STUFF---\n");
                        if (GUILayout.Button("Disconnect"))
                        {
                            Network.Disconnect.disc();
                        }
                        if (GUILayout.Button("Set Casual"))
                        {
                            Network.casual.casu();
                        }
                        if (GUILayout.Button("Set Infection"))
                        {
                            Network.infection.infect();
                        }

                        if (GUILayout.Button("Set Guardian"))
                        {
                            Network.guardian.guard();
                        }

                        if (GUILayout.Button("Set Freezetag"))
                        {
                            Network.freezetag.freeze();
                        }

                        if (GUILayout.Button("Set Hunt [old]"))
                        {
                            Network.hunt.humt();
                        }
                        if (GUILayout.Button("Set Paintbrawl [old]"))
                        {
                            Network.paintbrawl.brawl();
                        }

                        if (GUILayout.Button("Set Modded Casual"))
                        {
                            Network.moddedcasual.modcas();
                        }

                        GUILayout.Label("---PHOTON STUFF---\n");
                        if (GUILayout.Button("Connect EU"))
                        {
                            Network.eu.connecteu();
                        }
                        if (GUILayout.Button("Connect US"))
                        {
                            Network.us.connectus();
                        }
                        if (GUILayout.Button("Connect Best"))
                        {
                            Network.best.connectbest();
                        }


                        GUILayout.EndScrollView();

                        break;

                case 2: // Mods

                            GUILayout.Label("---VISUAL---\n");
                            if (GUILayout.Button("FullBright"))
                            {


                                if (fullbright != null)
                                {
                                    fullbright.enabled = !fullbright.enabled;
                                }
                            }

                            break;

                        case 3: // PC Stuff

                            break;

                        case 4: // Game
                            if (GUILayout.Button("Quit"))
                            {
                                Application.Quit();
                            }

                            if (GUILayout.Button("Enable Photon Logging"))
                            {
                                Mods.useful.PhotonLogging.Ena();
                            }

                            if (GUILayout.Button("Disable Photon Logging"))
                            {
                                Mods.useful.PhotonLogging.Dis();
                            }

                            break;

                        case 5:
                           
                            if (GUILayout.Button("Uncap FPS"))
                            {
                                Mods.useful.FPSCap.Update();
                            }

                            if (GUILayout.Button("Cap FPS"))
                            {
                                Mods.useful.FPSCap.ReturnNorm();
                            }

                            if (GUILayout.Button("Disable Mic"))
                            {
                                Mods.useful.DisableMic.Dis();
                            }

                            if (GUILayout.Button("Enable Mic"))
                            {
                                Mods.useful.DisableMic.Ena();
                            }

                            if (GUILayout.Button("Refesh Mic"))
                            {
                                Mods.useful.RefreshMic.Ref();
                            }

                            if (GUILayout.Button("Enable FPC"))
                            {
                                Mods.useful.FPC.EnaFPC();
                            }

                            if (GUILayout.Button("Disable FPC"))
                            {
                                Mods.useful.FPC.DisFPC();
                            }

                            break;

                        case 6: // Settings

                            drag = GUILayout.Toggle(drag, "Draggable");

                            break;
                        }
                        if (drag)
                        {
                            GUI.DragWindow();

                        }



                    } 

        public async Task JoinRoom()
        {

            if (!PhotonNetwork.IsConnected) { 
                
                PhotonNetwork.ConnectUsingSettings();
                Debug.Log("ROSE GUI|| FORCING PHOTON CONNECTION");

            } else { }
            await Task.Delay(2000);

            if (PhotonNetwork.IsConnectedAndReady)
            {
                Debug.Log("ROSE GUI|| TRYING TO JOIN ROOM");
                Network.best.connectbest();
                PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(roomnam, JoinType.Solo);
               await JoinRoomAgain();
            }
        }
        public async Task JoinRoomAgain()
        {
            if (!PhotonNetwork.IsConnected)
            {

                PhotonNetwork.ConnectUsingSettings();
                Debug.Log("ROSE GUI|| FORCING PHOTON CONNECTION");

            }
            else { }
            await Task.Delay(5000);

            if (PhotonNetwork.IsConnectedAndReady)
            {
                Debug.Log("ROSE GUI|| TRYING TO JOIN ROOM");
                Network.best.connectbest();
                PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(roomnam, JoinType.Solo);
            }
        }

        public void PhotonConnect()
        {
            if (!PhotonNetwork.IsConnected)
            {
                PhotonNetwork.ConnectUsingSettings();
                Debug.Log("ROSE GUI|| CONNECTING TO PHOTON");
            }
            else
            {
                Debug.Log("ROSE GUI|| ALREADY CONNECTED TO PHOTON");
            }
        }
       
        private IEnumerator COC()
        {
            yield return new WaitForSeconds(1f);

            TextStuff.COC.COCText();
           
        }

        private IEnumerator MOTD() {
            yield return new WaitForSeconds(3f);
            TextStuff.MOTD.MOTDText();
        }
            void OnEnable()
            {
                HarmonyPatches.ApplyHarmonyPatches();
            }

            void OnDisable()
            {
                HarmonyPatches.RemoveHarmonyPatches();
            }

        void OnGameInitialized(object sender, EventArgs e)
        {
            CustPropsAndStuff.InitCustomProp.MakeCustomProp("1.1.4");
            StartCoroutine(MOTD());
            PhotonNetwork.ConnectUsingSettings();
        }
        



        void Update()
            {
           
                StartCoroutine(COC());
            
            }
        }
    }
