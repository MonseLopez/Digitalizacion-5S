using Digitalizacion5S.Model;
using Digitalizacion5S.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace Digitalizacion5S.ViewModel
{
    public class AuditorViewModel
    {
        private FirebaseHelper firebaseHelper;

        public AuditorViewModel()
        {
            firebaseHelper = new FirebaseHelper("https://digitalizacion5s-default-rtdb.firebaseio.com/");
        }

        public async Task<(AuditoresModel Auditor, AreasModel AreaAudi1, AreasModel AreaAudi2, AreasModel AreaAudi3, AreasModel AreaAudi4)> GetAuditorDetailsWithAreas(string uid)
        {
            var auditor = await firebaseHelper.GetAuditorByUid(uid);

            if (auditor != null)
            {
                string audi1Value = auditor.Audi1;
                string audi2Value = auditor.Audi2;
                string audi3Value = auditor.Audi3;
                string audi4Value = auditor.Audi4;

                var areaAudi1 = await firebaseHelper.GetAreaById(audi1Value);
                var areaAudi2 = await firebaseHelper.GetAreaById(audi2Value);
                var areaAudi3 = await firebaseHelper.GetAreaById(audi3Value);
                var areaAudi4 = await firebaseHelper.GetAreaById(audi4Value);

                return (auditor, areaAudi1, areaAudi2, areaAudi3, areaAudi4);
            }
            else
            {
                return (null, null, null, null, null);
            }
        }
    }
}
