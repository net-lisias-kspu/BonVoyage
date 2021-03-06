﻿using KSP.IO;
using UnityEngine;

namespace BonVoyage
{
    /// <summary>
    /// Configuration of the mod
    /// </summary>
    internal static class Configuration
    {
        private static PluginConfiguration configuration; // Configuration data


        #region internal properties

        /// <summary>
        /// Automatic dewarp
        /// </summary>
        internal static bool FirstRun
        {
            get { return configuration.GetValue<bool>("firstRun", true); }
            set
            {
                configuration.SetValue("firstRun", value);
                configuration.save();
            }
        }


        /// <summary>
        /// UI skin
        /// </summary>
        internal static byte Skin
        {
            get { return configuration.GetValue<byte>("skin", 0); }
            set
            {
                configuration.SetValue("skin", value);
                configuration.save();
            }
        }


        /// <summary>
        /// Automatic dewarp
        /// </summary>
        internal static bool AutomaticDewarp
        {
            get { return configuration.GetValue<bool>("dewarp", false); }
            set
            {
                configuration.SetValue("dewarp", value);
                configuration.save();
            }
        }


        /// <summary>
        /// Automatic dewarp
        /// </summary>
        internal static bool DisableRotation
        {
            get { return configuration.GetValue<bool>("disableRotation", false); }
            set
            {
                configuration.SetValue("disableRotation", value);
                configuration.save();
            }
        }


        /// <summary>
        /// Use KSP toolbar
        /// </summary>
        internal static bool KSPToolbar
        {
            get { return configuration.GetValue<bool>("kspToolbar", true); }
            set
            {
                configuration.SetValue("kspToolbar", value);
                configuration.save();
            }
        }


        /// <summary>
        /// Use Toolbar Continued
        /// </summary>
        internal static bool ToolbarContinued
        {
            get { return configuration.GetValue<bool>("toolbarContinued", false); }
            set
            {
                configuration.SetValue("toolbarContinued", value);
                configuration.save();
            }
        }


        /// <summary>
        /// Main window position
        /// </summary>
        internal static Vector2 MainWindowPosition
        {
            get { return configuration.GetValue<Vector2>("mainWindow", new Vector2(0.5f, 0.5f)); }
            set
            {
                configuration.SetValue("mainWindow", value);
                configuration.save();
            }
        }


        /// <summary>
        /// Control window position
        /// </summary>
        internal static Vector2 ControlWindowPosition
        {
            get { return configuration.GetValue<Vector2>("controlWindow", new Vector2(0.5f, 0.5f)); }
            set
            {
                configuration.SetValue("controlWindow", value);
                configuration.save();
            }
        }


        /// <summary>
        /// Active vessels
        /// </summary>
        internal static bool ActiveControllers
        {
            get { return configuration.GetValue<bool>("activeControllers", true); }
            set
            {
                configuration.SetValue("activeControllers", value);
                configuration.save();
            }
        }


        /// <summary>
        /// Disabled vessels
        /// </summary>
        internal static bool DisabledControllers
        {
            get { return configuration.GetValue<bool>("disabledControllers", false); }
            set
            {
                configuration.SetValue("disabledControllers", value);
                configuration.save();
            }
        }

        #endregion


        /// <summary>
        /// Load configuration from file
        /// </summary>
        internal static void Load()
        {
            configuration = PluginConfiguration.CreateForType<BonVoyage>();
            configuration.load();
        }


        /// <summary>
        /// Save configuration to file
        /// </summary>
        internal static void Save()
        {
            configuration.save();
        }

    }

}
