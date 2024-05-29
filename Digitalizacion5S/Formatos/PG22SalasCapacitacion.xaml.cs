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

	public partial class PG22SalasCapacitacion : ContentPage
	{
        double resultadosF22;

        public PG22SalasCapacitacion ()
		{
			InitializeComponent ();
            BindingContext = new HallazgosViewModel();
        }

        private async void Result_Clicked(Object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5;
            int hallazCont = 0;
            double cp = 0;
            int c = 17;

            //Pregunta 1
            if (NA1F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 9
            if (NA9F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C9F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC9F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 10
            if (NA10F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C10F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC10F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 11
            if (NA11F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C11F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC11F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 12
            if (NA12F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C12F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC12F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 13
            if (NA13F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C13F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC13F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 14
            if (NA14F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C14F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC14F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 15
            if (NA15F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C15F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC15F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 16
            if (NA16F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C16F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC16F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 17
            if (NA17F22.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C17F22.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC17F22.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF22 = 0;
            }
            else
            {
                resultadosF22 = (cp / c) / 2;
                AppGlobals.resulArea = resultadosF22.ToString();
            }

            hallaz1 = F22H1.Text;
            hallaz2 = F22H2.Text;
            hallaz3 = F22H3.Text;
            hallaz4 = F22H4.Text;
            hallaz5 = F22H5.Text;

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