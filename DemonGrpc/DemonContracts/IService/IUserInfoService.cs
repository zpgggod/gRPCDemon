using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf.Grpc;

namespace DemonContracts
{
    [ServiceContract]
    public interface IUserInfoService
    {
        [OperationContract]
        Task<UserInfoReply> GetUserInfo(UserInfoRequest request, CallContext context = default);
    }
}
