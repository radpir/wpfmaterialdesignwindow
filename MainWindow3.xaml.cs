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

namespace NavigationDrawer_PopUpMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow3 : Window
    {
        public MainWindow3()
        {
            InitializeComponent();

            var sideMenuItems = new List<MenuItem>()
            {
                new MenuItem
                {
                    SideMenuItemIconName = "ViewDashboard",
                    SideMenuItemText = "Home"
                },

                new MenuItem
                {
                    SideMenuItemIconName = "Pencil",
                    SideMenuItemText = "Create"
                },

                new MenuItem
                {
                    SideMenuItemIconName = "Ticket",
                    SideMenuItemText = "Tickets"
                },

                new MenuItem
                {
                    SideMenuItemIconName = "Message",
                    SideMenuItemText = "Messages"
                },

                new MenuItem
                {
                    SideMenuItemIconName = "GithubBox",
                    SideMenuItemText = "Github"
                }
            };

            lvSideMenu.ItemsSource = sideMenuItems;
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }
    }
}
