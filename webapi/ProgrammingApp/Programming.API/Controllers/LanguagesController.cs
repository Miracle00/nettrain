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
        public HttpResponseMessage Get()
        {
            var languages = languageDAL.GetLanguages();
            return Request.CreateResponse(HttpStatusCode.OK, languages);
        }
        public HttpResponseMessage Get(int id)
        {
            var language = languageDAL.GetLanguagesById(id);
            if(language==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound,"Kayıt Bulunamadı");
            }
            return Request.CreateResponse(HttpStatusCode.OK, language);
        }
        public HttpResponseMessage Post(Languages language)
        {
            if (ModelState.IsValid)
            {
                var createLanguage = languageDAL.CreateLanguage(language);
                return Request.CreateResponse(HttpStatusCode.Created, createLanguage);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }            
        }
        public HttpResponseMessage Put(int id,Languages language)
        {
            if (languageDAL.IsThereAnyLanguage(id)==false)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Kayıt Bulunamadı");
            }
            else if (ModelState.IsValid==false)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            else
            {
                var putLanguage = languageDAL.UpdateLanguage(id, language);
                return Request.CreateResponse(HttpStatusCode.OK, putLanguage);
            }            
        }
        public HttpResponseMessage Delete(int id)
        {
            if (languageDAL.IsThereAnyLanguage(id) == false)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Kayıt Bulunamadı");
            }
            else
            {
                languageDAL.DeleteLanguage(id);
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
        }
    }
}
