﻿#pragma checksum "D:\project\MSP\UWP\MathGame\MathGame\View\Utama.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F38D6A54FFFB05CF68F1490524344208"
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
    partial class Utama : 
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
                    this.btnMainPage = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\View\Utama.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMainPage).Click += this.btnMainPage_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnGameDua = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\View\Utama.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnGameDua).Click += this.btnGameDua_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnAbout = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\View\Utama.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAbout).Click += this.btnAbout_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnExit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\View\Utama.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnExit).Click += this.btnExit_Click;
                    #line default
                }
                break;
            case 5:
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
