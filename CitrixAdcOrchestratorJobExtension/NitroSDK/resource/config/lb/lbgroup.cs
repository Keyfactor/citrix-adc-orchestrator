// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbgroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbgroup : base_resource
  {
    private string nameField = (string) null;
    private string persistencetypeField = (string) null;
    private string persistencebackupField = (string) null;
    private uint? backuppersistencetimeoutField = new uint?();
    private string persistmaskField = (string) null;
    private string cookienameField = (string) null;
    private uint? v6persistmasklenField = new uint?();
    private string cookiedomainField = (string) null;
    private uint? timeoutField = new uint?();
    private string ruleField = (string) null;
    private string newnameField = (string) null;
    private uint? tdField = new uint?();
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

    public string persistencetype
    {
      get => this.persistencetypeField;
      set => this.persistencetypeField = value;
    }

    public string persistencebackup
    {
      get => this.persistencebackupField;
      set => this.persistencebackupField = value;
    }

    public uint? backuppersistencetimeout
    {
      get => this.backuppersistencetimeoutField;
      set => this.backuppersistencetimeoutField = value;
    }

    public string persistmask
    {
      get => this.persistmaskField;
      set => this.persistmaskField = value;
    }

    public string cookiename
    {
      get => this.cookienameField;
      set => this.cookienameField = value;
    }

    public uint? v6persistmasklen
    {
      get => this.v6persistmasklenField;
      set => this.v6persistmasklenField = value;
    }

    public string cookiedomain
    {
      get => this.cookiedomainField;
      set => this.cookiedomainField = value;
    }

    public uint? timeout
    {
      get => this.timeoutField;
      set => this.timeoutField = value;
    }

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      private set => this.tdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbgroup.lbgroup_response lbgroupResponse = new lbgroup.lbgroup_response();
      lbgroup.lbgroup_response resource = (lbgroup.lbgroup_response) service.get_payload_formatter().string_to_resource(lbgroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbgroup;
    }

    internal override string get_object_name() => this.name;

    public static base_response update(nitro_service client, lbgroup resource) => new lbgroup()
    {
      name = resource.name,
      persistencetype = resource.persistencetype,
      persistencebackup = resource.persistencebackup,
      backuppersistencetimeout = resource.backuppersistencetimeout,
      persistmask = resource.persistmask,
      cookiename = resource.cookiename,
      v6persistmasklen = resource.v6persistmasklen,
      cookiedomain = resource.cookiedomain,
      timeout = resource.timeout,
      rule = resource.rule
    }.update_resource(client);

    public static base_responses update(nitro_service client, lbgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbgroup[] lbgroupArray = new lbgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbgroupArray[index] = new lbgroup();
          lbgroupArray[index].name = resources[index].name;
          lbgroupArray[index].persistencetype = resources[index].persistencetype;
          lbgroupArray[index].persistencebackup = resources[index].persistencebackup;
          lbgroupArray[index].backuppersistencetimeout = resources[index].backuppersistencetimeout;
          lbgroupArray[index].persistmask = resources[index].persistmask;
          lbgroupArray[index].cookiename = resources[index].cookiename;
          lbgroupArray[index].v6persistmasklen = resources[index].v6persistmasklen;
          lbgroupArray[index].cookiedomain = resources[index].cookiedomain;
          lbgroupArray[index].timeout = resources[index].timeout;
          lbgroupArray[index].rule = resources[index].rule;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbgroupArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new lbgroup() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lbgroup resource,
      string[] args)
    {
      return new lbgroup() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        lbgroup[] lbgroupArray = new lbgroup[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          lbgroupArray[index] = new lbgroup();
          lbgroupArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lbgroupArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lbgroup[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbgroup[] lbgroupArray = new lbgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbgroupArray[index] = new lbgroup();
          lbgroupArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lbgroupArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      lbgroup resource,
      string new_name)
    {
      return new lbgroup()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new lbgroup()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static lbgroup[] get(nitro_service service) => (lbgroup[]) new lbgroup().get_resources(service, (options) null);

    public static lbgroup[] get(nitro_service service, options option) => (lbgroup[]) new lbgroup().get_resources(service, option);

    public static lbgroup get(nitro_service service, string name) => (lbgroup) new lbgroup()
    {
      name = name
    }.get_resource(service);

    public static lbgroup[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (lbgroup[]) null;
      lbgroup[] lbgroupArray1 = new lbgroup[name.Length];
      lbgroup[] lbgroupArray2 = new lbgroup[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        lbgroupArray2[index] = new lbgroup();
        lbgroupArray2[index].name = name[index];
        lbgroupArray1[index] = (lbgroup) lbgroupArray2[index].get_resource(service);
      }
      return lbgroupArray1;
    }

    public static lbgroup[] get_filtered(nitro_service service, string filter)
    {
      lbgroup lbgroup = new lbgroup();
      options option = new options();
      option.set_filter(filter);
      return (lbgroup[]) lbgroup.getfiltered(service, option);
    }

    public static lbgroup[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lbgroup lbgroup = new lbgroup();
      options option = new options();
      option.set_filter(filter);
      return (lbgroup[]) lbgroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lbgroup lbgroup = new lbgroup();
      options option = new options();
      option.set_count(true);
      lbgroup[] resources = (lbgroup[]) lbgroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lbgroup lbgroup = new lbgroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbgroup[] lbgroupArray = (lbgroup[]) lbgroup.getfiltered(service, option);
      return lbgroupArray != null && lbgroupArray.Length > 0 ? lbgroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lbgroup lbgroup = new lbgroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbgroup[] lbgroupArray = (lbgroup[]) lbgroup.getfiltered(service, option);
      return lbgroupArray != null && lbgroupArray.Length > 0 ? lbgroupArray[0].__count.Value : 0U;
    }

    private class lbgroup_response : base_response
    {
      public lbgroup[] lbgroup = (lbgroup[]) null;
    }

    public static class persistencebackupEnum
    {
      public const string SOURCEIP = "SOURCEIP";
      public const string NONE = "NONE";
    }

    public static class persistencetypeEnum
    {
      public const string SOURCEIP = "SOURCEIP";
      public const string COOKIEINSERT = "COOKIEINSERT";
      public const string RULE = "RULE";
      public const string NONE = "NONE";
    }
  }
}
