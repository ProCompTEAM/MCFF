using MCFF.Framework.External;

using System.Diagnostics;
using System.Linq;

namespace MCFF.Framework.Common
{
    public static class GameWindow
    {
        private static readonly int ShowWindowCommand = 9;

        public static bool IsGameOpened()
        {
            return GetActiveGameProcess() != null;
        }

        public static void ActivateGameWindow()
        {
            var hwnd = GameWindowFunctions.FindWindow(null, Defaults.GameTitle);

            if (GameWindowFunctions.IsIconic(hwnd))
            {
                GameWindowFunctions.ShowWindow(hwnd, ShowWindowCommand);
            }
            else
            {
                GameWindowFunctions.SetForegroundWindow(hwnd);
            }
        }

        public static void StartGame()
        {
            Process.Start(Defaults.GameUrl);
        }

        private static Process GetActiveGameProcess()
        {
            return Process.GetProcessesByName(Defaults.GameProcessName).SingleOrDefault();
        }
    }
}
