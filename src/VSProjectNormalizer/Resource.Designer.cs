﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSProjectNormalizer {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Resource : global::System.Configuration.ApplicationSettingsBase {
        
        private static Resource defaultInstance = ((Resource)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Resource())));
        
        public static Resource Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tests\\$(AssemblyName)")]
        public string TEST_OUTPUT_PATH {
            get {
                return ((string)(this["TEST_OUTPUT_PATH"]));
            }
            set {
                this["TEST_OUTPUT_PATH"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Bin\\$(AssemblyName)")]
        public string BIN_OUTPUT_PATH {
            get {
                return ((string)(this["BIN_OUTPUT_PATH"]));
            }
            set {
                this["BIN_OUTPUT_PATH"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("obj\\$(AssemblyName)")]
        public string INTERMEDIATE_OUTPUT_PATH {
            get {
                return ((string)(this["INTERMEDIATE_OUTPUT_PATH"]));
            }
            set {
                this["INTERMEDIATE_OUTPUT_PATH"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Acceptance\\$(AssemblyName)")]
        public string ACCEPTANCE_TEST_OUTPUT_PATH {
            get {
                return ((string)(this["ACCEPTANCE_TEST_OUTPUT_PATH"]));
            }
            set {
                this["ACCEPTANCE_TEST_OUTPUT_PATH"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool USE_PLATFORM {
            get {
                return ((bool)(this["USE_PLATFORM"]));
            }
            set {
                this["USE_PLATFORM"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$(BuildDir)$(SolutionName)\\$(Configuration)")]
        public string SPECIFIC_BUILD_FOLDER {
            get {
                return ((string)(this["SPECIFIC_BUILD_FOLDER"]));
            }
            set {
                this["SPECIFIC_BUILD_FOLDER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$(SolutionDir)$(Configuration)")]
        public string DEFAULT_BUILD_FOLDER {
            get {
                return ((string)(this["DEFAULT_BUILD_FOLDER"]));
            }
            set {
                this["DEFAULT_BUILD_FOLDER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$(Platform)")]
        public string PLATFORM_OUTPUT_PATH {
            get {
                return ((string)(this["PLATFORM_OUTPUT_PATH"]));
            }
            set {
                this["PLATFORM_OUTPUT_PATH"] = value;
            }
        }
    }
}