﻿#pragma checksum "..\..\CustomersWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E3187C5D67E2650BDBB0819D9D4F8ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BMC_WPF {
    
    
    /// <summary>
    /// CustomersWindow
    /// </summary>
    public partial class CustomersWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoginC;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignupC;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogoutC;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\CustomersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BMC_WPF;component/customerswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomersWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnLoginC = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\CustomersWindow.xaml"
            this.btnLoginC.Click += new System.Windows.RoutedEventHandler(this.btnLoginC_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSignupC = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\CustomersWindow.xaml"
            this.btnSignupC.Click += new System.Windows.RoutedEventHandler(this.btnSignupC_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnLogoutC = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\CustomersWindow.xaml"
            this.btnLogoutC.Click += new System.Windows.RoutedEventHandler(this.btnLogoutC_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCart = ((System.Windows.Controls.Button)(target));
            
            #line 217 "..\..\CustomersWindow.xaml"
            this.btnCart.Click += new System.Windows.RoutedEventHandler(this.btnCart_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

