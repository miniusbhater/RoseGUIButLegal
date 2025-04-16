using System;
using System.Collections.Generic;
using System.Text;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Mods.useful
{
    internal class DisableMic
    {
        public static void Dis()
        {
            GorillaTagger.Instance.myRecorder.StopRecording();
        }

        public static void Ena()
        {
            GorillaTagger.Instance.myRecorder.StartRecording();
        }
    }
}
