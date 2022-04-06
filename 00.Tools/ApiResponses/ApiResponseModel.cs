using _00.Tools.Exceptions;
using System.Net;

namespace _00.Tools.ApiResponses
{
    public class ApiResponseModel<T> where T : class
    {
        public T Data { get; set; }
        public Error Error { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
