﻿#pragma checksum "D:\ХНУРЭ\2 Курс\1семестр\Computer-human interaction(ЛМВз)\Lab1\Lab1\Views\Menu\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "77DC694E6E4C3A1F9EBC65554D1FBA4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1
{
    partial class MainPage : 
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
                    this.text = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.Description = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.factsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\..\Views\Menu\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.factsBtn).Click += this.factsBtn_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.contactBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 54 "..\..\..\..\Views\Menu\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.contactBtn).Click += this.contactBtn_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.regBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 51 "..\..\..\..\Views\Menu\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.regBtn).Click += this.regBtn_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.mainBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 48 "..\..\..\..\Views\Menu\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.mainBtn).Click += this.mainBtn_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

