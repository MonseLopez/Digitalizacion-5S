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
    public class HallazgosViewModel : BaseViewModel
    { 

        FirebaseHelper firebaseHelper = new FirebaseHelper();

        #region Attributes
        private string Id;
        public string hallaz1;
        public string hallaz2;
        public string hallaz3;
        public string hallaz4;
        public string hallaz5;
        public DateTime fecha1;
        public DateTime fecha2;
        public DateTime fecha3;
        public DateTime fecha4;
        public DateTime fecha5;
        public string accion1;
        public string accion2;
        public string accion3;
        public string accion4;
        public string accion5;
        public string numHallaz;
        public string cal;

        public bool isRefreshing = false;
        public object listViewSource;
        #endregion

        #region Properties
        public string IDTxt
        {
            get { return this.Id; }
            set { SetValue(ref this.Id, value); }
        }

        public string Hallaz1Txt
        {
            get { return this.hallaz1; }
            set { SetValue(ref this.hallaz1, value); }
        }

        public string Hallaz2Txt
        {
            get { return this.hallaz2; }
            set { SetValue(ref this.hallaz2, value); }
        }

        public string Hallaz3Txt
        {
            get { return this.hallaz3; }
            set { SetValue(ref this.hallaz3, value); }
        }

        public string Hallaz4Txt
        {
            get { return this.hallaz4; }
            set { SetValue(ref this.hallaz4, value); }
        }

        public string Hallaz5Txt
        {
            get { return this.hallaz5; }
            set { SetValue(ref this.hallaz5, value); }
        }

        public DateTime Fecha1
        {
            get { return this.fecha1; }
            set { SetValue(ref this.fecha1, value);}
        }

        public DateTime Fecha2
        {
            get { return this.fecha2; }
            set { SetValue(ref this.fecha2, value); }
        }

        public DateTime Fecha3
        {
            get { return this.fecha3; }
            set { SetValue(ref this.fecha3, value); }
        }

        public DateTime Fecha4
        {
            get { return this.fecha4; }
            set { SetValue(ref this.fecha4, value); }
        }

        public DateTime Fecha5
        {
            get { return this.fecha5; }
            set { SetValue(ref this.fecha5, value); }
        }

        public string Accion1Txt
        {
            get { return this.accion1; }
            set { SetValue(ref this.accion1, value); }
        }

        public string Accion2Txt
        {
            get { return this.accion2; }
            set { SetValue(ref this.accion2, value); }
        }

        public string Accion3Txt
        {
            get { return this.accion3; }
            set { SetValue(ref this.accion3, value); }
        }

        public string Accion4Txt
        {
            get { return this.accion4; }
            set { SetValue(ref this.accion4, value); }
        }

        public string Accion5Txt
        {
            get { return this.accion5; }
            set { SetValue(ref this.accion5, value); }
        }

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

        #region Conversion_Fecha

        public string fecha1Txt => fecha1.ToString("yyyy-MM-dd");
        public string fecha2Txt => fecha2.ToString("yyyy-MM-dd");
        public string fecha3Txt => fecha3.ToString("yyyy-MM-dd");
        public string fecha4Txt => fecha4.ToString("yyyy-MM-dd");
        public string fecha5Txt => fecha5.ToString("yyyy-MM-dd");

        #endregion

        #region Commands
        public ICommand InsertCommand
        {
            get
            {
                return new RelayCommand(InsertMethod);
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                return new RelayCommand(UpdateMethod);
            }
        }
        #endregion

        #region Methods
        private async void InsertMethod()
        {
            var hallaz = new HallazgosModel
            {
                Hallaz1 = hallaz1,
                Hallaz2 = hallaz2,
                Hallaz3 = hallaz3,
                Hallaz4 = hallaz4,
                Hallaz5 = hallaz5,
                Fecha1 = fecha1Txt,
                Fecha2 = fecha2Txt,
                Fecha3 = fecha3Txt,
                Fecha4 = fecha4Txt,
                Fecha5 = fecha5Txt,
                Accion1 = accion1,
                Accion2 = accion2,
                Accion3 = accion3,
                Accion4 = accion4,
                Accion5 = accion5,
            };

            string nHall = AppGlobals.hallazCont;
            string cal = AppGlobals.resulArea;

            await firebaseHelper.AddHallaz(nHall, cal, hallaz);

            this.IsRefreshing = true;

            await Task.Delay(100);

            LoadData();

            this.IsRefreshing = false;

            await App.Current.MainPage.Navigation.PushAsync(new AccesoAuditorias());
        }

        private async void UpdateMethod()
        {
            var hallaz = new HallazgosModel
            {
                ID = IDTxt,
                Hallaz1 = Hallaz1Txt,
                Hallaz2 = Hallaz2Txt,
                Hallaz3 = Hallaz3Txt,
                Hallaz4 = Hallaz4Txt,
                Hallaz5 = Hallaz5Txt,
                Fecha1 = fecha1Txt,
                Fecha2 = fecha2Txt,
                Fecha3 = fecha3Txt,
                Fecha4 = fecha4Txt,
                Fecha5 = fecha5Txt,
                Accion1 = Accion1Txt,
                Accion2 = Accion2Txt,
                Accion3 = Accion3Txt,
                Accion4 = Accion4Txt,
                Accion5 = Accion5Txt,
            };

            await firebaseHelper.UpdateHallaz(hallaz);

            await App.Current.MainPage.DisplayAlert("AUDITORIA", "Auditoria cargada correctamente", "Ok");
            await App.Current.MainPage.Navigation.PushAsync(new AccesoAuditorias());
        }

        private async Task LoadData()
        {
            this.ListViewSource = await firebaseHelper.GetAllHallaz();
        }
        #endregion

        #region Constructor
        public HallazgosViewModel()
        {
            var loginViewModel = App.Current.MainPage.BindingContext as LoginViewModel;

            LoadData();
        }
        #endregion
    }
}
