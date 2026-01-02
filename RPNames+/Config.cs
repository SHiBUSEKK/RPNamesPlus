using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RPNamesPlus
{
    public class Config : IConfig
    {
        [Description("Enables or disables the plugin.")]
        public bool IsEnabled { get; set; } = true;
        [Description("Enables or disables debug mode for the plugin.")]
        public bool Debug { get; set; } = false;
    }
}
