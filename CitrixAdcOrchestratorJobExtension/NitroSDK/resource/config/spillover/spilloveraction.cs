// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.spillover.spilloveraction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.spillover
{
  public class spilloveraction : base_resource
  {
    private string nameField = (string) null;
    private string actionField = (string) null;
    private string newnameField = (string) null;
    private string[] builtinField = (string[]) null;
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

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
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
      spilloveraction.spilloveraction_response spilloveractionResponse = new spilloveraction.spilloveraction_response();
      spilloveraction.spilloveraction_response resource = (spilloveraction.spilloveraction_response) service.get_payload_formatter().string_to_resource(spilloveractionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.spilloveraction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, spilloveraction resource) => new spilloveraction()
    {
      name = resource.name,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      spilloveraction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        spilloveraction[] spilloveractionArray = new spilloveraction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          spilloveractionArray[index] = new spilloveraction();
          spilloveractionArray[index].name = resources[index].name;
          spilloveractionArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) spilloveractionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new spilloveraction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, spilloveraction resource) => new spilloveraction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        spilloveraction[] spilloveractionArray = new spilloveraction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          spilloveractionArray[index] = new spilloveraction();
          spilloveractionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) spilloveractionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      spilloveraction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        spilloveraction[] spilloveractionArray = new spilloveraction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          spilloveractionArray[index] = new spilloveraction();
          spilloveractionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) spilloveractionArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      spilloveraction resource,
      string new_name)
    {
      return new spilloveraction()
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
      return new spilloveraction()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static spilloveraction[] get(nitro_service service) => (spilloveraction[]) new spilloveraction().get_resources(service, (options) null);

    public static spilloveraction[] get(nitro_service service, options option) => (spilloveraction[]) new spilloveraction().get_resources(service, option);

    public static spilloveraction get(nitro_service service, string name) => (spilloveraction) new spilloveraction()
    {
      name = name
    }.get_resource(service);

    public static spilloveraction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (spilloveraction[]) null;
      spilloveraction[] spilloveractionArray1 = new spilloveraction[name.Length];
      spilloveraction[] spilloveractionArray2 = new spilloveraction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        spilloveractionArray2[index] = new spilloveraction();
        spilloveractionArray2[index].name = name[index];
        spilloveractionArray1[index] = (spilloveraction) spilloveractionArray2[index].get_resource(service);
      }
      return spilloveractionArray1;
    }

    public static spilloveraction[] get_filtered(
      nitro_service service,
      string filter)
    {
      spilloveraction spilloveraction = new spilloveraction();
      options option = new options();
      option.set_filter(filter);
      return (spilloveraction[]) spilloveraction.getfiltered(service, option);
    }

    public static spilloveraction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      spilloveraction spilloveraction = new spilloveraction();
      options option = new options();
      option.set_filter(filter);
      return (spilloveraction[]) spilloveraction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      spilloveraction spilloveraction = new spilloveraction();
      options option = new options();
      option.set_count(true);
      spilloveraction[] resources = (spilloveraction[]) spilloveraction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      spilloveraction spilloveraction = new spilloveraction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      spilloveraction[] spilloveractionArray = (spilloveraction[]) spilloveraction.getfiltered(service, option);
      return spilloveractionArray != null && spilloveractionArray.Length > 0 ? spilloveractionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      spilloveraction spilloveraction = new spilloveraction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      spilloveraction[] spilloveractionArray = (spilloveraction[]) spilloveraction.getfiltered(service, option);
      return spilloveractionArray != null && spilloveractionArray.Length > 0 ? spilloveractionArray[0].__count.Value : 0U;
    }

    private class spilloveraction_response : base_response
    {
      public spilloveraction[] spilloveraction = (spilloveraction[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class actionEnum
    {
      public const string SPILLOVER = "SPILLOVER";
    }
  }
}
