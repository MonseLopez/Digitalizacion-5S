using Digitalizacion5S.Model;
using Digitalizacion5S.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Digitalizacion5S.ViewModel
{

    public class GetHallazViewModel
    {
        private FirebaseHelper firebaseHelper;

        public GetHallazViewModel()
        {
            firebaseHelper = new FirebaseHelper("https://digitalizacion5s-default-rtdb.firebaseio.com/");
        }

        public async Task<(AreasModel AreaAudi1, AreasModel AreaAudi2, AreasModel AreaAudi3, AreasModel AreaAudi4, HallazgosModel Hallaz1, HallazgosModel Hallaz2, HallazgosModel Hallaz3, HallazgosModel Hallaz4)>GetHallazDetailsWithAreas(string id1, string id2, string id3, string id4)
        {
            var areaAudi1 = await firebaseHelper.GetAreaById(id1);
            var areaAudi2 = await firebaseHelper.GetAreaById(id2);
            var areaAudi3 = await firebaseHelper.GetAreaById(id3);
            var areaAudi4 = await firebaseHelper.GetAreaById(id4);

            if (areaAudi1 != null || areaAudi2 != null || areaAudi3 != null || areaAudi4 != null)
            {
                var hallaz1 = await firebaseHelper.GetHallazById(id1);
                var hallaz2 = await firebaseHelper.GetHallazById(id2);
                var hallaz3 = await firebaseHelper.GetHallazById(id3);
                var hallaz4 = await firebaseHelper.GetHallazById(id4);

                return (areaAudi1, areaAudi2, areaAudi3, areaAudi4, hallaz1, hallaz2, hallaz3, hallaz4);
            }
            else
            {
                return (null, null, null, null, null, null, null, null);
            }    
        }
    }
}
