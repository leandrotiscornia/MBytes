﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Negocio {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Paths : global::System.Configuration.ApplicationSettingsBase {
        
        private static Paths defaultInstance = ((Paths)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Paths())));
        
        public static Paths Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Spiral\\Desktop\\log\\")]
        public string LogsRoute {
            get {
                return ((string)(this["LogsRoute"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Spiral\\Desktop\\pics\\")]
        public string PictureRoute {
            get {
                return ((string)(this["PictureRoute"]));
            }
            set {
                this["PictureRoute"] = value;
            }
        }
    }
}
