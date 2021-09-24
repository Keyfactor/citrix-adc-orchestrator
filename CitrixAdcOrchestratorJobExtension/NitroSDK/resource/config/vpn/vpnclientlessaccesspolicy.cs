// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnclientlessaccesspolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnclientlessaccesspolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string profilenameField = (string) null;
    private string undefactionField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private string descriptionField = (string) null;
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

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public string undefaction
    {
      get => this.undefactionField;
      private set => this.undefactionField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
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
      vpnclientlessaccesspolicy.vpnclientlessaccesspolicy_response vpnclientlessaccesspolicyResponse = new vpnclientlessaccesspolicy.vpnclientlessaccesspolicy_response();
      vpnclientlessaccesspolicy.vpnclientlessaccesspolicy_response resource = (vpnclientlessaccesspolicy.vpnclientlessaccesspolicy_response) service.get_payload_formatter().string_to_resource(vpnclientlessaccesspolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnclientlessaccesspolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      vpnclientlessaccesspolicy resource)
    {
      return new vpnclientlessaccesspolicy()
      {
        name = resource.name,
        rule = resource.rule,
        profilename = resource.profilename
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnclientlessaccesspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnclientlessaccesspolicy[] vpnclientlessaccesspolicyArray = new vpnclientlessaccesspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccesspolicyArray[index] = new vpnclientlessaccesspolicy();
          vpnclientlessaccesspolicyArray[index].name = resources[index].name;
          vpnclientlessaccesspolicyArray[index].rule = resources[index].rule;
          vpnclientlessaccesspolicyArray[index].profilename = resources[index].profilename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnclientlessaccesspolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpnclientlessaccesspolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      vpnclientlessaccesspolicy resource)
    {
      return new vpnclientlessaccesspolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnclientlessaccesspolicy[] vpnclientlessaccesspolicyArray = new vpnclientlessaccesspolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnclientlessaccesspolicyArray[index] = new vpnclientlessaccesspolicy();
          vpnclientlessaccesspolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnclientlessaccesspolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpnclientlessaccesspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnclientlessaccesspolicy[] vpnclientlessaccesspolicyArray = new vpnclientlessaccesspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccesspolicyArray[index] = new vpnclientlessaccesspolicy();
          vpnclientlessaccesspolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnclientlessaccesspolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      vpnclientlessaccesspolicy resource)
    {
      return new vpnclientlessaccesspolicy()
      {
        name = resource.name,
        rule = resource.rule,
        profilename = resource.profilename
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      vpnclientlessaccesspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnclientlessaccesspolicy[] vpnclientlessaccesspolicyArray = new vpnclientlessaccesspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccesspolicyArray[index] = new vpnclientlessaccesspolicy();
          vpnclientlessaccesspolicyArray[index].name = resources[index].name;
          vpnclientlessaccesspolicyArray[index].rule = resources[index].rule;
          vpnclientlessaccesspolicyArray[index].profilename = resources[index].profilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnclientlessaccesspolicyArray);
      }
      return baseResponses;
    }

    public static vpnclientlessaccesspolicy[] get(nitro_service service) => (vpnclientlessaccesspolicy[]) new vpnclientlessaccesspolicy().get_resources(service, (options) null);

    public static vpnclientlessaccesspolicy[] get(
      nitro_service service,
      options option)
    {
      return (vpnclientlessaccesspolicy[]) new vpnclientlessaccesspolicy().get_resources(service, option);
    }

    public static vpnclientlessaccesspolicy get(
      nitro_service service,
      string name)
    {
      return (vpnclientlessaccesspolicy) new vpnclientlessaccesspolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static vpnclientlessaccesspolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnclientlessaccesspolicy[]) null;
      vpnclientlessaccesspolicy[] vpnclientlessaccesspolicyArray1 = new vpnclientlessaccesspolicy[name.Length];
      vpnclientlessaccesspolicy[] vpnclientlessaccesspolicyArray2 = new vpnclientlessaccesspolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnclientlessaccesspolicyArray2[index] = new vpnclientlessaccesspolicy();
        vpnclientlessaccesspolicyArray2[index].name = name[index];
        vpnclientlessaccesspolicyArray1[index] = (vpnclientlessaccesspolicy) vpnclientlessaccesspolicyArray2[index].get_resource(service);
      }
      return vpnclientlessaccesspolicyArray1;
    }

    public static vpnclientlessaccesspolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnclientlessaccesspolicy vpnclientlessaccesspolicy = new vpnclientlessaccesspolicy();
      options option = new options();
      option.set_filter(filter);
      return (vpnclientlessaccesspolicy[]) vpnclientlessaccesspolicy.getfiltered(service, option);
    }

    public static vpnclientlessaccesspolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnclientlessaccesspolicy vpnclientlessaccesspolicy = new vpnclientlessaccesspolicy();
      options option = new options();
      option.set_filter(filter);
      return (vpnclientlessaccesspolicy[]) vpnclientlessaccesspolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnclientlessaccesspolicy vpnclientlessaccesspolicy = new vpnclientlessaccesspolicy();
      options option = new options();
      option.set_count(true);
      vpnclientlessaccesspolicy[] resources = (vpnclientlessaccesspolicy[]) vpnclientlessaccesspolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnclientlessaccesspolicy vpnclientlessaccesspolicy = new vpnclientlessaccesspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnclientlessaccesspolicy[] vpnclientlessaccesspolicyArray = (vpnclientlessaccesspolicy[]) vpnclientlessaccesspolicy.getfiltered(service, option);
      return vpnclientlessaccesspolicyArray != null && vpnclientlessaccesspolicyArray.Length > 0 ? vpnclientlessaccesspolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnclientlessaccesspolicy vpnclientlessaccesspolicy = new vpnclientlessaccesspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnclientlessaccesspolicy[] vpnclientlessaccesspolicyArray = (vpnclientlessaccesspolicy[]) vpnclientlessaccesspolicy.getfiltered(service, option);
      return vpnclientlessaccesspolicyArray != null && vpnclientlessaccesspolicyArray.Length > 0 ? vpnclientlessaccesspolicyArray[0].__count.Value : 0U;
    }

    private class vpnclientlessaccesspolicy_response : base_response
    {
      public vpnclientlessaccesspolicy[] vpnclientlessaccesspolicy = (vpnclientlessaccesspolicy[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
