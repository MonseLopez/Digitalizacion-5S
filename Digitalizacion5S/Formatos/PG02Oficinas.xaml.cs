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
    public partial class PG02Oficinas : ContentPage
    {
        double resulFin;
        public PG02Oficinas()
        {
            InitializeComponent();
            BindingContext = new HallazgosOOViewModel();
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            string hallaz1S1, hallaz2S1, hallaz3S1, hallaz4S1,
                   hallaz1S2, hallaz2S2, hallaz3S2, hallaz4S2,
                   hallaz1S3, hallaz2S3, hallaz3S3, hallaz4S3,
                   hallaz1S4, hallaz2S4, hallaz3S4, hallaz4S4,
                   hallaz1S5, hallaz2S5, hallaz3S5, hallaz4S5;

            int hallazCont1 = 0,
                hallazCont2 = 0,
                hallazCont3 = 0,
                hallazCont4 = 0,
                hallazCont5 = 0,
                hallazContF = 0;

            int pregTot1 = 2,
                pregTot2 = 3,
                pregTot3 = 4,
                pregTot4 = 2,
                pregTot5 = 3;

            int contS1 = 0,
                contS2 = 0,
                contS3 = 0,
                contS4 = 0,
                contS5 = 0;

            double calS1 = 0.0,
                   calS2 = 0.0,
                   calS3 = 0.0,
                   calS4 = 0.0,
                   calS5 = 0.0,
                   calTot = 0.0;

            #region Calificaciones

            #region Calificaciones_1raS

            //Pregunta 1
            if (NA1F2S1.IsChecked)
            {
                pregTot1 -= 1;
            }
            else
            {
                if (C1F2S1.IsChecked)
                {
                    contS1 += 10;
                }
                else if (NC1F2S1.IsChecked)
                {
                    contS1 -= 0;
                }
            }

            //Pregunta 2
            if (NA2F2S1.IsChecked)
            {
                pregTot1 -= 1;
            }
            else
            {
                if (C2F2S1.IsChecked)
                {
                    contS1 += 10;
                }
                else if (NC2F2S1.IsChecked)
                {
                    contS1 -= 0;
                }
            }

            if (contS1 == 0)
            {
                calS1 = 0.0;
            }
            else
            {
                calS1 = (contS1 / pregTot1) / 10;
            }

            #endregion

            #region Calificaciones_2daS

            //Pregunta 1
            if (NA1F2S2.IsChecked)
            {
                pregTot2 -= 1;
            }
            else
            {
                if (C1F2S2.IsChecked)
                {
                    contS2 += 10;
                }
                else if (NC1F2S2.IsChecked)
                {
                    contS2 -= 0;
                }
            }

            //Pregunta 2
            if (NA2F2S2.IsChecked)
            {
                pregTot2 = -1;
            }
            else
            {
                if (C2F2S2.IsChecked)
                {
                    contS2 += 10;
                }
                else if (NC2F2S2.IsChecked)
                {
                    contS2 -= 0;
                }
            }

            //Pregunta 3
            if (NA3F2S2.IsChecked)
            {
                pregTot2 = -1;
            }
            else
            {
                if (C3F2S2.IsChecked)
                {
                    contS2 += 10;
                }
                else if (NC3F2S2.IsChecked)
                {
                    contS2 -= 0;
                }
            }


            if (contS2 == 0)
            {
                calS2 = 0.0;
            }
            else
            {
                calS2 = (contS2 / pregTot2) / 10;
            }

            #endregion

            #region Calificaciones_3raS

            //Pregunta 1
            if (NA1F2S3.IsChecked)
            {
                pregTot3 -= 1;
            }
            else
            {
                if (C1F2S3.IsChecked)
                {
                    contS3 += 10;
                }
                else if (NC1F2S3.IsChecked)
                {
                    contS3 -= 0;
                }
            }

            //Pregunta 2
            if (NA2F2S3.IsChecked)
            {
                pregTot3 = -1;
            }
            else
            {
                if (C2F2S3.IsChecked)
                {
                    contS3 += 10;
                }
                else if (NC2F2S3.IsChecked)
                {
                    contS3 -= 0;
                }
            }

            //Pregunta 3
            if (NA3F2S3.IsChecked)
            {
                pregTot3 = -1;
            }
            else
            {
                if (C3F2S3.IsChecked)
                {
                    contS3 += 10;
                }
                else if (NC3F2S3.IsChecked)
                {
                    contS3 -= 0;
                }
            }

            //Pregunta 4
            if (NA4F2S3.IsChecked)
            {
                pregTot3 -= 1;
            }
            else
            {
                if (C4F2S3.IsChecked)
                {
                    contS3 += 10;
                }
                else if (NC4F2S3.IsChecked)
                {
                    contS3 -= 0;
                }
            }

            if (contS3 == 0)
            {
                calS3 = 0.0;
            }
            else
            {
                calS3 = (contS3 / pregTot3) / 10;
            }

            #endregion

            #region Calificaciones_4taS

            //Pregunta 1
            if (NA1F2S4.IsChecked)
            {
                pregTot4 -= 1;
            }
            else
            {
                if (C1F2S4.IsChecked)
                {
                    contS4 += 10;
                }
                else if (NC1F2S4.IsChecked)
                {
                    contS4 -= 0;
                }
            }

            //Pregunta 2
            if (NA2F2S4.IsChecked)
            {
                pregTot4 = -1;
            }
            else
            {
                if (C2F2S4.IsChecked)
                {
                    contS4 += 10;
                }
                else if (NC2F2S4.IsChecked)
                {
                    contS4 -= 0;
                }
            }

            if (contS4 == 0)
            {
                calS4 = 0.0;
            }
            else
            {
                calS4 = (contS4 / pregTot4) / 10;
            }

            #endregion

            #region Calificaciones_5taS

            //Pregunta 1
            if (NA1F2S5.IsChecked)
            {
                pregTot5 -= 1;
            }
            else
            {
                if (C1F2S5.IsChecked)
                {
                    contS5 += 10;
                }
                else if (NC1F2S5.IsChecked)
                {
                    contS5 -= 0;
                }
            }

            //Pregunta 2
            if (NA2F2S5.IsChecked)
            {
                pregTot5 = -1;
            }
            else
            {
                if (C2F2S5.IsChecked)
                {
                    contS5 += 10;
                }
                else if (NC2F2S5.IsChecked)
                {
                    contS5 -= 0;
                }
            }

            //Pregunta 3
            if (NA3F2S5.IsChecked)
            {
                pregTot5 = -1;
            }
            else
            {
                if (C3F2S5.IsChecked)
                {
                    contS5 += 10;
                }
                else if (NC3F2S5.IsChecked)
                {
                    contS5 -= 0;
                }
            }

            if (contS5 == 0)
            {
                calS5 = 0.0;
            }
            else
            {
                calS5 = (contS5 / pregTot5) / 10;
            }

            #endregion

            #region Calificación_Final

            if (calS1 >= 0.5)
            {
                calTot = calTot + calS1;

                if (calS2 >= 0.5)
                {
                    calTot = calTot + calS2;

                    if (calS3 >= 0.5)
                    {
                        calTot = calTot + calS3;

                        if (calS4 >= 0.5)
                        {
                            calTot = calTot + calS4;

                            if (calS5 >= 0.66)
                            {
                                calTot = calTot + calS5;
                            }
                        }
                    }
                }
            }
            else if (calS1 < 0.5)
            {
                calTot = calTot + calS1;
            }

            AppGlobals.resulArea = calTot.ToString();

            #endregion

            #endregion

            #region Hallazgos

            #region Hallazgos_1raS

            hallaz1S1 = F2H1S1.Text;
            hallaz2S1 = F2H2S1.Text;
            hallaz3S1 = F2H3S1.Text;
            hallaz4S1 = F2H4S1.Text;

            //Numero de hallazgos
            if (hallaz1S1 != null)
            {
                hallazCont1 += 1;
            }

            if (hallaz2S1 != null)
            {
                hallazCont1 += 1;
            }

            if (hallaz3S1 != null)
            {
                hallazCont1 += 1;
            }

            if (hallaz4S1 != null)
            {
                hallazCont1 += 1;
            }

            hallazContF = hallazContF + hallazCont1;

            #endregion

            #region Hallazgos_2daS

            hallaz1S2 = F2H1S2.Text;
            hallaz2S2 = F2H2S2.Text;
            hallaz3S2 = F2H3S2.Text;
            hallaz4S2 = F2H4S2.Text;

            //Numero de hallazgos
            if (hallaz1S2 != null)
            {
                hallazCont2 += 1;
            }

            if (hallaz2S2 != null)
            {
                hallazCont2 += 1;
            }

            if (hallaz3S2 != null)
            {
                hallazCont2 += 1;
            }

            if (hallaz4S2 != null)
            {
                hallazCont2 += 1;
            }

            hallazContF = hallazContF + hallazCont2;

            #endregion

            #region Hallazgos_3raS

            hallaz1S3 = F2H1S3.Text;
            hallaz2S3 = F2H2S3.Text;
            hallaz3S3 = F2H3S3.Text;
            hallaz4S3 = F2H4S3.Text;

            //Numero de hallazgos
            if (hallaz1S3 != null)
            {
                hallazCont3 += 1;
            }

            if (hallaz2S3 != null)
            {
                hallazCont3 += 1;
            }

            if (hallaz3S3 != null)
            {
                hallazCont3 += 1;
            }

            if (hallaz4S3 != null)
            {
                hallazCont3 += 1;
            }

            hallazContF = hallazContF + hallazCont3;

            #endregion

            #region Hallazgos_4taS

            hallaz1S4 = F2H1S4.Text;
            hallaz2S4 = F2H2S4.Text;
            hallaz3S4 = F2H3S4.Text;
            hallaz4S4 = F2H4S4.Text;

            //Numero de hallazgos
            if (hallaz1S4 != null)
            {
                hallazCont4 += 1;
            }

            if (hallaz2S4 != null)
            {
                hallazCont4 += 1;
            }

            if (hallaz3S4 != null)
            {
                hallazCont4 += 1;
            }

            if (hallaz4S4 != null)
            {
                hallazCont4 += 1;
            }

            hallazContF = hallazContF + hallazCont4;

            #endregion

            #region Hallazgos_5taS

            hallaz1S5 = F2H1S5.Text;
            hallaz2S5 = F2H2S5.Text;
            hallaz3S5 = F2H3S5.Text;
            hallaz4S5 = F2H4S5.Text;

            //Numero de hallazgos
            if (hallaz1S5 != null)
            {
                hallazCont5 += 1;
            }

            if (hallaz2S5 != null)
            {
                hallazCont5 += 1;
            }

            if (hallaz3S5 != null)
            {
                hallazCont5 += 1;
            }

            if (hallaz4S5 != null)
            {
                hallazCont5 += 1;
            }

            hallazContF = hallazContF + hallazCont5;

            #endregion

            AppGlobals.hallazCont = hallazContF.ToString();

            #endregion

            FirebaseHelper fb = new FirebaseHelper();

            await DisplayAlert("Mensaje", "Auditoria Cargada", "Continuar");
        }

    }
}