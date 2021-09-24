// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidppolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationsamlidppolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string undefactionField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private long? hitsField = new long?();
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

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationsamlidppolicy.authenticationsamlidppolicy_response authenticationsamlidppolicyResponse = new authenticationsamlidppolicy.authenticationsamlidppolicy_response();
      authenticationsamlidppolicy.authenticationsamlidppolicy_response resource = (authenticationsamlidppolicy.authenticationsamlidppolicy_response) service.get_payload_formatter().string_to_resource(authenticationsamlidppolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationsamlidppolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationsamlidppolicy resource)
    {
      return new authenticationsamlidppolicy()
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
      authenticationsamlidppolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlidppolicy[] authenticationsamlidppolicyArray = new authenticationsamlidppolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlidppolicyArray[index] = new authenticationsamlidppolicy();
          authenticationsamlidppolicyArray[index].name = resources[index].name;
          authenticationsamlidppolicyArray[index].rule = resources[index].rule;
          authenticationsamlidppolicyArray[index].action = resources[index].action;
          authenticationsamlidppolicyArray[index].undefaction = resources[index].undefaction;
          authenticationsamlidppolicyArray[index].comment = resources[index].comment;
          authenticationsamlidppolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationsamlidppolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationsamlidppolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationsamlidppolicy resource)
    {
      return new authenticationsamlidppolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationsamlidppolicy[] authenticationsamlidppolicyArray = new authenticationsamlidppolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationsamlidppolicyArray[index] = new authenticationsamlidppolicy();
          authenticationsamlidppolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationsamlidppolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationsamlidppolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlidppolicy[] authenticationsamlidppolicyArray = new authenticationsamlidppolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlidppolicyArray[index] = new authenticationsamlidppolicy();
          authenticationsamlidppolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationsamlidppolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationsamlidppolicy resource)
    {
      return new authenticationsamlidppolicy()
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
      authenticationsamlidppolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlidppolicy[] authenticationsamlidppolicyArray = new authenticationsamlidppolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlidppolicyArray[index] = new authenticationsamlidppolicy();
          authenticationsamlidppolicyArray[index].name = resources[index].name;
          authenticationsamlidppolicyArray[index].rule = resources[index].rule;
          authenticationsamlidppolicyArray[index].action = resources[index].action;
          authenticationsamlidppolicyArray[index].undefaction = resources[index].undefaction;
          authenticationsamlidppolicyArray[index].comment = resources[index].comment;
          authenticationsamlidppolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationsamlidppolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationsamlidppolicy()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationsamlidppolicy resource,
      string[] args)
    {
      return new authenticationsamlidppolicy()
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
        authenticationsamlidppolicy[] authenticationsamlidppolicyArray = new authenticationsamlidppolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationsamlidppolicyArray[index] = new authenticationsamlidppolicy();
          authenticationsamlidppolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationsamlidppolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationsamlidppolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationsamlidppolicy[] authenticationsamlidppolicyArray = new authenticationsamlidppolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationsamlidppolicyArray[index] = new authenticationsamlidppolicy();
          authenticationsamlidppolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationsamlidppolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      authenticationsamlidppolicy resource,
      string new_name)
    {
      return new authenticationsamlidppolicy()
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
      return new authenticationsamlidppolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static authenticationsamlidppolicy[] get(nitro_service service) => (authenticationsamlidppolicy[]) new authenticationsamlidppolicy().get_resources(service, (options) null);

    public static authenticationsamlidppolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationsamlidppolicy[]) new authenticationsamlidppolicy().get_resources(service, option);
    }

    public static authenticationsamlidppolicy get(
      nitro_service service,
      string name)
    {
      return (authenticationsamlidppolicy) new authenticationsamlidppolicy()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationsamlidppolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationsamlidppolicy[]) null;
      authenticationsamlidppolicy[] authenticationsamlidppolicyArray1 = new authenticationsamlidppolicy[name.Length];
      authenticationsamlidppolicy[] authenticationsamlidppolicyArray2 = new authenticationsamlidppolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationsamlidppolicyArray2[index] = new authenticationsamlidppolicy();
        authenticationsamlidppolicyArray2[index].name = name[index];
        authenticationsamlidppolicyArray1[index] = (authenticationsamlidppolicy) authenticationsamlidppolicyArray2[index].get_resource(service);
      }
      return authenticationsamlidppolicyArray1;
    }

    public static authenticationsamlidppolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationsamlidppolicy authenticationsamlidppolicy = new authenticationsamlidppolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationsamlidppolicy[]) authenticationsamlidppolicy.getfiltered(service, option);
    }

    public static authenticationsamlidppolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationsamlidppolicy authenticationsamlidppolicy = new authenticationsamlidppolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationsamlidppolicy[]) authenticationsamlidppolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationsamlidppolicy authenticationsamlidppolicy = new authenticationsamlidppolicy();
      options option = new options();
      option.set_count(true);
      authenticationsamlidppolicy[] resources = (authenticationsamlidppolicy[]) authenticationsamlidppolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationsamlidppolicy authenticationsamlidppolicy = new authenticationsamlidppolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationsamlidppolicy[] authenticationsamlidppolicyArray = (authenticationsamlidppolicy[]) authenticationsamlidppolicy.getfiltered(service, option);
      return authenticationsamlidppolicyArray != null && authenticationsamlidppolicyArray.Length > 0 ? authenticationsamlidppolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationsamlidppolicy authenticationsamlidppolicy = new authenticationsamlidppolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationsamlidppolicy[] authenticationsamlidppolicyArray = (authenticationsamlidppolicy[]) authenticationsamlidppolicy.getfiltered(service, option);
      return authenticationsamlidppolicyArray != null && authenticationsamlidppolicyArray.Length > 0 ? authenticationsamlidppolicyArray[0].__count.Value : 0U;
    }

    private class authenticationsamlidppolicy_response : base_response
    {
      public authenticationsamlidppolicy[] authenticationsamlidppolicy = (authenticationsamlidppolicy[]) null;
    }
  }
}
