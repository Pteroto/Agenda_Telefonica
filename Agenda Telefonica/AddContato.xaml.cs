using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Collections;

namespace Agenda_Telefonica
{
    public partial class AddContato : PhoneApplicationPage
    {

        String[] Grupos = { "Faculdade\n", "Familia\n", "Trabalho\n", "Bairro\n", "Casa\n", "Clube\n", "Random\n"};
        String[] Tipos = { "Residencial\n", "Celular\n", "Comercial\n", "Outro\n" };



        public AddContato()
        {
            InitializeComponent();

            this.lpkGrupos.ItemsSource = Grupos;
            this.lpkTipo.ItemsSource = Tipos;
        }

        private void bttSalvar_Click(object sender, RoutedEventArgs e)
        {


            DadosAgenda novosDadosAgenda;
            //var settings = IsolatedStorageSettings.ApplicationSettings;


            novosDadosAgenda = new DadosAgenda();

            novosDadosAgenda.Nome = this.txtNome.Text;
            novosDadosAgenda.Numero = this.txtNumero.Text;
            novosDadosAgenda.Grupo = this.lpkGrupos.SelectedItem + "";
            novosDadosAgenda.Tipo = this.lpkTipo.SelectedItem + "";


            //Salvando no Storage
            //int cont = settings.Count();

            Controles.DadosControle controle = new Controles.DadosControle();
            
            controle.Save(novosDadosAgenda);
            
            //settings[Convert.ToString(cont)] = novosDadosAgenda;
            //settings.Save();
            //MessageBox.Show("Contato salvo!");




            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void bttLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Text = "";
            txtNumero.Text = "";
            lpkGrupos.SelectedItem = Grupos.First();
            lpkTipo.SelectedItem = Tipos.First();

        }


    }
}