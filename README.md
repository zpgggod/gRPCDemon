# gRPCDemon
gRPCDemon first demon
# dev environment
  vs2019 Version 16.9.8 <br/>
  .net5.0
 
 # using package
  protobuf-net.Grpc --create data contract <br/>
  Grpc.AspNetCore<br/>
  protobuf-net.Grpc.AspNetCore --using  services.AddCodeFirstGrpc();<br/>
 
 # note 
 the errors may can be solved by below way<br/>
 1."error starting gRPC call. HttpRequestException: The SSL connection could not.."<br/>
   dotnet dev-certs https --trust<br/>
   ref:https://docs.microsoft.com/zh-cn/aspnet/core/security/enforcing-ssl?view=aspnetcore-2.2&tabs=visual-studio<br/>
 2."One or more errors occurred. (Status(StatusCode="Unimplemented", Detail="Ser"<br/>
  using package  protobuf-net.Grpc.AspNetCore<br/>
  services.AddCodeFirstGrpc();<br/>
