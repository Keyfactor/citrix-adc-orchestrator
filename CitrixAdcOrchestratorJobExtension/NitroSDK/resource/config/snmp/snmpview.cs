// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpview
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpview : base_resource
  {
    private string nameField = (string) null;
    private string subtreeField = (string) null;
    private string typeField = (string) null;
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

    public string subtree
    {
      get => this.subtreeField;
      set => this.subtreeField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
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
      snmpview.snmpview_response snmpviewResponse = new snmpview.snmpview_response();
      snmpview.snmpview_response resource = (snmpview.snmpview_response) service.get_payload_formatter().string_to_resource(snmpviewResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmpview;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, snmpview resource) => new snmpview()
    {
      name = resource.name,
      subtree = resource.subtree,
      type = resource.type
    }.add_resource(client);

    public static base_responses add(nitro_service client, snmpview[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpview[] snmpviewArray = new snmpview[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpviewArray[index] = new snmpview();
          snmpviewArray[index].name = resources[index].name;
          snmpviewArray[index].subtree = resources[index].subtree;
          snmpviewArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) snmpviewArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new snmpview()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, snmpview resource) => new snmpview()
    {
      name = resource.name,
      subtree = resource.subtree
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        snmpview[] snmpviewArray = new snmpview[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          snmpviewArray[index] = new snmpview();
          snmpviewArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpviewArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, snmpview[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpview[] snmpviewArray = new snmpview[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpviewArray[index] = new snmpview();
          snmpviewArray[index].name = resources[index].name;
          snmpviewArray[index].subtree = resources[index].subtree;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpviewArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, snmpview resource) => new snmpview()
    {
      name = resource.name,
      subtree = resource.subtree,
      type = resource.type
    }.update_resource(client);

    public static base_responses update(nitro_service client, snmpview[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpview[] snmpviewArray = new snmpview[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpviewArray[index] = new snmpview();
          snmpviewArray[index].name = resources[index].name;
          snmpviewArray[index].subtree = resources[index].subtree;
          snmpviewArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) snmpviewArray);
      }
      return baseResponses;
    }

    public static snmpview[] get(nitro_service service) => (snmpview[]) new snmpview().get_resources(service, (options) null);

    public static snmpview[] get(nitro_service service, options option) => (snmpview[]) new snmpview().get_resources(service, option);

    public static snmpview get(nitro_service service, snmpview obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmpview) obj.get_resource(service, option);
    }

    public static snmpview[] get(nitro_service service, snmpview[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (snmpview[]) null;
      snmpview[] snmpviewArray = new snmpview[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        snmpviewArray[index] = (snmpview) obj[index].get_resource(service, option);
      }
      return snmpviewArray;
    }

    public static snmpview[] get_filtered(nitro_service service, string filter)
    {
      snmpview snmpview = new snmpview();
      options option = new options();
      option.set_filter(filter);
      return (snmpview[]) snmpview.getfiltered(service, option);
    }

    public static snmpview[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpview snmpview = new snmpview();
      options option = new options();
      option.set_filter(filter);
      return (snmpview[]) snmpview.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      snmpview snmpview = new snmpview();
      options option = new options();
      option.set_count(true);
      snmpview[] resources = (snmpview[]) snmpview.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      snmpview snmpview = new snmpview();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpview[] snmpviewArray = (snmpview[]) snmpview.getfiltered(service, option);
      return snmpviewArray != null && snmpviewArray.Length > 0 ? snmpviewArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpview snmpview = new snmpview();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpview[] snmpviewArray = (snmpview[]) snmpview.getfiltered(service, option);
      return snmpviewArray != null && snmpviewArray.Length > 0 ? snmpviewArray[0].__count.Value : 0U;
    }

    private class snmpview_response : base_response
    {
      public snmpview[] snmpview = (snmpview[]) null;
    }

    public static class storagetypeEnum
    {
      public const string Volatile = "volatile";
      public const string nonVolatile = "nonVolatile";
    }

    public static class typeEnum
    {
      public const string included = "included";
      public const string excluded = "excluded";
    }

    public static class statusEnum
    {
      public const string active = "active";
    }
  }
}
