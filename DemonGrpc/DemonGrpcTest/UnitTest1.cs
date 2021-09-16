using NUnit.Framework;
using DemonGrpcClient;
using DemonContracts;

namespace DemonGrpcTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        UserInfoServiceClient client = UserInfoServiceClient.getInstance("https://localhost:5001");

        [Test]
        public void Test1()
        {
            UserInfoReply userInfoReply = client.GetUserInfo(new UserInfoRequest() { Name = "aaa" });
            UserInfoReply userInfoReply2 = client.GetUserInfo(new UserInfoRequest() { Name = "aaa" });
            Assert.Pass();
        }
    }
}