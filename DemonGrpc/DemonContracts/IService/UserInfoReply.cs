using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DemonContracts
{
    [DataContract]
    public class UserInfoReply
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }
    }
}
