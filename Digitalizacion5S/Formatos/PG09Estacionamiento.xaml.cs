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
    public partial class PG09Estacionamiento : ContentPage
    {
        double resultadosF9;
        public PG09Estacionamiento()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 14;

            //Pregunta 1
            if (NA1F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 12
            if (NA12F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C12F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC12F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 13
            if (NA13F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C13F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC13F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 14
            if (NA14F9.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C14F9.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC14F9.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF9 = 0;
            }
            else
            {
                resultadosF9 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF9.ToString();
            }

            hallaz1 = F9H1.Text;
            hallaz2 = F9H2.Text;
            hallaz3 = F9H3.Text;
            hallaz4 = F9H4.Text;
            hallaz5 = F9H5.Text;

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