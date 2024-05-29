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
    public partial class PG16Vestidores : ContentPage
    {
        double resultadosF16;
        public PG16Vestidores()
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
                if (NA1F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F16.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F16.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F16.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF16 = 0;
            }
            else
            {
                resultadosF16 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF16.ToString();
            }

            hallaz1 = F16H1.Text;
            hallaz2 = F16H2.Text;
            hallaz3 = F16H3.Text;
            hallaz4 = F16H4.Text;
            hallaz5 = F16H5.Text;

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