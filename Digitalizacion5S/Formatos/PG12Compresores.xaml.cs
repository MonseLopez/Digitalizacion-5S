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
    public partial class PG12Compresores : ContentPage
    {
        double resultadosF12;
        public PG12Compresores()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 11;

            //Pregunta 1
            if (NA1F12.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F12.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F12.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F12.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F12.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F12.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F12.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F12.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F12.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F12.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F12.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F12.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F12.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F12.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F12.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F12.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F12.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F12.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F12.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F12.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F12.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F12.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F12.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F12.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF12 = 0;
            }
            else
            {
                resultadosF12 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF12.ToString();

            }

            hallaz1 = F12H1.Text;
            hallaz2 = F12H2.Text;
            hallaz3 = F12H3.Text;
            hallaz4 = F12H4.Text;
            hallaz5 = F12H5.Text;

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