﻿using OutlookPrism.Core;
using OutlookPrism.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace OutlookPrism.Modules.Mail
{
    public class MailModule : IModule
    {
        private readonly IRegionManager regionManager;

        public MailModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}