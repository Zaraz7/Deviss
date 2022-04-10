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

namespace Deviss.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientGeneralPage.xaml
    /// </summary>
    public partial class ClientGeneralPage : Page
    {
        public ClientGeneralPage()
        {
            InitializeComponent();
            //SingleFrame.Navigate(new Empty());
            //Manager.SingleFrame = SingleFrame;
            dgIssue.ItemsSource = DevissDBEntities.GetContext().Issue.ToList();
            dgTeachers.ItemsSource = DevissDBEntities.GetContext().User.ToList();
            dgDevises.ItemsSource = DevissDBEntities.GetContext().Device.ToList();
        }

        private void NewIssueClick(object sender, RoutedEventArgs e)
        {
            //SingleFrame.Navigate(new IssueEditor());
        }
    }
}
