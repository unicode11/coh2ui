using System.Windows;
using System.Windows.Input;

namespace coh2ui;

public partial class AddWindow : Window
{
    public AddWindow()
    {
        InitializeComponent();
        this.Focus();
    }
    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
        // Show the pressed key
        LeftAddBlock.Text = $"{e.Key}";
        RightAddBlock.Text = $"{e.Key}";
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) { LeftAddBlock.Text = "LMB"; }
        else if (e.RightButton == MouseButtonState.Pressed) { LeftAddBlock.Text = "RMB"; }
    }
}