using OutlookPrism.Business;
using OutlookPrism.Core;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace OutlookPrism.Modules.Mail.ViewModels
{
    public class MailGroupViewModel : ViewModelBase
    {
        private readonly IApplicationCommands applicationCommands;

        private ObservableCollection<NavigationItem> items;
        public ObservableCollection<NavigationItem> Items
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }

        private DelegateCommand<NavigationItem> selectedCommand;
        public DelegateCommand<NavigationItem> SelectedCommand =>
            selectedCommand ??= new DelegateCommand<NavigationItem>(ExecuteSelectedCommand);

        public MailGroupViewModel(IApplicationCommands applicationCommands)
        {
            GenerateMenu();
            this.applicationCommands = applicationCommands;
        }

        void ExecuteSelectedCommand(NavigationItem navigationItem)
        {
            if(navigationItem != null)
            {
                applicationCommands.NavigateCommand.Execute(navigationItem.NavigationPath);
            }
        }

        void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            var root = new NavigationItem() { Caption = "Personal Folder", NavigationPath = "MailList?id=Default" };
            root.Items.Add(new NavigationItem() { Caption = "Inbox", NavigationPath = "MailList?id=Inbox" });
            root.Items.Add(new NavigationItem() { Caption = "Deleted", NavigationPath = "MailList?id=Deleted" });
            root.Items.Add(new NavigationItem() { Caption = "Sent", NavigationPath = "MailList?id=Sent" });

            Items.Add(root);
        }
    }
}
