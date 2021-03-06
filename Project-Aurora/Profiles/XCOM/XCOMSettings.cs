﻿using Aurora.Settings;
using System.Collections.Generic;

namespace Aurora.Profiles.XCOM
{
    class XCOMSettings : ProfileSettings
    {
        //General
        public bool first_time_installed;

        //Effects
        //// Lighting Areas
        public List<ColorZone> lighting_areas { get; set; }

        public XCOMSettings()
        {
            //General
            isEnabled = true;
            first_time_installed = false;

            //Effects
            //// Lighting Areas
            lighting_areas = new List<ColorZone>() {
                new ColorZone(new Devices.DeviceKeys[] { Devices.DeviceKeys.W, Devices.DeviceKeys.A, Devices.DeviceKeys.S, Devices.DeviceKeys.D, Devices.DeviceKeys.Q, Devices.DeviceKeys.E, Devices.DeviceKeys.HOME, Devices.DeviceKeys.Z }, System.Drawing.Color.Orange, "Camera Movement"),
                new ColorZone(new Devices.DeviceKeys[] { Devices.DeviceKeys.ENTER, Devices.DeviceKeys.ESC, Devices.DeviceKeys.V, Devices.DeviceKeys.X, Devices.DeviceKeys.BACKSPACE, Devices.DeviceKeys.F1, Devices.DeviceKeys.R, Devices.DeviceKeys.B, Devices.DeviceKeys.Y }, System.Drawing.Color.DarkOrange, "Other Actions")
            };
        }
    }
}
