using Infragistics.Windows.OutlookBar;
using OutlookPrism.Business;
using OutlookPrism.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OutlookPrism.Modules.Mail.Menus
{
    /// <summary>
    /// Interaction logic for MailGroup.xaml
    /// </summary>
    public partial class MailGroup : OutlookBarGroup, IOutlookBarGroup
    {
        public MailGroup()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath
        {
            get
            {
                var item = _dataTree.SelectedDataItems?.FirstOrDefault() as NavigationItem;
                if (item != null)
                    return item.NavigationPath;

                return "MailList";
            }
        }
    }
}
