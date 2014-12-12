using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RememberMyPass.Classes;

namespace RememberMyPass
{
    public partial class NovoPW : PhoneApplicationPage
    {
        public NovoPW()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Passwords p = new Passwords();
            p.descricao = txtDesc.Text;
            p.password = txtPW.Password;

            PasswordDB.SalvarPW(p);
            NavigationService.GoBack();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}