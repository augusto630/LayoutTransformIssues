using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace LayoutTransformIssues
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void MoreZoom(object? sender, RoutedEventArgs e)
        {
            var transformControl = this.FindControl<LayoutTransformControl>("transformControl");
            ((ScaleTransform) transformControl.LayoutTransform).ScaleX += 0.1;
            ((ScaleTransform) transformControl.LayoutTransform).ScaleY += 0.1;
        }

        void LessZoom(object? sender, RoutedEventArgs e)
        {
            var transformControl = this.FindControl<LayoutTransformControl>("transformControl");
            ((ScaleTransform) transformControl.LayoutTransform).ScaleX -= 0.1;
            ((ScaleTransform) transformControl.LayoutTransform).ScaleY -= 0.1;
        }
    }
}