using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Xpf.Docking;
using System.Windows.Media;

namespace WpfApplication.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<PanelViewModel> DocumentViews {
            get { return GetValue<ObservableCollection<PanelViewModel>>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<PanelViewModel> LayoutViews {
            get { return GetValue<ObservableCollection<PanelViewModel>>(); }
            set { SetValue(value); }
        }

        public MainViewModel()
        {
            DocumentViews = new ObservableCollection<PanelViewModel>() {
                new DocumentViewModel() { Caption = "Document1", Content = "A document panel", Glyph="/Images/change.png"  },
                new DocumentViewModel() { Caption = "Document2", Content = "A document panel", Glyph="/Images/create.png" },
                new DocumentViewModel() { Caption = "Document3", Content = "A document panel", Glyph="/Images/new-16x16.png" },
                new DocumentViewModel() { Caption = "Document4", Content = "A document panel" },
            };
            LayoutViews = new ObservableCollection<PanelViewModel>() {
                new PanelViewModel() { Caption = "One", Content = "A regular panel" },
                new PanelViewModel() { Caption = "Two", Content = "A regular panel" },
                new PanelViewModel() { Caption = "Three", Content = "A regular panel" },
                new PanelViewModel() { Caption = "Five", Content = "A regular panel" },
            };
        }
    }

    public class PanelViewModel : ViewModelBase
    {
        public string Caption {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public string Content {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }

    public class DocumentViewModel : PanelViewModel
    {
        public string Glyph {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}