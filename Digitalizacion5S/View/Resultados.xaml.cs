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
    public partial class Resultados : ContentPage
    {
        public Resultados()
        {
            InitializeComponent();

            //var button = new Button
            //{
            //    Text = "Haz clic en mí",
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    HorizontalOptions = LayoutOptions.CenterAndExpand
            //};

            //var stackLayout = new StackLayout
            //{
            //    Children = { button }
            //};

            //var frame = new Frame
            //{
            //    Content = stackLayout,
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalOptions = LayoutOptions.FillAndExpand
            //};

            //// Asegúrate de agregar el frame a la vista principal de tu página
            //this.Content = frame;

        }
    }
}