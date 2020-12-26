using MCFF.Framework.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MCFF.Tests.Common
{
    [TestClass]
    public class GameWindowTests
    {
        [TestMethod]
        public void OpenGameWindowAndShow()
        {
            GameWindow.StartGame();
            GameWindow.ActivateGameWindow();

            var processState = GameWindow.IsGameOpened();
            Assert.IsTrue(processState, "Game process not found");
        }
    }
}
