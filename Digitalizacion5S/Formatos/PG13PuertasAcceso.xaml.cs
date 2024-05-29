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
    public partial class PG13PuertasAcceso : ContentPage
    {
        double resultadosF13;
        public PG13PuertasAcceso()
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
            if (NA1F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F13.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F13.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F13.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF13 = 0;
            }
            else
            {
                resultadosF13 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF13.ToString();

            }

            hallaz1 = F13H1.Text;
            hallaz2 = F13H2.Text;
            hallaz3 = F13H3.Text;
            hallaz4 = F13H4.Text;
            hallaz5 = F13H5.Text;

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