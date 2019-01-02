﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using Demo.ViewModel;

namespace Demo.SampleData
{
    /// <summary>
    /// 注：这个类型没有用到，用的是ViewModel中的ViewModelCustomStyleExampleWindow;
    /// </summary>
    class SampleViewModelCustomStyleExampleWindow : ViewModelExampleBase, IViewModelCustomStyleExampleWindow
    {
        private ObservableCollection<TabBase> _itemCollection;

        public new ObservableCollection<TabBase> ItemCollection
        {
            get => _itemCollection ?? (_itemCollection =
                       new ObservableCollection<TabBase>
                       {
                           CreateTab1(),
                           CreateTab2(),
                           CreateTab3(),
                           CreateTabLoremIpsum()
                       });
            set => _itemCollection = value;
        }
        public new TabBase SelectedTab
        {
            get => ItemCollection.FirstOrDefault();
            set => throw new NotImplementedException();
        }
    }
}
