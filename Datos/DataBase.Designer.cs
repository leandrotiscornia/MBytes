﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class DataBase : global::System.Configuration.ApplicationSettingsBase {
        
        private static DataBase defaultInstance = ((DataBase)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DataBase())));
        
        public static DataBase Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mbytes")]
        public string dbName {
            get {
                return ((string)(this["dbName"]));
            }
            set {
                this["dbName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string dbServer {
            get {
                return ((string)(this["dbServer"]));
            }
            set {
                this["dbServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3306")]
        public string dbPort {
            get {
                return ((string)(this["dbPort"]));
            }
            set {
                this["dbPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("system")]
        public string dbPassword {
            get {
                return ((string)(this["dbPassword"]));
            }
            set {
                this["dbPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("system")]
        public string dbUser {
            get {
                return ((string)(this["dbUser"]));
            }
            set {
                this["dbUser"] = value;
            }
        }
    }
}
