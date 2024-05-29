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
    public partial class PG15Metrologia_A : ContentPage
    {
        double resultadosF15A;
        public PG15Metrologia_A()
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
            if (NA1F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F15A.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F15A.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F15A.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF15A = 0;
            }
            else
            {
                resultadosF15A = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF15A.ToString();
            }

            hallaz1 = F15H1.Text;
            hallaz2 = F15H2.Text;
            hallaz3 = F15H3.Text;
            hallaz4 = F15H4.Text;
            hallaz5 = F15H5.Text;

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