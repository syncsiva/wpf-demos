#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Shared;
using System.Windows.Controls;

namespace syncfusion.floorplanner.wpf
{
    /// <summary>
    /// Interaction logic for FloorPlannerDemo.xaml
    /// </summary>
    public partial class FloorPlannerDemo : ChromelessWindow
    {
        public FloorPlannerDemo()
        {
            InitializeComponent();
            this.Template = this.Resources["ChromelessWindowTemplate"] as ControlTemplate;
            FloorPlannerViewModel floor = new FloorPlannerViewModel();
            floor.GoBack = new DelegateCommand<object>(OnGoBack);
            this.DataContext = floor;
        }

        private void OnGoBack(object parameter)
        {
            FloorPlannerViewModel VM = this.DataContext as FloorPlannerViewModel;
            VM.GoBack = null;
            this.DataContext = null;
            //Frame.GoBack();
        }
    }
}
