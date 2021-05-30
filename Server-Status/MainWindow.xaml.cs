using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Server_Status.Exceptions;

namespace Server_Status
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Server> servers = new ObservableCollection<Server>();

        public MainWindow()
        {
            InitializeComponent();
            lstServers.DataContext = servers;
            servers.CollectionChanged += Servers_CollectionChanged;
        }

        private void Servers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.lstServers.Items.Refresh();
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.txtUrl.Text.Length > 0)
                {
                    if (CheckURL(txtUrl.Text))
                        AddServer();
                    else
                        throw new InvalidURLException();
                }
            }
            catch (InvalidURLException ex) { Messages.ShowError(ex); }

            //RefreshList()
        }



        public void AddServer()
        {
            servers.Add(new Server(txtUrl.Text, servers.Count % 2 == 0 ? true : false));
        }

        public void RefreshList()
        {
            lstServers.DataContext = null;
            lstServers.DataContext = servers;
        }

        private bool CheckURL(string url)
        {
            Regex reg = new Regex(@"(http|ftp|https)://([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])?"); //Regex to detect URL
            if (reg.IsMatch(url))
                return true;
            return false;
        }
    }
}
