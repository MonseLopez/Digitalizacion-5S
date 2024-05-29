using CommunityToolkit.Mvvm.Input;
using Digitalizacion5S.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Digitalizacion5S.ViewModel
{
    public class ConsultaViewModel : BaseViewModel
    {
        #region Commands

        public ICommand ConsultaPropCommand
        {
            get
            {
                return new RelayCommand(ConsultaPropMethod);
            }
        }

        public ICommand ConsultaCommand
        {
            get
            {
                return new RelayCommand(ConsultaMethod);
            }
        }


        #endregion

        #region Methods
        private void ConsultaPropMethod()
        {

        }

        private async void ConsultaMethod()
        {
            var nombreAreas = new Dictionary<string, string>();
            var hallazgos = new Dictionary<string, HallazgosModel>();

            string Id1 = AppGlobals.Audi1_Area;
            string Id2 = AppGlobals.Audi2_Area;
            string Id3 = AppGlobals.Audi3_Area;
            string Id4 = AppGlobals.Audi4_Area;

            var getHallazViewModel = new GetHallazViewModel();

            var (areaAudi1, areaAudi2, areaAudi3, areaAudi4, hallaz1, hallaz2, hallaz3, hallaz4) = await getHallazViewModel.GetHallazDetailsWithAreas(Id1, Id2, Id3, Id4);

            //if (areaAudi1 != null)
            //{
            //    nombreAreas.Add("Area1", areaAudi1.Nombre);
            //}

            //if (areaAudi2 != null)
            //{
            //    nombreAreas.Add("Area2", areaAudi2.Nombre);
            //}

            //if (areaAudi3 != null)
            //{
            //    nombreAreas.Add("Area3", areaAudi3.Nombre);
            //}

            //if (areaAudi4 != null)
            //{
            //    nombreAreas.Add("Area4", areaAudi4.Nombre);
            //}

            if (hallaz1 != null)
            {
                hallazgos.Add("AreaHallaz1", hallaz1);
                AppGlobals.cal1 = hallaz1.Cal;
                AppGlobals.cant1 = hallaz1.NumHallaz;
            }

            if (hallaz2 != null)
            {
                hallazgos.Add("AreaHallaz2", hallaz2);
                AppGlobals.cal2 = hallaz2.Cal;
                AppGlobals.cant2 = hallaz2.NumHallaz;
            }

            if (hallaz3 != null)
            {
                hallazgos.Add("AreaHallaz3", hallaz3);
                AppGlobals.cal3 = hallaz3.Cal;
                AppGlobals.cant3 = hallaz3.NumHallaz;
            }

            if (hallaz4 != null)
            {
                hallazgos.Add("AreaHallaz4", hallaz4);
                AppGlobals.cal4 = hallaz4.Cal;
                AppGlobals.cant4 = hallaz4.NumHallaz;
            }
        }

        #endregion
    }
}
