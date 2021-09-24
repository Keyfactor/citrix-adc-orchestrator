// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationoauthaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationoauthaction : base_resource
  {
    private string nameField = (string) null;
    private string authorizationendpointField = (string) null;
    private string tokenendpointField = (string) null;
    private string idtokendecryptendpointField = (string) null;
    private string clientidField = (string) null;
    private string clientsecretField = (string) null;
    private string defaultauthenticationgroupField = (string) null;
    private string attribute1Field = (string) null;
    private string attribute2Field = (string) null;
    private string attribute3Field = (string) null;
    private string attribute4Field = (string) null;
    private string attribute5Field = (string) null;
    private string attribute6Field = (string) null;
    private string attribute7Field = (string) null;
    private string attribute8Field = (string) null;
    private string attribute9Field = (string) null;
    private string attribute10Field = (string) null;
    private string attribute11Field = (string) null;
    private string attribute12Field = (string) null;
    private string attribute13Field = (string) null;
    private string attribute14Field = (string) null;
    private string attribute15Field = (string) null;
    private string attribute16Field = (string) null;
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

    public string authorizationendpoint
    {
      get => this.authorizationendpointField;
      set => this.authorizationendpointField = value;
    }

    public string tokenendpoint
    {
      get => this.tokenendpointField;
      set => this.tokenendpointField = value;
    }

    public string idtokendecryptendpoint
    {
      get => this.idtokendecryptendpointField;
      set => this.idtokendecryptendpointField = value;
    }

    public string clientid
    {
      get => this.clientidField;
      set => this.clientidField = value;
    }

    public string clientsecret
    {
      get => this.clientsecretField;
      set => this.clientsecretField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    public string attribute1
    {
      get => this.attribute1Field;
      set => this.attribute1Field = value;
    }

    public string attribute2
    {
      get => this.attribute2Field;
      set => this.attribute2Field = value;
    }

    public string attribute3
    {
      get => this.attribute3Field;
      set => this.attribute3Field = value;
    }

    public string attribute4
    {
      get => this.attribute4Field;
      set => this.attribute4Field = value;
    }

    public string attribute5
    {
      get => this.attribute5Field;
      set => this.attribute5Field = value;
    }

    public string attribute6
    {
      get => this.attribute6Field;
      set => this.attribute6Field = value;
    }

    public string attribute7
    {
      get => this.attribute7Field;
      set => this.attribute7Field = value;
    }

    public string attribute8
    {
      get => this.attribute8Field;
      set => this.attribute8Field = value;
    }

    public string attribute9
    {
      get => this.attribute9Field;
      set => this.attribute9Field = value;
    }

    public string attribute10
    {
      get => this.attribute10Field;
      set => this.attribute10Field = value;
    }

    public string attribute11
    {
      get => this.attribute11Field;
      set => this.attribute11Field = value;
    }

    public string attribute12
    {
      get => this.attribute12Field;
      set => this.attribute12Field = value;
    }

    public string attribute13
    {
      get => this.attribute13Field;
      set => this.attribute13Field = value;
    }

    public string attribute14
    {
      get => this.attribute14Field;
      set => this.attribute14Field = value;
    }

    public string attribute15
    {
      get => this.attribute15Field;
      set => this.attribute15Field = value;
    }

    public string attribute16
    {
      get => this.attribute16Field;
      set => this.attribute16Field = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationoauthaction.authenticationoauthaction_response authenticationoauthactionResponse = new authenticationoauthaction.authenticationoauthaction_response();
      authenticationoauthaction.authenticationoauthaction_response resource = (authenticationoauthaction.authenticationoauthaction_response) service.get_payload_formatter().string_to_resource(authenticationoauthactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationoauthaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationoauthaction resource)
    {
      return new authenticationoauthaction()
      {
        name = resource.name,
        authorizationendpoint = resource.authorizationendpoint,
        tokenendpoint = resource.tokenendpoint,
        idtokendecryptendpoint = resource.idtokendecryptendpoint,
        clientid = resource.clientid,
        clientsecret = resource.clientsecret,
        defaultauthenticationgroup = resource.defaultauthenticationgroup,
        attribute1 = resource.attribute1,
        attribute2 = resource.attribute2,
        attribute3 = resource.attribute3,
        attribute4 = resource.attribute4,
        attribute5 = resource.attribute5,
        attribute6 = resource.attribute6,
        attribute7 = resource.attribute7,
        attribute8 = resource.attribute8,
        attribute9 = resource.attribute9,
        attribute10 = resource.attribute10,
        attribute11 = resource.attribute11,
        attribute12 = resource.attribute12,
        attribute13 = resource.attribute13,
        attribute14 = resource.attribute14,
        attribute15 = resource.attribute15,
        attribute16 = resource.attribute16
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationoauthaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationoauthaction[] authenticationoauthactionArray = new authenticationoauthaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationoauthactionArray[index] = new authenticationoauthaction();
          authenticationoauthactionArray[index].name = resources[index].name;
          authenticationoauthactionArray[index].authorizationendpoint = resources[index].authorizationendpoint;
          authenticationoauthactionArray[index].tokenendpoint = resources[index].tokenendpoint;
          authenticationoauthactionArray[index].idtokendecryptendpoint = resources[index].idtokendecryptendpoint;
          authenticationoauthactionArray[index].clientid = resources[index].clientid;
          authenticationoauthactionArray[index].clientsecret = resources[index].clientsecret;
          authenticationoauthactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationoauthactionArray[index].attribute1 = resources[index].attribute1;
          authenticationoauthactionArray[index].attribute2 = resources[index].attribute2;
          authenticationoauthactionArray[index].attribute3 = resources[index].attribute3;
          authenticationoauthactionArray[index].attribute4 = resources[index].attribute4;
          authenticationoauthactionArray[index].attribute5 = resources[index].attribute5;
          authenticationoauthactionArray[index].attribute6 = resources[index].attribute6;
          authenticationoauthactionArray[index].attribute7 = resources[index].attribute7;
          authenticationoauthactionArray[index].attribute8 = resources[index].attribute8;
          authenticationoauthactionArray[index].attribute9 = resources[index].attribute9;
          authenticationoauthactionArray[index].attribute10 = resources[index].attribute10;
          authenticationoauthactionArray[index].attribute11 = resources[index].attribute11;
          authenticationoauthactionArray[index].attribute12 = resources[index].attribute12;
          authenticationoauthactionArray[index].attribute13 = resources[index].attribute13;
          authenticationoauthactionArray[index].attribute14 = resources[index].attribute14;
          authenticationoauthactionArray[index].attribute15 = resources[index].attribute15;
          authenticationoauthactionArray[index].attribute16 = resources[index].attribute16;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationoauthactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationoauthaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationoauthaction resource)
    {
      return new authenticationoauthaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationoauthaction[] authenticationoauthactionArray = new authenticationoauthaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationoauthactionArray[index] = new authenticationoauthaction();
          authenticationoauthactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationoauthactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationoauthaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationoauthaction[] authenticationoauthactionArray = new authenticationoauthaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationoauthactionArray[index] = new authenticationoauthaction();
          authenticationoauthactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationoauthactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationoauthaction resource)
    {
      return new authenticationoauthaction()
      {
        name = resource.name,
        authorizationendpoint = resource.authorizationendpoint,
        tokenendpoint = resource.tokenendpoint,
        idtokendecryptendpoint = resource.idtokendecryptendpoint,
        clientid = resource.clientid,
        clientsecret = resource.clientsecret,
        defaultauthenticationgroup = resource.defaultauthenticationgroup,
        attribute1 = resource.attribute1,
        attribute2 = resource.attribute2,
        attribute3 = resource.attribute3,
        attribute4 = resource.attribute4,
        attribute5 = resource.attribute5,
        attribute6 = resource.attribute6,
        attribute7 = resource.attribute7,
        attribute8 = resource.attribute8,
        attribute9 = resource.attribute9,
        attribute10 = resource.attribute10,
        attribute11 = resource.attribute11,
        attribute12 = resource.attribute12,
        attribute13 = resource.attribute13,
        attribute14 = resource.attribute14,
        attribute15 = resource.attribute15,
        attribute16 = resource.attribute16
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationoauthaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationoauthaction[] authenticationoauthactionArray = new authenticationoauthaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationoauthactionArray[index] = new authenticationoauthaction();
          authenticationoauthactionArray[index].name = resources[index].name;
          authenticationoauthactionArray[index].authorizationendpoint = resources[index].authorizationendpoint;
          authenticationoauthactionArray[index].tokenendpoint = resources[index].tokenendpoint;
          authenticationoauthactionArray[index].idtokendecryptendpoint = resources[index].idtokendecryptendpoint;
          authenticationoauthactionArray[index].clientid = resources[index].clientid;
          authenticationoauthactionArray[index].clientsecret = resources[index].clientsecret;
          authenticationoauthactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationoauthactionArray[index].attribute1 = resources[index].attribute1;
          authenticationoauthactionArray[index].attribute2 = resources[index].attribute2;
          authenticationoauthactionArray[index].attribute3 = resources[index].attribute3;
          authenticationoauthactionArray[index].attribute4 = resources[index].attribute4;
          authenticationoauthactionArray[index].attribute5 = resources[index].attribute5;
          authenticationoauthactionArray[index].attribute6 = resources[index].attribute6;
          authenticationoauthactionArray[index].attribute7 = resources[index].attribute7;
          authenticationoauthactionArray[index].attribute8 = resources[index].attribute8;
          authenticationoauthactionArray[index].attribute9 = resources[index].attribute9;
          authenticationoauthactionArray[index].attribute10 = resources[index].attribute10;
          authenticationoauthactionArray[index].attribute11 = resources[index].attribute11;
          authenticationoauthactionArray[index].attribute12 = resources[index].attribute12;
          authenticationoauthactionArray[index].attribute13 = resources[index].attribute13;
          authenticationoauthactionArray[index].attribute14 = resources[index].attribute14;
          authenticationoauthactionArray[index].attribute15 = resources[index].attribute15;
          authenticationoauthactionArray[index].attribute16 = resources[index].attribute16;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationoauthactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationoauthaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationoauthaction resource,
      string[] args)
    {
      return new authenticationoauthaction()
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
        authenticationoauthaction[] authenticationoauthactionArray = new authenticationoauthaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationoauthactionArray[index] = new authenticationoauthaction();
          authenticationoauthactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationoauthactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationoauthaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationoauthaction[] authenticationoauthactionArray = new authenticationoauthaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationoauthactionArray[index] = new authenticationoauthaction();
          authenticationoauthactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationoauthactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationoauthaction[] get(nitro_service service) => (authenticationoauthaction[]) new authenticationoauthaction().get_resources(service, (options) null);

    public static authenticationoauthaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationoauthaction[]) new authenticationoauthaction().get_resources(service, option);
    }

    public static authenticationoauthaction get(
      nitro_service service,
      string name)
    {
      return (authenticationoauthaction) new authenticationoauthaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationoauthaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationoauthaction[]) null;
      authenticationoauthaction[] authenticationoauthactionArray1 = new authenticationoauthaction[name.Length];
      authenticationoauthaction[] authenticationoauthactionArray2 = new authenticationoauthaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationoauthactionArray2[index] = new authenticationoauthaction();
        authenticationoauthactionArray2[index].name = name[index];
        authenticationoauthactionArray1[index] = (authenticationoauthaction) authenticationoauthactionArray2[index].get_resource(service);
      }
      return authenticationoauthactionArray1;
    }

    public static authenticationoauthaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationoauthaction authenticationoauthaction = new authenticationoauthaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationoauthaction[]) authenticationoauthaction.getfiltered(service, option);
    }

    public static authenticationoauthaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationoauthaction authenticationoauthaction = new authenticationoauthaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationoauthaction[]) authenticationoauthaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationoauthaction authenticationoauthaction = new authenticationoauthaction();
      options option = new options();
      option.set_count(true);
      authenticationoauthaction[] resources = (authenticationoauthaction[]) authenticationoauthaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationoauthaction authenticationoauthaction = new authenticationoauthaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationoauthaction[] authenticationoauthactionArray = (authenticationoauthaction[]) authenticationoauthaction.getfiltered(service, option);
      return authenticationoauthactionArray != null && authenticationoauthactionArray.Length > 0 ? authenticationoauthactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationoauthaction authenticationoauthaction = new authenticationoauthaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationoauthaction[] authenticationoauthactionArray = (authenticationoauthaction[]) authenticationoauthaction.getfiltered(service, option);
      return authenticationoauthactionArray != null && authenticationoauthactionArray.Length > 0 ? authenticationoauthactionArray[0].__count.Value : 0U;
    }

    private class authenticationoauthaction_response : base_response
    {
      public authenticationoauthaction[] authenticationoauthaction = (authenticationoauthaction[]) null;
    }
  }
}
