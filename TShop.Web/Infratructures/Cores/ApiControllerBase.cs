using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TShop.Model.Models;
using TShop.Service;

namespace TShop.Web.Infratructures.Cores
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;

        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }

        protected HttpResponseMessage CreateHttpReponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage responseMessage = null;
            try
            {
                responseMessage = function.Invoke();
            }
            catch (DbEntityValidationException ex)
            {
                LogError(ex);
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine("Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation erros.");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine("Properties : \"{ve.PropertyName}\", Error \"{ve.ErrorMessage}\"");
                    }
                }
            }
            catch (DbUpdateException dex)
            {
                LogError(dex);
                responseMessage = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dex.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                responseMessage = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return responseMessage;
        }

        public void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.ErrorMessgae = ex.Message;
                error.CreateDate = DateTime.Now;
                error.StackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch
            {
            }
        }
    }
}