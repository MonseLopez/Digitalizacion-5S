using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace Digitalizacion5S.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Auditorias : ContentPage
    {
        public Auditorias()
        {
            InitializeComponent();

            MostrarResul(AppGlobals.Audi1_Nombre, AppGlobals.cal1, AppGlobals.cant1);
            MostrarResul(AppGlobals.Audi2_Nombre, AppGlobals.cal2, AppGlobals.cant2);
            MostrarResul(AppGlobals.Audi3_Nombre, AppGlobals.cal3, AppGlobals.cant3);
            MostrarResul(AppGlobals.Audi4_Nombre, AppGlobals.cal4, AppGlobals.cant4);
        }

        private void MostrarResul(string nombre, string calificacion, string hallazgos)
        {
            /*
            if (!string.IsNullOrEmpty(nombre))
            {

                var stacklayaout1 = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal

                    var frame = new Frame()
                    {

                    }
                };

                var frame = new Frame
                {
                    Padding = new Thickness(0, 20, 0, 20),
                    Margin = new Thickness(20, 25, 20, 0),
                    BackgroundColor = Color.FromHex("#75F94D"),
                    HasShadow = true

                };

                var stackLayout = new StackLayout();

                // Título (nombre del área desde el ViewModel)
                stackLayout.Children.Add(new Label
                {
                    Text = nombre,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 20,
                    Padding = new Thickness(0, 0, 0, 20)
                });

                stackLayout.Children.Add(new Frame
                {
                    
                });

                // Calificación (calificación desde el ViewModel)
                stackLayout.Children.Add(new Label
                {
                    Text = "Calificación",
                    TextColor = Color.Black,
                    FontAttributes = FontAttributes.Bold
                });

                // Hallazgos (cantidad de hallazgos desde el ViewModel)
                stackLayout.Children.Add(new Label
                {
                    Text = $"Hallazgos: {(hallazgos.ContainsKey("AreaHallaz1") ? hallazgos["AreaHallaz1"].CantidadHallazgos.ToString() : "N/A")}",
                    TextColor = Color.Black,
                    FontAttributes = FontAttributes.Bold
                });

                // Botón "Ver más"
                stackLayout.Children.Add(new Button
                {
                    Text = "Ver más",
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    BackgroundColor = Color.Black,
                    TextColor = Color.FromHex("#FFC803"),
                    FontAttributes = FontAttributes.Bold
                });

                frame.Content = stackLayout;

                // Agregar el marco a tu diseño (por ejemplo, a un StackLayout)
                // myStackLayout.Children.Add(frame);
            }
            */
        }  
    }
}