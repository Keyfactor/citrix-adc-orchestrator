// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbwlm
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbwlm : base_resource
  {
    private string wlmnameField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string lbuidField = (string) null;
    private uint? katimeoutField = new uint?();
    private string secureField = (string) null;
    private string stateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string wlmname
    {
      get => this.wlmnameField;
      set => this.wlmnameField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string lbuid
    {
      get => this.lbuidField;
      set => this.lbuidField = value;
    }

    public uint? katimeout
    {
      get => this.katimeoutField;
      set => this.katimeoutField = value;
    }

    public string secure
    {
      get => this.secureField;
      private set => this.secureField = value;
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
      lbwlm.lbwlm_response lbwlmResponse = new lbwlm.lbwlm_response();
      lbwlm.lbwlm_response resource = (lbwlm.lbwlm_response) service.get_payload_formatter().string_to_resource(lbwlmResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbwlm;
    }

    internal override string get_object_name() => this.wlmname;

    public static base_response add(nitro_service client, lbwlm resource) => new lbwlm()
    {
      wlmname = resource.wlmname,
      ipaddress = resource.ipaddress,
      port = resource.port,
      lbuid = resource.lbuid,
      katimeout = resource.katimeout
    }.add_resource(client);

    public static base_responses add(nitro_service client, lbwlm[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbwlm[] lbwlmArray = new lbwlm[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbwlmArray[index] = new lbwlm();
          lbwlmArray[index].wlmname = resources[index].wlmname;
          lbwlmArray[index].ipaddress = resources[index].ipaddress;
          lbwlmArray[index].port = resources[index].port;
          lbwlmArray[index].lbuid = resources[index].lbuid;
          lbwlmArray[index].katimeout = resources[index].katimeout;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lbwlmArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string wlmname) => new lbwlm()
    {
      wlmname = wlmname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lbwlm resource) => new lbwlm()
    {
      wlmname = resource.wlmname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] wlmname)
    {
      base_responses baseResponses = (base_responses) null;
      if (wlmname != null && wlmname.Length > 0)
      {
        lbwlm[] lbwlmArray = new lbwlm[wlmname.Length];
        for (int index = 0; index < wlmname.Length; ++index)
        {
          lbwlmArray[index] = new lbwlm();
          lbwlmArray[index].wlmname = wlmname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbwlmArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lbwlm[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbwlm[] lbwlmArray = new lbwlm[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbwlmArray[index] = new lbwlm();
          lbwlmArray[index].wlmname = resources[index].wlmname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbwlmArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lbwlm resource) => new lbwlm()
    {
      wlmname = resource.wlmname,
      katimeout = resource.katimeout
    }.update_resource(client);

    public static base_responses update(nitro_service client, lbwlm[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbwlm[] lbwlmArray = new lbwlm[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbwlmArray[index] = new lbwlm();
          lbwlmArray[index].wlmname = resources[index].wlmname;
          lbwlmArray[index].katimeout = resources[index].katimeout;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbwlmArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string wlmname,
      string[] args)
    {
      return new lbwlm() { wlmname = wlmname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lbwlm resource,
      string[] args)
    {
      return new lbwlm() { wlmname = resource.wlmname }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] wlmname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (wlmname != null && wlmname.Length > 0)
      {
        lbwlm[] lbwlmArray = new lbwlm[wlmname.Length];
        for (int index = 0; index < wlmname.Length; ++index)
        {
          lbwlmArray[index] = new lbwlm();
          lbwlmArray[index].wlmname = wlmname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lbwlmArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lbwlm[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbwlm[] lbwlmArray = new lbwlm[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbwlmArray[index] = new lbwlm();
          lbwlmArray[index].wlmname = resources[index].wlmname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lbwlmArray, args);
      }
      return baseResponses;
    }

    public static lbwlm[] get(nitro_service service) => (lbwlm[]) new lbwlm().get_resources(service, (options) null);

    public static lbwlm[] get(nitro_service service, options option) => (lbwlm[]) new lbwlm().get_resources(service, option);

    public static lbwlm get(nitro_service service, string wlmname) => (lbwlm) new lbwlm()
    {
      wlmname = wlmname
    }.get_resource(service);

    public static lbwlm[] get(nitro_service service, string[] wlmname)
    {
      if (wlmname == null || wlmname.Length <= 0)
        return (lbwlm[]) null;
      lbwlm[] lbwlmArray1 = new lbwlm[wlmname.Length];
      lbwlm[] lbwlmArray2 = new lbwlm[wlmname.Length];
      for (int index = 0; index < wlmname.Length; ++index)
      {
        lbwlmArray2[index] = new lbwlm();
        lbwlmArray2[index].wlmname = wlmname[index];
        lbwlmArray1[index] = (lbwlm) lbwlmArray2[index].get_resource(service);
      }
      return lbwlmArray1;
    }

    public static lbwlm[] get_filtered(nitro_service service, string filter)
    {
      lbwlm lbwlm = new lbwlm();
      options option = new options();
      option.set_filter(filter);
      return (lbwlm[]) lbwlm.getfiltered(service, option);
    }

    public static lbwlm[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lbwlm lbwlm = new lbwlm();
      options option = new options();
      option.set_filter(filter);
      return (lbwlm[]) lbwlm.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lbwlm lbwlm = new lbwlm();
      options option = new options();
      option.set_count(true);
      lbwlm[] resources = (lbwlm[]) lbwlm.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lbwlm lbwlm = new lbwlm();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbwlm[] lbwlmArray = (lbwlm[]) lbwlm.getfiltered(service, option);
      return lbwlmArray != null && lbwlmArray.Length > 0 ? lbwlmArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lbwlm lbwlm = new lbwlm();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbwlm[] lbwlmArray = (lbwlm[]) lbwlm.getfiltered(service, option);
      return lbwlmArray != null && lbwlmArray.Length > 0 ? lbwlmArray[0].__count.Value : 0U;
    }

    private class lbwlm_response : base_response
    {
      public lbwlm[] lbwlm = (lbwlm[]) null;
    }

    public static class secureEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class stateEnum
    {
      public const string ACTIVE = "ACTIVE";
      public const string INACTIVE = "INACTIVE";
      public const string UNKNOWN = "UNKNOWN";
    }
  }
}
