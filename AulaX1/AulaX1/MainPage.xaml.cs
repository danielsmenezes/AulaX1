using AulaX1.Services;
using AulaX1.Services.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AulaX1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnSearch.Clicked += SearchCEP;

        }

        private void SearchCEP(object sender, EventArgs args)
        {

            if (isValidCEP(tbCEP.Text.Trim()))
            {
                Endereco end = ViaCEPServices.BrowserAdressViaCEP(tbCEP.Text.Trim());

                lblResult.Text = string.Format("Endereço: {0}, {1} {2}, {3}", end.logradouro, end.bairro, end.localidade, end.uf);
            }
        }

        private bool isValidCEP(string cep)
        {
            if(cep.Length != 8)
            {
                DisplayAlert("Erro","CEP Inválido", "OK");
            }
            else
            {
                return true;
            }

            return false;
        }
    }
}
