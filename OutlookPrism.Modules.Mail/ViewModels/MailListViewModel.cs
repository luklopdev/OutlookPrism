using OutlookPrism.Core;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OutlookPrism.Modules.Mail.ViewModels
{
    public class MailListViewModel : ViewModelBase
    {
        private string title = "Default";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public MailListViewModel()
        {

        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            Title = navigationContext.Parameters.GetValue<string>("id");
        }
    }
}
