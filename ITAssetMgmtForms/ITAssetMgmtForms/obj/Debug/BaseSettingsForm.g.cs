﻿#pragma checksum "..\..\BaseSettingsForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9282CFF402C414A1324C7C19B8209ED5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ITAssetMgmtForms;
using Microsoft.EnterpriseManagement.UI.FormsInfra;
using Microsoft.EnterpriseManagement.UI.WpfControls;
using Microsoft.EnterpriseManagement.UI.WpfToolbox;
using Microsoft.Windows.Controls;
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


namespace ITAssetMgmtForms {
    
    
    /// <summary>
    /// BaseSettingsForm
    /// </summary>
    public partial class BaseSettingsForm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 85 "..\..\BaseSettingsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItemGeneral;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\BaseSettingsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander expMain;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\BaseSettingsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander expDetails;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\BaseSettingsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.EnterpriseManagement.UI.WpfControls.SortableListView Role;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\BaseSettingsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd_Role;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\BaseSettingsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove_Role;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\BaseSettingsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpen_Role;
        
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
            System.Uri resourceLocater = new System.Uri("/ITAssetMgmtForms;component/basesettingsform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BaseSettingsForm.xaml"
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
            
            #line 14 "..\..\BaseSettingsForm.xaml"
            ((ITAssetMgmtForms.BaseSettingsForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tabItemGeneral = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.expMain = ((System.Windows.Controls.Expander)(target));
            
            #line 99 "..\..\BaseSettingsForm.xaml"
            this.expMain.Loaded += new System.Windows.RoutedEventHandler(this.expMain_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.expDetails = ((System.Windows.Controls.Expander)(target));
            
            #line 137 "..\..\BaseSettingsForm.xaml"
            this.expDetails.Loaded += new System.Windows.RoutedEventHandler(this.expDetails_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Role = ((Microsoft.EnterpriseManagement.UI.WpfControls.SortableListView)(target));
            
            #line 155 "..\..\BaseSettingsForm.xaml"
            this.Role.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MouseDoubleClick_Role);
            
            #line default
            #line hidden
            
            #line 155 "..\..\BaseSettingsForm.xaml"
            this.Role.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Role_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAdd_Role = ((System.Windows.Controls.Button)(target));
            
            #line 164 "..\..\BaseSettingsForm.xaml"
            this.btnAdd_Role.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click_Role);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnRemove_Role = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\BaseSettingsForm.xaml"
            this.btnRemove_Role.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click_Role);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnOpen_Role = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\BaseSettingsForm.xaml"
            this.btnOpen_Role.Click += new System.Windows.RoutedEventHandler(this.btnOpen_Click_Role);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

