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

namespace Deviss
{
    /// <summary>
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        public EnterPage()
        {
            InitializeComponent();
        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(pwPassword.Password))
            {
                MessageBox.Show("Обнаружены пустые поля!");
                return;
            }
            using (var db = new DevissDBEntities())
            {
                var user = db.User.AsNoTracking().FirstOrDefault(u => u.Login == tbLogin.Text && u.Password == pwPassword.Password);
                if (user == null)
                { 
                    MessageBox.Show("Неверный логин или пароль!");
                    return;
                }
                switch (user.Role)
                {
                    case "admi":
                        MessageBox.Show($"Вы вошли под админом, {user.FullName}");
                        break;
                    case "teac":
                        MessageBox.Show($"Вы вошли за учителя, {user.FullName}");
                        Manager.MainFrame.Navigate(new Pages.ClientGeneralPage());
                        break;
                    default:
                        MessageBox.Show($"???");
                        break;
                }
            }
        }
    }
}
