﻿#pragma checksum "..\..\SoftwareAssetForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D2E005362480B1727D461B152A689B5"
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
    /// SoftwareAssetForm
    /// </summary>
    public partial class SoftwareAssetForm : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 85 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItemGeneral;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander expMain;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.EnterpriseManagement.UI.WpfControls.SortableListView SoftwareAgreement;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd_SoftwareAgreement;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove_SoftwareAgreement;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpen_SoftwareAgreement;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander expDetails;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItemRelItems;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\SoftwareAssetForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabItemHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/ITAssetMgmtForms;component/softwareassetform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SoftwareAssetForm.xaml"
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
            this.tabItemGeneral = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.expMain = ((System.Windows.Controls.Expander)(target));
            
            #line 99 "..\..\SoftwareAssetForm.xaml"
            this.expMain.Loaded += new System.Windows.RoutedEventHandler(this.expMain_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 124 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SoftwareAgreement = ((Microsoft.EnterpriseManagement.UI.WpfControls.SortableListView)(target));
            
            #line 139 "..\..\SoftwareAssetForm.xaml"
            this.SoftwareAgreement.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MouseDoubleClick_SoftwareAgreement);
            
            #line default
            #line hidden
            
            #line 139 "..\..\SoftwareAssetForm.xaml"
            this.SoftwareAgreement.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SoftwareAgreement_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAdd_SoftwareAgreement = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\SoftwareAssetForm.xaml"
            this.btnAdd_SoftwareAgreement.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click_SoftwareAgreement);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRemove_SoftwareAgreement = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\SoftwareAssetForm.xaml"
            this.btnRemove_SoftwareAgreement.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click_SoftwareAgreement);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOpen_SoftwareAgreement = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\SoftwareAssetForm.xaml"
            this.btnOpen_SoftwareAgreement.Click += new System.Windows.RoutedEventHandler(this.btnOpen_Click_SoftwareAgreement);
            
            #line default
            #line hidden
            return;
            case 8:
            this.expDetails = ((System.Windows.Controls.Expander)(target));
            
            #line 186 "..\..\SoftwareAssetForm.xaml"
            this.expDetails.Loaded += new System.Windows.RoutedEventHandler(this.expDetails_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 205 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 208 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 211 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 214 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 225 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 228 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 231 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 235 "..\..\SoftwareAssetForm.xaml"
            ((Microsoft.EnterpriseManagement.UI.WpfControls.SingleInstancePicker)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InstancePicker_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 17:
            this.tabItemRelItems = ((System.Windows.Controls.TabItem)(target));
            return;
            case 18:
            this.tabItemHistory = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
