﻿namespace TouchPortalSDK.Models
{
    public class TouchPortalOptions
    {
        public string IpAddress { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 12136;
        public bool LogCommands { get; set; }
        public bool RestoreCommands { get; set; }
    }
}