using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    internal class Mp3Players
    {
        [DllImport("winm.dll")]
        private static extern long mciSendString(string lpstrCommand,StringBuilder lpstrReturnString,int uReturnLingth,int hwdCall);

        public void Open(string File)
        {
            string Formt = @"open ""{0}""type MPEGVideo alias MediaFile";
            string command = string.Format(Formt,File);
            mciSendString(command,null, 0, 0);
        }
        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }

    }
}
