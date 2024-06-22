﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Testing.Extensions.VSTestBridge.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExtensionResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExtensionResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Testing.Extensions.VSTestBridge.Resources.ExtensionResources", typeof(ExtensionResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to runsettings file &apos;{0}&apos; cannot be read.
        /// </summary>
        internal static string RunsettingsFileCannotBeRead {
            get {
                return ResourceManager.GetString("RunsettingsFileCannotBeRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to runsettings file &apos;{0}&apos; does not exist.
        /// </summary>
        internal static string RunsettingsFileDoesNotExist {
            get {
                return ResourceManager.GetString("RunsettingsFileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path, relative or absolute, to the .runsettings file. For more information and examples on how to configure test run, see https://learn.microsoft.com/visualstudio/test/configure-unit-tests-by-using-a-dot-runsettings-file#the-runsettings-file.
        /// </summary>
        internal static string RunSettingsOptionDescription {
            get {
                return ResourceManager.GetString("RunSettingsOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filters tests using the given expression. For more information, see the Filter option details section. For more information and examples on how to use selective unit test filtering, see https://learn.microsoft.com/dotnet/core/testing/selective-unit-tests..
        /// </summary>
        internal static string TestCaseFilterOptionDescription {
            get {
                return ResourceManager.GetString("TestCaseFilterOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to argument &apos;{0}&apos; is not a parameter. Parameters arguments are matching the following pattern &apos;key=value&apos;..
        /// </summary>
        internal static string TestRunParameterOptionArgumentIsNotParameter {
            get {
                return ResourceManager.GetString("TestRunParameterOptionArgumentIsNotParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify or override a key-value pair parameter. For more information and examples, see https://learn.microsoft.com/visualstudio/test/configure-unit-tests-by-using-a-dot-runsettings-file#testrunparameters.
        /// </summary>
        internal static string TestRunParameterOptionDescription {
            get {
                return ResourceManager.GetString("TestRunParameterOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The bridged framework supports only one session at a time. A session with UID {0} is already open..
        /// </summary>
        internal static string VSTestBridgedTestFrameworkSessionAlreadyCreatedErrorMessage {
            get {
                return ResourceManager.GetString("VSTestBridgedTestFrameworkSessionAlreadyCreatedErrorMessage", resourceCulture);
            }
        }
    }
}