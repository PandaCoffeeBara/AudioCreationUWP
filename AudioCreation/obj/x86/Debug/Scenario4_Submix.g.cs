﻿#pragma checksum "C:\Users\aaa48571\Source\Repos\audioCreation\AudioCreation\Scenario4_Submix.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "38445D4208972E2EEF6F54EFC3DD4302"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AudioCreation
{
    partial class Scenario4_Submix : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Scenario4_Submix.xaml line 81
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2: // Scenario4_Submix.xaml line 129
                {
                    this.ErrorBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 3: // Scenario4_Submix.xaml line 130
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Scenario4_Submix.xaml line 95
                {
                    this.fileButton1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.fileButton1).Click += this.File1_Click;
                }
                break;
            case 5: // Scenario4_Submix.xaml line 96
                {
                    this.fileButton2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.fileButton2).Click += this.File2_Click;
                }
                break;
            case 6: // Scenario4_Submix.xaml line 97
                {
                    this.audioPipe1 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 7: // Scenario4_Submix.xaml line 105
                {
                    this.audioPipe2 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 8: // Scenario4_Submix.xaml line 113
                {
                    this.submixNodeContainer = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 9: // Scenario4_Submix.xaml line 119
                {
                    this.audioPipe3 = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 10: // Scenario4_Submix.xaml line 120
                {
                    this.speakerContainer = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 11: // Scenario4_Submix.xaml line 123
                {
                    this.graphButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.graphButton).Click += this.GraphButton_Click;
                }
                break;
            case 12: // Scenario4_Submix.xaml line 121
                {
                    this.speaker = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Scenario4_Submix.xaml line 115
                {
                    this.submixLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Scenario4_Submix.xaml line 116
                {
                    this.echoEffectToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.echoEffectToggle).Toggled += this.EchoEffectToggle_Toggled;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

