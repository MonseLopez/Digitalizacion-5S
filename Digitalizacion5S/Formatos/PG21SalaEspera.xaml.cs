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
	public partial class PG21SalaEspera : ContentPage
	{
        double resultadosF21;
        public PG21SalaEspera ()
		{
			InitializeComponent ();
            BindingContext = new HallazgosViewModel();
        }

		private async void Result_Clicked(Object sender, EventArgs e)
		{
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 11;

            //Pregunta 1
            if (NA1F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 1
            if (NA2F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA9F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 1
            if (NA9F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F21.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F21.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F21.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF21 = 0;
            }
            else
            {
                resultadosF21 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF21.ToString();
            }

            hallaz1 = F21H1.Text;
            hallaz2 = F21H2.Text;
            hallaz3 = F21H3.Text;
            hallaz4 = F21H4.Text;
            hallaz5 = F21H5.Text;

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