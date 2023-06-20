using System.Runtime.InteropServices;

namespace UpdaterExtensions.WinApi
{
    public class Win
    {
        [DllImport("urlmon.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int URLDownloadToFile(int pCaller, string szURL, string szFileName, int dwReserved, int lpfnCB);

    }
}