using System.Net;

namespace BlazorPeliculas.Client.Repositorios
{
    public class HttpResponseWrapper<T>
    {
        public bool Error { get; set; }
        public T? Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Response = response;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

        public async Task<string?> ObtenerMensajeError()
        {
            if (!Error) 
            {
                return null;
            }

            var codigoStatus = HttpResponseMessage.StatusCode;

            if (codigoStatus == HttpStatusCode.NotFound)
            {
                return "Recurso no encontrado";
            }
            else if (codigoStatus == HttpStatusCode.BadRequest)
            {
                return await HttpResponseMessage.Content.ReadAsStringAsync();
            }
            else if (codigoStatus == HttpStatusCode.Unauthorized)
            {
                return "Tienes que loguearte para hacer esto";
            }
            else if (codigoStatus == HttpStatusCode.Forbidden)
            {
                return "No tienes permisos para hacer esto";
            }
            else 
            {
                return "Ha ocurrido un error inesperado";
            }
        }
    }
}
