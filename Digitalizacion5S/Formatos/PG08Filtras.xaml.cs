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
    public partial class PG08Filtras : ContentPage
    {
        double resultadosF8;
        public PG08Filtras()
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
            if (NA1F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 12
            if (NA12F8.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C12F8.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC12F8.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF8 = 0;
            }
            else
            {
                resultadosF8 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF8.ToString();
            }

            hallaz1 = F8H1.Text;
            hallaz2 = F8H2.Text;
            hallaz3 = F8H3.Text;
            hallaz4 = F8H4.Text;
            hallaz5 = F8H5.Text;

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