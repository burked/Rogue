﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Rogue
{
    class ManageCommands
    {
        private bool debugMode;
        KeyboardState cmdks;

        public bool DebugMode
        {
            get { return debugMode; }
            set { debugMode = value; }
        }

        public void CheckCommands()
        {
            cmdks = Keyboard.GetState();

            if (cmdks.IsKeyDown(Keys.LeftControl) && cmdks.IsKeyDown(Keys.LeftShift) && cmdks.IsKeyDown(Keys.OemTilde) && !DebugMode)
                DebugMode = true;
            else if (cmdks.IsKeyDown(Keys.LeftControl) && cmdks.IsKeyDown(Keys.LeftShift) && cmdks.IsKeyDown(Keys.OemTilde) && DebugMode)
                DebugMode = false;
        }
    }
}
