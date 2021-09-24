// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacsaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationtacacsaction : base_resource
  {
    private string nameField = (string) null;
    private string serveripField = (string) null;
    private ushort? serverportField = new ushort?();
    private uint? authtimeoutField = new uint?();
    private string tacacssecretField = (string) null;
    private string authorizationField = (string) null;
    private string accountingField = (string) null;
    private string auditfailedcmdsField = (string) null;
    private string defaultauthenticationgroupField = (string) null;
    private long? successField = new long?();
    private long? failureField = new long?();
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

    public string serverip
    {
      get => this.serveripField;
      set => this.serveripField = value;
    }

    public ushort? serverport
    {
      get => this.serverportField;
      set => this.serverportField = value;
    }

    public uint? authtimeout
    {
      get => this.authtimeoutField;
      set => this.authtimeoutField = value;
    }

    public string tacacssecret
    {
      get => this.tacacssecretField;
      set => this.tacacssecretField = value;
    }

    public string authorization
    {
      get => this.authorizationField;
      set => this.authorizationField = value;
    }

    public string accounting
    {
      get => this.accountingField;
      set => this.accountingField = value;
    }

    public string auditfailedcmds
    {
      get => this.auditfailedcmdsField;
      set => this.auditfailedcmdsField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    public long? success
    {
      get => this.successField;
      private set => this.successField = value;
    }

    public long? failure
    {
      get => this.failureField;
      private set => this.failureField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationtacacsaction.authenticationtacacsaction_response authenticationtacacsactionResponse = new authenticationtacacsaction.authenticationtacacsaction_response();
      authenticationtacacsaction.authenticationtacacsaction_response resource = (authenticationtacacsaction.authenticationtacacsaction_response) service.get_payload_formatter().string_to_resource(authenticationtacacsactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationtacacsaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationtacacsaction resource)
    {
      return new authenticationtacacsaction()
      {
        name = resource.name,
        serverip = resource.serverip,
        serverport = resource.serverport,
        authtimeout = resource.authtimeout,
        tacacssecret = resource.tacacssecret,
        authorization = resource.authorization,
        accounting = resource.accounting,
        auditfailedcmds = resource.auditfailedcmds,
        defaultauthenticationgroup = resource.defaultauthenticationgroup
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationtacacsaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationtacacsaction[] authenticationtacacsactionArray = new authenticationtacacsaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationtacacsactionArray[index] = new authenticationtacacsaction();
          authenticationtacacsactionArray[index].name = resources[index].name;
          authenticationtacacsactionArray[index].serverip = resources[index].serverip;
          authenticationtacacsactionArray[index].serverport = resources[index].serverport;
          authenticationtacacsactionArray[index].authtimeout = resources[index].authtimeout;
          authenticationtacacsactionArray[index].tacacssecret = resources[index].tacacssecret;
          authenticationtacacsactionArray[index].authorization = resources[index].authorization;
          authenticationtacacsactionArray[index].accounting = resources[index].accounting;
          authenticationtacacsactionArray[index].auditfailedcmds = resources[index].auditfailedcmds;
          authenticationtacacsactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationtacacsactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationtacacsaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationtacacsaction resource)
    {
      return new authenticationtacacsaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationtacacsaction[] authenticationtacacsactionArray = new authenticationtacacsaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationtacacsactionArray[index] = new authenticationtacacsaction();
          authenticationtacacsactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationtacacsactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationtacacsaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationtacacsaction[] authenticationtacacsactionArray = new authenticationtacacsaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationtacacsactionArray[index] = new authenticationtacacsaction();
          authenticationtacacsactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationtacacsactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationtacacsaction resource)
    {
      return new authenticationtacacsaction()
      {
        name = resource.name,
        serverip = resource.serverip,
        serverport = resource.serverport,
        authtimeout = resource.authtimeout,
        tacacssecret = resource.tacacssecret,
        authorization = resource.authorization,
        accounting = resource.accounting,
        auditfailedcmds = resource.auditfailedcmds,
        defaultauthenticationgroup = resource.defaultauthenticationgroup
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationtacacsaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationtacacsaction[] authenticationtacacsactionArray = new authenticationtacacsaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationtacacsactionArray[index] = new authenticationtacacsaction();
          authenticationtacacsactionArray[index].name = resources[index].name;
          authenticationtacacsactionArray[index].serverip = resources[index].serverip;
          authenticationtacacsactionArray[index].serverport = resources[index].serverport;
          authenticationtacacsactionArray[index].authtimeout = resources[index].authtimeout;
          authenticationtacacsactionArray[index].tacacssecret = resources[index].tacacssecret;
          authenticationtacacsactionArray[index].authorization = resources[index].authorization;
          authenticationtacacsactionArray[index].accounting = resources[index].accounting;
          authenticationtacacsactionArray[index].auditfailedcmds = resources[index].auditfailedcmds;
          authenticationtacacsactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationtacacsactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationtacacsaction()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationtacacsaction resource,
      string[] args)
    {
      return new authenticationtacacsaction()
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
        authenticationtacacsaction[] authenticationtacacsactionArray = new authenticationtacacsaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationtacacsactionArray[index] = new authenticationtacacsaction();
          authenticationtacacsactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationtacacsactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationtacacsaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationtacacsaction[] authenticationtacacsactionArray = new authenticationtacacsaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationtacacsactionArray[index] = new authenticationtacacsaction();
          authenticationtacacsactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationtacacsactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationtacacsaction[] get(nitro_service service) => (authenticationtacacsaction[]) new authenticationtacacsaction().get_resources(service, (options) null);

    public static authenticationtacacsaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationtacacsaction[]) new authenticationtacacsaction().get_resources(service, option);
    }

    public static authenticationtacacsaction get(
      nitro_service service,
      string name)
    {
      return (authenticationtacacsaction) new authenticationtacacsaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationtacacsaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationtacacsaction[]) null;
      authenticationtacacsaction[] authenticationtacacsactionArray1 = new authenticationtacacsaction[name.Length];
      authenticationtacacsaction[] authenticationtacacsactionArray2 = new authenticationtacacsaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationtacacsactionArray2[index] = new authenticationtacacsaction();
        authenticationtacacsactionArray2[index].name = name[index];
        authenticationtacacsactionArray1[index] = (authenticationtacacsaction) authenticationtacacsactionArray2[index].get_resource(service);
      }
      return authenticationtacacsactionArray1;
    }

    public static authenticationtacacsaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationtacacsaction authenticationtacacsaction = new authenticationtacacsaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationtacacsaction[]) authenticationtacacsaction.getfiltered(service, option);
    }

    public static authenticationtacacsaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationtacacsaction authenticationtacacsaction = new authenticationtacacsaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationtacacsaction[]) authenticationtacacsaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationtacacsaction authenticationtacacsaction = new authenticationtacacsaction();
      options option = new options();
      option.set_count(true);
      authenticationtacacsaction[] resources = (authenticationtacacsaction[]) authenticationtacacsaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationtacacsaction authenticationtacacsaction = new authenticationtacacsaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationtacacsaction[] authenticationtacacsactionArray = (authenticationtacacsaction[]) authenticationtacacsaction.getfiltered(service, option);
      return authenticationtacacsactionArray != null && authenticationtacacsactionArray.Length > 0 ? authenticationtacacsactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationtacacsaction authenticationtacacsaction = new authenticationtacacsaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationtacacsaction[] authenticationtacacsactionArray = (authenticationtacacsaction[]) authenticationtacacsaction.getfiltered(service, option);
      return authenticationtacacsactionArray != null && authenticationtacacsactionArray.Length > 0 ? authenticationtacacsactionArray[0].__count.Value : 0U;
    }

    private class authenticationtacacsaction_response : base_response
    {
      public authenticationtacacsaction[] authenticationtacacsaction = (authenticationtacacsaction[]) null;
    }

    public static class auditfailedcmdsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class authorizationEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class accountingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
