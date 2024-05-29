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
    public partial class PG20AlmacenRefac : ContentPage
    {
        double resultadosF20;
        public PG20AlmacenRefac()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 12;

            //Pregunta 1
            if (NA1F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 12
            if (NA12F20.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C12F20.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC12F20.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF20 = 0;
            }
            else
            {
                resultadosF20 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF20.ToString();
            }

            hallaz1 = F20H1.Text;
            hallaz2 = F20H2.Text;
            hallaz3 = F20H3.Text;
            hallaz4 = F20H4.Text;
            hallaz5 = F20H5.Text;

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