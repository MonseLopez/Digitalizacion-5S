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
	public partial class PG23PuertasAcceso34 : ContentPage
	{
        double resultadosF23;

        public PG23PuertasAcceso34 ()
		{
			InitializeComponent ();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(Object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 18;

            //Pregunta 1
            if (NA1F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 12
            if (NA12F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C12F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC12F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 13
            if (NA13F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C13F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC13F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 14
            if (NA14F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C14F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC14F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 15
            if (NA15F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C15F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC15F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 16
            if (NA16F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C16F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 17
            if (NA17F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C17F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC17F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 18
            if (NA18F23.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C18F23.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC18F23.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF23 = 0;
            }
            else
            {
                resultadosF23 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF23.ToString();
            }

            hallaz1 = F23H1.Text;
            hallaz2 = F23H2.Text;
            hallaz3 = F23H3.Text;
            hallaz4 = F23H4.Text;
            hallaz5 = F23H5.Text;

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