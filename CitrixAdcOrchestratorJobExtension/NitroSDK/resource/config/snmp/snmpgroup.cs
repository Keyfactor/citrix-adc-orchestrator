// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpgroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpgroup : base_resource
  {
    private string nameField = (string) null;
    private string securitylevelField = (string) null;
    private string readviewnameField = (string) null;
    private string storagetypeField = (string) null;
    private string statusField = (string) null;
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

    public string securitylevel
    {
      get => this.securitylevelField;
      set => this.securitylevelField = value;
    }

    public string readviewname
    {
      get => this.readviewnameField;
      set => this.readviewnameField = value;
    }

    public string storagetype
    {
      get => this.storagetypeField;
      private set => this.storagetypeField = value;
    }

    public string status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpgroup.snmpgroup_response snmpgroupResponse = new snmpgroup.snmpgroup_response();
      snmpgroup.snmpgroup_response resource = (snmpgroup.snmpgroup_response) service.get_payload_formatter().string_to_resource(snmpgroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmpgroup;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, snmpgroup resource) => new snmpgroup()
    {
      name = resource.name,
      securitylevel = resource.securitylevel,
      readviewname = resource.readviewname
    }.add_resource(client);

    public static base_responses add(nitro_service client, snmpgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpgroup[] snmpgroupArray = new snmpgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpgroupArray[index] = new snmpgroup();
          snmpgroupArray[index].name = resources[index].name;
          snmpgroupArray[index].securitylevel = resources[index].securitylevel;
          snmpgroupArray[index].readviewname = resources[index].readviewname;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) snmpgroupArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new snmpgroup()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, snmpgroup resource) => new snmpgroup()
    {
      name = resource.name,
      securitylevel = resource.securitylevel
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        snmpgroup[] snmpgroupArray = new snmpgroup[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          snmpgroupArray[index] = new snmpgroup();
          snmpgroupArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpgroupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, snmpgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpgroup[] snmpgroupArray = new snmpgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpgroupArray[index] = new snmpgroup();
          snmpgroupArray[index].name = resources[index].name;
          snmpgroupArray[index].securitylevel = resources[index].securitylevel;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpgroupArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, snmpgroup resource) => new snmpgroup()
    {
      name = resource.name,
      securitylevel = resource.securitylevel,
      readviewname = resource.readviewname
    }.update_resource(client);

    public static base_responses update(nitro_service client, snmpgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpgroup[] snmpgroupArray = new snmpgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpgroupArray[index] = new snmpgroup();
          snmpgroupArray[index].name = resources[index].name;
          snmpgroupArray[index].securitylevel = resources[index].securitylevel;
          snmpgroupArray[index].readviewname = resources[index].readviewname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) snmpgroupArray);
      }
      return baseResponses;
    }

    public static snmpgroup[] get(nitro_service service) => (snmpgroup[]) new snmpgroup().get_resources(service, (options) null);

    public static snmpgroup[] get(nitro_service service, options option) => (snmpgroup[]) new snmpgroup().get_resources(service, option);

    public static snmpgroup get(nitro_service service, snmpgroup obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmpgroup) obj.get_resource(service, option);
    }

    public static snmpgroup[] get(nitro_service service, snmpgroup[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (snmpgroup[]) null;
      snmpgroup[] snmpgroupArray = new snmpgroup[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        snmpgroupArray[index] = (snmpgroup) obj[index].get_resource(service, option);
      }
      return snmpgroupArray;
    }

    public static snmpgroup[] get_filtered(nitro_service service, string filter)
    {
      snmpgroup snmpgroup = new snmpgroup();
      options option = new options();
      option.set_filter(filter);
      return (snmpgroup[]) snmpgroup.getfiltered(service, option);
    }

    public static snmpgroup[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpgroup snmpgroup = new snmpgroup();
      options option = new options();
      option.set_filter(filter);
      return (snmpgroup[]) snmpgroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      snmpgroup snmpgroup = new snmpgroup();
      options option = new options();
      option.set_count(true);
      snmpgroup[] resources = (snmpgroup[]) snmpgroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      snmpgroup snmpgroup = new snmpgroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpgroup[] snmpgroupArray = (snmpgroup[]) snmpgroup.getfiltered(service, option);
      return snmpgroupArray != null && snmpgroupArray.Length > 0 ? snmpgroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpgroup snmpgroup = new snmpgroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpgroup[] snmpgroupArray = (snmpgroup[]) snmpgroup.getfiltered(service, option);
      return snmpgroupArray != null && snmpgroupArray.Length > 0 ? snmpgroupArray[0].__count.Value : 0U;
    }

    private class snmpgroup_response : base_response
    {
      public snmpgroup[] snmpgroup = (snmpgroup[]) null;
    }

    public static class storagetypeEnum
    {
      public const string Volatile = "volatile";
      public const string nonVolatile = "nonVolatile";
    }

    public static class securitylevelEnum
    {
      public const string noAuthNoPriv = "noAuthNoPriv";
      public const string authNoPriv = "authNoPriv";
      public const string authPriv = "authPriv";
    }

    public static class statusEnum
    {
      public const string active = "active";
    }
  }
}
