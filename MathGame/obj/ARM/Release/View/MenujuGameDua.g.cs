﻿#pragma checksum "D:\project\MSP\UWP\MathGame\MathGame\View\MenujuGameDua.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7791F09E5FB1B6328B4D0A2E4EA5BED8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathGame.View
{
    partial class MenujuGameDua : 
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
            case 1:
                {
                    this.Display = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.btnPlayGameDua = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\View\MenujuGameDua.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPlayGameDua).Click += this.btnPlayGameDua_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnPlayBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\View\MenujuGameDua.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPlayBack).Click += this.btnPlayBack_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

