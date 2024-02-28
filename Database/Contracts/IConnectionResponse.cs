using System;

namespace Database.Interface
{
    public interface IConnectionResponse
    {
        DateTime DateTime { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
        object Data { get; set; }
    }
}
