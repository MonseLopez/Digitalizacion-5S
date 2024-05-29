using Digitalizacion5S.Services;
using Digitalizacion5S.View;
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
    public partial class PG17MesasCambio : ContentPage
    {
        private HallazgosViewModel _hallaz;
        double resultadosF17;
        //public PG17MesasCambio(HallazgosViewModel Hallaz)
        public PG17MesasCambio()

        {
            InitializeComponent();
            BindingContext = new HallazgosViewModel();
            //_hallaz = Hallaz;
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1, hallaz2, hallaz3, hallaz4, hallaz5; 
            int hallazCont = 0;
            double cp = 0;
            int c = 8;

            //Pregunta 1
            if (NA1F17.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C1F17.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC1F17.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 2
            if (NA2F17.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C2F17.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC2F17.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 3
            if (NA3F17.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C3F17.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC3F17.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 4
            if (NA4F17.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C4F17.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC4F17.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 5
            if (NA5F17.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C5F17.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC5F17.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 6
            if (NA6F17.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C6F17.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC6F17.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 7
            if (NA7F17.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C7F17.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC7F17.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Pregunta 8
            if (NA8F17.IsChecked)
            {
                c = c - 1;
            }
            else
            {
                if (C8F17.IsChecked)
                {
                    cp = cp + 10;
                }
                else if (NC8F17.IsChecked)
                {
                    cp = cp + 0;
                }
            }

            //Calificación
            if (c == 0)
            {
                resultadosF17 = 0;
            }
            else
            {
                resultadosF17 = (cp / c) / 2;

                AppGlobals.resulArea = resultadosF17.ToString();
            }

            hallaz1 = F17H1.Text;
            hallaz2 = F17H2.Text;
            hallaz3 = F17H3.Text;
            hallaz4 = F17H4.Text;
            hallaz5 = F17H5.Text;

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

            //if (_hallaz.InsertCommand.CanExecute(null))
            //{
            //    _hallaz.InsertCommand.Execute(null);
            //}
        }
    }
}