﻿#pragma checksum "..\..\..\..\Views\Orders\NewReportmentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5D167FBB28E726C5E46C74398A0EF255858773259F14AC31F9E9D55DAB2C6B54"
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
    /// NewReportmentPage
    /// </summary>
    public partial class NewReportmentPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DeviceTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DeviceBrandComboBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DeviceModelComboBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Sdl.MultiSelectComboBox.Themes.Generic.MultiSelectComboBox ProblemsComboBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EmployeesComboBox;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Repair_Service;component/views/orders/newreportmentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
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
            
            #line 12 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
            ((Repair_Service.NewReportmentPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.NewReportmentPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 37 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
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
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 110 "..\..\..\..\Views\Orders\NewReportmentPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

