﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallCenter.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HP_G7\\KD;Initial Catalog=CallCenter;Persist Security Info=True;User I" +
            "D=sa;Password=123@tanhoa")]
        public string CallCenterConnectionString {
            get {
                return ((string)(this["CallCenterConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SERVER9;Initial Catalog=TANHOA_WATER;Persist Security Info=True;User " +
            "ID=sa;Password=123@tanhoa")]
        public string TANHOA_WATERConnectionString {
            get {
                return ((string)(this["TANHOA_WATERConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SERVER9;Initial Catalog=HOADON_TA;Persist Security Info=True;User ID=" +
            "sa;Password=123@tanhoa")]
        public string HOADON_TAConnectionString {
            get {
                return ((string)(this["HOADON_TAConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=CAPNUOCTANHOA;Integrated Security=True")]
        public string CAPNUOCTANHOAConnectionString {
            get {
                return ((string)(this["CAPNUOCTANHOAConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HP_G7\\KD;Initial Catalog=DocSoTH;Persist Security Info=True;User ID=s" +
            "a;Password=123@tanhoa")]
        public string DocSoTHConnectionString {
            get {
                return ((string)(this["DocSoTHConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HP_G7\\KD;Initial Catalog=CAPNUOCTANHOA;Persist Security Info=True;Use" +
            "r ID=sa;Password=123@tanhoa")]
        public string CAPNUOCTANHOAConnectionString1 {
            get {
                return ((string)(this["CAPNUOCTANHOAConnectionString1"]));
            }
        }
    }
}
