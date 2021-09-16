using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf.Grpc;


namespace DemonContracts
{
    [DataContract]
   public class UserInfoRequest
    {
        [DataMember(Order =1)]
        public string Name { get; set; }

    }
}
