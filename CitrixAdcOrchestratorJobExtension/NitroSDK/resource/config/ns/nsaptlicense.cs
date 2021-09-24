// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsaptlicense
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsaptlicense : base_resource
  {
    private string serialnoField = (string) null;
    private string useproxyField = (string) null;
    private string idField = (string) null;
    private string sessionidField = (string) null;
    private string bindtypeField = (string) null;
    private string countavailableField = (string) null;
    private string licensedirField = (string) null;
    private string responseField = (string) null;
    private string counttotalField = (string) null;
    private string nameField = (string) null;
    private string relevanceField = (string) null;
    private string datepurchasedField = (string) null;
    private string datesaField = (string) null;
    private string dateexpField = (string) null;
    private string[] featuresField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string serialno
    {
      get => this.serialnoField;
      set => this.serialnoField = value;
    }

    public string useproxy
    {
      get => this.useproxyField;
      set => this.useproxyField = value;
    }

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string sessionid
    {
      get => this.sessionidField;
      set => this.sessionidField = value;
    }

    public string bindtype
    {
      get => this.bindtypeField;
      set => this.bindtypeField = value;
    }

    public string countavailable
    {
      get => this.countavailableField;
      set => this.countavailableField = value;
    }

    public string licensedir
    {
      get => this.licensedirField;
      set => this.licensedirField = value;
    }

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    public string counttotal
    {
      get => this.counttotalField;
      private set => this.counttotalField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    public string relevance
    {
      get => this.relevanceField;
      private set => this.relevanceField = value;
    }

    public string datepurchased
    {
      get => this.datepurchasedField;
      private set => this.datepurchasedField = value;
    }

    public string datesa
    {
      get => this.datesaField;
      private set => this.datesaField = value;
    }

    public string dateexp
    {
      get => this.dateexpField;
      private set => this.dateexpField = value;
    }

    public string[] features
    {
      get => this.featuresField;
      private set => this.featuresField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsaptlicense.nsaptlicense_response nsaptlicenseResponse = new nsaptlicense.nsaptlicense_response();
      nsaptlicense.nsaptlicense_response resource = (nsaptlicense.nsaptlicense_response) service.get_payload_formatter().string_to_resource(nsaptlicenseResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsaptlicense;
    }

    internal override string get_object_name() => (string) null;

    public static base_response change(nitro_service client, nsaptlicense resource) => new nsaptlicense()
    {
      id = resource.id,
      sessionid = resource.sessionid,
      bindtype = resource.bindtype,
      countavailable = resource.countavailable,
      licensedir = resource.licensedir,
      useproxy = resource.useproxy
    }.perform_operation_byaction(client, "update");

    public static base_responses change(
      nitro_service client,
      nsaptlicense[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsaptlicense[] nsaptlicenseArray = new nsaptlicense[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsaptlicenseArray[index] = new nsaptlicense();
          nsaptlicenseArray[index].id = resources[index].id;
          nsaptlicenseArray[index].sessionid = resources[index].sessionid;
          nsaptlicenseArray[index].bindtype = resources[index].bindtype;
          nsaptlicenseArray[index].countavailable = resources[index].countavailable;
          nsaptlicenseArray[index].licensedir = resources[index].licensedir;
          nsaptlicenseArray[index].useproxy = resources[index].useproxy;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsaptlicenseArray, "update");
      }
      return baseResponses;
    }

    public static nsaptlicense[] get(nitro_service service, nsaptlicense_args args)
    {
      nsaptlicense nsaptlicense = new nsaptlicense();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nsaptlicense[]) nsaptlicense.get_resources(service, option);
    }

    public static uint count(nitro_service service, nsaptlicense obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      nsaptlicense[] resources = (nsaptlicense[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    private class nsaptlicense_response : base_response
    {
      public nsaptlicense[] nsaptlicense = (nsaptlicense[]) null;
    }

    public static class useproxyEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
