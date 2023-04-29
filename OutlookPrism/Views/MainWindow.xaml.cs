using Infragistics.Themes;
using Infragistics.Windows.OutlookBar;
using Infragistics.Windows.Ribbon;
using OutlookPrism.Core;
using Prism.Regions;
using System.Windows;

namespace OutlookPrism.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : XamRibbonWindow
    {
        private readonly IApplicationCommands applicationCommands;

        public MainWindow(IApplicationCommands applicationCommands)
        {
            InitializeComponent();
            ThemeManager.ApplicationTheme = new Office2013Theme();
            this.applicationCommands = applicationCommands;
        }

        private void XamOutlookBar_SelectedGroupChanged(object sender, RoutedEventArgs e)
        {
            var group = ((XamOutlookBar)sender).SelectedGroup as IOutlookBarGroup;
            if(group != null) 
            {
               applicationCommands.NavigateCommand.Execute(group.DefaultNavigationPath);
            }
        }
    }
}
