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
    public partial class PG15Metrologia_B : ContentPage
    {
        double resultadosF15B;
        public PG15Metrologia_B()
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
            if (NA1F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 12
            if (NA12F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C12F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC12F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 13
            if (NA13F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C13F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC13F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 14
            if (NA14F15B.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C14F15B.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC14F15B.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF15B = 0;
            }
            else
            {
                resultadosF15B = (cp / c) / 2;
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