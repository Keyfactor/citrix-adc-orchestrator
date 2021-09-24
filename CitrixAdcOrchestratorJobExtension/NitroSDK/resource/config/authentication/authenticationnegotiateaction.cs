// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationnegotiateaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationnegotiateaction : base_resource
  {
    private string nameField = (string) null;
    private string domainField = (string) null;
    private string domainuserField = (string) null;
    private string domainuserpasswdField = (string) null;
    private string ouField = (string) null;
    private string defaultauthenticationgroupField = (string) null;
    private string keytabField = (string) null;
    private string ntlmpathField = (string) null;
    private string kcdspnField = (string) null;
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

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
    }

    public string domainuser
    {
      get => this.domainuserField;
      set => this.domainuserField = value;
    }

    public string domainuserpasswd
    {
      get => this.domainuserpasswdField;
      set => this.domainuserpasswdField = value;
    }

    public string ou
    {
      get => this.ouField;
      set => this.ouField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    public string keytab
    {
      get => this.keytabField;
      set => this.keytabField = value;
    }

    public string ntlmpath
    {
      get => this.ntlmpathField;
      set => this.ntlmpathField = value;
    }

    public string kcdspn
    {
      get => this.kcdspnField;
      private set => this.kcdspnField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationnegotiateaction.authenticationnegotiateaction_response authenticationnegotiateactionResponse = new authenticationnegotiateaction.authenticationnegotiateaction_response();
      authenticationnegotiateaction.authenticationnegotiateaction_response resource = (authenticationnegotiateaction.authenticationnegotiateaction_response) service.get_payload_formatter().string_to_resource(authenticationnegotiateactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationnegotiateaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationnegotiateaction resource)
    {
      return new authenticationnegotiateaction()
      {
        name = resource.name,
        domain = resource.domain,
        domainuser = resource.domainuser,
        domainuserpasswd = resource.domainuserpasswd,
        ou = resource.ou,
        defaultauthenticationgroup = resource.defaultauthenticationgroup,
        keytab = resource.keytab,
        ntlmpath = resource.ntlmpath
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationnegotiateaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationnegotiateaction[] authenticationnegotiateactionArray = new authenticationnegotiateaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationnegotiateactionArray[index] = new authenticationnegotiateaction();
          authenticationnegotiateactionArray[index].name = resources[index].name;
          authenticationnegotiateactionArray[index].domain = resources[index].domain;
          authenticationnegotiateactionArray[index].domainuser = resources[index].domainuser;
          authenticationnegotiateactionArray[index].domainuserpasswd = resources[index].domainuserpasswd;
          authenticationnegotiateactionArray[index].ou = resources[index].ou;
          authenticationnegotiateactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationnegotiateactionArray[index].keytab = resources[index].keytab;
          authenticationnegotiateactionArray[index].ntlmpath = resources[index].ntlmpath;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationnegotiateactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationnegotiateaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationnegotiateaction resource)
    {
      return new authenticationnegotiateaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationnegotiateaction[] authenticationnegotiateactionArray = new authenticationnegotiateaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationnegotiateactionArray[index] = new authenticationnegotiateaction();
          authenticationnegotiateactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationnegotiateactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationnegotiateaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationnegotiateaction[] authenticationnegotiateactionArray = new authenticationnegotiateaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationnegotiateactionArray[index] = new authenticationnegotiateaction();
          authenticationnegotiateactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationnegotiateactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationnegotiateaction resource)
    {
      return new authenticationnegotiateaction()
      {
        name = resource.name,
        domain = resource.domain,
        domainuser = resource.domainuser,
        domainuserpasswd = resource.domainuserpasswd,
        ou = resource.ou,
        defaultauthenticationgroup = resource.defaultauthenticationgroup,
        keytab = resource.keytab,
        ntlmpath = resource.ntlmpath
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationnegotiateaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationnegotiateaction[] authenticationnegotiateactionArray = new authenticationnegotiateaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationnegotiateactionArray[index] = new authenticationnegotiateaction();
          authenticationnegotiateactionArray[index].name = resources[index].name;
          authenticationnegotiateactionArray[index].domain = resources[index].domain;
          authenticationnegotiateactionArray[index].domainuser = resources[index].domainuser;
          authenticationnegotiateactionArray[index].domainuserpasswd = resources[index].domainuserpasswd;
          authenticationnegotiateactionArray[index].ou = resources[index].ou;
          authenticationnegotiateactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationnegotiateactionArray[index].keytab = resources[index].keytab;
          authenticationnegotiateactionArray[index].ntlmpath = resources[index].ntlmpath;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationnegotiateactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationnegotiateaction()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationnegotiateaction resource,
      string[] args)
    {
      return new authenticationnegotiateaction()
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
        authenticationnegotiateaction[] authenticationnegotiateactionArray = new authenticationnegotiateaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationnegotiateactionArray[index] = new authenticationnegotiateaction();
          authenticationnegotiateactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationnegotiateactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationnegotiateaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationnegotiateaction[] authenticationnegotiateactionArray = new authenticationnegotiateaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationnegotiateactionArray[index] = new authenticationnegotiateaction();
          authenticationnegotiateactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationnegotiateactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationnegotiateaction[] get(
      nitro_service service)
    {
      return (authenticationnegotiateaction[]) new authenticationnegotiateaction().get_resources(service, (options) null);
    }

    public static authenticationnegotiateaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationnegotiateaction[]) new authenticationnegotiateaction().get_resources(service, option);
    }

    public static authenticationnegotiateaction get(
      nitro_service service,
      string name)
    {
      return (authenticationnegotiateaction) new authenticationnegotiateaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationnegotiateaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationnegotiateaction[]) null;
      authenticationnegotiateaction[] authenticationnegotiateactionArray1 = new authenticationnegotiateaction[name.Length];
      authenticationnegotiateaction[] authenticationnegotiateactionArray2 = new authenticationnegotiateaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationnegotiateactionArray2[index] = new authenticationnegotiateaction();
        authenticationnegotiateactionArray2[index].name = name[index];
        authenticationnegotiateactionArray1[index] = (authenticationnegotiateaction) authenticationnegotiateactionArray2[index].get_resource(service);
      }
      return authenticationnegotiateactionArray1;
    }

    public static authenticationnegotiateaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationnegotiateaction authenticationnegotiateaction = new authenticationnegotiateaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationnegotiateaction[]) authenticationnegotiateaction.getfiltered(service, option);
    }

    public static authenticationnegotiateaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationnegotiateaction authenticationnegotiateaction = new authenticationnegotiateaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationnegotiateaction[]) authenticationnegotiateaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationnegotiateaction authenticationnegotiateaction = new authenticationnegotiateaction();
      options option = new options();
      option.set_count(true);
      authenticationnegotiateaction[] resources = (authenticationnegotiateaction[]) authenticationnegotiateaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationnegotiateaction authenticationnegotiateaction = new authenticationnegotiateaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationnegotiateaction[] authenticationnegotiateactionArray = (authenticationnegotiateaction[]) authenticationnegotiateaction.getfiltered(service, option);
      return authenticationnegotiateactionArray != null && authenticationnegotiateactionArray.Length > 0 ? authenticationnegotiateactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationnegotiateaction authenticationnegotiateaction = new authenticationnegotiateaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationnegotiateaction[] authenticationnegotiateactionArray = (authenticationnegotiateaction[]) authenticationnegotiateaction.getfiltered(service, option);
      return authenticationnegotiateactionArray != null && authenticationnegotiateactionArray.Length > 0 ? authenticationnegotiateactionArray[0].__count.Value : 0U;
    }

    private class authenticationnegotiateaction_response : base_response
    {
      public authenticationnegotiateaction[] authenticationnegotiateaction = (authenticationnegotiateaction[]) null;
    }
  }
}
