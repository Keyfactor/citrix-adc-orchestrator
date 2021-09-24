// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.sc.scparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.sc
{
  public class scparameter : base_resource
  {
    private long? sessionlifeField = new long?();
    private string vsrField = (string) null;

    public long? sessionlife
    {
      get => this.sessionlifeField;
      set => this.sessionlifeField = value;
    }

    public string vsr
    {
      get => this.vsrField;
      set => this.vsrField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      scparameter[] scparameterArray = new scparameter[1];
      scparameter.scparameter_response scparameterResponse = new scparameter.scparameter_response();
      scparameter.scparameter_response resource = (scparameter.scparameter_response) service.get_payload_formatter().string_to_resource(scparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      scparameterArray[0] = resource.scparameter;
      return (base_resource[]) scparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, scparameter resource) => new scparameter()
    {
      sessionlife = resource.sessionlife,
      vsr = resource.vsr
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      scparameter resource,
      string[] args)
    {
      return new scparameter().unset_resource(client, args);
    }

    public static scparameter get(nitro_service service) => ((scparameter[]) new scparameter().get_resources(service, (options) null))[0];

    public static scparameter get(nitro_service service, options option) => ((scparameter[]) new scparameter().get_resources(service, option))[0];

    private class scparameter_response : base_response
    {
      public scparameter scparameter = (scparameter) null;
    }
  }
}
