// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformaction : base_resource
  {
    private string nameField = (string) null;
    private string profilenameField = (string) null;
    private uint? priorityField = new uint?();
    private string stateField = (string) null;
    private string requrlfromField = (string) null;
    private string requrlintoField = (string) null;
    private string resurlfromField = (string) null;
    private string resurlintoField = (string) null;
    private string cookiedomainfromField = (string) null;
    private string cookiedomainintoField = (string) null;
    private string commentField = (string) null;
    private string continuematchingField = (string) null;
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

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string requrlfrom
    {
      get => this.requrlfromField;
      set => this.requrlfromField = value;
    }

    public string requrlinto
    {
      get => this.requrlintoField;
      set => this.requrlintoField = value;
    }

    public string resurlfrom
    {
      get => this.resurlfromField;
      set => this.resurlfromField = value;
    }

    public string resurlinto
    {
      get => this.resurlintoField;
      set => this.resurlintoField = value;
    }

    public string cookiedomainfrom
    {
      get => this.cookiedomainfromField;
      set => this.cookiedomainfromField = value;
    }

    public string cookiedomaininto
    {
      get => this.cookiedomainintoField;
      set => this.cookiedomainintoField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string continuematching
    {
      get => this.continuematchingField;
      private set => this.continuematchingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformaction.transformaction_response transformactionResponse = new transformaction.transformaction_response();
      transformaction.transformaction_response resource = (transformaction.transformaction_response) service.get_payload_formatter().string_to_resource(transformactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, transformaction resource) => new transformaction()
    {
      name = resource.name,
      profilename = resource.profilename,
      priority = resource.priority,
      state = resource.state
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      transformaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformaction[] transformactionArray = new transformaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformactionArray[index] = new transformaction();
          transformactionArray[index].name = resources[index].name;
          transformactionArray[index].profilename = resources[index].profilename;
          transformactionArray[index].priority = resources[index].priority;
          transformactionArray[index].state = resources[index].state;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) transformactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new transformaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, transformaction resource) => new transformaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        transformaction[] transformactionArray = new transformaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          transformactionArray[index] = new transformaction();
          transformactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      transformaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformaction[] transformactionArray = new transformaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformactionArray[index] = new transformaction();
          transformactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, transformaction resource) => new transformaction()
    {
      name = resource.name,
      priority = resource.priority,
      requrlfrom = resource.requrlfrom,
      requrlinto = resource.requrlinto,
      resurlfrom = resource.resurlfrom,
      resurlinto = resource.resurlinto,
      cookiedomainfrom = resource.cookiedomainfrom,
      cookiedomaininto = resource.cookiedomaininto,
      state = resource.state,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      transformaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformaction[] transformactionArray = new transformaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformactionArray[index] = new transformaction();
          transformactionArray[index].name = resources[index].name;
          transformactionArray[index].priority = resources[index].priority;
          transformactionArray[index].requrlfrom = resources[index].requrlfrom;
          transformactionArray[index].requrlinto = resources[index].requrlinto;
          transformactionArray[index].resurlfrom = resources[index].resurlfrom;
          transformactionArray[index].resurlinto = resources[index].resurlinto;
          transformactionArray[index].cookiedomainfrom = resources[index].cookiedomainfrom;
          transformactionArray[index].cookiedomaininto = resources[index].cookiedomaininto;
          transformactionArray[index].state = resources[index].state;
          transformactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) transformactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new transformaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      transformaction resource,
      string[] args)
    {
      return new transformaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        transformaction[] transformactionArray = new transformaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          transformactionArray[index] = new transformaction();
          transformactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) transformactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      transformaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformaction[] transformactionArray = new transformaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformactionArray[index] = new transformaction();
          transformactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) transformactionArray, args);
      }
      return baseResponses;
    }

    public static transformaction[] get(nitro_service service) => (transformaction[]) new transformaction().get_resources(service, (options) null);

    public static transformaction[] get(nitro_service service, options option) => (transformaction[]) new transformaction().get_resources(service, option);

    public static transformaction get(nitro_service service, string name) => (transformaction) new transformaction()
    {
      name = name
    }.get_resource(service);

    public static transformaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (transformaction[]) null;
      transformaction[] transformactionArray1 = new transformaction[name.Length];
      transformaction[] transformactionArray2 = new transformaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        transformactionArray2[index] = new transformaction();
        transformactionArray2[index].name = name[index];
        transformactionArray1[index] = (transformaction) transformactionArray2[index].get_resource(service);
      }
      return transformactionArray1;
    }

    public static transformaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      transformaction transformaction = new transformaction();
      options option = new options();
      option.set_filter(filter);
      return (transformaction[]) transformaction.getfiltered(service, option);
    }

    public static transformaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      transformaction transformaction = new transformaction();
      options option = new options();
      option.set_filter(filter);
      return (transformaction[]) transformaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      transformaction transformaction = new transformaction();
      options option = new options();
      option.set_count(true);
      transformaction[] resources = (transformaction[]) transformaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      transformaction transformaction = new transformaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformaction[] transformactionArray = (transformaction[]) transformaction.getfiltered(service, option);
      return transformactionArray != null && transformactionArray.Length > 0 ? transformactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      transformaction transformaction = new transformaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformaction[] transformactionArray = (transformaction[]) transformaction.getfiltered(service, option);
      return transformactionArray != null && transformactionArray.Length > 0 ? transformactionArray[0].__count.Value : 0U;
    }

    private class transformaction_response : base_response
    {
      public transformaction[] transformaction = (transformaction[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class continuematchingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
