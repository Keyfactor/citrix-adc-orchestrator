// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string undefactionField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private string descriptionField = (string) null;
    private string policysubtypeField = (string) null;
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

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    public string policysubtype
    {
      get => this.policysubtypeField;
      private set => this.policysubtypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationpolicy.authenticationpolicy_response authenticationpolicyResponse = new authenticationpolicy.authenticationpolicy_response();
      authenticationpolicy.authenticationpolicy_response resource = (authenticationpolicy.authenticationpolicy_response) service.get_payload_formatter().string_to_resource(authenticationpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationpolicy resource)
    {
      return new authenticationpolicy()
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
      authenticationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationpolicy[] authenticationpolicyArray = new authenticationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationpolicyArray[index] = new authenticationpolicy();
          authenticationpolicyArray[index].name = resources[index].name;
          authenticationpolicyArray[index].rule = resources[index].rule;
          authenticationpolicyArray[index].action = resources[index].action;
          authenticationpolicyArray[index].undefaction = resources[index].undefaction;
          authenticationpolicyArray[index].comment = resources[index].comment;
          authenticationpolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationpolicy resource)
    {
      return new authenticationpolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationpolicy[] authenticationpolicyArray = new authenticationpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationpolicyArray[index] = new authenticationpolicy();
          authenticationpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationpolicy[] authenticationpolicyArray = new authenticationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationpolicyArray[index] = new authenticationpolicy();
          authenticationpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationpolicy resource)
    {
      return new authenticationpolicy()
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
      authenticationpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationpolicy[] authenticationpolicyArray = new authenticationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationpolicyArray[index] = new authenticationpolicy();
          authenticationpolicyArray[index].name = resources[index].name;
          authenticationpolicyArray[index].rule = resources[index].rule;
          authenticationpolicyArray[index].action = resources[index].action;
          authenticationpolicyArray[index].undefaction = resources[index].undefaction;
          authenticationpolicyArray[index].comment = resources[index].comment;
          authenticationpolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationpolicy resource,
      string[] args)
    {
      return new authenticationpolicy()
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
        authenticationpolicy[] authenticationpolicyArray = new authenticationpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationpolicyArray[index] = new authenticationpolicy();
          authenticationpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationpolicy[] authenticationpolicyArray = new authenticationpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationpolicyArray[index] = new authenticationpolicy();
          authenticationpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      authenticationpolicy resource,
      string new_name)
    {
      return new authenticationpolicy()
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
      return new authenticationpolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static authenticationpolicy[] get(nitro_service service) => (authenticationpolicy[]) new authenticationpolicy().get_resources(service, (options) null);

    public static authenticationpolicy[] get(
      nitro_service service,
      options option)
    {
      return (authenticationpolicy[]) new authenticationpolicy().get_resources(service, option);
    }

    public static authenticationpolicy get(nitro_service service, string name) => (authenticationpolicy) new authenticationpolicy()
    {
      name = name
    }.get_resource(service);

    public static authenticationpolicy[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationpolicy[]) null;
      authenticationpolicy[] authenticationpolicyArray1 = new authenticationpolicy[name.Length];
      authenticationpolicy[] authenticationpolicyArray2 = new authenticationpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationpolicyArray2[index] = new authenticationpolicy();
        authenticationpolicyArray2[index].name = name[index];
        authenticationpolicyArray1[index] = (authenticationpolicy) authenticationpolicyArray2[index].get_resource(service);
      }
      return authenticationpolicyArray1;
    }

    public static authenticationpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationpolicy authenticationpolicy = new authenticationpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationpolicy[]) authenticationpolicy.getfiltered(service, option);
    }

    public static authenticationpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationpolicy authenticationpolicy = new authenticationpolicy();
      options option = new options();
      option.set_filter(filter);
      return (authenticationpolicy[]) authenticationpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationpolicy authenticationpolicy = new authenticationpolicy();
      options option = new options();
      option.set_count(true);
      authenticationpolicy[] resources = (authenticationpolicy[]) authenticationpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationpolicy authenticationpolicy = new authenticationpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationpolicy[] authenticationpolicyArray = (authenticationpolicy[]) authenticationpolicy.getfiltered(service, option);
      return authenticationpolicyArray != null && authenticationpolicyArray.Length > 0 ? authenticationpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationpolicy authenticationpolicy = new authenticationpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationpolicy[] authenticationpolicyArray = (authenticationpolicy[]) authenticationpolicy.getfiltered(service, option);
      return authenticationpolicyArray != null && authenticationpolicyArray.Length > 0 ? authenticationpolicyArray[0].__count.Value : 0U;
    }

    private class authenticationpolicy_response : base_response
    {
      public authenticationpolicy[] authenticationpolicy = (authenticationpolicy[]) null;
    }

    public static class policysubtypeEnum
    {
      public const string LOCAL = "LOCAL";
      public const string RADIUS = "RADIUS";
      public const string LDAP = "LDAP";
      public const string TACACS = "TACACS";
      public const string CERT = "CERT";
      public const string NEGOTIATE = "NEGOTIATE";
      public const string SAML = "SAML";
      public const string PROFILE = "PROFILE";
      public const string DFA = "DFA";
      public const string SAMLIDP = "SAMLIDP";
      public const string WEBAUTH = "WEBAUTH";
      public const string OAUTH = "OAUTH";
      public const string NO_AUTHN = "NO_AUTHN";
    }
  }
}
