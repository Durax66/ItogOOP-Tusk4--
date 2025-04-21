using proect_3_gif.Model;
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

namespace proect_3_gif.View.UserControl
{
    /// <summary>
    /// Логика взаимодействия для LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userName = TbLogin.Text;
                var uID = PbUID.Password;
                using (UserDataContext db = new UserDataContext())
                {
                    bool userFound = db.Users.Any(u => u.Login == userName && u.UID == uID);

                    if (userFound)
                    {
                        MessageBox.Show("Успешно!", " системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("ошибка", " системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), " системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
