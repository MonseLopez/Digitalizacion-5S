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
	public partial class PG25AlmacenRollos : ContentPage
	{
        double resultadosF25;
        public PG25AlmacenRollos ()
		{
			InitializeComponent ();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(Object sender, EventArgs e)
        {

            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 9;

            //Pregunta 1
            if (NA1F25.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F25.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F25.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F25.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F25.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F25.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F25.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F25.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F25.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F25.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F25.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F25.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F25.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F25.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F25.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F25.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F25.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F25.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F25.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F25.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F25.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F25.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F25.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F25.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF25 = 0;
            }
            else
            {
                resultadosF25 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF25.ToString();
            }

            hallaz1 = F25H1.Text;
            hallaz2 = F25H2.Text;
            hallaz3 = F25H3.Text;
            hallaz4 = F25H4.Text;
            hallaz5 = F25H5.Text;

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