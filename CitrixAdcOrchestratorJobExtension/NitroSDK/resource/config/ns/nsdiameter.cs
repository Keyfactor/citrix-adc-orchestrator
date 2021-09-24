// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsdiameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsdiameter : base_resource
  {
    private string identityField = (string) null;
    private string realmField = (string) null;
    private string serverclosepropagationField = (string) null;

    public string identity
    {
      get => this.identityField;
      set => this.identityField = value;
    }

    public string realm
    {
      get => this.realmField;
      set => this.realmField = value;
    }

    public string serverclosepropagation
    {
      get => this.serverclosepropagationField;
      set => this.serverclosepropagationField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsdiameter[] nsdiameterArray = new nsdiameter[1];
      nsdiameter.nsdiameter_response nsdiameterResponse = new nsdiameter.nsdiameter_response();
      nsdiameter.nsdiameter_response resource = (nsdiameter.nsdiameter_response) service.get_payload_formatter().string_to_resource(nsdiameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsdiameterArray[0] = resource.nsdiameter;
      return (base_resource[]) nsdiameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nsdiameter resource) => new nsdiameter()
    {
      identity = resource.identity,
      realm = resource.realm,
      serverclosepropagation = resource.serverclosepropagation
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nsdiameter resource,
      string[] args)
    {
      return new nsdiameter().unset_resource(client, args);
    }

    public static nsdiameter get(nitro_service service) => ((nsdiameter[]) new nsdiameter().get_resources(service, (options) null))[0];

    public static nsdiameter get(nitro_service service, options option) => ((nsdiameter[]) new nsdiameter().get_resources(service, option))[0];

    private class nsdiameter_response : base_response
    {
      public nsdiameter nsdiameter = (nsdiameter) null;
    }

    public static class serverclosepropagationEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
