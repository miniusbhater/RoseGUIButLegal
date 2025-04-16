using UnityEngine;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Mods.Visual
{
    public class FullBright : MonoBehaviour
    {
        void OnEnable()
        {
            LightmapSettings.lightmapsMode = LightmapsMode.CombinedDirectional;
        }

        void OnDisable()
        {
            LightmapSettings.lightmapsMode = LightmapsMode.NonDirectional;
        }
    }
}
