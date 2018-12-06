﻿using Foundation;
using osu.Framework.iOS;
using osu.Game;

namespace osu.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : GameAppDelegate
    {
        protected override Framework.Game CreateGame() => new OsuGame();
    }
}

