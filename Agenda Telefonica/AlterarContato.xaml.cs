using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Agenda_Telefonica
{
    public partial class AlterarContato : PhoneApplicationPage
    {

        String[] Grupos = { "Faculdade\n", "Familia\n", "Trabalho\n", "Bairro\n", "Casa\n", "Clube\n", "Random\n" };
        String[] Tipos = { "Residencial\n", "Celular\n", "Comercial\n", "Outro\n" };

        public AlterarContato()
        {
            InitializeComponent();
            this.lpkGrupos.ItemsSource = Grupos;
            this.lpkGrupos.SelectedItem = GlobalVariables.grupo;
            this.lpkTipo.ItemsSource = Tipos;
            this.lpkTipo.SelectedItem = GlobalVariables.tipo;


            // listagem de parametros
            txtNome.Text = GlobalVariables.nome;
            txtNumero.Text = GlobalVariables.numero;
            
        }

        private void bttSalvar_Click(object sender, RoutedEventArgs e)
        {


            DadosAgenda AlterarDadosAgenda  = new DadosAgenda();
            //var settings = IsolatedStorageSettings.ApplicationSettings;



            AlterarDadosAgenda.Id = GlobalVariables.id;
            AlterarDadosAgenda.Nome = this.txtNome.Text;
            AlterarDadosAgenda.Numero = this.txtNumero.Text;
            AlterarDadosAgenda.Grupo = this.lpkGrupos.SelectedItem + "";
            AlterarDadosAgenda.Tipo = this.lpkTipo.SelectedItem + "";


            //Salvando no Storage
            //int cont = settings.Count();

            Controles.DadosControle controle = new Controles.DadosControle();

            controle.Update(AlterarDadosAgenda);

            //settings[Convert.ToString(cont)] = novosDadosAgenda;
            //settings.Save();
            //MessageBox.Show("Contato salvo!");


            
            
            

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));

        }

       /* private void bttLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Text = "";
            txtNumero.Text = "";
            lpkGrupos.SelectedItem = Grupos.First();
            lpkTipo.SelectedItem = Tipos.First();

        } */


    }
}