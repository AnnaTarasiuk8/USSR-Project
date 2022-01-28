using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Gurskaia_Tarasiuk_Final.Controllers
{
    public class ValuesController : ApiController
    {
        DebtSuicideEntities myCollections = new DebtSuicideEntities();

        // GET api/<controller>
        [Route("api/values/query1")]
        [HttpGet]
        public IHttpActionResult Get1()
        {
            //var Collection1 = from(((((DebtPerYear
            //INNER JOIN Year ON[DebtPerYear].year_id = Year.id)
            //INNER JOIN NationalDebt ON[NationalDebt].id = [DebtPerYear].national_debt_id)
            //INNER JOIN Country ON[NationalDebt].country_id = [Country].id)
            //INNER JOIN Suicide ON[Suicide].country_id = [Country].id)
            //INNER JOIN Age ON[Suicide].age_id = [Age].id);

            Console.WriteLine($"INNER FUNC!");
            var Collection1 = from oneDebtPerYear in myCollections.DebtPerYears
                              join oneYear in myCollections.Years on oneDebtPerYear.year_id equals oneYear.id
                              join oneNationalDebt in myCollections.NationalDebts on oneDebtPerYear.national_debt_id equals oneNationalDebt.id
                              join oneCountry in myCollections.Countries on oneNationalDebt.country_id equals oneCountry.id
                              join oneSuicide in myCollections.Suicides on oneCountry.id equals oneSuicide.country_id
                              join oneAge in myCollections.Ages on oneSuicide.age_id equals oneAge.id
                              select new
                              {
                                  //oneCountry.name,
                                  
                                  oneDebtPerYear.debt,
                                  oneDebtPerYear.Year.year1
                                  //oneDebtPerYear.Year.Suicides
                                  //
                                  //oneNationalDebt.DebtPerYears
                                  //oneSuicide.suicide_count,
                                  //oneSuicide.population,
                                  //oneAge.period
                              };
            //foreach (var obj in Collection1)
            //{
            //    Console.WriteLine(
            //        $"The cat \"{obj.Country}\" : \"{obj.DebtPerYear}\".");
            //}
            //return Json("TESTOUT");
            return Json(Collection1);
        }
    }
}
