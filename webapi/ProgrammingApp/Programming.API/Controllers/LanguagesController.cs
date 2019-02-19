using Programming.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Programming.API.Controllers
{
    public class LanguagesController : ApiController
    {
        LanguagesDAL languageDAL = new LanguagesDAL();
        public IEnumerable<Languages> Get()
        {
            return languageDAL.GetLanguages();
        }
        public Languages Get(int id)
        {
            return languageDAL.GetLanguagesById(id);
        }
        public Languages Post(Languages language)
        {
            return languageDAL.CreateLanguage(language);
        }
        public Languages Put(int id,Languages language)
        {
            return languageDAL.UpdateLanguage(id, language);
        }
        public void Delete(int id)
        {
            languageDAL.DeleteLanguage(id);
        }
    }
}
