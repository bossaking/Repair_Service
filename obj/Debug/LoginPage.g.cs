﻿#pragma checksum "..\..\LoginPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32CBE7C313AFE367FF930FC19BE580457F2485535C503432D98E21876AB18B54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Repair_Service;
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


namespace Repair_Service {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TextBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxRememberMe;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonLogin;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressBar;
        
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
            System.Uri resourceLocater = new System.Uri("/Repair_Service;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginPage.xaml"
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
            
            #line 8 "..\..\LoginPage.xaml"
            ((Repair_Service.LoginPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.LoginPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.CheckBoxRememberMe = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\LoginPage.xaml"
            this.CheckBoxRememberMe.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxRememberMeUnchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonLogin = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\LoginPage.xaml"
            this.ButtonLogin.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

