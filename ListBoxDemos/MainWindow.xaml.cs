using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBoxDemos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aantalItemsButton_Click(object sender, RoutedEventArgs e)
        {
            aantalItemsTextBlock.Text = listBox.Items.Count.ToString();
        }

        private void voegItemToeButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(toeTeVoegenItem.Text);
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedIndexTextBlock.Text = listBox.SelectedIndex.ToString();
            selectedItemTextBlock.Text = listBox.SelectedItem.ToString();
            selectedValueTextBlock.Text = listBox.SelectedValue.ToString();
        }
    }
}
