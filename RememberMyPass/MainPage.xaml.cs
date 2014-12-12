using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RememberMyPass.Resources;
using RememberMyPass.Classes;

namespace RememberMyPass
{
    public partial class MainPage : PhoneApplicationPage
    {
        public Passwords pass;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            AtualizarLista();
        }
        private void AtualizarLista()
        {
            List<Passwords> lista = PasswordDB.GetPass();
            lstPW.ItemsSource = lista;
        }
        public void onClickNovo(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/NovoPW.xaml", UriKind.Relative));
        }
        public void onClickDelete(object sender, EventArgs e)
        {
            if (pass == null)
                MessageBox.Show("Nenhum item selecionado");
            else if (MessageBox.Show("Deletar " + pass.descricao + "?", "Atenção", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            PasswordDB.DeletarPW(pass);
            AtualizarLista();
        }
        private void onSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            pass = (sender as ListBox).SelectedItem as Passwords;
        }

        private void onHold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if ((pass = (sender as ListBox).SelectedItem as Passwords) == null)
                MessageBox.Show("Nenhum item selecionado");
            else
                MessageBox.Show("Senha: " + pass.password);
            
        }



        







        
    }
}