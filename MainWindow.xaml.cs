using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace coh2ui;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddButton(object sender, RoutedEventArgs e)
    {
        AddWindow cum = new AddWindow();
        cum.ShowDialog();
    }

    private void EditButton(object sender, RoutedEventArgs e)
    {
    }

    private void DeleteButton(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void NineButton(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("ᗜ˰ᗜ", "ᗜ˰ᗜ");
    }

    private void KeysList_OnMouseDoubleClickClicked(object sender, MouseButtonEventArgs e)
    {
        throw new NotImplementedException();
    }
}