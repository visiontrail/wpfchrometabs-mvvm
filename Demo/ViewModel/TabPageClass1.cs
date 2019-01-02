using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Demo.ViewModel
{

    public class TabPageClass1 : TabBase
    {
        private string m_LabelShow;
        public string Label1Show
        {
            get { return m_LabelShow; }
            set { Set(() => m_LabelShow ,ref m_LabelShow, value); }
        }

        public TabPageClass1()
        {
            Label1Show = "LabelShow";
        }
    }
}
