﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Benday.BuildUtilities.Core.Tests {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class UnitTestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UnitTestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Benday.BuildUtilities.Core.Tests.UnitTestResources", typeof(UnitTestResources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;configuration&gt;
        ///  &lt;!--
        ///    Configure your application settings in appsettings.json. Learn more at http://go.microsoft.com/fwlink/?LinkId=786380
        ///  --&gt;
        ///  &lt;appSettings&gt;
        ///    &lt;add key=&quot;SettingWithATokenInTheValue&quot; value=&quot;%%token%%&quot; /&gt;
        ///    &lt;add key=&quot;SettingWithAValue&quot; value=&quot;this is a value&quot; /&gt;
        ///  &lt;/appSettings&gt;
        ///
        ///  &lt;connectionStrings&gt;
        ///    &lt;add 
        ///      name=&quot;(default)&quot; 
        ///      providerName=&quot;System.Data.SqlClient&quot; 
        ///      connectionString=&quot;default-connection-string&quot;  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SampleConfigFile {
            get {
                return ResourceManager.GetString("SampleConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;FirstLevel&quot;: &quot;FirstLevelValue&quot;, 
        ///  &quot;ConnectionStrings&quot;: {
        ///    &quot;DefaultConnectionString&quot;: &quot;default-connection-string-value&quot;
        ///  },
        ///  &quot;Logging&quot;: {
        ///    &quot;IncludeScopes&quot;: false,
        ///    &quot;LogLevel&quot;: {
        ///      &quot;Default&quot;: &quot;Debug&quot;,
        ///      &quot;System&quot;: &quot;Information&quot;,
        ///      &quot;Microsoft&quot;: &quot;Information&quot;
        ///    }
        ///  },
        ///  &quot;CustomConfig&quot;: {
        ///    &quot;Value1&quot;: &quot;value1-value&quot;,
        ///    &quot;Value2&quot;: &quot;value2-value&quot;
        ///  }
        ///}
        ///.
        /// </summary>
        internal static string SampleJsonAppSettings {
            get {
                return ResourceManager.GetString("SampleJsonAppSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  
        ///}
        ///.
        /// </summary>
        internal static string SampleJsonAppSettingsEmpty {
            get {
                return ResourceManager.GetString("SampleJsonAppSettingsEmpty", resourceCulture);
            }
        }
    }
}
