using Ramos14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ramos14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListadoView : ContentPage
    {
        public ListadoView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelCompras();
        }
    }
}