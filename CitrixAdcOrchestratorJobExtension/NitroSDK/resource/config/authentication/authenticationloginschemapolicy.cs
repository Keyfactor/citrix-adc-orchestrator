// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationloginschemapolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string undefactionField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
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

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public string undefaction
    {
      get => this.undefactionField;
      set => this.undefactionField = value;
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

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
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
      authenticationloginschemapolicy.authenticationloginschemapolicy_response authenticationloginschemapolicyResponse = new authenticationloginschemapolicy.authenticationloginschemapolicy_response();
      authenticationloginschemapolicy.authenticationloginschemapolicy_response resource = (authenticationloginschemapolicy.authenticationloginschemapolicy_response) service.get_payload_formatter().string_to_resource(authenticationloginschemapolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationloginschemapolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationloginschemapolicy resource)
    {
      return new authenticationloginschemapolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action,
        undefaction = resource.undefaction,
        comment = resource.comment,
        logaction = resource.logaction
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationloginschemapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationloginschemapolicy[] authenticationloginschemapolicyArray = new authenticationloginschemapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemapolicyArray[index] = new authenticationloginschemapolicy();
          authenticationloginschemapolicyArray[index].name = resources[index].name;
          authenticationloginschemapolicyArray[index].rule = resources[index].rule;
          authenticationloginschemapolicyArray[index].action = resources[index].action;
          authenticationloginschemapolicyArray[index].undefaction = resources[index].undefaction;
          authenticationloginschemapolicyArray[index].comment = resources[index].comment;
          authenticationloginschemapolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationloginschemapolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationloginschemapolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationloginschemapolicy resource)
    {
      return new authenticationloginschemapolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationloginschemapolicy[] authenticationloginschemapolicyArray = new authenticationloginschemapolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationloginschemapolicyArray[index] = new authenticationloginschemapolicy();
          authenticationloginschemapolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationloginschemapolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationloginschemapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationloginschemapolicy[] authenticationloginschemapolicyArray = new authenticationloginschemapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemapolicyArray[index] = new authenticationloginschemapolicy();
          authenticationloginschemapolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationloginschemapolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationloginschemapolicy resource)
    {
      return new authenticationloginschemapolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action,
        undefaction = resource.undefaction,
        comment = resource.comment,
        logaction = resource.logaction
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationloginschemapolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationloginschemapolicy[] authenticationloginschemapolicyArray = new authenticationloginschemapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemapolicyArray[index] = new authenticationloginschemapolicy();
          authenticationloginschemapolicyArray[index].name = resources[index].name;
          authenticationloginschemapolicyArray[index].rule = resources[index].rule;
          authenticationloginschemapolicyArray[index].action = resources[index].action;
          authenticationloginschemapolicyArray[index].undefaction = resources[index].undefaction;
          authenticationloginschemapolicyArray[index].comment = resources[index].comment;
          authenticationloginschemapolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationloginschemapolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationloginschemapolicy()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationloginschemapolicy resource,
      string[] args)
    {
      return new authenticationloginschemapolicy()
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
        authenticationloginschemapolicy[] authenticationloginschemapolicyArray = new authenticationloginschemapolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationloginschemapolicyArray[index] = new authenticationloginschemapolicy();
          authenticationloginschemapolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationloginschemapolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationloginschemapolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationloginschemapolicy[] authenticationloginschemapolicyArray = new authenticationloginschemapolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemapolicyArray[index] = new authenticationloginschemapolicy();
          authenticationloginschemapolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationloginschemapolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      authenticationloginschemapolicy resource,
      string new_name)
    {
      return new authenticationloginschemapolicy()
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
      return new authenticationloginschemapolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static authenticationloginschemapolicy[] get(
      nitro_service service)
    {
      return (authenticationloginschemapolicy[]) new authenticationloginschemapolicy().get_resources(service, (options) null);
    }

    public static authenticationloginschemapolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationloginschemapolicy[]) new authenticationloginschemapolicy().get_resources(service, option);
    }

    public static authenticationloginschemapolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationloginschemapolicy) new authenticationloginschemapolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationloginschemapolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationloginschemapolicy[]) null;
      authenticationloginschemapolicy[] authenticationloginschemapolicyArray1 = new authenticationloginschemapolicy[name.Length];
      authenticationloginschemapolicy[] authenticationloginschemapolicyArray2 = new authenticationloginschemapolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationloginschemapolicyArray2[index] = new authenticationloginschemapolicy();
        authenticationloginschemapolicyArray2[index].name = name[index];
        authenticationloginschemapolicyArray1[index] = (authenticationloginschemapolicy) authenticationloginschemapolicyArray2[index].get_resource(service);
      }
      return authenticationloginschemapolicyArray1;
    }

    public static authenticationloginschemapolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationloginschemapolicy authenticationloginschemapolicy = new authenticationloginschemapolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationloginschemapolicy[]) authenticationloginschemapolicy.getfiltered(service, option);
    }

    public static authenticationloginschemapolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationloginschemapolicy authenticationloginschemapolicy = new authenticationloginschemapolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationloginschemapolicy[]) authenticationloginschemapolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationloginschemapolicy authenticationloginschemapolicy = new authenticationloginschemapolicy();
      options option = new options();
      option.set_count(true);
      authenticationloginschemapolicy[] resources = (authenticationloginschemapolicy[]) authenticationloginschemapolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationloginschemapolicy authenticationloginschemapolicy = new authenticationloginschemapolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationloginschemapolicy[] authenticationloginschemapolicyArray = (authenticationloginschemapolicy[]) authenticationloginschemapolicy.getfiltered(service, option);
      return authenticationloginschemapolicyArray != null && authenticationloginschemapolicyArray.Length > 0 ? authenticationloginschemapolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationloginschemapolicy authenticationloginschemapolicy = new authenticationloginschemapolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationloginschemapolicy[] authenticationloginschemapolicyArray = (authenticationloginschemapolicy[]) authenticationloginschemapolicy.getfiltered(service, option);
      return authenticationloginschemapolicyArray != null && authenticationloginschemapolicyArray.Length > 0 ? authenticationloginschemapolicyArray[0].__count.Value : 0U;
    }

    private class authenticationloginschemapolicy_response : base_response
    {
      public authenticationloginschemapolicy[] authenticationloginschemapolicy = (authenticationloginschemapolicy[]) null;
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
