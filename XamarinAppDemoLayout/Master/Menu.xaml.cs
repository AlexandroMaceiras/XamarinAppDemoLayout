using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAppDemoLayout.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void VaiParaPerfil1(object o, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.Perfil1());
            IsPresented = false;
        }
        public void VaiParaXamarin(object o, EventArgs e)
        {
            //Detail = new Pages.Xamarin(); <!-- Deste jeito a página é chamada, mas a ToolBar não aparece e o menu fica escondido tendo que ser arrastado -->
            Detail = new NavigationPage(new Pages.Xamarin());
            IsPresented = false;
        }
    }
}