// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpntrafficaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpntrafficaction : base_resource
  {
    private string nameField = (string) null;
    private string qualField = (string) null;
    private uint? apptimeoutField = new uint?();
    private string ssoField = (string) null;
    private string hdxField = (string) null;
    private string formssoactionField = (string) null;
    private string ftaField = (string) null;
    private string wanscalerField = (string) null;
    private string kcdaccountField = (string) null;
    private string samlssoprofileField = (string) null;
    private string proxyField = (string) null;
    private string userexpressionField = (string) null;
    private string passwdexpressionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string qual
    {
      get => this.qualField;
      set => this.qualField = value;
    }

    public uint? apptimeout
    {
      get => this.apptimeoutField;
      set => this.apptimeoutField = value;
    }

    public string sso
    {
      get => this.ssoField;
      set => this.ssoField = value;
    }

    public string hdx
    {
      get => this.hdxField;
      set => this.hdxField = value;
    }

    public string formssoaction
    {
      get => this.formssoactionField;
      set => this.formssoactionField = value;
    }

    public string fta
    {
      get => this.ftaField;
      set => this.ftaField = value;
    }

    public string wanscaler
    {
      get => this.wanscalerField;
      set => this.wanscalerField = value;
    }

    public string kcdaccount
    {
      get => this.kcdaccountField;
      set => this.kcdaccountField = value;
    }

    public string samlssoprofile
    {
      get => this.samlssoprofileField;
      set => this.samlssoprofileField = value;
    }

    public string proxy
    {
      get => this.proxyField;
      set => this.proxyField = value;
    }

    public string userexpression
    {
      get => this.userexpressionField;
      set => this.userexpressionField = value;
    }

    public string passwdexpression
    {
      get => this.passwdexpressionField;
      set => this.passwdexpressionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpntrafficaction.vpntrafficaction_response vpntrafficactionResponse = new vpntrafficaction.vpntrafficaction_response();
      vpntrafficaction.vpntrafficaction_response resource = (vpntrafficaction.vpntrafficaction_response) service.get_payload_formatter().string_to_resource(vpntrafficactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpntrafficaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpntrafficaction resource) => new vpntrafficaction()
    {
      name = resource.name,
      qual = resource.qual,
      apptimeout = resource.apptimeout,
      sso = resource.sso,
      hdx = resource.hdx,
      formssoaction = resource.formssoaction,
      fta = resource.fta,
      wanscaler = resource.wanscaler,
      kcdaccount = resource.kcdaccount,
      samlssoprofile = resource.samlssoprofile,
      proxy = resource.proxy,
      userexpression = resource.userexpression,
      passwdexpression = resource.passwdexpression
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      vpntrafficaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpntrafficaction[] vpntrafficactionArray = new vpntrafficaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficactionArray[index] = new vpntrafficaction();
          vpntrafficactionArray[index].name = resources[index].name;
          vpntrafficactionArray[index].qual = resources[index].qual;
          vpntrafficactionArray[index].apptimeout = resources[index].apptimeout;
          vpntrafficactionArray[index].sso = resources[index].sso;
          vpntrafficactionArray[index].hdx = resources[index].hdx;
          vpntrafficactionArray[index].formssoaction = resources[index].formssoaction;
          vpntrafficactionArray[index].fta = resources[index].fta;
          vpntrafficactionArray[index].wanscaler = resources[index].wanscaler;
          vpntrafficactionArray[index].kcdaccount = resources[index].kcdaccount;
          vpntrafficactionArray[index].samlssoprofile = resources[index].samlssoprofile;
          vpntrafficactionArray[index].proxy = resources[index].proxy;
          vpntrafficactionArray[index].userexpression = resources[index].userexpression;
          vpntrafficactionArray[index].passwdexpression = resources[index].passwdexpression;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpntrafficactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpntrafficaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpntrafficaction resource) => new vpntrafficaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpntrafficaction[] vpntrafficactionArray = new vpntrafficaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpntrafficactionArray[index] = new vpntrafficaction();
          vpntrafficactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpntrafficactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpntrafficaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpntrafficaction[] vpntrafficactionArray = new vpntrafficaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficactionArray[index] = new vpntrafficaction();
          vpntrafficactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpntrafficactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vpntrafficaction resource) => new vpntrafficaction()
    {
      name = resource.name,
      apptimeout = resource.apptimeout,
      sso = resource.sso,
      hdx = resource.hdx,
      formssoaction = resource.formssoaction,
      fta = resource.fta,
      wanscaler = resource.wanscaler,
      kcdaccount = resource.kcdaccount,
      samlssoprofile = resource.samlssoprofile,
      proxy = resource.proxy,
      userexpression = resource.userexpression,
      passwdexpression = resource.passwdexpression
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      vpntrafficaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpntrafficaction[] vpntrafficactionArray = new vpntrafficaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficactionArray[index] = new vpntrafficaction();
          vpntrafficactionArray[index].name = resources[index].name;
          vpntrafficactionArray[index].apptimeout = resources[index].apptimeout;
          vpntrafficactionArray[index].sso = resources[index].sso;
          vpntrafficactionArray[index].hdx = resources[index].hdx;
          vpntrafficactionArray[index].formssoaction = resources[index].formssoaction;
          vpntrafficactionArray[index].fta = resources[index].fta;
          vpntrafficactionArray[index].wanscaler = resources[index].wanscaler;
          vpntrafficactionArray[index].kcdaccount = resources[index].kcdaccount;
          vpntrafficactionArray[index].samlssoprofile = resources[index].samlssoprofile;
          vpntrafficactionArray[index].proxy = resources[index].proxy;
          vpntrafficactionArray[index].userexpression = resources[index].userexpression;
          vpntrafficactionArray[index].passwdexpression = resources[index].passwdexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpntrafficactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new vpntrafficaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      vpntrafficaction resource,
      string[] args)
    {
      return new vpntrafficaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpntrafficaction[] vpntrafficactionArray = new vpntrafficaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpntrafficactionArray[index] = new vpntrafficaction();
          vpntrafficactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpntrafficactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vpntrafficaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpntrafficaction[] vpntrafficactionArray = new vpntrafficaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficactionArray[index] = new vpntrafficaction();
          vpntrafficactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpntrafficactionArray, args);
      }
      return baseResponses;
    }

    public static vpntrafficaction[] get(nitro_service service) => (vpntrafficaction[]) new vpntrafficaction().get_resources(service, (options) null);

    public static vpntrafficaction[] get(nitro_service service, options option) => (vpntrafficaction[]) new vpntrafficaction().get_resources(service, option);

    public static vpntrafficaction get(nitro_service service, string name) => (vpntrafficaction) new vpntrafficaction()
    {
      name = name
    }.get_resource(service);

    public static vpntrafficaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpntrafficaction[]) null;
      vpntrafficaction[] vpntrafficactionArray1 = new vpntrafficaction[name.Length];
      vpntrafficaction[] vpntrafficactionArray2 = new vpntrafficaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpntrafficactionArray2[index] = new vpntrafficaction();
        vpntrafficactionArray2[index].name = name[index];
        vpntrafficactionArray1[index] = (vpntrafficaction) vpntrafficactionArray2[index].get_resource(service);
      }
      return vpntrafficactionArray1;
    }

    public static vpntrafficaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpntrafficaction vpntrafficaction = new vpntrafficaction();
      options option = new options();
      option.set_filter(filter);
      return (vpntrafficaction[]) vpntrafficaction.getfiltered(service, option);
    }

    public static vpntrafficaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpntrafficaction vpntrafficaction = new vpntrafficaction();
      options option = new options();
      option.set_filter(filter);
      return (vpntrafficaction[]) vpntrafficaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpntrafficaction vpntrafficaction = new vpntrafficaction();
      options option = new options();
      option.set_count(true);
      vpntrafficaction[] resources = (vpntrafficaction[]) vpntrafficaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpntrafficaction vpntrafficaction = new vpntrafficaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpntrafficaction[] vpntrafficactionArray = (vpntrafficaction[]) vpntrafficaction.getfiltered(service, option);
      return vpntrafficactionArray != null && vpntrafficactionArray.Length > 0 ? vpntrafficactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpntrafficaction vpntrafficaction = new vpntrafficaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpntrafficaction[] vpntrafficactionArray = (vpntrafficaction[]) vpntrafficaction.getfiltered(service, option);
      return vpntrafficactionArray != null && vpntrafficactionArray.Length > 0 ? vpntrafficactionArray[0].__count.Value : 0U;
    }

    private class vpntrafficaction_response : base_response
    {
      public vpntrafficaction[] vpntrafficaction = (vpntrafficaction[]) null;
    }

    public static class qualEnum
    {
      public const string http = "http";
      public const string tcp = "tcp";
    }

    public static class wanscalerEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class hdxEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class ftaEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class ssoEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
