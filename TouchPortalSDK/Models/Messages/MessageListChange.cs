﻿namespace TouchPortalSDK.Models.Messages
{
    public class MessageListChange : MessageBase
    {
        /// <summary>
        /// The id of the plugin.
        /// </summary>
        public string PluginId { get; set; }

        /// <summary>
        /// The actionId the list (dropdown) is a part of.
        /// </summary>
        public string ActionId { get; set; }

        /// <summary>
        /// The dataId the list (dropdown) is built upon.
        /// </summary>
        public string ListId { get; set; }

        /// <summary>
        /// InstanceId is a unique name that identified the action the user is changing.
        /// A button might have multiple actions, and a action might be bound to multiple buttons.
        /// This id will be different. However, it can also be null.
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Value of the selected list (dropdown).
        /// Might be null if nothing is selected, ex. choices updated to something else.
        /// </summary>
        public string Value { get; set; }
    }
}
