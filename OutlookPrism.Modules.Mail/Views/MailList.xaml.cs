using OutlookPrism.Core;
using OutlookPrism.Modules.Mail.Menus;
using System.Windows.Controls;

namespace OutlookPrism.Modules.Mail.Views
{
    /// <summary>
    /// Interaction logic for MailList
    /// </summary>
    [DependantView(RegionNames.RibbonRegion, typeof(HomeTab))]
    public partial class MailList : UserControl
    {
        public MailList()
        {
            InitializeComponent();
        }
    }
}
