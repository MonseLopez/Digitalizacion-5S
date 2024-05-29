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
	public partial class PG26AlmacenCintasVenta : ContentPage
	{
        double resultadosF26;
        public PG26AlmacenCintasVenta ()
		{
			InitializeComponent ();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 9;

            //Pregunta 1
            if (NA1F26.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F26.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F26.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F26.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F26.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F26.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F26.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F26.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F26.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F26.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F26.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F26.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F26.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F26.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F26.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F26.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F26.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F26.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F26.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F26.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F26.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F26.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F26.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F26.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF26 = 0;
            }
            else
            {
                resultadosF26 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF26.ToString();
            }

            hallaz1 = F26H1.Text;
            hallaz2 = F26H2.Text;
            hallaz3 = F26H3.Text;
            hallaz4 = F26H4.Text;
            hallaz5 = F26H5.Text;

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