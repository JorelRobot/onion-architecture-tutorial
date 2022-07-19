using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrappers
{
    public class Response<T>
    {
        public bool Succeeded { get; set; }
        public string Messagge { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }

        public Response()
        {

        }

        public Response(T data, string message = null)
        {
            Succeeded = true;
            Messagge = message;
            Data = data;
        }

        public Response(string messagge)
        {
            Succeeded = false;
            Messagge = messagge;
        }
    }
}
