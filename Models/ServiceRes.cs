using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstC_.Models
{
    public class ServiceRes<T>
    {
        public T? Data { get; set; }
        public bool Succes { get; set; } = true;

        public string Message { get; set; } = "All good";
    }
}
