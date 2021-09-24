// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.Base.login
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.Base
{
  public class login : base_resource
  {
    public string username;
    public string password;
    public string ipaddress;
    public string sessionid;
    public uint? timeout;

    public login(string username, string password)
    {
      this.username = username;
      this.password = password;
    }

    public login(string username, string password, uint? timeout)
    {
      this.username = username;
      this.password = password;
      if (!timeout.HasValue)
        return;
      this.timeout = timeout;
    }

    internal override string get_object_name() => (string) null;

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      return (base_resource[]) null;
    }
  }
}
