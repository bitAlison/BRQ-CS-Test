using System;
using Database.Interface;

namespace Database.Model
{
    public class ConnectionRequest : IConnectionRequest
    {

        public virtual string Server { get; set; }
        public virtual string Data__Source { get; set; }
        public virtual string Database { get; set; }
        public virtual string Failover__Partner { get; set; }
        public virtual string Initial__Catalog { get; set; }
        public virtual string AttachDbFilename { get; set; }
        public virtual string User__ID { get; set; }
        public virtual string Password { get; set; }
        public virtual bool Integrated__Security { get; set; }
        public virtual bool Trusted_Connection { get; set; }
        public virtual bool User__Instance { get; set; }
        public virtual bool Asynchronous__Processing { get; set; }
        public virtual bool MultipleActiveResultSets { get; set; }
        public virtual bool Column__Encryption__Setting { get; set; }
        public virtual int Packet__Size { get; set; }
        public virtual Uri Enclave__Attestation__Url { get; set; }
    }
}
