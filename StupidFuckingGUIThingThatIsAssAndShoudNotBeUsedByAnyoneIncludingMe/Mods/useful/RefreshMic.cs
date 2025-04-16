using System;
using System.Collections.Generic;
using System.Text;

namespace StupidFuckingGUIThingThatIsAssAndShoudNotBeUsedByAnyoneIncludingMe.Mods.useful
{
    internal class RefreshMic
    {
        public static void Ref()
        {
            GorillaTagger.Instance.myRecorder.RestartRecording();
        }
    }
}
