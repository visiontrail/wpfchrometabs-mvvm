using System;
using System.Collections.ObjectModel;
using System.Linq;
using Demo.ViewModel;

namespace Demo.SampleData
{
    /// <summary>
    /// 注：这个类型没有用，用的是ViewModel中的ViewModelSampleBase;
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
