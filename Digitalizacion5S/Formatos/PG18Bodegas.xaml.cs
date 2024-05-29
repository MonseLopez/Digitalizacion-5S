using Digitalizacion5S.Services;
using Digitalizacion5S.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace Digitalizacion5S.Formatos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PG18Bodegas : ContentPage
    {
        double resultadosF18;
        public PG18Bodegas()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 4;

            //Pregunta 1
            if (NA1F18.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F18.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F18.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F18.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F18.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F18.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F18.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F18.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F18.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F18.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F18.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F18.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF18 = 0;
            }
            else
            {
                resultadosF18 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF18.ToString();
            }

            hallaz1 = F18H1.Text;
            hallaz2 = F18H2.Text;
            hallaz3 = F18H3.Text;
            hallaz4 = F18H4.Text;
            hallaz5 = F18H5.Text;

            //Numero de hallazgos
            if (hallaz1 != null)
            {
                hallazCont += 1;
                //AppGlobals.hallazCont = hallazCont.ToString();

                if (hallaz2 != null)
                {
                    hallazCont += 1;
                    //AppGlobals.hallazCont = hallazCont.ToString();

                    if (hallaz3 != null)
                    {
                        hallazCont += 1;
                        //AppGlobals.hallazCont = hallazCont.ToString();

                        if (hallaz4 != null)
                        {
                            hallazCont += 1;
                            //AppGlobals.hallazCont = hallazCont.ToString();

                            if (hallaz5 != null)
                            {
                                hallazCont += 1;
                                //AppGlobals.hallazCont = hallazCont.ToString();
                            }
                        }
                    }
                }
                AppGlobals.hallazCont = hallazCont.ToString();

                FirebaseHelper fb = new FirebaseHelper();
            }

            await DisplayAlert("AUDITORIA", "Calificación cargada correctamente", "Ok");

        }
    }
}