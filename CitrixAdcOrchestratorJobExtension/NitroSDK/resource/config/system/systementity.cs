// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systementity
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systementity : base_resource
  {
    private string typeField = (string) null;
    private string datasourceField = (string) null;
    private int? coreField = new int?();
    private string responseField = (string) null;

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string datasource
    {
      get => this.datasourceField;
      set => this.datasourceField = value;
    }

    public int? core
    {
      get => this.coreField;
      set => this.coreField = value;
    }

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systementity[] systementityArray = new systementity[1];
      systementity.systementity_response systementityResponse = new systementity.systementity_response();
      systementity.systementity_response resource = (systementity.systementity_response) service.get_payload_formatter().string_to_resource(systementityResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systementityArray[0] = resource.systementity;
      return (base_resource[]) systementityArray;
    }

    internal override string get_object_name() => (string) null;

    public static systementity get(nitro_service service, systementity obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (systementity) obj.get_resource(service, option);
    }

    public static systementity[] get(nitro_service service, systementity_args args)
    {
      systementity systementity = new systementity();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systementity[]) systementity.get_resources(service, option);
    }

    private class systementity_response : base_response
    {
      public systementity systementity = (systementity) null;
    }
  }
}
