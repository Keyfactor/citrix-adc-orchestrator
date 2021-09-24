// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.Base.loginchallengeresponse
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.Base
{
  internal class loginchallengeresponse : base_resource
  {
    public string response;

    public loginchallengeresponse(string response) => this.response = response;

    internal override string get_object_name() => (string) null;

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      return (base_resource[]) null;
    }
  }
}
