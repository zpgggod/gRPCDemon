using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemonContracts;
using ProtoBuf.Grpc;

namespace DemonGrpcService
{
    public class UserInfoService : IUserInfoService
    {
        public Task<UserInfoReply> GetUserInfo(UserInfoRequest request, CallContext context = default)
        {
            return Task.FromResult(new UserInfoReply()
            {
                Message = "OK"
            }); ;
        }
    }
}
