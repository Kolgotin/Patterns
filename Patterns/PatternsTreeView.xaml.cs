using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Patterns
{
    /// <summary>
    /// Interaction logic for PatternsTreeView.xaml
    /// </summary>
    public partial class PatternsTreeView : UserControl
    {
        public PatternsTreeView()
        {
            InitializeComponent();
            DataContext = new PatternsTreeViewModel();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);

            e.Handled = true;
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var sv = (sender as ScrollViewer);

            if(e.Delta > 0)
            {
                sv.LineUp();
                sv.LineUp();
            }
            else
            {
                sv.LineDown();
                sv.LineDown();
            }
        }
    }
}
