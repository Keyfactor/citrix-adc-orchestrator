// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string profilenameField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private bool? isdefaultField = new bool?();
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

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string logaction
    {
      get => this.logactionField;
      set => this.logactionField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformpolicy.transformpolicy_response transformpolicyResponse = new transformpolicy.transformpolicy_response();
      transformpolicy.transformpolicy_response resource = (transformpolicy.transformpolicy_response) service.get_payload_formatter().string_to_resource(transformpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, transformpolicy resource) => new transformpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      profilename = resource.profilename,
      comment = resource.comment,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      transformpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformpolicy[] transformpolicyArray = new transformpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformpolicyArray[index] = new transformpolicy();
          transformpolicyArray[index].name = resources[index].name;
          transformpolicyArray[index].rule = resources[index].rule;
          transformpolicyArray[index].profilename = resources[index].profilename;
          transformpolicyArray[index].comment = resources[index].comment;
          transformpolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) transformpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new transformpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, transformpolicy resource) => new transformpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        transformpolicy[] transformpolicyArray = new transformpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          transformpolicyArray[index] = new transformpolicy();
          transformpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      transformpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformpolicy[] transformpolicyArray = new transformpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformpolicyArray[index] = new transformpolicy();
          transformpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, transformpolicy resource) => new transformpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      profilename = resource.profilename,
      comment = resource.comment,
      logaction = resource.logaction
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      transformpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformpolicy[] transformpolicyArray = new transformpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformpolicyArray[index] = new transformpolicy();
          transformpolicyArray[index].name = resources[index].name;
          transformpolicyArray[index].rule = resources[index].rule;
          transformpolicyArray[index].profilename = resources[index].profilename;
          transformpolicyArray[index].comment = resources[index].comment;
          transformpolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) transformpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new transformpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      transformpolicy resource,
      string[] args)
    {
      return new transformpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        transformpolicy[] transformpolicyArray = new transformpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          transformpolicyArray[index] = new transformpolicy();
          transformpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) transformpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      transformpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformpolicy[] transformpolicyArray = new transformpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformpolicyArray[index] = new transformpolicy();
          transformpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) transformpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      transformpolicy resource,
      string new_name)
    {
      return new transformpolicy()
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
      return new transformpolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static transformpolicy[] get(nitro_service service) => (transformpolicy[]) new transformpolicy().get_resources(service, (options) null);

    public static transformpolicy[] get(nitro_service service, options option) => (transformpolicy[]) new transformpolicy().get_resources(service, option);

    public static transformpolicy get(nitro_service service, string name) => (transformpolicy) new transformpolicy()
    {
      name = name
    }.get_resource(service);

    public static transformpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (transformpolicy[]) null;
      transformpolicy[] transformpolicyArray1 = new transformpolicy[name.Length];
      transformpolicy[] transformpolicyArray2 = new transformpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        transformpolicyArray2[index] = new transformpolicy();
        transformpolicyArray2[index].name = name[index];
        transformpolicyArray1[index] = (transformpolicy) transformpolicyArray2[index].get_resource(service);
      }
      return transformpolicyArray1;
    }

    public static transformpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      transformpolicy transformpolicy = new transformpolicy();
      options option = new options();
      option.set_filter(filter);
      return (transformpolicy[]) transformpolicy.getfiltered(service, option);
    }

    public static transformpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      transformpolicy transformpolicy = new transformpolicy();
      options option = new options();
      option.set_filter(filter);
      return (transformpolicy[]) transformpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      transformpolicy transformpolicy = new transformpolicy();
      options option = new options();
      option.set_count(true);
      transformpolicy[] resources = (transformpolicy[]) transformpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      transformpolicy transformpolicy = new transformpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformpolicy[] transformpolicyArray = (transformpolicy[]) transformpolicy.getfiltered(service, option);
      return transformpolicyArray != null && transformpolicyArray.Length > 0 ? transformpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      transformpolicy transformpolicy = new transformpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformpolicy[] transformpolicyArray = (transformpolicy[]) transformpolicy.getfiltered(service, option);
      return transformpolicyArray != null && transformpolicyArray.Length > 0 ? transformpolicyArray[0].__count.Value : 0U;
    }

    private class transformpolicy_response : base_response
    {
      public transformpolicy[] transformpolicy = (transformpolicy[]) null;
    }
  }
}
