﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRCRealtimeLogger.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("irc.freenode.net")]
        public string IrcServer {
            get {
                return ((string)(this["IrcServer"]));
            }
            set {
                this["IrcServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("robint91_log")]
        public string Nick {
            get {
                return ((string)(this["Nick"]));
            }
            set {
                this["Nick"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#sparkfun")]
        public string Channel {
            get {
                return ((string)(this["Channel"]));
            }
            set {
                this["Channel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ZmzBYWUdoBqlsK_34GT-HGavUx5b9L7Nk0rFCug4D1aJz0mhkUX5d9EcB4NtBGYOV8kNOLdYmSuXqMepy" +
            "uK9aOvfD7X1JERMqfTFp29Ytq0M6XMTqw837tsjIirGWikw")]
        public string PachubeKey {
            get {
                return ((string)(this["PachubeKey"]));
            }
            set {
                this["PachubeKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("43697")]
        public string PachubeFeed {
            get {
                return ((string)(this["PachubeFeed"]));
            }
            set {
                this["PachubeFeed"] = value;
            }
        }
    }
}