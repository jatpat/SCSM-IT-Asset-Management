﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Collections;
using Microsoft.EnterpriseManagement.Common;
using Microsoft.EnterpriseManagement.UI.Core.Connection;
using Microsoft.EnterpriseManagement.ConsoleFramework;
using Microsoft.EnterpriseManagement.Configuration;
using Microsoft.EnterpriseManagement.UI.SdkDataAccess.DataAdapters;
using Microsoft.EnterpriseManagement.GenericForm;
using Microsoft.EnterpriseManagement;
using Microsoft.EnterpriseManagement.ServiceManager.Application.Common;

////Requires Microsoft.EnterpriseManagement.UI.SMControls
using Microsoft.EnterpriseManagement.UI.WpfControls;    //Contains InstancePickerDialog, UserPicker, and ListPicker

////Requires Microsoft.EnterpriseManagement.UI.WpfViews
using Microsoft.EnterpriseManagement.UI.WpfViews;       //Contains FormEvents

//// Requires Microsoft.EnterpriseManagement.UI.Foundation
using Microsoft.EnterpriseManagement.UI.DataModel;      //Contains IDataItem

////Requires Microsoft.EnterpriseManagement.UI.FormsInfra
using Microsoft.EnterpriseManagement.UI.FormsInfra;     //Contains PreviewFormCommandEventArgs

namespace ITAssetMgmtForms
{
    /// <summary>
    /// Interaction logic for HardwareForm.xaml
    /// </summary>
    public partial class HardwareForm : UserControl
    {
        private RelatedItemsPane _relatedItemsPane;
        public HardwareForm()
        {
            InitializeComponent();
            _relatedItemsPane = new RelatedItemsPane(new ConfigItemRelatedItemsConfiguration());
            tabItemRelItems.Content = _relatedItemsPane;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.AddHandler(FormEvents.PreviewSubmitEvent, new EventHandler<PreviewFormCommandEventArgs>(this.OnPreviewSubmit));
        }
        private void OnPreviewSubmit(object sender, PreviewFormCommandEventArgs e)
        {
            IDataItem DisplayName = this.DataContext as IDataItem;
            String strDisplayName;
            strDisplayName = DisplayName["DisplayName"].ToString();
            DisplayName["DisplayName"] = strDisplayName;
        }

        private void expMain_Loaded(object sender, RoutedEventArgs e)
        {
            HeaderedContentControl headeredContentControl = new HeaderedContentControl();
            headeredContentControl.OverridesDefaultStyle = true;
            headeredContentControl.Foreground = Brushes.Black;
            headeredContentControl.Header = "Main";
            this.expMain.Header = headeredContentControl;
        }
        private void expDetails_Loaded(object sender, RoutedEventArgs e)
        {
            HeaderedContentControl headeredContentControlr = new HeaderedContentControl();
            headeredContentControlr.OverridesDefaultStyle = true;
            headeredContentControlr.Foreground = Brushes.Black;
            headeredContentControlr.Header = "References";
            this.expMain.Header = headeredContentControlr;
        }
        private void InstancePicker_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SingleInstancePicker singleInstancePicker = (SingleInstancePicker)sender;
            FormUtilities.Instance.PopoutForm(singleInstancePicker.Instance);
        }
        //

        private void btnAdd_Click_Disk(object sender, RoutedEventArgs e)
        {
            AddItemToListView(this.ContainsDisk, ITAssetMgmtForms.Resources.guidWindowsDiskClass);
        }

        private void btnRemove_Click_Disk(object sender, RoutedEventArgs e)
        {
            RemoveItemFromWorkItemListView(this.ContainsDisk);
        }

        private void btnOpen_Click_Disk(object sender, RoutedEventArgs e)
        {
            IDataItem emoProjectionObject = (IDataItem)ContainsDisk.SelectedItem;
            Microsoft.EnterpriseManagement.GenericForm.FormUtilities.Instance.PopoutForm(emoProjectionObject);
        }

        private void MouseDoubleClick_Disk(object sender, MouseButtonEventArgs e)
        {
            IDataItem emoProjectionObject = (IDataItem)ContainsDisk.SelectedItem;
            Microsoft.EnterpriseManagement.GenericForm.FormUtilities.Instance.PopoutForm(emoProjectionObject);
        }
        //

        //
        
        private void btnAdd_Click_Volume(object sender, RoutedEventArgs e)
        {
            AddItemToListView(this.ContainsVolumes, ITAssetMgmtForms.Resources.guidWindowsVolumeClass);
        }

        private void btnRemove_Click_Volume(object sender, RoutedEventArgs e)
        {
            RemoveItemFromWorkItemListView(this.ContainsVolumes);
        }

        private void btnOpen_Click_Volume(object sender, RoutedEventArgs e)
        {
            IDataItem emoProjectionObject = (IDataItem)ContainsVolumes.SelectedItem;
            Microsoft.EnterpriseManagement.GenericForm.FormUtilities.Instance.PopoutForm(emoProjectionObject);
        }

        private void MouseDoubleClick_Volume(object sender, MouseButtonEventArgs e)
        {
            IDataItem emoProjectionObject = (IDataItem)ContainsVolumes.SelectedItem;
            Microsoft.EnterpriseManagement.GenericForm.FormUtilities.Instance.PopoutForm(emoProjectionObject);
        }

        //
        
        

        internal static void AddItemToListView(ListView listView, Guid classId)
        {
            if (listView != null && listView.Items != null)
            {
                InstancePickerDialog ciPicker = new InstancePickerDialog();
                ciPicker.ClassId = classId;
                ciPicker.SelectionMode = SelectionMode.Multiple;

                if (listView.Items.Count > 0)
                {
                    ciPicker.SetPickedInstances((Collection<IDataItem>)listView.ItemsSource);
                }

                bool? result = ciPicker.ShowDialog();
                if (result != null && result == true)
                {
                    Collection<IDataItem> items = listView.ItemsSource as Collection<IDataItem>;
                    foreach (IDataItem item in ciPicker.RemovedInstances)
                        items.Remove(item);

                    foreach (IDataItem item in ciPicker.PickedInstances)
                        if (!items.Contains(item))
                            items.Add(item);
                }
            }
        }

        internal static void RemoveItemFromWorkItemListView(ListView listView)
        {
            if (listView.ItemsSource == null ||
                            listView.SelectedItems == null ||
                            listView.SelectedItems.Count == 0)
            {
                return;
            }

            Collection<IDataItem> items = listView.ItemsSource as Collection<IDataItem>;
            if (items != null)
            {
                foreach (object obj in new ArrayList(listView.SelectedItems))
                {
                    /* NOTE: The use of the IDataItem interface here is not supported/documented.
                    * This interface may change in the future and no migration path is guaranteed 
        by Microsoft.
                    */
                    items.Remove(obj as IDataItem);
                }
            }
        }

        private void Disk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Volume_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
