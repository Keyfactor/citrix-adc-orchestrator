// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.wi.wipackage
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.wi
{
  public class wipackage : base_resource
  {
    private string jreField = (string) null;
    private string wiField = (string) null;
    private string maxsitesField = (string) null;

    public string jre
    {
      get => this.jreField;
      set => this.jreField = value;
    }

    public string wi
    {
      get => this.wiField;
      set => this.wiField = value;
    }

    public string maxsites
    {
      get => this.maxsitesField;
      set => this.maxsitesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      wipackage[] wipackageArray = new wipackage[1];
      wipackage.wipackage_response wipackageResponse = new wipackage.wipackage_response();
      wipackage.wipackage_response resource = (wipackage.wipackage_response) service.get_payload_formatter().string_to_resource(wipackageResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      wipackageArray[0] = resource.wipackage;
      return (base_resource[]) wipackageArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Install(nitro_service client, wipackage resource) => new wipackage()
    {
      jre = resource.jre,
      wi = resource.wi,
      maxsites = resource.maxsites
    }.perform_operation_byaction(client, nameof (Install));

    public static wipackage get(nitro_service service) => ((wipackage[]) new wipackage().get_resources(service, (options) null))[0];

    public static wipackage get(nitro_service service, options option) => ((wipackage[]) new wipackage().get_resources(service, option))[0];

    private class wipackage_response : base_response
    {
      public wipackage wipackage = (wipackage) null;
    }

    public static class maxsitesEnum
    {
      public const string _3 = "3";
      public const string _25 = "25";
      public const string _50 = "50";
      public const string _100 = "100";
      public const string _200 = "200";
      public const string _500 = "500";
    }
  }
}
