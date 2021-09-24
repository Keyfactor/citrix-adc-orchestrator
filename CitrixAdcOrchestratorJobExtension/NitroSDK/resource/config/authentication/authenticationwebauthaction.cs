// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationwebauthaction : base_resource
  {
    private string nameField = (string) null;
    private string serveripField = (string) null;
    private ushort? serverportField = new ushort?();
    private string fullreqexprField = (string) null;
    private string schemeField = (string) null;
    private string successruleField = (string) null;
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

    public string fullreqexpr
    {
      get => this.fullreqexprField;
      set => this.fullreqexprField = value;
    }

    public string scheme
    {
      get => this.schemeField;
      set => this.schemeField = value;
    }

    public string successrule
    {
      get => this.successruleField;
      set => this.successruleField = value;
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
      authenticationwebauthaction.authenticationwebauthaction_response authenticationwebauthactionResponse = new authenticationwebauthaction.authenticationwebauthaction_response();
      authenticationwebauthaction.authenticationwebauthaction_response resource = (authenticationwebauthaction.authenticationwebauthaction_response) service.get_payload_formatter().string_to_resource(authenticationwebauthactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationwebauthaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationwebauthaction resource)
    {
      return new authenticationwebauthaction()
      {
        name = resource.name,
        serverip = resource.serverip,
        serverport = resource.serverport,
        fullreqexpr = resource.fullreqexpr,
        scheme = resource.scheme,
        successrule = resource.successrule,
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
      authenticationwebauthaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationwebauthaction[] authenticationwebauthactionArray = new authenticationwebauthaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationwebauthactionArray[index] = new authenticationwebauthaction();
          authenticationwebauthactionArray[index].name = resources[index].name;
          authenticationwebauthactionArray[index].serverip = resources[index].serverip;
          authenticationwebauthactionArray[index].serverport = resources[index].serverport;
          authenticationwebauthactionArray[index].fullreqexpr = resources[index].fullreqexpr;
          authenticationwebauthactionArray[index].scheme = resources[index].scheme;
          authenticationwebauthactionArray[index].successrule = resources[index].successrule;
          authenticationwebauthactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationwebauthactionArray[index].attribute1 = resources[index].attribute1;
          authenticationwebauthactionArray[index].attribute2 = resources[index].attribute2;
          authenticationwebauthactionArray[index].attribute3 = resources[index].attribute3;
          authenticationwebauthactionArray[index].attribute4 = resources[index].attribute4;
          authenticationwebauthactionArray[index].attribute5 = resources[index].attribute5;
          authenticationwebauthactionArray[index].attribute6 = resources[index].attribute6;
          authenticationwebauthactionArray[index].attribute7 = resources[index].attribute7;
          authenticationwebauthactionArray[index].attribute8 = resources[index].attribute8;
          authenticationwebauthactionArray[index].attribute9 = resources[index].attribute9;
          authenticationwebauthactionArray[index].attribute10 = resources[index].attribute10;
          authenticationwebauthactionArray[index].attribute11 = resources[index].attribute11;
          authenticationwebauthactionArray[index].attribute12 = resources[index].attribute12;
          authenticationwebauthactionArray[index].attribute13 = resources[index].attribute13;
          authenticationwebauthactionArray[index].attribute14 = resources[index].attribute14;
          authenticationwebauthactionArray[index].attribute15 = resources[index].attribute15;
          authenticationwebauthactionArray[index].attribute16 = resources[index].attribute16;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationwebauthactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationwebauthaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationwebauthaction resource)
    {
      return new authenticationwebauthaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationwebauthaction[] authenticationwebauthactionArray = new authenticationwebauthaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationwebauthactionArray[index] = new authenticationwebauthaction();
          authenticationwebauthactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationwebauthactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationwebauthaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationwebauthaction[] authenticationwebauthactionArray = new authenticationwebauthaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationwebauthactionArray[index] = new authenticationwebauthaction();
          authenticationwebauthactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationwebauthactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationwebauthaction resource)
    {
      return new authenticationwebauthaction()
      {
        name = resource.name,
        serverip = resource.serverip,
        serverport = resource.serverport,
        fullreqexpr = resource.fullreqexpr,
        scheme = resource.scheme,
        successrule = resource.successrule,
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
      authenticationwebauthaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationwebauthaction[] authenticationwebauthactionArray = new authenticationwebauthaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationwebauthactionArray[index] = new authenticationwebauthaction();
          authenticationwebauthactionArray[index].name = resources[index].name;
          authenticationwebauthactionArray[index].serverip = resources[index].serverip;
          authenticationwebauthactionArray[index].serverport = resources[index].serverport;
          authenticationwebauthactionArray[index].fullreqexpr = resources[index].fullreqexpr;
          authenticationwebauthactionArray[index].scheme = resources[index].scheme;
          authenticationwebauthactionArray[index].successrule = resources[index].successrule;
          authenticationwebauthactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationwebauthactionArray[index].attribute1 = resources[index].attribute1;
          authenticationwebauthactionArray[index].attribute2 = resources[index].attribute2;
          authenticationwebauthactionArray[index].attribute3 = resources[index].attribute3;
          authenticationwebauthactionArray[index].attribute4 = resources[index].attribute4;
          authenticationwebauthactionArray[index].attribute5 = resources[index].attribute5;
          authenticationwebauthactionArray[index].attribute6 = resources[index].attribute6;
          authenticationwebauthactionArray[index].attribute7 = resources[index].attribute7;
          authenticationwebauthactionArray[index].attribute8 = resources[index].attribute8;
          authenticationwebauthactionArray[index].attribute9 = resources[index].attribute9;
          authenticationwebauthactionArray[index].attribute10 = resources[index].attribute10;
          authenticationwebauthactionArray[index].attribute11 = resources[index].attribute11;
          authenticationwebauthactionArray[index].attribute12 = resources[index].attribute12;
          authenticationwebauthactionArray[index].attribute13 = resources[index].attribute13;
          authenticationwebauthactionArray[index].attribute14 = resources[index].attribute14;
          authenticationwebauthactionArray[index].attribute15 = resources[index].attribute15;
          authenticationwebauthactionArray[index].attribute16 = resources[index].attribute16;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationwebauthactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationwebauthaction()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationwebauthaction resource,
      string[] args)
    {
      return new authenticationwebauthaction()
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
        authenticationwebauthaction[] authenticationwebauthactionArray = new authenticationwebauthaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationwebauthactionArray[index] = new authenticationwebauthaction();
          authenticationwebauthactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationwebauthactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationwebauthaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationwebauthaction[] authenticationwebauthactionArray = new authenticationwebauthaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationwebauthactionArray[index] = new authenticationwebauthaction();
          authenticationwebauthactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationwebauthactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationwebauthaction[] get(nitro_service service) => (authenticationwebauthaction[]) new authenticationwebauthaction().get_resources(service, (options) null);

    public static authenticationwebauthaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationwebauthaction[]) new authenticationwebauthaction().get_resources(service, option);
    }

    public static authenticationwebauthaction get(
      nitro_service service,
      string name)
    {
      return (authenticationwebauthaction) new authenticationwebauthaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationwebauthaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationwebauthaction[]) null;
      authenticationwebauthaction[] authenticationwebauthactionArray1 = new authenticationwebauthaction[name.Length];
      authenticationwebauthaction[] authenticationwebauthactionArray2 = new authenticationwebauthaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationwebauthactionArray2[index] = new authenticationwebauthaction();
        authenticationwebauthactionArray2[index].name = name[index];
        authenticationwebauthactionArray1[index] = (authenticationwebauthaction) authenticationwebauthactionArray2[index].get_resource(service);
      }
      return authenticationwebauthactionArray1;
    }

    public static authenticationwebauthaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationwebauthaction authenticationwebauthaction = new authenticationwebauthaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationwebauthaction[]) authenticationwebauthaction.getfiltered(service, option);
    }

    public static authenticationwebauthaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationwebauthaction authenticationwebauthaction = new authenticationwebauthaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationwebauthaction[]) authenticationwebauthaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationwebauthaction authenticationwebauthaction = new authenticationwebauthaction();
      options option = new options();
      option.set_count(true);
      authenticationwebauthaction[] resources = (authenticationwebauthaction[]) authenticationwebauthaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationwebauthaction authenticationwebauthaction = new authenticationwebauthaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationwebauthaction[] authenticationwebauthactionArray = (authenticationwebauthaction[]) authenticationwebauthaction.getfiltered(service, option);
      return authenticationwebauthactionArray != null && authenticationwebauthactionArray.Length > 0 ? authenticationwebauthactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationwebauthaction authenticationwebauthaction = new authenticationwebauthaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationwebauthaction[] authenticationwebauthactionArray = (authenticationwebauthaction[]) authenticationwebauthaction.getfiltered(service, option);
      return authenticationwebauthactionArray != null && authenticationwebauthactionArray.Length > 0 ? authenticationwebauthactionArray[0].__count.Value : 0U;
    }

    private class authenticationwebauthaction_response : base_response
    {
      public authenticationwebauthaction[] authenticationwebauthaction = (authenticationwebauthaction[]) null;
    }

    public static class schemeEnum
    {
      public const string http = "http";
      public const string https = "https";
    }
  }
}
