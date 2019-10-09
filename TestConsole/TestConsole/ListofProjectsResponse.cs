using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class ListofProjectsResponse
    {
        public class Projects : BaseViewModel
        {
            public int Count { get; set; }
            public Value[] Value { get; set; }
        }

        public class Value
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
            public string State { get; set; }
        }

    }

    public class BaseViewModel
    {
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
