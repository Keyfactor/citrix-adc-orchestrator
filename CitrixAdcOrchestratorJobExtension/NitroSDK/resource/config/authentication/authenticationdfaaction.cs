// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationdfaaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationdfaaction : base_resource
  {
    private string nameField = (string) null;
    private string clientidField = (string) null;
    private string serverurlField = (string) null;
    private string passphraseField = (string) null;
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

    public string clientid
    {
      get => this.clientidField;
      set => this.clientidField = value;
    }

    public string serverurl
    {
      get => this.serverurlField;
      set => this.serverurlField = value;
    }

    public string passphrase
    {
      get => this.passphraseField;
      set => this.passphraseField = value;
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
      authenticationdfaaction.authenticationdfaaction_response authenticationdfaactionResponse = new authenticationdfaaction.authenticationdfaaction_response();
      authenticationdfaaction.authenticationdfaaction_response resource = (authenticationdfaaction.authenticationdfaaction_response) service.get_payload_formatter().string_to_resource(authenticationdfaactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationdfaaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationdfaaction resource)
    {
      return new authenticationdfaaction()
      {
        name = resource.name,
        clientid = resource.clientid,
        serverurl = resource.serverurl,
        passphrase = resource.passphrase,
        defaultauthenticationgroup = resource.defaultauthenticationgroup
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationdfaaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationdfaaction[] authenticationdfaactionArray = new authenticationdfaaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationdfaactionArray[index] = new authenticationdfaaction();
          authenticationdfaactionArray[index].name = resources[index].name;
          authenticationdfaactionArray[index].clientid = resources[index].clientid;
          authenticationdfaactionArray[index].serverurl = resources[index].serverurl;
          authenticationdfaactionArray[index].passphrase = resources[index].passphrase;
          authenticationdfaactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationdfaactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationdfaaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationdfaaction resource)
    {
      return new authenticationdfaaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationdfaaction[] authenticationdfaactionArray = new authenticationdfaaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationdfaactionArray[index] = new authenticationdfaaction();
          authenticationdfaactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationdfaactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationdfaaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationdfaaction[] authenticationdfaactionArray = new authenticationdfaaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationdfaactionArray[index] = new authenticationdfaaction();
          authenticationdfaactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationdfaactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationdfaaction resource)
    {
      return new authenticationdfaaction()
      {
        name = resource.name,
        clientid = resource.clientid,
        serverurl = resource.serverurl,
        passphrase = resource.passphrase,
        defaultauthenticationgroup = resource.defaultauthenticationgroup
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationdfaaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationdfaaction[] authenticationdfaactionArray = new authenticationdfaaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationdfaactionArray[index] = new authenticationdfaaction();
          authenticationdfaactionArray[index].name = resources[index].name;
          authenticationdfaactionArray[index].clientid = resources[index].clientid;
          authenticationdfaactionArray[index].serverurl = resources[index].serverurl;
          authenticationdfaactionArray[index].passphrase = resources[index].passphrase;
          authenticationdfaactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationdfaactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationdfaaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationdfaaction resource,
      string[] args)
    {
      return new authenticationdfaaction()
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
        authenticationdfaaction[] authenticationdfaactionArray = new authenticationdfaaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationdfaactionArray[index] = new authenticationdfaaction();
          authenticationdfaactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationdfaactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationdfaaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationdfaaction[] authenticationdfaactionArray = new authenticationdfaaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationdfaactionArray[index] = new authenticationdfaaction();
          authenticationdfaactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationdfaactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationdfaaction[] get(nitro_service service) => (authenticationdfaaction[]) new authenticationdfaaction().get_resources(service, (options) null);

    public static authenticationdfaaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationdfaaction[]) new authenticationdfaaction().get_resources(service, option);
    }

    public static authenticationdfaaction get(
      nitro_service service,
      string name)
    {
      return (authenticationdfaaction) new authenticationdfaaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationdfaaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationdfaaction[]) null;
      authenticationdfaaction[] authenticationdfaactionArray1 = new authenticationdfaaction[name.Length];
      authenticationdfaaction[] authenticationdfaactionArray2 = new authenticationdfaaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationdfaactionArray2[index] = new authenticationdfaaction();
        authenticationdfaactionArray2[index].name = name[index];
        authenticationdfaactionArray1[index] = (authenticationdfaaction) authenticationdfaactionArray2[index].get_resource(service);
      }
      return authenticationdfaactionArray1;
    }

    public static authenticationdfaaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationdfaaction authenticationdfaaction = new authenticationdfaaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationdfaaction[]) authenticationdfaaction.getfiltered(service, option);
    }

    public static authenticationdfaaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationdfaaction authenticationdfaaction = new authenticationdfaaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationdfaaction[]) authenticationdfaaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationdfaaction authenticationdfaaction = new authenticationdfaaction();
      options option = new options();
      option.set_count(true);
      authenticationdfaaction[] resources = (authenticationdfaaction[]) authenticationdfaaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationdfaaction authenticationdfaaction = new authenticationdfaaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationdfaaction[] authenticationdfaactionArray = (authenticationdfaaction[]) authenticationdfaaction.getfiltered(service, option);
      return authenticationdfaactionArray != null && authenticationdfaactionArray.Length > 0 ? authenticationdfaactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationdfaaction authenticationdfaaction = new authenticationdfaaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationdfaaction[] authenticationdfaactionArray = (authenticationdfaaction[]) authenticationdfaaction.getfiltered(service, option);
      return authenticationdfaactionArray != null && authenticationdfaactionArray.Length > 0 ? authenticationdfaactionArray[0].__count.Value : 0U;
    }

    private class authenticationdfaaction_response : base_response
    {
      public authenticationdfaaction[] authenticationdfaaction = (authenticationdfaaction[]) null;
    }
  }
}
