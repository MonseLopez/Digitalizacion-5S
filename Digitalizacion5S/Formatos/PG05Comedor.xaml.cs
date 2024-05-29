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
    public partial class PG05Comedor : ContentPage
    {
        double resultadosF5;
        public PG05Comedor()
        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 22;

            //Pregunta 1
            if (NA1F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F5.IsChecked)
            {
                //c = c - 1;
                c -= 1;
            }
            else
            {
                if (C2F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 12
            if (NA12F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C12F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC12F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 13
            if (NA13F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C13F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC13F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 14
            if (NA14F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C14F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC14F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 15
            if (NA15F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C15F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC15F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 16
            if (NA16F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C16F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC16F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 17
            if (NA17F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C17F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC17F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 18
            if (NA18F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C18F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC18F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 19
            if (NA19F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C19F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC19F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 20
            if (NA20F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C20F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC20F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 21
            if (NA21F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C21F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC21F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 22
            if (NA22F5.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C22F5.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC22F5.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF5 = 0;
            }
            else
            {
                resultadosF5 = (cp / c) / 2;
            }

            hallaz1 = F5H1.Text;
            hallaz2 = F5H2.Text;
            hallaz3 = F5H3.Text;
            hallaz4 = F5H4.Text;
            hallaz5 = F5H5.Text;

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