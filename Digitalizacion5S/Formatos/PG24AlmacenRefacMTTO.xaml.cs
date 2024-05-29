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
	public partial class PG24AlmacenRefacMTTO : ContentPage
	{
        double resultadosF24;
        public PG24AlmacenRefacMTTO ()
		{
			InitializeComponent ();
            BindingContext = new HallazgosViewModel();
        }

		private async void Result_Clicked(Object sender, EventArgs e)
		{
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 10;

            //Pregunta 1
            if (NA1F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F24.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F24.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F24.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF24 = 0;
            }
            else
            {
                resultadosF24 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF24.ToString();
            }

            hallaz1 = F24H1.Text;
            hallaz2 = F24H2.Text;
            hallaz3 = F24H3.Text;
            hallaz4 = F24H4.Text;
            hallaz5 = F24H5.Text;

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