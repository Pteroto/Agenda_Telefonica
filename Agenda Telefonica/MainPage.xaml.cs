using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;
namespace Agenda_Telefonica
{
    public partial class MainPage : PhoneApplicationPage
    {


        // metodos tem q ficar fora do MainPage (metodo Main)
        private void bttAddContato_Click(object sender, EventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/AddContato.xaml", UriKind.RelativeOrAbsolute));
            
        }
        
        private void bttAlterarContato_click(object sender, EventArgs e)
        {
            DadosAgenda contato = lbxContatos.SelectedItem as DadosAgenda;
            GlobalVariables.id = contato.Id;
            GlobalVariables.nome = contato.Nome;
            GlobalVariables.numero = contato.Numero;
            GlobalVariables.grupo = contato.Grupo;
            GlobalVariables.tipo = contato.Tipo;
            
            NavigationService.Navigate(new Uri("/AlterarContato.xaml", UriKind.RelativeOrAbsolute));
            
            
        }

        private void bttExcluirContato_click(object sender, EventArgs e)
        {
            DadosAgenda contato = lbxContatos.SelectedItem as DadosAgenda;
           //ListBoxItem pressedItem = this.lbxContatos.ItemContainerGenerator.ContainerFromItem(contato) as ListBoxItem;
            Controles.DadosControle controle = new Controles.DadosControle();
            controle.Remove(contato);
            
            //select soh pra atualizar a lista

            List<DadosAgenda> lista = new List<DadosAgenda>();
            IEnumerable<DadosAgenda> itens = controle.GetDataItem();

            foreach (DadosAgenda listItem in itens)
            {
                lista.Add(listItem);
            }

            lbxContatos.ItemsSource = lista;
            
           
        }

        private void bttConfig_click(object sender, EventArgs e)
        {
            //falta criar a nova pagina
            //NavigationService.Navigate(new Uri("/AddContato.xaml", UriKind.RelativeOrAbsolute));
        }

        private void bttSobre_click(object sender, EventArgs e)
        {

            //falta criar a nova pagina
            //NavigationService.Navigate(new Uri("/AddContato.xaml", UriKind.RelativeOrAbsolute));
        }

        private void lbxContatos_Tap(object sender, EventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/AddContato.xaml", UriKind.RelativeOrAbsolute));
            
        }




        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ApplicationBar = new ApplicationBar();

            ApplicationBar.Mode = ApplicationBarMode.Default;
            ApplicationBar.Opacity = 1.0;
            ApplicationBar.IsVisible = true;
            ApplicationBar.IsMenuEnabled = true;

            ApplicationBarIconButton bttAddContato = new ApplicationBarIconButton();
            bttAddContato.IconUri = new Uri("/icons/iconsblack/add.png", UriKind.Relative);
            bttAddContato.Text = "Adicionar";
            ApplicationBar.Buttons.Add(bttAddContato);
            bttAddContato.Click += new EventHandler(bttAddContato_Click);

            

            /*  apenas com imagem feita, tem q criar os métodos e as telas ainda
             * 
             * LIMITE APENAS PARA 4 BOTÕES
             * 
             * Alterar
             * só aparecer depois de selecionado
             * 
             */
            ApplicationBarIconButton bttAlterarContato = new ApplicationBarIconButton();
            bttAlterarContato.IconUri = new Uri("/icons/iconsblack/edit.png", UriKind.Relative);
            bttAlterarContato.Text = "Alterar";
            ApplicationBar.Buttons.Add(bttAlterarContato);
            bttAlterarContato.Click += new EventHandler(bttAlterarContato_click);

             /*  Excluir
             *  só aparecer depois de selecionado
             */ 
            ApplicationBarIconButton bttExcluirContato = new ApplicationBarIconButton();
            bttExcluirContato.IconUri = new Uri("/icons/iconsblack/delete.png", UriKind.Relative);
            bttExcluirContato.Text = "Excluir";
            ApplicationBar.Buttons.Add(bttExcluirContato);
            bttExcluirContato.Click += new EventHandler(bttExcluirContato_click);

             /*  Sobre
             * 
             */ 
            ApplicationBarIconButton bttSobreContato = new ApplicationBarIconButton();
            bttSobreContato.IconUri = new Uri("/icons/iconsblack/questionmark.png", UriKind.Relative);
            bttSobreContato.Text = "Sobre";
            ApplicationBar.Buttons.Add(bttSobreContato);
            bttSobreContato.Click += new EventHandler(bttSobre_click);

             /*  Configurações - fazer como um item do menu
             *  
             */ 
            /* ApplicationBarIconButton bttConfigContato = new ApplicationBarIconButton();
            bttConfigContato.IconUri = new Uri("/icons/iconsblack/feature.settings.png", UriKind.Relative);
            bttConfigContato.Text = "Configurações";
            ApplicationBar.Buttons.Add(bttConfigContato);
            bttConfigContato.Click += new EventHandler(bttConfig_click);
             
                 
                 /* 
             * 
             *  talvez um search, mas não sei aonde
             * 
             * */


            //var iso = IsolatedStorageSettings.ApplicationSettings;

            // Listando os contatos do Storage

            List<DadosAgenda> lista = new List<DadosAgenda>();
            
            //DadosAgenda dado;
            
            /*for (int i = 0; i <= iso.Count; i++)
            {
                if (iso.Contains(i + ""))
                {
                    dado = new DadosAgenda();
                    dado = (DadosAgenda)iso[i + ""];
                    lista.Add(dado);

                }

            }
             */
            Controles.DadosControle controle = new Controles.DadosControle();
            controle.CreateDataBase();
                IEnumerable<DadosAgenda> itens = controle.GetDataItem();

                foreach (DadosAgenda listItem in itens)
                {
                    lista.Add(listItem);
                }
            
            lbxContatos.ItemsSource = lista;

        }

        private void btt_Ligar(object sender, RoutedEventArgs e)
        {
            DadosAgenda contato = (sender as Button).DataContext as DadosAgenda;
            ListBoxItem pressedItem = this.lbxContatos.ItemContainerGenerator.ContainerFromItem(contato) as ListBoxItem;
            if (pressedItem != null)
            {
                PhoneCallTask phoneCallTask = new PhoneCallTask();

                phoneCallTask.PhoneNumber = contato.Numero;
                phoneCallTask.DisplayName = contato.Nome;

                phoneCallTask.Show();
            }
        }
        
    }
}