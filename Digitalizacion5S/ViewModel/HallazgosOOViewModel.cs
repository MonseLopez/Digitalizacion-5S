using CommunityToolkit.Mvvm.Input;
using Digitalizacion5S.Model;
using Digitalizacion5S.Services;
using Digitalizacion5S.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Digitalizacion5S.ViewModel
{
    public class HallazgosOOViewModel : BaseViewModel
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        #region Attributes
        private string Id;

        #region 1eraS
        
        public string hallaz1S1;
        public string hallaz2S1;
        public string hallaz3S1;
        public string hallaz4S1;

        public DateTime fecha1S1;
        public DateTime fecha2S1;
        public DateTime fecha3S1;
        public DateTime fecha4S1;

        public string accion1S1;
        public string accion2S1;
        public string accion3S1;
        public string accion4S1;

        #endregion

        #region 2daS

        public string hallaz1S2;
        public string hallaz2S2;
        public string hallaz3S2;
        public string hallaz4S2;

        public DateTime fecha1S2;
        public DateTime fecha2S2;
        public DateTime fecha3S2;
        public DateTime fecha4S2;

        public string accion1S2;
        public string accion2S2;
        public string accion3S2;
        public string accion4S2;

        #endregion

        #region 3eraS

        public string hallaz1S3;
        public string hallaz2S3;
        public string hallaz3S3;
        public string hallaz4S3;

        public DateTime fecha1S3;
        public DateTime fecha2S3;
        public DateTime fecha3S3;
        public DateTime fecha4S3;

        public string accion1S3;
        public string accion2S3;
        public string accion3S3;
        public string accion4S3;

        #endregion

        #region 4taS

        public string hallaz1S4;
        public string hallaz2S4;
        public string hallaz3S4;
        public string hallaz4S4;

        public DateTime fecha1S4;
        public DateTime fecha2S4;
        public DateTime fecha3S4;
        public DateTime fecha4S4;

        public string accion1S4;
        public string accion2S4;
        public string accion3S4;
        public string accion4S4;

        #endregion

        #region 5taS

        public string hallaz1S5;
        public string hallaz2S5;
        public string hallaz3S5;
        public string hallaz4S5;

        public DateTime fecha1S5;
        public DateTime fecha2S5;
        public DateTime fecha3S5;
        public DateTime fecha4S5;

        public string accion1S5;
        public string accion2S5;
        public string accion3S5;
        public string accion4S5;

        #endregion

        public string numHallaz;
        public string cal;

        public bool isRefreshing = false;
        public object listViewSource;
        #endregion

        #region Proporties
        public string IDTxt
        {
            get { return this.Id; }
            set { SetValue(ref this.Id, value); }
        }

        #region 1eraS

        public string Hallaz1S1Txt
        {
            get { return this.hallaz1S1; }
            set { SetValue(ref this.hallaz1S1, value); }
        }

        public string Hallaz2S1Txt
        {
            get { return this.hallaz2S1; }
            set { SetValue(ref this.hallaz2S1, value); }
        }

        public string Hallaz3S1Txt
        {
            get { return this.hallaz3S1; }
            set { SetValue(ref this.hallaz3S1, value); }
        }

        public string Hallaz4S1Txt
        {
            get { return this.hallaz4S1; }
            set { SetValue(ref this.hallaz4S1, value); }
        }

        public DateTime Fecha1S1Txt
        {
            get { return this.fecha1S1; }
            set { SetValue(ref this.fecha1S1, value); }
        }

        public DateTime Fecha2S1Txt
        {
            get { return this.fecha2S1; }
            set { SetValue(ref this.fecha2S1, value); }
        }

        public DateTime Fecha3S1Txt
        {
            get { return this.fecha3S1; }
            set { SetValue(ref this.fecha3S1, value); }
        }

        public DateTime Fecha4S1Txt
        {
            get { return this.fecha4S1; }
            set { SetValue(ref this.fecha4S1, value); }
        }

        public string Accion1S1Txt
        {
            get { return this.accion1S1; }
            set { SetValue(ref this.accion1S1, value); }
        }

        public string Accion2S1Txt
        {
            get { return this.accion1S1; }
            set { SetValue(ref this.accion1S1, value); }
        }

        public string Accion3S1Txt
        {
            get { return this.accion1S1; }
            set { SetValue(ref this.accion1S1, value); }
        }

        public string Accion4S1Txt
        {
            get { return this.accion1S1; }
            set { SetValue(ref this.accion1S1, value); }
        }

        #endregion

        #region 2daS

        public string Hallaz1S2Txt
        {
            get { return this.hallaz1S2; }
            set { SetValue(ref this.hallaz1S2, value); }
        }

        public string Hallaz2S2Txt
        {
            get { return this.hallaz2S2; }
            set { SetValue(ref this.hallaz2S2, value); }
        }

        public string Hallaz3S2Txt
        {
            get { return this.hallaz3S2; }
            set { SetValue(ref this.hallaz3S2, value); }
        }

        public string Hallaz4S2Txt
        {
            get { return this.hallaz4S2; }
            set { SetValue(ref this.hallaz4S2, value); }
        }

        public DateTime Fecha1S2Txt
        {
            get { return this.fecha1S2; }
            set { SetValue(ref this.fecha1S2, value); }
        }

        public DateTime Fecha2S2Txt
        {
            get { return this.fecha2S2; }
            set { SetValue(ref this.fecha2S2, value); }
        }

        public DateTime Fecha3S2Txt
        {
            get { return this.fecha3S2; }
            set { SetValue(ref this.fecha3S2, value); }
        }

        public DateTime Fecha4S2Txt
        {
            get { return this.fecha4S2; }
            set { SetValue(ref this.fecha4S2, value); }
        }

        public string Accion1S2Txt
        {
            get { return this.accion1S2; }
            set { SetValue(ref this.accion1S2, value); }
        }

        public string Accion2S2Txt
        {
            get { return this.accion2S1; }
            set { SetValue(ref this.accion2S2, value); }
        }

        public string Accion3S2Txt
        {
            get { return this.accion3S2; }
            set { SetValue(ref this.accion3S2, value); }
        }

        public string Accion4S2Txt
        {
            get { return this.accion4S2; }
            set { SetValue(ref this.accion4S2, value); }
        }

        #endregion

        #region 3eraS

        public string Hallaz1S3Txt
        {
            get { return this.hallaz1S3; }
            set { SetValue(ref this.hallaz1S3, value); }
        }

        public string Hallaz2S3Txt
        {
            get { return this.hallaz2S3; }
            set { SetValue(ref this.hallaz2S3, value); }
        }

        public string Hallaz3S3Txt
        {
            get { return this.hallaz3S3; }
            set { SetValue(ref this.hallaz3S3, value); }
        }

        public string Hallaz4S3Txt
        {
            get { return this.hallaz4S3; }
            set { SetValue(ref this.hallaz4S3, value); }
        }

        public DateTime Fecha1S3Txt
        {
            get { return this.fecha1S3; }
            set { SetValue(ref this.fecha1S3, value); }
        }

        public DateTime Fecha2S3Txt
        {
            get { return this.fecha2S3; }
            set { SetValue(ref this.fecha2S3, value); }
        }

        public DateTime Fecha3S3Txt
        {
            get { return this.fecha3S3; }
            set { SetValue(ref this.fecha3S3, value); }
        }

        public DateTime Fecha4S3Txt
        {
            get { return this.fecha4S3; }
            set { SetValue(ref this.fecha4S3, value); }
        }

        public string Accion1S3Txt
        {
            get { return this.accion1S3; }
            set { SetValue(ref this.accion1S3, value); }
        }

        public string Accion2S3Txt
        {
            get { return this.accion2S3; }
            set { SetValue(ref this.accion2S3, value); }
        }

        public string Accion3S3Txt
        {
            get { return this.accion3S3; }
            set { SetValue(ref this.accion3S3, value); }
        }

        public string Accion4S3Txt
        {
            get { return this.accion4S3; }
            set { SetValue(ref this.accion4S3, value); }
        }

        #endregion

        #region 4taS

        public string Hallaz1S4Txt
        {
            get { return this.hallaz1S4; }
            set { SetValue(ref this.hallaz1S4, value); }
        }

        public string Hallaz2S4Txt
        {
            get { return this.hallaz2S4; }
            set { SetValue(ref this.hallaz2S4, value); }
        }

        public string Hallaz3S4Txt
        {
            get { return this.hallaz3S4; }
            set { SetValue(ref this.hallaz3S4, value); }
        }

        public string Hallaz4S4Txt
        {
            get { return this.hallaz4S4; }
            set { SetValue(ref this.hallaz4S4, value); }
        }

        public DateTime Fecha1S4Txt
        {
            get { return this.fecha1S4; }
            set { SetValue(ref this.fecha1S4, value); }
        }

        public DateTime Fecha2S4Txt
        {
            get { return this.fecha2S4; }
            set { SetValue(ref this.fecha2S4, value); }
        }

        public DateTime Fecha3S4Txt
        {
            get { return this.fecha3S4; }
            set { SetValue(ref this.fecha3S4, value); }
        }

        public DateTime Fecha4S4Txt
        {
            get { return this.fecha4S4; }
            set { SetValue(ref this.fecha4S4, value); }
        }

        public string Accion1S4Txt
        {
            get { return this.accion1S4; }
            set { SetValue(ref this.accion1S4, value); }
        }

        public string Accion2S4Txt
        {
            get { return this.accion2S4; }
            set { SetValue(ref this.accion2S4, value); }
        }

        public string Accion3S4Txt
        {
            get { return this.accion3S4; }
            set { SetValue(ref this.accion3S4, value); }
        }

        public string Accion4S4Txt
        {
            get { return this.accion4S4; }
            set { SetValue(ref this.accion4S4, value); }
        }

        #endregion

        #region 5taS

        public string Hallaz1S5Txt
        {
            get { return this.hallaz1S5; }
            set { SetValue(ref this.hallaz1S5, value); }
        }

        public string Hallaz2S5Txt
        {
            get { return this.hallaz2S5; }
            set { SetValue(ref this.hallaz2S5, value); }
        }

        public string Hallaz3S5Txt
        {
            get { return this.hallaz3S5; }
            set { SetValue(ref this.hallaz3S5, value); }
        }

        public string Hallaz4S5Txt
        {
            get { return this.hallaz4S5; }
            set { SetValue(ref this.hallaz4S5, value); }
        }

        public DateTime Fecha1S5Txt
        {
            get { return this.fecha1S5; }
            set { SetValue(ref this.fecha1S5, value); }
        }

        public DateTime Fecha2S5Txt
        {
            get { return this.fecha2S5; }
            set { SetValue(ref this.fecha2S5, value); }
        }

        public DateTime Fecha3S5Txt
        {
            get { return this.fecha3S5; }
            set { SetValue(ref this.fecha3S5, value); }
        }

        public DateTime Fecha4S5Txt
        {
            get { return this.fecha4S5; }
            set { SetValue(ref this.fecha4S5, value); }
        }

        public string Accion1S5Txt
        {
            get { return this.accion1S5; }
            set { SetValue(ref this.accion1S5, value); }
        }

        public string Accion2S5Txt
        {
            get { return this.accion2S5; }
            set { SetValue(ref this.accion2S5, value); }
        }

        public string Accion3S5Txt
        {
            get { return this.accion3S5; }
            set { SetValue(ref this.accion3S5, value); }
        }

        public string Accion4S5Txt
        {
            get { return this.accion4S5; }
            set { SetValue(ref this.accion4S5, value); }
        }

        #endregion

        public string NumHallazTxt
        {
            get { return this.numHallaz; }
            set { SetValue(ref this.numHallaz, value); }
        }

        public string CalTxt
        {
            get { return this.cal; }
            set { SetValue(ref this.cal, value); }
        }

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }

        public object ListViewSource
        {
            get { return this.listViewSource; }
            set
            {
                SetValue(ref this.listViewSource, value);
            }
        }

        #endregion

        #region Converscion_Fechas

        #region 1raS
   
        public string Fecha1S1 => Fecha1S1Txt.ToString("yyyy-MM-dd");
        public string Fecha2S1 => Fecha2S1Txt.ToString("yyyy-MM-dd");
        public string Fecha3S1 => Fecha3S1Txt.ToString("yyyy-MM-dd");
        public string Fecha4S1 => Fecha4S1Txt.ToString("yyyy-MM-dd");

        #endregion

        #region 2daS

        public string Fecha1S2 => Fecha1S2Txt.ToString("yyyy-MM-dd");
        public string Fecha2S2 => Fecha2S2Txt.ToString("yyyy-MM-dd");
        public string Fecha3S2 => Fecha3S2Txt.ToString("yyyy-MM-dd");
        public string Fecha4S2 => Fecha4S2Txt.ToString("yyyy-MM-dd");

        #endregion

        #region 3raS

        public string Fecha1S3 => Fecha1S3Txt.ToString("yyyy-MM-dd");
        public string Fecha2S3 => Fecha2S3Txt.ToString("yyyy-MM-dd");
        public string Fecha3S3 => Fecha3S3Txt.ToString("yyyy-MM-dd");
        public string Fecha4S3 => Fecha4S3Txt.ToString("yyyy-MM-dd");

        #endregion

        #region 4taS

        public string Fecha1S4 => Fecha1S4Txt.ToString("yyyy-MM-dd");
        public string Fecha2S4 => Fecha2S4Txt.ToString("yyyy-MM-dd");
        public string Fecha3S4 => Fecha3S4Txt.ToString("yyyy-MM-dd");
        public string Fecha4S4 => Fecha4S4Txt.ToString("yyyy-MM-dd");

        #endregion

        #region 5taS

        public string Fecha1S5 => Fecha1S5Txt.ToString("yyyy-MM-dd");
        public string Fecha2S5 => Fecha2S5Txt.ToString("yyyy-MM-dd");
        public string Fecha3S5 => Fecha3S5Txt.ToString("yyyy-MM-dd");
        public string Fecha4S5 => Fecha4S5Txt.ToString("yyyy-MM-dd");

        #endregion

        #endregion

        #region Commands
        public ICommand InsertCommandOO
        {
            get
            {
                return new RelayCommand(InsertMethodOO);
            }
        }
        #endregion

        #region Methods

        private async void InsertMethodOO()
        {
            var hallazOO = new HallazgosOOModel
            {
                #region 1eraS
                Hallaz1S1 = hallaz1S1,
                Hallaz2S1 = hallaz2S1,
                Hallaz3S1 = hallaz3S1,
                Hallaz4S1 = hallaz4S1,
                Fecha1S1 = Fecha1S1,
                Fecha2S1 = Fecha2S1,
                Fecha3S1 = Fecha3S1,
                Fecha4S1 = Fecha4S1,
                Accion1S1 = accion1S1,
                Accion2S1 = accion2S1,
                Accion3S1 = accion3S1,
                Accion4S1 = accion4S1,
                #endregion

                #region 2daS
                Hallaz1S2 = hallaz1S2,
                Hallaz2S2 = hallaz2S2,
                Hallaz3S2 = hallaz3S2,
                Hallaz4S2 = hallaz4S2,
                Fecha1S2 = Fecha1S2,
                Fecha2S2 = Fecha2S2,
                Fecha3S2 = Fecha3S2,
                Fecha4S2 = Fecha4S2,
                Accion1S2 = accion1S2,
                Accion2S2 = accion2S2,
                Accion3S2 = accion3S2,
                Accion4S2 = accion4S2,
                #endregion

                #region 3eraS
                Hallaz1S3 = hallaz1S3,
                Hallaz2S3 = hallaz2S3,
                Hallaz3S3 = hallaz3S3,
                Hallaz4S3 = hallaz4S3,
                Fecha1S3 = Fecha1S3,
                Fecha2S3 = Fecha2S3,
                Fecha3S3 = Fecha3S3,
                Fecha4S3 = Fecha4S3,
                Accion1S3 = accion1S3,
                Accion2S3 = accion2S3,
                Accion3S3 = accion3S3,
                Accion4S3 = accion4S3,
                #endregion

                #region 4taS
                Hallaz1S4 = hallaz1S4,
                Hallaz2S4 = hallaz2S4,
                Hallaz3S4 = hallaz3S4,
                Hallaz4S4 = hallaz4S4,
                Fecha1S4 = Fecha1S4,
                Fecha2S4 = Fecha2S4,
                Fecha3S4 = Fecha3S4,
                Fecha4S4 = Fecha4S4,
                Accion1S4 = accion1S4,
                Accion2S4 = accion2S4,
                Accion3S4 = accion3S4,
                Accion4S4 = accion4S4,
                #endregion

                #region 5taS
                Hallaz1S5 = hallaz1S5,
                Hallaz2S5 = hallaz2S5,
                Hallaz3S5 = hallaz3S5,
                Hallaz4S5 = hallaz4S5,
                Fecha1S5 = Fecha1S5,
                Fecha2S5 = Fecha2S5,
                Fecha3S5 = Fecha3S5,
                Fecha4S5 = Fecha4S5,
                Accion1S5 = accion1S5,
                Accion2S5 = accion2S5,
                Accion3S5 = accion3S5,
                Accion4S5 = accion4S5,
                #endregion
            };

            string nHall = AppGlobals.hallazCont;
            string cal = AppGlobals.resulArea;

            await firebaseHelper.AddHallazOO(nHall, cal, hallazOO);

            this.IsRefreshing = true;

            await Task.Delay(100);

            LoadData();

            this.IsRefreshing = false;

            await App.Current.MainPage.Navigation.PushAsync(new AccesoAuditorias());
        }

        private async Task LoadData()
        {
            this.ListViewSource = await firebaseHelper.GetAllHallaz();
        }

        #endregion

        #region Constructors

        public HallazgosOOViewModel()
        {
            var loginViewModel = App.Current.MainPage.BindingContext as LoginViewModel;

            LoadData();
        }

        #endregion
    }
}
