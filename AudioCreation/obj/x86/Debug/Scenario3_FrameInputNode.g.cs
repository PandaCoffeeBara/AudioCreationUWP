﻿#pragma checksum "C:\Users\aaa48571\Source\Repos\audioCreation\AudioCreation\Scenario3_FrameInputNode.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A096BFCEB9BE929E038294018EB7C453"
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
    partial class Scenario3_FrameInput : 
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
            case 1: // Scenario3_FrameInputNode.xaml line 69
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2: // Scenario3_FrameInputNode.xaml line 56
                {
                    this.frameContainer = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 3: // Scenario3_FrameInputNode.xaml line 59
                {
                    this.audioPipe = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 4: // Scenario3_FrameInputNode.xaml line 60
                {
                    this.speakerContainer = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 5: // Scenario3_FrameInputNode.xaml line 63
                {
                    this.generateButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.generateButton).Click += this.Button_Click;
                }
                break;
            case 6: // Scenario3_FrameInputNode.xaml line 61
                {
                    this.speaker = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Scenario3_FrameInputNode.xaml line 57
                {
                    this.frame = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

