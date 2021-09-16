using DemonContracts;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;

namespace DemonGrpcClient
{
    public class UserInfoServiceClient
    {
        private static volatile UserInfoServiceClient instance;
        private static readonly object locker = new object();
        private static string serviceUrl;
        private static IUserInfoService _client;

        /// <summary>
        /// TODO... init service
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static UserInfoServiceClient getInstance(string url = "")
        {
            lock (locker)
            {
                if (!string.IsNullOrEmpty(url))
                {
                    serviceUrl = url;
                }
                if (_client == null)
                {
                    var grpcChannel = GrpcChannel.ForAddress(serviceUrl);
                    _client = grpcChannel.CreateGrpcService<IUserInfoService>();
                }
                if (instance == null)
                {
                    instance = new UserInfoServiceClient();
                }
            }
            return instance;
        }



        /// <summary>
        /// get user info 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UserInfoReply GetUserInfo(UserInfoRequest request)
        {
            var response = _client.GetUserInfo(request);
            return response.Result;
        }
    }
}
