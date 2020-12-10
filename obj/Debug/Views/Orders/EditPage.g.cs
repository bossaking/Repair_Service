﻿#pragma checksum "..\..\..\..\Views\Orders\EditPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE03DEEC906641B942E3363AD88C3173FACB44A89145500AF45A1B43E13F3934"
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
using Repair_Service.Models;
using Sdl.MultiSelectComboBox.API;
using Sdl.MultiSelectComboBox.Behaviours;
using Sdl.MultiSelectComboBox.Controls;
using Sdl.MultiSelectComboBox.EventArgs;
using Sdl.MultiSelectComboBox.Services;
using Sdl.MultiSelectComboBox.Themes.Generic;
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
    /// EditPage
    /// </summary>
    public partial class EditPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Views\Orders\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\Views\Orders\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DeviceTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\Views\Orders\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DeviceBrandComboBox;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\..\Views\Orders\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DeviceModelComboBox;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\..\Views\Orders\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Sdl.MultiSelectComboBox.Themes.Generic.MultiSelectComboBox ProblemsComboBox;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\..\Views\Orders\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EmployeesComboBox;
        
        #line default
        #line hidden
        
        
        #line 316 "..\..\..\..\Views\Orders\EditPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StatusComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Repair_Service;component/views/orders/editpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Orders\EditPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 14 "..\..\..\..\Views\Orders\EditPage.xaml"
            ((Repair_Service.EditPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 52 "..\..\..\..\Views\Orders\EditPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SelectClientButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeviceTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.DeviceBrandComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.DeviceModelComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.ProblemsComboBox = ((Sdl.MultiSelectComboBox.Themes.Generic.MultiSelectComboBox)(target));
            return;
            case 8:
            this.EmployeesComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.StatusComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            
            #line 360 "..\..\..\..\Views\Orders\EditPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 368 "..\..\..\..\Views\Orders\EditPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

