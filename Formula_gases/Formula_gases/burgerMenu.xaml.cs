using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula_gases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class burgerMenu : MasterDetailPage
    {
        public burgerMenu()
        {
            InitializeComponent();

            Init();

            listMenu.ItemSelected += ListMenu_ItemSelected;
        }

        

        private void Init()
        {
            List<Menu> menu = new List<Menu>
            {
                new Menu{page=new MainPage(), menuTitle="Inicio", menuDetail="Regresar a pagina principal"},
                new Menu{page=new Ley_boyle(), menuTitle="Ley de Boyle", menuDetail="V1*P1=V2*P2"}
            };

            listMenu.ItemsSource = menu;

            listMenu.Margin = new Thickness(0, 24, 0, 0);

            Detail = new NavigationPage(new MainPage());
        }
        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            var pagina = menu.page;
            IsPresented = false;
            Detail = new NavigationPage(menu.page);
        }
        internal class Menu
        {
            public string menuTitle
            {
                get;
                set;
            }
            public string menuDetail
            {
                get;
                set;
            }
            public Page page
            {
                get;
                set;
            }
        }
    }
}

