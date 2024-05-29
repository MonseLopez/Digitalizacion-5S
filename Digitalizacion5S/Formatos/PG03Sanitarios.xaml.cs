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
    public partial class PG03Sanitarios : ContentPage
    {
        double resultadosF3;
        public PG03Sanitarios()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 10;

            //Pregunta 1
            if (NA1F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F3.IsChecked)
            {
                //c = c - 1;
                c -= 1;
            }
            else
            {
                if (C2F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F3.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F3.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F3.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF3 = 0;
            }
            else
            {
                resultadosF3 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF3.ToString();
            }

            hallaz1 = F3H1.Text;
            hallaz2 = F3H2.Text;
            hallaz3 = F3H3.Text;
            hallaz4 = F3H4.Text;
            hallaz5 = F3H5.Text;

            //Numero de hallazgos
            if (hallaz1 != null)
            {
                hallazCont += 1;

                if (hallaz2 != null)
                {
                    hallazCont += 1;

                    if (hallaz3 != null)
                    {
                        hallazCont += 1;

                        if (hallaz4 != null)
                        {
                            hallazCont += 1;

                            if (hallaz5 != null)
                            {
                                hallazCont += 1;
                            }
                        }
                    }
                }
            }

            AppGlobals.hallazCont = hallazCont.ToString();

            FirebaseHelper fb = new FirebaseHelper();

            await DisplayAlert("AUDITORIA", "Calificación cargada correctamente", "Ok");

        }

    }



}