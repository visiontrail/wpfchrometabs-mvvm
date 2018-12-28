using System;
using System.Collections.ObjectModel;
using System.Linq;
using Demo.ViewModel;

namespace Demo.SampleData
{
    /// <summary>
    /// 这个是在Locator中;
    /// if (ViewModelBase.IsInDesignModeStatic) 被注册关联的;
    /// ?????????????
    /// </summary>
    public class SampleViewModelMainWindow : ViewModelExampleBase, IViewModelMainWindow
    {
        public SampleViewModelMainWindow()
        {
            Console.WriteLine("Enter the SampleViewModelMainWindow!");
        }

        public bool CanMoveTabs
        {
            get => true;
            set => throw new NotImplementedException();
        }

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

        public bool ShowAddButton
        {
            get => true;
            set => throw new NotImplementedException();
        }
    }
}
