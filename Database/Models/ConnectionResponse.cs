using System;
using Database.Interface;

namespace Database
{
    public class ConnectionResponse : IConnectionResponse
    {
        public DateTime DateTime { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
