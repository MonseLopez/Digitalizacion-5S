using Digitalizacion5S.Formatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Xaml;
using ZXing.Net.Maui;
using static Microsoft.Maui.Authentication.AppleSignInAuthenticator;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Authentication;

namespace Digitalizacion5S.View
{
    public partial class LectorQR : ContentPage
    {
        private string ClaveArea;
        private string ClaveFormato;

        public LectorQR(string claveArea, string claveFormato)
        {
            InitializeComponent();

            ClaveArea = claveArea;
            ClaveFormato = claveFormato;
        }

        private async void btnScannerQr_Clicked(object sender, EventArgs e)
        {
            Dictionary<string, Action> formatos = new Dictionary<string, Action>
            {
                { "CHOE3IAF", () => Navigation.PushAsync(new PG01Operacion()) },
                { "PT6UZWPJ", () => Navigation.PushAsync(new PG02Oficinas()) },
                { "0ARQ6C0R", () => Navigation.PushAsync(new PG03Sanitarios()) },
                { "9Q4L9U46", () => Navigation.PushAsync(new PG04Mezzanines()) },
                { "9WRO0GQD", () => Navigation.PushAsync(new PG05Comedor()) },
                { "SRVUYQ6M", () => Navigation.PushAsync(new PG06Salas()) },
                { "C1W9BGS5", () => Navigation.PushAsync(new PG07Jardin()) },
                { "TYPAOXVJ", () => Navigation.PushAsync(new PG08Filtras()) },
                { "F9O125XM", () => Navigation.PushAsync(new PG09Estacionamiento()) },
                { "8UZ2J28G", () => Navigation.PushAsync(new PG10RampaBascula()) },
                { "KRBTG8SL", () => Navigation.PushAsync(new PG11Osmosis()) },
                { "46KCSY6F", () => Navigation.PushAsync(new PG12Compresores()) },
                { "LQXAQV3C", () => Navigation.PushAsync(new PG13PuertasAcceso()) },
                { "0YSW8J5L", () => Navigation.PushAsync(new PG14Transfers()) },
                { "KUCD6JLN", () => Navigation.PushAsync(new PG15Metrologia_A()) },
                { "0299OD6G", () => Navigation.PushAsync(new PG15Metrologia_B()) },
                { "IB0FP2BK", () => Navigation.PushAsync(new PG16Vestidores()) },
                { "UP6OZ69M", () => Navigation.PushAsync(new PG17MesasCambio()) },
                { "LWMONZMC", () => Navigation.PushAsync(new PG18Bodegas()) },
                { "CA2U2UZO", () => Navigation.PushAsync(new PG19BibliotecaMTTO()) },
                { "I1VRDT2L", () => Navigation.PushAsync(new PG20AlmacenRefac()) },
                { "SOSP2548", () => Navigation.PushAsync(new PG21SalaEspera()) },
                { "DWHEFQ7N", () => Navigation.PushAsync(new PG22SalasCapacitacion()) },
                { "1Y2CUFHG", () => Navigation.PushAsync(new PG23PuertasAcceso34()) },
                { "GKSFRS3Y", () => Navigation.PushAsync(new PG24AlmacenRefacMTTO()) },
                { "QZLDCV9E", () => Navigation.PushAsync(new PG25AlmacenRollos()) },
                { "P8OLKK9C", () => Navigation.PushAsync(new PG26AlmacenCintasVenta()) },
                { "QQ3PK1HO", () => Navigation.PushAsync(new PG27AlmacenTemporalResPel()) }
            };

            try
            {
                /*
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = "Escanee el codigo de el área";
                scanner.BottomText = "Asegurese de estar en el área correcta";
                var result = await scanner.Scan();
                string sc = result.ToString();

                if(result != null)
                {
                    if (sc.Equals(ClaveArea))
                    {
                        if (formatos.ContainsKey(ClaveFormato))
                        {
                            formatos[ClaveFormato].Invoke();
                        }
                    }
                }
                */
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "OK");
            }
        }
    }
}