// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filteraction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filteraction : base_resource
  {
    private string nameField = (string) null;
    private string qualField = (string) null;
    private string servicenameField = (string) null;
    private string valueField = (string) null;
    private uint? respcodeField = new uint?();
    private string pageField = (string) null;
    private bool? isdefaultField = new bool?();
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

    public string qual
    {
      get => this.qualField;
      set => this.qualField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string value
    {
      get => this.valueField;
      set => this.valueField = value;
    }

    public uint? respcode
    {
      get => this.respcodeField;
      set => this.respcodeField = value;
    }

    public string page
    {
      get => this.pageField;
      set => this.pageField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
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
      filteraction.filteraction_response filteractionResponse = new filteraction.filteraction_response();
      filteraction.filteraction_response resource = (filteraction.filteraction_response) service.get_payload_formatter().string_to_resource(filteractionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.filteraction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, filteraction resource) => new filteraction()
    {
      name = resource.name,
      qual = resource.qual,
      servicename = resource.servicename,
      value = resource.value,
      respcode = resource.respcode,
      page = resource.page
    }.add_resource(client);

    public static base_responses add(nitro_service client, filteraction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filteraction[] filteractionArray = new filteraction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filteractionArray[index] = new filteraction();
          filteractionArray[index].name = resources[index].name;
          filteractionArray[index].qual = resources[index].qual;
          filteractionArray[index].servicename = resources[index].servicename;
          filteractionArray[index].value = resources[index].value;
          filteractionArray[index].respcode = resources[index].respcode;
          filteractionArray[index].page = resources[index].page;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) filteractionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new filteraction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, filteraction resource) => new filteraction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        filteraction[] filteractionArray = new filteraction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          filteractionArray[index] = new filteraction();
          filteractionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) filteractionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      filteraction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filteraction[] filteractionArray = new filteraction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filteractionArray[index] = new filteraction();
          filteractionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) filteractionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, filteraction resource) => new filteraction()
    {
      name = resource.name,
      servicename = resource.servicename,
      value = resource.value,
      respcode = resource.respcode,
      page = resource.page
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      filteraction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filteraction[] filteractionArray = new filteraction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filteractionArray[index] = new filteraction();
          filteractionArray[index].name = resources[index].name;
          filteractionArray[index].servicename = resources[index].servicename;
          filteractionArray[index].value = resources[index].value;
          filteractionArray[index].respcode = resources[index].respcode;
          filteractionArray[index].page = resources[index].page;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) filteractionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new filteraction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      filteraction resource,
      string[] args)
    {
      return new filteraction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        filteraction[] filteractionArray = new filteraction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          filteractionArray[index] = new filteraction();
          filteractionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) filteractionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      filteraction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filteraction[] filteractionArray = new filteraction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filteractionArray[index] = new filteraction();
          filteractionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) filteractionArray, args);
      }
      return baseResponses;
    }

    public static filteraction[] get(nitro_service service) => (filteraction[]) new filteraction().get_resources(service, (options) null);

    public static filteraction[] get(nitro_service service, options option) => (filteraction[]) new filteraction().get_resources(service, option);

    public static filteraction get(nitro_service service, string name) => (filteraction) new filteraction()
    {
      name = name
    }.get_resource(service);

    public static filteraction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (filteraction[]) null;
      filteraction[] filteractionArray1 = new filteraction[name.Length];
      filteraction[] filteractionArray2 = new filteraction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        filteractionArray2[index] = new filteraction();
        filteractionArray2[index].name = name[index];
        filteractionArray1[index] = (filteraction) filteractionArray2[index].get_resource(service);
      }
      return filteractionArray1;
    }

    public static filteraction[] get_filtered(nitro_service service, string filter)
    {
      filteraction filteraction = new filteraction();
      options option = new options();
      option.set_filter(filter);
      return (filteraction[]) filteraction.getfiltered(service, option);
    }

    public static filteraction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      filteraction filteraction = new filteraction();
      options option = new options();
      option.set_filter(filter);
      return (filteraction[]) filteraction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      filteraction filteraction = new filteraction();
      options option = new options();
      option.set_count(true);
      filteraction[] resources = (filteraction[]) filteraction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      filteraction filteraction = new filteraction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      filteraction[] filteractionArray = (filteraction[]) filteraction.getfiltered(service, option);
      return filteractionArray != null && filteractionArray.Length > 0 ? filteractionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      filteraction filteraction = new filteraction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      filteraction[] filteractionArray = (filteraction[]) filteraction.getfiltered(service, option);
      return filteractionArray != null && filteractionArray.Length > 0 ? filteractionArray[0].__count.Value : 0U;
    }

    private class filteraction_response : base_response
    {
      public filteraction[] filteraction = (filteraction[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class qualEnum
    {
      public const string reset = "reset";
      public const string Add = "add";
      public const string corrupt = "corrupt";
      public const string forward = "forward";
      public const string errorcode = "errorcode";
      public const string drop = "drop";
    }
  }
}
