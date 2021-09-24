// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.wf.wfsite
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.wf
{
  public class wfsite : base_resource
  {
    private string sitenameField = (string) null;
    private string storefronturlField = (string) null;
    private string storenameField = (string) null;
    private string html5receiverField = (string) null;
    private string workspacecontrolField = (string) null;
    private string displayroamingaccountsField = (string) null;
    private string xframeoptionsField = (string) null;
    private string stateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string sitename
    {
      get => this.sitenameField;
      set => this.sitenameField = value;
    }

    public string storefronturl
    {
      get => this.storefronturlField;
      set => this.storefronturlField = value;
    }

    public string storename
    {
      get => this.storenameField;
      set => this.storenameField = value;
    }

    public string html5receiver
    {
      get => this.html5receiverField;
      set => this.html5receiverField = value;
    }

    public string workspacecontrol
    {
      get => this.workspacecontrolField;
      set => this.workspacecontrolField = value;
    }

    public string displayroamingaccounts
    {
      get => this.displayroamingaccountsField;
      set => this.displayroamingaccountsField = value;
    }

    public string xframeoptions
    {
      get => this.xframeoptionsField;
      set => this.xframeoptionsField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      wfsite.wfsite_response wfsiteResponse = new wfsite.wfsite_response();
      wfsite.wfsite_response resource = (wfsite.wfsite_response) service.get_payload_formatter().string_to_resource(wfsiteResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.wfsite;
    }

    internal override string get_object_name() => this.sitename;

    public static base_response add(nitro_service client, wfsite resource) => new wfsite()
    {
      sitename = resource.sitename,
      storefronturl = resource.storefronturl,
      storename = resource.storename,
      html5receiver = resource.html5receiver,
      workspacecontrol = resource.workspacecontrol,
      displayroamingaccounts = resource.displayroamingaccounts,
      xframeoptions = resource.xframeoptions
    }.add_resource(client);

    public static base_responses add(nitro_service client, wfsite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wfsite[] wfsiteArray = new wfsite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wfsiteArray[index] = new wfsite();
          wfsiteArray[index].sitename = resources[index].sitename;
          wfsiteArray[index].storefronturl = resources[index].storefronturl;
          wfsiteArray[index].storename = resources[index].storename;
          wfsiteArray[index].html5receiver = resources[index].html5receiver;
          wfsiteArray[index].workspacecontrol = resources[index].workspacecontrol;
          wfsiteArray[index].displayroamingaccounts = resources[index].displayroamingaccounts;
          wfsiteArray[index].xframeoptions = resources[index].xframeoptions;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) wfsiteArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string sitename) => new wfsite()
    {
      sitename = sitename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, wfsite resource) => new wfsite()
    {
      sitename = resource.sitename
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] sitename)
    {
      base_responses baseResponses = (base_responses) null;
      if (sitename != null && sitename.Length > 0)
      {
        wfsite[] wfsiteArray = new wfsite[sitename.Length];
        for (int index = 0; index < sitename.Length; ++index)
        {
          wfsiteArray[index] = new wfsite();
          wfsiteArray[index].sitename = sitename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) wfsiteArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, wfsite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wfsite[] wfsiteArray = new wfsite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wfsiteArray[index] = new wfsite();
          wfsiteArray[index].sitename = resources[index].sitename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) wfsiteArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, wfsite resource) => new wfsite()
    {
      sitename = resource.sitename,
      storefronturl = resource.storefronturl,
      storename = resource.storename,
      html5receiver = resource.html5receiver,
      workspacecontrol = resource.workspacecontrol,
      displayroamingaccounts = resource.displayroamingaccounts,
      xframeoptions = resource.xframeoptions
    }.update_resource(client);

    public static base_responses update(nitro_service client, wfsite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wfsite[] wfsiteArray = new wfsite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wfsiteArray[index] = new wfsite();
          wfsiteArray[index].sitename = resources[index].sitename;
          wfsiteArray[index].storefronturl = resources[index].storefronturl;
          wfsiteArray[index].storename = resources[index].storename;
          wfsiteArray[index].html5receiver = resources[index].html5receiver;
          wfsiteArray[index].workspacecontrol = resources[index].workspacecontrol;
          wfsiteArray[index].displayroamingaccounts = resources[index].displayroamingaccounts;
          wfsiteArray[index].xframeoptions = resources[index].xframeoptions;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) wfsiteArray);
      }
      return baseResponses;
    }

    public static wfsite[] get(nitro_service service) => (wfsite[]) new wfsite().get_resources(service, (options) null);

    public static wfsite[] get(nitro_service service, options option) => (wfsite[]) new wfsite().get_resources(service, option);

    public static wfsite get(nitro_service service, string sitename) => (wfsite) new wfsite()
    {
      sitename = sitename
    }.get_resource(service);

    public static wfsite[] get(nitro_service service, string[] sitename)
    {
      if (sitename == null || sitename.Length <= 0)
        return (wfsite[]) null;
      wfsite[] wfsiteArray1 = new wfsite[sitename.Length];
      wfsite[] wfsiteArray2 = new wfsite[sitename.Length];
      for (int index = 0; index < sitename.Length; ++index)
      {
        wfsiteArray2[index] = new wfsite();
        wfsiteArray2[index].sitename = sitename[index];
        wfsiteArray1[index] = (wfsite) wfsiteArray2[index].get_resource(service);
      }
      return wfsiteArray1;
    }

    public static wfsite[] get_filtered(nitro_service service, string filter)
    {
      wfsite wfsite = new wfsite();
      options option = new options();
      option.set_filter(filter);
      return (wfsite[]) wfsite.getfiltered(service, option);
    }

    public static wfsite[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      wfsite wfsite = new wfsite();
      options option = new options();
      option.set_filter(filter);
      return (wfsite[]) wfsite.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      wfsite wfsite = new wfsite();
      options option = new options();
      option.set_count(true);
      wfsite[] resources = (wfsite[]) wfsite.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      wfsite wfsite = new wfsite();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wfsite[] wfsiteArray = (wfsite[]) wfsite.getfiltered(service, option);
      return wfsiteArray != null && wfsiteArray.Length > 0 ? wfsiteArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      wfsite wfsite = new wfsite();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wfsite[] wfsiteArray = (wfsite[]) wfsite.getfiltered(service, option);
      return wfsiteArray != null && wfsiteArray.Length > 0 ? wfsiteArray[0].__count.Value : 0U;
    }

    private class wfsite_response : base_response
    {
      public wfsite[] wfsite = (wfsite[]) null;
    }

    public static class displayroamingaccountsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class xframeoptionsEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
    }

    public static class stateEnum
    {
      public const string UP = "UP";
      public const string INITIALIZING = "INITIALIZING";
      public const string DOWN_HostUnknown = "DOWN-HostUnknown";
      public const string DOWN_ReqTimeout = "DOWN-ReqTimeout";
      public const string DOWN_Wrong_Store = "DOWN-Wrong Store";
      public const string DOWN_SF_Error = "DOWN-SF Error";
      public const string DOWN_SSL_Error = "DOWN-SSL Error";
      public const string DOWN_Conn_Reset = "DOWN-Conn Reset";
      public const string DOWN = "DOWN";
    }

    public static class html5receiverEnum
    {
      public const string ALWAYS = "ALWAYS";
      public const string FALLBACK = "FALLBACK";
      public const string OFF = "OFF";
    }

    public static class workspacecontrolEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
