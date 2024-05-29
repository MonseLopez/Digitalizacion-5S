using CommunityToolkit.Mvvm.Input;
using Digitalizacion5S.Model;
using Digitalizacion5S.View;
using Firebase.Auth;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace Digitalizacion5S.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {

        #region Attributes
        private string email;
        private string password;
        private string nombreAuditor;

        private bool isRunning;
        private bool isEnabled;
        private bool isVisible;
        #endregion

        #region Properties
        public String EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunningTxt
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsEnabledTxt
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        public bool IsVisibleTxt
        {
            get { return this.isVisible; }
            set { SetValue(ref this.isVisible, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(LoginMethod);
            }
        }
        #endregion

        #region Methods
        private async void LoginMethod()
        {
            /*
            if (string.IsNullOrEmpty(this.email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Debes ingresar el email", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Debes ingresar la contraseña", "Aceptar");
                return;
            }

            string WebApiKey = "AIzaSyBCH5m3vfvqOZg9KmRDbDBpmM9YORM-5ug";

            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebApiKey));

            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(EmailTxt.ToString(), PasswordTxt.ToString());
                var content = await auth.GetFreshAuthAsync();
                var user = auth.User;
                var serializedContent = JsonConvert.SerializeObject(content);
                Preferences.Set("MyFirebaseRefreshToken", serializedContent);

                if (user != null)
                {
                    string uid = user.LocalId;

                    AppGlobals.UID = uid;

                    var auditorViewModel = new AuditorViewModel();
                    var (auditor, areaAudi1, areaAudi2, areaAudi3, areaAudi4) = await auditorViewModel.GetAuditorDetailsWithAreas(uid);

                    
                    if (auditor != null)
                    {
                        AppGlobals.nombreAudi = auditor.Nombre;
                        AppGlobals.areaResp1 = auditor.Resp1;

                        if (areaAudi1 != null)
                        {
                            AppGlobals.Audi1_Area = auditor.Audi1;
                            AppGlobals.Audi1_Formato = areaAudi1.Formato;
                            AppGlobals.Audi1_Geren = areaAudi1.Geren;
                            AppGlobals.Audi1_Nombre = areaAudi1.Nombre;
                            AppGlobals.Audi1_Resp = areaAudi1.Resp;
                            AppGlobals.Audi1_Cal = areaAudi1.Cal;
                            AppGlobals.Audi1_NumHaz = areaAudi1.Hallaz;
                        }

                        if (areaAudi2 != null)
                        {
                            AppGlobals.Audi2_Area = auditor.Audi2;
                            AppGlobals.Audi2_Formato = areaAudi2.Formato;
                            AppGlobals.Audi2_Geren = areaAudi2.Geren;
                            AppGlobals.Audi2_Nombre = areaAudi2.Nombre;
                            AppGlobals.Audi2_Resp = areaAudi2.Resp;
                            AppGlobals.Audi2_Cal = areaAudi2.Cal;
                            AppGlobals.Audi2_NumHaz = areaAudi2.Hallaz;
                        }

                        if (areaAudi3 != null)
                        {
                            AppGlobals.Audi3_Area = auditor.Audi3;
                            AppGlobals.Audi3_Formato = areaAudi3.Formato;
                            AppGlobals.Audi3_Geren = areaAudi3.Geren;
                            AppGlobals.Audi3_Nombre = areaAudi3.Nombre;
                            AppGlobals.Audi3_Resp = areaAudi3.Resp;
                            AppGlobals.Audi3_Cal = areaAudi3.Cal;
                            AppGlobals.Audi3_NumHaz = areaAudi3.Hallaz;
                        }

                        if (areaAudi4 != null)
                        {
                            AppGlobals.Audi4_Area = auditor.Audi4;
                            AppGlobals.Audi4_Formato = areaAudi4.Formato;
                            AppGlobals.Audi4_Geren = areaAudi4.Geren;
                            AppGlobals.Audi4_Nombre = areaAudi4.Nombre;
                            AppGlobals.Audi4_Resp = areaAudi4.Resp;
                            AppGlobals.Audi4_Cal = areaAudi4.Cal;
                            AppGlobals.Audi4_NumHaz = areaAudi4.Hallaz;
                        }
                    }
                }

                await Application.Current.MainPage.Navigation.PushAsync(new MainPage());

            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Email o contraseña incorrectas", "Aceptar");
            }

            this.IsVisibleTxt = true;
            this.IsRunningTxt = true;
            this.IsEnabledTxt = false;

            await Task.Delay(20);

            */
            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsEnabledTxt = true;
        }
        #endregion
    }
}
