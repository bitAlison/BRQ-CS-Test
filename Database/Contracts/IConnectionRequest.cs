using System;

namespace Database.Interface
{
    public interface IConnectionRequest
    {
        string Server { get; set; }
        string Data__Source { get; set; }
        string Database { get; set; }
        string Failover__Partner { get; set; }
        string Initial__Catalog { get; set; }
        string AttachDbFilename { get; set; }
        string User__ID { get; set; }
        string Password { get; set; }
        bool Integrated__Security { get; set; }
        bool Trusted_Connection { get; set; }
        bool User__Instance { get; set; }
        bool Asynchronous__Processing { get; set; }
        bool MultipleActiveResultSets { get; set; }
        bool Column__Encryption__Setting { get; set; }
        int Packet__Size { get; set; }
        Uri Enclave__Attestation__Url { get; set; }
    }
}
