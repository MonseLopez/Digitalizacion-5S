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
    public partial class PG06Salas : ContentPage
    {
        double resultadosF6;
        public PG06Salas()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 15;

            //Pregunta 1
            if (NA1F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 12
            if (NA12F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C12F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC12F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 13
            if (NA13F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C13F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC13F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 14
            if (NA14F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C14F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC14F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 15
            if (NA15F6.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C15F6.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC15F6.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF6 = 0;
            }
            else
            {
                resultadosF6 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF6.ToString();
            }

            hallaz1 = F6H1.Text;
            hallaz2 = F6H2.Text;
            hallaz3 = F6H3.Text;
            hallaz4 = F6H4.Text;
            hallaz5 = F6H5.Text;

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