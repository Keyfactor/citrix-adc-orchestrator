// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnparameter : base_resource
  {
    private long? memlimitField = new long?();
    private string sessionsyncField = (string) null;
    private long? memlimitactiveField = new long?();
    private long? maxmemlimitField = new long?();

    public long? memlimit
    {
      get => this.memlimitField;
      set => this.memlimitField = value;
    }

    public string sessionsync
    {
      get => this.sessionsyncField;
      set => this.sessionsyncField = value;
    }

    public long? memlimitactive
    {
      get => this.memlimitactiveField;
      private set => this.memlimitactiveField = value;
    }

    public long? maxmemlimit
    {
      get => this.maxmemlimitField;
      private set => this.maxmemlimitField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnparameter[] lsnparameterArray = new lsnparameter[1];
      lsnparameter.lsnparameter_response lsnparameterResponse = new lsnparameter.lsnparameter_response();
      lsnparameter.lsnparameter_response resource = (lsnparameter.lsnparameter_response) service.get_payload_formatter().string_to_resource(lsnparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      lsnparameterArray[0] = resource.lsnparameter;
      return (base_resource[]) lsnparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, lsnparameter resource) => new lsnparameter()
    {
      memlimit = resource.memlimit,
      sessionsync = resource.sessionsync
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      lsnparameter resource,
      string[] args)
    {
      return new lsnparameter().unset_resource(client, args);
    }

    public static lsnparameter get(nitro_service service) => ((lsnparameter[]) new lsnparameter().get_resources(service, (options) null))[0];

    public static lsnparameter get(nitro_service service, options option) => ((lsnparameter[]) new lsnparameter().get_resources(service, option))[0];

    private class lsnparameter_response : base_response
    {
      public lsnparameter lsnparameter = (lsnparameter) null;
    }

    public static class sessionsyncEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
