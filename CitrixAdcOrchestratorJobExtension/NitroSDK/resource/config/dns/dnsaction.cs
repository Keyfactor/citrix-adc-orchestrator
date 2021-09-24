// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsaction : base_resource
  {
    private string actionnameField = (string) null;
    private string actiontypeField = (string) null;
    private string[] ipaddressField = (string[]) null;
    private long? ttlField = new long?();
    private string viewnameField = (string) null;
    private string[] preferredloclistField = (string[]) null;
    private string dnsprofilenameField = (string) null;
    private string dropField = (string) null;
    private string cachebypassField = (string) null;
    private string[] builtinField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string actionname
    {
      get => this.actionnameField;
      set => this.actionnameField = value;
    }

    public string actiontype
    {
      get => this.actiontypeField;
      set => this.actiontypeField = value;
    }

    public string[] ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public string viewname
    {
      get => this.viewnameField;
      set => this.viewnameField = value;
    }

    public string[] preferredloclist
    {
      get => this.preferredloclistField;
      set => this.preferredloclistField = value;
    }

    public string dnsprofilename
    {
      get => this.dnsprofilenameField;
      set => this.dnsprofilenameField = value;
    }

    public string drop
    {
      get => this.dropField;
      private set => this.dropField = value;
    }

    public string cachebypass
    {
      get => this.cachebypassField;
      private set => this.cachebypassField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsaction.dnsaction_response dnsactionResponse = new dnsaction.dnsaction_response();
      dnsaction.dnsaction_response resource = (dnsaction.dnsaction_response) service.get_payload_formatter().string_to_resource(dnsactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsaction;
    }

    internal override string get_object_name() => this.actionname;

    public static base_response add(nitro_service client, dnsaction resource) => new dnsaction()
    {
      actionname = resource.actionname,
      actiontype = resource.actiontype,
      ipaddress = resource.ipaddress,
      ttl = resource.ttl,
      viewname = resource.viewname,
      preferredloclist = resource.preferredloclist,
      dnsprofilename = resource.dnsprofilename
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaction[] dnsactionArray = new dnsaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsactionArray[index] = new dnsaction();
          dnsactionArray[index].actionname = resources[index].actionname;
          dnsactionArray[index].actiontype = resources[index].actiontype;
          dnsactionArray[index].ipaddress = resources[index].ipaddress;
          dnsactionArray[index].ttl = resources[index].ttl;
          dnsactionArray[index].viewname = resources[index].viewname;
          dnsactionArray[index].preferredloclist = resources[index].preferredloclist;
          dnsactionArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string actionname) => new dnsaction()
    {
      actionname = actionname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsaction resource) => new dnsaction()
    {
      actionname = resource.actionname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] actionname)
    {
      base_responses baseResponses = (base_responses) null;
      if (actionname != null && actionname.Length > 0)
      {
        dnsaction[] dnsactionArray = new dnsaction[actionname.Length];
        for (int index = 0; index < actionname.Length; ++index)
        {
          dnsactionArray[index] = new dnsaction();
          dnsactionArray[index].actionname = actionname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaction[] dnsactionArray = new dnsaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsactionArray[index] = new dnsaction();
          dnsactionArray[index].actionname = resources[index].actionname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnsaction resource) => new dnsaction()
    {
      actionname = resource.actionname,
      ipaddress = resource.ipaddress,
      ttl = resource.ttl,
      viewname = resource.viewname,
      preferredloclist = resource.preferredloclist,
      dnsprofilename = resource.dnsprofilename
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnsaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaction[] dnsactionArray = new dnsaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsactionArray[index] = new dnsaction();
          dnsactionArray[index].actionname = resources[index].actionname;
          dnsactionArray[index].ipaddress = resources[index].ipaddress;
          dnsactionArray[index].ttl = resources[index].ttl;
          dnsactionArray[index].viewname = resources[index].viewname;
          dnsactionArray[index].preferredloclist = resources[index].preferredloclist;
          dnsactionArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnsactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string actionname,
      string[] args)
    {
      return new dnsaction() { actionname = actionname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dnsaction resource,
      string[] args)
    {
      return new dnsaction()
      {
        actionname = resource.actionname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] actionname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (actionname != null && actionname.Length > 0)
      {
        dnsaction[] dnsactionArray = new dnsaction[actionname.Length];
        for (int index = 0; index < actionname.Length; ++index)
        {
          dnsactionArray[index] = new dnsaction();
          dnsactionArray[index].actionname = actionname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dnsaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaction[] dnsactionArray = new dnsaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsactionArray[index] = new dnsaction();
          dnsactionArray[index].actionname = resources[index].actionname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsactionArray, args);
      }
      return baseResponses;
    }

    public static dnsaction[] get(nitro_service service) => (dnsaction[]) new dnsaction().get_resources(service, (options) null);

    public static dnsaction[] get(nitro_service service, options option) => (dnsaction[]) new dnsaction().get_resources(service, option);

    public static dnsaction get(nitro_service service, string actionname) => (dnsaction) new dnsaction()
    {
      actionname = actionname
    }.get_resource(service);

    public static dnsaction[] get(nitro_service service, string[] actionname)
    {
      if (actionname == null || actionname.Length <= 0)
        return (dnsaction[]) null;
      dnsaction[] dnsactionArray1 = new dnsaction[actionname.Length];
      dnsaction[] dnsactionArray2 = new dnsaction[actionname.Length];
      for (int index = 0; index < actionname.Length; ++index)
      {
        dnsactionArray2[index] = new dnsaction();
        dnsactionArray2[index].actionname = actionname[index];
        dnsactionArray1[index] = (dnsaction) dnsactionArray2[index].get_resource(service);
      }
      return dnsactionArray1;
    }

    public static dnsaction[] get_filtered(nitro_service service, string filter)
    {
      dnsaction dnsaction = new dnsaction();
      options option = new options();
      option.set_filter(filter);
      return (dnsaction[]) dnsaction.getfiltered(service, option);
    }

    public static dnsaction[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsaction dnsaction = new dnsaction();
      options option = new options();
      option.set_filter(filter);
      return (dnsaction[]) dnsaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsaction dnsaction = new dnsaction();
      options option = new options();
      option.set_count(true);
      dnsaction[] resources = (dnsaction[]) dnsaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsaction dnsaction = new dnsaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsaction[] dnsactionArray = (dnsaction[]) dnsaction.getfiltered(service, option);
      return dnsactionArray != null && dnsactionArray.Length > 0 ? dnsactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsaction dnsaction = new dnsaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsaction[] dnsactionArray = (dnsaction[]) dnsaction.getfiltered(service, option);
      return dnsactionArray != null && dnsactionArray.Length > 0 ? dnsactionArray[0].__count.Value : 0U;
    }

    private class dnsaction_response : base_response
    {
      public dnsaction[] dnsaction = (dnsaction[]) null;
    }

    public static class cachebypassEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class actiontypeEnum
    {
      public const string ViewName = "ViewName";
      public const string GslbPrefLoc = "GslbPrefLoc";
      public const string noop = "noop";
      public const string Drop = "Drop";
      public const string Cache_Bypass = "Cache_Bypass";
      public const string Rewrite_Response = "Rewrite_Response";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class dropEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
