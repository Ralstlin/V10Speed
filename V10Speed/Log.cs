﻿/* 
 * Copyright(c) 2015 Alexander Dzhoganov
 * Copyright(c) 2018 Thomas Rohloff <v10lator@myway.de>
 * 
 * Licensed under the MIT
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace V10Speed
{
    public static class Log
    {
        public static void Message(string s)
        {
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, s);
        }

        public static void Error(string s)
        {
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Error, s);
        }

        public static void Warning(string s)
        {
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Warning, s);
        }
    }
}
