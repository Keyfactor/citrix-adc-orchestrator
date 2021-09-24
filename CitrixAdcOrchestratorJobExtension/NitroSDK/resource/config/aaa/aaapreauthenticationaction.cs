// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaapreauthenticationaction : base_resource
  {
    private string nameField = (string) null;
    private string preauthenticationactionField = (string) null;
    private string killprocessField = (string) null;
    private string deletefilesField = (string) null;
    private string defaultepagroupField = (string) null;
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

    public string preauthenticationaction
    {
      get => this.preauthenticationactionField;
      set => this.preauthenticationactionField = value;
    }

    public string killprocess
    {
      get => this.killprocessField;
      set => this.killprocessField = value;
    }

    public string deletefiles
    {
      get => this.deletefilesField;
      set => this.deletefilesField = value;
    }

    public string defaultepagroup
    {
      get => this.defaultepagroupField;
      set => this.defaultepagroupField = value;
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
      aaapreauthenticationaction.aaapreauthenticationaction_response aaapreauthenticationactionResponse = new aaapreauthenticationaction.aaapreauthenticationaction_response();
      aaapreauthenticationaction.aaapreauthenticationaction_response resource = (aaapreauthenticationaction.aaapreauthenticationaction_response) service.get_payload_formatter().string_to_resource(aaapreauthenticationactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaapreauthenticationaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      aaapreauthenticationaction resource)
    {
      return new aaapreauthenticationaction()
      {
        name = resource.name,
        preauthenticationaction = resource.preauthenticationaction,
        killprocess = resource.killprocess,
        deletefiles = resource.deletefiles,
        defaultepagroup = resource.defaultepagroup
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaapreauthenticationaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaapreauthenticationaction[] aaapreauthenticationactionArray = new aaapreauthenticationaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationactionArray[index] = new aaapreauthenticationaction();
          aaapreauthenticationactionArray[index].name = resources[index].name;
          aaapreauthenticationactionArray[index].preauthenticationaction = resources[index].preauthenticationaction;
          aaapreauthenticationactionArray[index].killprocess = resources[index].killprocess;
          aaapreauthenticationactionArray[index].deletefiles = resources[index].deletefiles;
          aaapreauthenticationactionArray[index].defaultepagroup = resources[index].defaultepagroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) aaapreauthenticationactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new aaapreauthenticationaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      aaapreauthenticationaction resource)
    {
      return new aaapreauthenticationaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        aaapreauthenticationaction[] aaapreauthenticationactionArray = new aaapreauthenticationaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          aaapreauthenticationactionArray[index] = new aaapreauthenticationaction();
          aaapreauthenticationactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaapreauthenticationactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      aaapreauthenticationaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaapreauthenticationaction[] aaapreauthenticationactionArray = new aaapreauthenticationaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationactionArray[index] = new aaapreauthenticationaction();
          aaapreauthenticationactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaapreauthenticationactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      aaapreauthenticationaction resource)
    {
      return new aaapreauthenticationaction()
      {
        name = resource.name,
        preauthenticationaction = resource.preauthenticationaction,
        killprocess = resource.killprocess,
        deletefiles = resource.deletefiles,
        defaultepagroup = resource.defaultepagroup
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      aaapreauthenticationaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaapreauthenticationaction[] aaapreauthenticationactionArray = new aaapreauthenticationaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationactionArray[index] = new aaapreauthenticationaction();
          aaapreauthenticationactionArray[index].name = resources[index].name;
          aaapreauthenticationactionArray[index].preauthenticationaction = resources[index].preauthenticationaction;
          aaapreauthenticationactionArray[index].killprocess = resources[index].killprocess;
          aaapreauthenticationactionArray[index].deletefiles = resources[index].deletefiles;
          aaapreauthenticationactionArray[index].defaultepagroup = resources[index].defaultepagroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) aaapreauthenticationactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new aaapreauthenticationaction()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      aaapreauthenticationaction resource,
      string[] args)
    {
      return new aaapreauthenticationaction()
      {
        name = resource.name
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        aaapreauthenticationaction[] aaapreauthenticationactionArray = new aaapreauthenticationaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          aaapreauthenticationactionArray[index] = new aaapreauthenticationaction();
          aaapreauthenticationactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) aaapreauthenticationactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      aaapreauthenticationaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaapreauthenticationaction[] aaapreauthenticationactionArray = new aaapreauthenticationaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationactionArray[index] = new aaapreauthenticationaction();
          aaapreauthenticationactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) aaapreauthenticationactionArray, args);
      }
      return baseResponses;
    }

    public static aaapreauthenticationaction[] get(nitro_service service) => (aaapreauthenticationaction[]) new aaapreauthenticationaction().get_resources(service, (options) null);

    public static aaapreauthenticationaction[] get(
      nitro_service service,
      options option)
    {
      return (aaapreauthenticationaction[]) new aaapreauthenticationaction().get_resources(service, option);
    }

    public static aaapreauthenticationaction get(
      nitro_service service,
      string name)
    {
      return (aaapreauthenticationaction) new aaapreauthenticationaction()
      {
        name = name
      }.get_resource(service);
    }

    public static aaapreauthenticationaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (aaapreauthenticationaction[]) null;
      aaapreauthenticationaction[] aaapreauthenticationactionArray1 = new aaapreauthenticationaction[name.Length];
      aaapreauthenticationaction[] aaapreauthenticationactionArray2 = new aaapreauthenticationaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        aaapreauthenticationactionArray2[index] = new aaapreauthenticationaction();
        aaapreauthenticationactionArray2[index].name = name[index];
        aaapreauthenticationactionArray1[index] = (aaapreauthenticationaction) aaapreauthenticationactionArray2[index].get_resource(service);
      }
      return aaapreauthenticationactionArray1;
    }

    public static aaapreauthenticationaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      aaapreauthenticationaction aaapreauthenticationaction = new aaapreauthenticationaction();
      options option = new options();
      option.set_filter(filter);
      return (aaapreauthenticationaction[]) aaapreauthenticationaction.getfiltered(service, option);
    }

    public static aaapreauthenticationaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      aaapreauthenticationaction aaapreauthenticationaction = new aaapreauthenticationaction();
      options option = new options();
      option.set_filter(filter);
      return (aaapreauthenticationaction[]) aaapreauthenticationaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      aaapreauthenticationaction aaapreauthenticationaction = new aaapreauthenticationaction();
      options option = new options();
      option.set_count(true);
      aaapreauthenticationaction[] resources = (aaapreauthenticationaction[]) aaapreauthenticationaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      aaapreauthenticationaction aaapreauthenticationaction = new aaapreauthenticationaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaapreauthenticationaction[] aaapreauthenticationactionArray = (aaapreauthenticationaction[]) aaapreauthenticationaction.getfiltered(service, option);
      return aaapreauthenticationactionArray != null && aaapreauthenticationactionArray.Length > 0 ? aaapreauthenticationactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      aaapreauthenticationaction aaapreauthenticationaction = new aaapreauthenticationaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaapreauthenticationaction[] aaapreauthenticationactionArray = (aaapreauthenticationaction[]) aaapreauthenticationaction.getfiltered(service, option);
      return aaapreauthenticationactionArray != null && aaapreauthenticationactionArray.Length > 0 ? aaapreauthenticationactionArray[0].__count.Value : 0U;
    }

    private class aaapreauthenticationaction_response : base_response
    {
      public aaapreauthenticationaction[] aaapreauthenticationaction = (aaapreauthenticationaction[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class preauthenticationactionEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
    }
  }
}
