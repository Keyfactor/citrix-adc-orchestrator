// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationcertaction : base_resource
  {
    private string nameField = (string) null;
    private string twofactorField = (string) null;
    private string usernamefieldField = (string) null;
    private string groupnamefieldField = (string) null;
    private string defaultauthenticationgroupField = (string) null;
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

    public string twofactor
    {
      get => this.twofactorField;
      set => this.twofactorField = value;
    }

    public string usernamefield
    {
      get => this.usernamefieldField;
      set => this.usernamefieldField = value;
    }

    public string groupnamefield
    {
      get => this.groupnamefieldField;
      set => this.groupnamefieldField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationcertaction.authenticationcertaction_response authenticationcertactionResponse = new authenticationcertaction.authenticationcertaction_response();
      authenticationcertaction.authenticationcertaction_response resource = (authenticationcertaction.authenticationcertaction_response) service.get_payload_formatter().string_to_resource(authenticationcertactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationcertaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationcertaction resource)
    {
      return new authenticationcertaction()
      {
        name = resource.name,
        twofactor = resource.twofactor,
        usernamefield = resource.usernamefield,
        groupnamefield = resource.groupnamefield,
        defaultauthenticationgroup = resource.defaultauthenticationgroup
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationcertaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationcertaction[] authenticationcertactionArray = new authenticationcertaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationcertactionArray[index] = new authenticationcertaction();
          authenticationcertactionArray[index].name = resources[index].name;
          authenticationcertactionArray[index].twofactor = resources[index].twofactor;
          authenticationcertactionArray[index].usernamefield = resources[index].usernamefield;
          authenticationcertactionArray[index].groupnamefield = resources[index].groupnamefield;
          authenticationcertactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationcertactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationcertaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationcertaction resource)
    {
      return new authenticationcertaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationcertaction[] authenticationcertactionArray = new authenticationcertaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationcertactionArray[index] = new authenticationcertaction();
          authenticationcertactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationcertactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationcertaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationcertaction[] authenticationcertactionArray = new authenticationcertaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationcertactionArray[index] = new authenticationcertaction();
          authenticationcertactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationcertactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationcertaction resource)
    {
      return new authenticationcertaction()
      {
        name = resource.name,
        twofactor = resource.twofactor,
        usernamefield = resource.usernamefield,
        groupnamefield = resource.groupnamefield,
        defaultauthenticationgroup = resource.defaultauthenticationgroup
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationcertaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationcertaction[] authenticationcertactionArray = new authenticationcertaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationcertactionArray[index] = new authenticationcertaction();
          authenticationcertactionArray[index].name = resources[index].name;
          authenticationcertactionArray[index].twofactor = resources[index].twofactor;
          authenticationcertactionArray[index].usernamefield = resources[index].usernamefield;
          authenticationcertactionArray[index].groupnamefield = resources[index].groupnamefield;
          authenticationcertactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationcertactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationcertaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationcertaction resource,
      string[] args)
    {
      return new authenticationcertaction()
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
        authenticationcertaction[] authenticationcertactionArray = new authenticationcertaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationcertactionArray[index] = new authenticationcertaction();
          authenticationcertactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationcertactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationcertaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationcertaction[] authenticationcertactionArray = new authenticationcertaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationcertactionArray[index] = new authenticationcertaction();
          authenticationcertactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationcertactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationcertaction[] get(nitro_service service) => (authenticationcertaction[]) new authenticationcertaction().get_resources(service, (options) null);

    public static authenticationcertaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationcertaction[]) new authenticationcertaction().get_resources(service, option);
    }

    public static authenticationcertaction get(
      nitro_service service,
      string name)
    {
      return (authenticationcertaction) new authenticationcertaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationcertaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationcertaction[]) null;
      authenticationcertaction[] authenticationcertactionArray1 = new authenticationcertaction[name.Length];
      authenticationcertaction[] authenticationcertactionArray2 = new authenticationcertaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationcertactionArray2[index] = new authenticationcertaction();
        authenticationcertactionArray2[index].name = name[index];
        authenticationcertactionArray1[index] = (authenticationcertaction) authenticationcertactionArray2[index].get_resource(service);
      }
      return authenticationcertactionArray1;
    }

    public static authenticationcertaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationcertaction authenticationcertaction = new authenticationcertaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationcertaction[]) authenticationcertaction.getfiltered(service, option);
    }

    public static authenticationcertaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationcertaction authenticationcertaction = new authenticationcertaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationcertaction[]) authenticationcertaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationcertaction authenticationcertaction = new authenticationcertaction();
      options option = new options();
      option.set_count(true);
      authenticationcertaction[] resources = (authenticationcertaction[]) authenticationcertaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationcertaction authenticationcertaction = new authenticationcertaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationcertaction[] authenticationcertactionArray = (authenticationcertaction[]) authenticationcertaction.getfiltered(service, option);
      return authenticationcertactionArray != null && authenticationcertactionArray.Length > 0 ? authenticationcertactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationcertaction authenticationcertaction = new authenticationcertaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationcertaction[] authenticationcertactionArray = (authenticationcertaction[]) authenticationcertaction.getfiltered(service, option);
      return authenticationcertactionArray != null && authenticationcertactionArray.Length > 0 ? authenticationcertactionArray[0].__count.Value : 0U;
    }

    private class authenticationcertaction_response : base_response
    {
      public authenticationcertaction[] authenticationcertaction = (authenticationcertaction[]) null;
    }

    public static class twofactorEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
