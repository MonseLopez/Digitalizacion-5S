using Digitalizacion5S.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalizacion5S.Services
{
    public class FirebaseHelper
    {

        private FirebaseClient firebase;

        private string ClaveArea = AppGlobals.area;

        public FirebaseHelper(string databaseUrl)
        {
            firebase = new FirebaseClient(databaseUrl);
        }

        #region CONSULTA DE HALLAZGOS

        public async Task<HallazgosModel> GetHallazById(string areaId)
        {
            var hallazgo = await firebase
                .Child("Hallazgo")
                .Child(areaId)
                .OnceSingleAsync<HallazgosModel>();
            return hallazgo;
        }

        #endregion

        #region CONSULTA HALLAZ
        public async Task<List<HallazgosModel>> GetAllHallaz()
        {
            return (await firebase
                .Child("Hallazgo")
                .Child(ClaveArea)
                .OnceAsync<HallazgosModel>()).Select(item => new HallazgosModel
                {
                    Hallaz1 = item.Object.Hallaz1,
                    Hallaz2 = item.Object.Hallaz2,
                    Hallaz3 = item.Object.Hallaz3,
                    Hallaz4 = item.Object.Hallaz4,
                    Hallaz5 = item.Object.Hallaz5,
                    ID = item.Object.ID,
                    Fecha1 = item.Object.Fecha1,
                    Fecha2 = item.Object.Fecha2,
                    Fecha3 = item.Object.Fecha3,
                    Fecha4 = item.Object.Fecha4,
                    Fecha5 = item.Object.Fecha5,
                    Accion1 = item.Object.Accion1,
                    Accion2 = item.Object.Accion2,
                    Accion3 = item.Object.Accion3,
                    Accion4 = item.Object.Accion4,
                    Accion5 = item.Object.Accion5,
                }).ToList();
        }
        #endregion

        #region INSERT HALLAZGOS
        public async Task AddHallaz(string numHallaz, string Cal,HallazgosModel hallazgosModel)
        {

        await firebase
            .Child("Hallazgo")
            .Child(ClaveArea)
            .PutAsync(new HallazgosModel()
            {
                //ID = ClaveArea,
                Hallaz1 = hallazgosModel.Hallaz1,
                Hallaz2 = hallazgosModel.Hallaz2,
                Hallaz3 = hallazgosModel.Hallaz3,
                Hallaz4 = hallazgosModel.Hallaz4,
                Hallaz5 = hallazgosModel.Hallaz5,
                Fecha1 = hallazgosModel.Fecha1,
                Fecha2 = hallazgosModel.Fecha2,
                Fecha3 = hallazgosModel.Fecha3,
                Fecha4 = hallazgosModel.Fecha4,
                Fecha5 = hallazgosModel.Fecha5,
                Accion1 = hallazgosModel.Accion1,
                Accion2 = hallazgosModel.Accion2,
                Accion3 = hallazgosModel.Accion3,
                Accion4 = hallazgosModel.Accion4,
                Accion5 = hallazgosModel.Accion5,
                Cal = Cal,
                NumHallaz = numHallaz
            });
        }

        public async Task AddHallazOO(string numHallaz, string Cal, HallazgosOOModel hallazgosOOModel)
        {

            await firebase
                .Child("Hallazgo")
                .Child(ClaveArea)
                .PutAsync(new HallazgosOOModel()
                {
                    //ID = ClaveArea,
                    #region 1eraS
                    Hallaz1S1 = hallazgosOOModel.Hallaz1S1,
                    Hallaz2S1 = hallazgosOOModel.Hallaz2S1,
                    Hallaz3S1 = hallazgosOOModel.Hallaz3S1,
                    Hallaz4S1 = hallazgosOOModel.Hallaz4S1,
                    Fecha1S1 = hallazgosOOModel.Fecha1S1,
                    Fecha2S1 = hallazgosOOModel.Fecha2S1,
                    Fecha3S1 = hallazgosOOModel.Fecha3S1,
                    Fecha4S1 = hallazgosOOModel.Fecha4S1,
                    Accion1S1 = hallazgosOOModel.Accion1S1,
                    Accion2S1 = hallazgosOOModel.Accion2S1,
                    Accion3S1 = hallazgosOOModel.Accion3S1,
                    Accion4S1 = hallazgosOOModel.Accion4S1,
                    #endregion

                    #region 2daS
                    Hallaz1S2 = hallazgosOOModel.Hallaz1S2,
                    Hallaz2S2 = hallazgosOOModel.Hallaz2S2,
                    Hallaz3S2 = hallazgosOOModel.Hallaz3S2,
                    Hallaz4S2 = hallazgosOOModel.Hallaz4S2,
                    Fecha1S2 = hallazgosOOModel.Fecha1S2,
                    Fecha2S2 = hallazgosOOModel.Fecha2S2,
                    Fecha3S2 = hallazgosOOModel.Fecha3S2,
                    Fecha4S2 = hallazgosOOModel.Fecha4S2,
                    Accion1S2 = hallazgosOOModel.Accion1S2,
                    Accion2S2 = hallazgosOOModel.Accion2S2,
                    Accion3S2 = hallazgosOOModel.Accion3S2,
                    Accion4S2 = hallazgosOOModel.Accion4S2,
                    #endregion

                    #region 3eraS
                    Hallaz1S3 = hallazgosOOModel.Hallaz1S3,
                    Hallaz2S3 = hallazgosOOModel.Hallaz2S3,
                    Hallaz3S3 = hallazgosOOModel.Hallaz3S3,
                    Hallaz4S3 = hallazgosOOModel.Hallaz4S3,
                    Fecha1S3 = hallazgosOOModel.Fecha1S3,
                    Fecha2S3 = hallazgosOOModel.Fecha2S3,
                    Fecha3S3 = hallazgosOOModel.Fecha3S3,
                    Fecha4S3 = hallazgosOOModel.Fecha4S3,
                    Accion1S3 = hallazgosOOModel.Accion1S3,
                    Accion2S3 = hallazgosOOModel.Accion2S3,
                    Accion3S3 = hallazgosOOModel.Accion3S3,
                    Accion4S3 = hallazgosOOModel.Accion4S3,
                    #endregion

                    #region 4taS
                    Hallaz1S4 = hallazgosOOModel.Hallaz1S4,
                    Hallaz2S4 = hallazgosOOModel.Hallaz2S4,
                    Hallaz3S4 = hallazgosOOModel.Hallaz3S4,
                    Hallaz4S4 = hallazgosOOModel.Hallaz4S4,
                    Fecha1S4 = hallazgosOOModel.Fecha1S4,
                    Fecha2S4 = hallazgosOOModel.Fecha2S4,
                    Fecha3S4 = hallazgosOOModel.Fecha3S4,
                    Fecha4S4 = hallazgosOOModel.Fecha4S4,
                    Accion1S4 = hallazgosOOModel.Accion1S4,
                    Accion2S4 = hallazgosOOModel.Accion2S4,
                    Accion3S4 = hallazgosOOModel.Accion3S4,
                    Accion4S4 = hallazgosOOModel.Accion4S4,
                    #endregion

                    #region 5taS
                    Hallaz1S5 = hallazgosOOModel.Hallaz1S5,
                    Hallaz2S5 = hallazgosOOModel.Hallaz2S5,
                    Hallaz3S5 = hallazgosOOModel.Hallaz3S5,
                    Hallaz4S5 = hallazgosOOModel.Hallaz4S5,
                    Fecha1S5 = hallazgosOOModel.Fecha1S5,
                    Fecha2S5 = hallazgosOOModel.Fecha2S5,
                    Fecha3S5 = hallazgosOOModel.Fecha3S5,
                    Fecha4S5 = hallazgosOOModel.Fecha4S5,
                    Accion1S5 = hallazgosOOModel.Accion1S5,
                    Accion2S5 = hallazgosOOModel.Accion2S5,
                    Accion3S5 = hallazgosOOModel.Accion3S5,
                    Accion4S5 = hallazgosOOModel.Accion4S5,
                    #endregion
                    Cal = Cal,
                    NumHallaz = numHallaz
                });
        }
        #endregion

        #region Hallazgos
        public async Task UpdateHallaz(HallazgosModel hallazgosModel)
        {
            var toUpdatePerson = (await firebase
               .Child("Persons")
               //.Child(ClaveArea)
               .OnceAsync<HallazgosModel>()).Where(a => a.Object.ID == hallazgosModel.ID).FirstOrDefault();

            await firebase
                .Child("Hallazgo")
                .Child(toUpdatePerson.Key)
                .PutAsync(new HallazgosModel() 
                { 
                    ID = hallazgosModel.ID,
                    Hallaz1 = hallazgosModel.Hallaz1,
                    Hallaz2 = hallazgosModel.Hallaz2,
                    Hallaz3 = hallazgosModel.Hallaz3,
                    Hallaz4 = hallazgosModel.Hallaz4,
                    Hallaz5 = hallazgosModel.Hallaz5,
                    Fecha1 = hallazgosModel.Fecha1,
                    Fecha2 = hallazgosModel.Fecha2,
                    Fecha3 = hallazgosModel.Fecha3,
                    Fecha4 = hallazgosModel.Fecha4,
                    Fecha5 = hallazgosModel.Fecha5,
                    Accion1 = hallazgosModel.Accion1,
                    Accion2 = hallazgosModel.Accion2,
                    Accion3 = hallazgosModel.Accion3,
                    Accion4 = hallazgosModel.Accion4,
                    Accion5 = hallazgosModel.Accion5,
                });
        }
        #endregion

        public async Task<AuditoresModel> GetAuditorByUid(string uid)
        {
            var auditor = await firebase
                .Child("Auditor")
                .Child(uid)
                .OnceSingleAsync<AuditoresModel>();
            return auditor;
        }

        public async Task<bool> IsAuditorExists(string uid)
        {
            var auditor = await GetAuditorByUid(uid);
            return auditor != null;
        }

        public async Task<AreasModel> GetAreaById(string areaId)
        {
            var area = await firebase
                .Child("Areas")
                .Child(areaId)
                .OnceSingleAsync<AreasModel>();
            return area;
        }

        public FirebaseHelper()
        {
            firebase = new FirebaseClient("https://digitalizacion5s-default-rtdb.firebaseio.com/");
        }
    }
}
