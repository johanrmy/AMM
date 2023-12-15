using Ramos14.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace Ramos14.ViewModels
{
    public class ViewModelCompras: BaseViewModel
    {
        private string cliente;
        public string Cliente
        {
            get { return this.cliente; }
            set { SetValue(ref this.cliente, value); }
        }

        private string total;
        public string Total
        {
            get { return this.total; }
            set { SetValue(ref this.total, value); }
        }

        private string vendedor;
        public string Vendedor
        {
            get { return this.vendedor; }
            set { SetValue(ref this.vendedor, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Compra> compras;
        public List<Compra> Compras
        {
            get { return this.compras; }
            set { SetValue(ref this.compras, value); }
        }


        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }


        public ViewModelCompras()
        {

            SearchCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                Compras = service.GetByText(Filter);

            });

            InsertCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                int newCompraId = service.Get().Count + 1;
                service.Create(new Compra { Cliente = Cliente, Total = Total, Vendedor = Vendedor, CompraId = newCompraId });

                App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok");
            });


        }
    }
}
