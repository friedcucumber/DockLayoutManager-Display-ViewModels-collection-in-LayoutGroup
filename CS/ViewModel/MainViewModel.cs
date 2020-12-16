using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Docking;
using System.Windows.Media;

namespace WpfApplication
{
    public class MainViewModel 
    {

        public MainViewModel()
        {
            DocumentViews.Add(new DocumentViewModel("Document1", "/Images/change.png"));
            DocumentViews.Add(new DocumentViewModel("Document2", "/Images/create.png"));
            DocumentViews.Add(new DocumentViewModel("Document2", "/Images/new-16x16.png"));
            ChildViews.Add(new PanelViewModel(Colors.Red));
            ChildViews.Add(new PanelViewModel(Colors.Blue));
            ChildViews.Add(new PanelViewModel(Colors.Green));
        }

        public ObservableCollection<object> ChildViews { get; set; } = new ObservableCollection<object>();


        public ObservableCollection<object> DocumentViews { get; set; } = new ObservableCollection<object>();


    }
}