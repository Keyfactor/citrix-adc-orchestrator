// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemcollectionparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemcollectionparam : base_resource
  {
    private string communitynameField = (string) null;
    private string loglevelField = (string) null;
    private string datapathField = (string) null;

    public string communityname
    {
      get => this.communitynameField;
      set => this.communitynameField = value;
    }

    public string loglevel
    {
      get => this.loglevelField;
      set => this.loglevelField = value;
    }

    public string datapath
    {
      get => this.datapathField;
      set => this.datapathField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemcollectionparam[] systemcollectionparamArray = new systemcollectionparam[1];
      systemcollectionparam.systemcollectionparam_response systemcollectionparamResponse = new systemcollectionparam.systemcollectionparam_response();
      systemcollectionparam.systemcollectionparam_response resource = (systemcollectionparam.systemcollectionparam_response) service.get_payload_formatter().string_to_resource(systemcollectionparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemcollectionparamArray[0] = resource.systemcollectionparam;
      return (base_resource[]) systemcollectionparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      systemcollectionparam resource)
    {
      return new systemcollectionparam()
      {
        communityname = resource.communityname,
        loglevel = resource.loglevel,
        datapath = resource.datapath
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      systemcollectionparam resource,
      string[] args)
    {
      return new systemcollectionparam().unset_resource(client, args);
    }

    public static systemcollectionparam get(nitro_service service) => ((systemcollectionparam[]) new systemcollectionparam().get_resources(service, (options) null))[0];

    public static systemcollectionparam get(
      nitro_service service,
      options option)
    {
      return ((systemcollectionparam[]) new systemcollectionparam().get_resources(service, option))[0];
    }

    private class systemcollectionparam_response : base_response
    {
      public systemcollectionparam systemcollectionparam = (systemcollectionparam) null;
    }
  }
}
