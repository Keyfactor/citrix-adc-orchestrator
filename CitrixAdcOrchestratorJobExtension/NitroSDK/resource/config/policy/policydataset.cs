// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policydataset
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policydataset : base_resource
  {
    private string nameField = (string) null;
    private string typeField = (string) null;
    private string indextypeField = (string) null;
    private string commentField = (string) null;
    private string descriptionField = (string) null;
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

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string indextype
    {
      get => this.indextypeField;
      set => this.indextypeField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policydataset.policydataset_response policydatasetResponse = new policydataset.policydataset_response();
      policydataset.policydataset_response resource = (policydataset.policydataset_response) service.get_payload_formatter().string_to_resource(policydatasetResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policydataset;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, policydataset resource) => new policydataset()
    {
      name = resource.name,
      type = resource.type,
      indextype = resource.indextype,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, policydataset[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policydataset[] policydatasetArray = new policydataset[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policydatasetArray[index] = new policydataset();
          policydatasetArray[index].name = resources[index].name;
          policydatasetArray[index].type = resources[index].type;
          policydatasetArray[index].indextype = resources[index].indextype;
          policydatasetArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) policydatasetArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new policydataset()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, policydataset resource) => new policydataset()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        policydataset[] policydatasetArray = new policydataset[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          policydatasetArray[index] = new policydataset();
          policydatasetArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policydatasetArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      policydataset[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policydataset[] policydatasetArray = new policydataset[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policydatasetArray[index] = new policydataset();
          policydatasetArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policydatasetArray);
      }
      return baseResponses;
    }

    public static policydataset[] get(nitro_service service) => (policydataset[]) new policydataset().get_resources(service, (options) null);

    public static policydataset[] get(nitro_service service, options option) => (policydataset[]) new policydataset().get_resources(service, option);

    public static policydataset get(nitro_service service, string name) => (policydataset) new policydataset()
    {
      name = name
    }.get_resource(service);

    public static policydataset[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (policydataset[]) null;
      policydataset[] policydatasetArray1 = new policydataset[name.Length];
      policydataset[] policydatasetArray2 = new policydataset[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        policydatasetArray2[index] = new policydataset();
        policydatasetArray2[index].name = name[index];
        policydatasetArray1[index] = (policydataset) policydatasetArray2[index].get_resource(service);
      }
      return policydatasetArray1;
    }

    public static policydataset[] get_filtered(nitro_service service, string filter)
    {
      policydataset policydataset = new policydataset();
      options option = new options();
      option.set_filter(filter);
      return (policydataset[]) policydataset.getfiltered(service, option);
    }

    public static policydataset[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      policydataset policydataset = new policydataset();
      options option = new options();
      option.set_filter(filter);
      return (policydataset[]) policydataset.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      policydataset policydataset = new policydataset();
      options option = new options();
      option.set_count(true);
      policydataset[] resources = (policydataset[]) policydataset.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      policydataset policydataset = new policydataset();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policydataset[] policydatasetArray = (policydataset[]) policydataset.getfiltered(service, option);
      return policydatasetArray != null && policydatasetArray.Length > 0 ? policydatasetArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      policydataset policydataset = new policydataset();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policydataset[] policydatasetArray = (policydataset[]) policydataset.getfiltered(service, option);
      return policydatasetArray != null && policydatasetArray.Length > 0 ? policydatasetArray[0].__count.Value : 0U;
    }

    private class policydataset_response : base_response
    {
      public policydataset[] policydataset = (policydataset[]) null;
    }

    public static class typeEnum
    {
      public const string ipv4 = "ipv4";
      public const string number = "number";
      public const string ipv6 = "ipv6";
      public const string Ulong = "ulong";
      public const string Double = "double";
      public const string mac = "mac";
    }

    public static class indextypeEnum
    {
      public const string Auto_generated = "Auto-generated";
      public const string User_defined = "User-defined";
    }
  }
}
