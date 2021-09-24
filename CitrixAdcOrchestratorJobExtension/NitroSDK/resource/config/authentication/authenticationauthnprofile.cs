// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationauthnprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationauthnprofile : base_resource
  {
    private string nameField = (string) null;
    private string authnvsnameField = (string) null;
    private string authenticationhostField = (string) null;
    private string authenticationdomainField = (string) null;
    private uint? authenticationlevelField = new uint?();
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

    public string authnvsname
    {
      get => this.authnvsnameField;
      set => this.authnvsnameField = value;
    }

    public string authenticationhost
    {
      get => this.authenticationhostField;
      set => this.authenticationhostField = value;
    }

    public string authenticationdomain
    {
      get => this.authenticationdomainField;
      set => this.authenticationdomainField = value;
    }

    public uint? authenticationlevel
    {
      get => this.authenticationlevelField;
      set => this.authenticationlevelField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationauthnprofile.authenticationauthnprofile_response authenticationauthnprofileResponse = new authenticationauthnprofile.authenticationauthnprofile_response();
      authenticationauthnprofile.authenticationauthnprofile_response resource = (authenticationauthnprofile.authenticationauthnprofile_response) service.get_payload_formatter().string_to_resource(authenticationauthnprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationauthnprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationauthnprofile resource)
    {
      return new authenticationauthnprofile()
      {
        name = resource.name,
        authnvsname = resource.authnvsname,
        authenticationhost = resource.authenticationhost,
        authenticationdomain = resource.authenticationdomain,
        authenticationlevel = resource.authenticationlevel
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationauthnprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationauthnprofile[] authenticationauthnprofileArray = new authenticationauthnprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationauthnprofileArray[index] = new authenticationauthnprofile();
          authenticationauthnprofileArray[index].name = resources[index].name;
          authenticationauthnprofileArray[index].authnvsname = resources[index].authnvsname;
          authenticationauthnprofileArray[index].authenticationhost = resources[index].authenticationhost;
          authenticationauthnprofileArray[index].authenticationdomain = resources[index].authenticationdomain;
          authenticationauthnprofileArray[index].authenticationlevel = resources[index].authenticationlevel;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationauthnprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationauthnprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationauthnprofile resource)
    {
      return new authenticationauthnprofile()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationauthnprofile[] authenticationauthnprofileArray = new authenticationauthnprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationauthnprofileArray[index] = new authenticationauthnprofile();
          authenticationauthnprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationauthnprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationauthnprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationauthnprofile[] authenticationauthnprofileArray = new authenticationauthnprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationauthnprofileArray[index] = new authenticationauthnprofile();
          authenticationauthnprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationauthnprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationauthnprofile resource)
    {
      return new authenticationauthnprofile()
      {
        name = resource.name,
        authnvsname = resource.authnvsname,
        authenticationhost = resource.authenticationhost,
        authenticationdomain = resource.authenticationdomain,
        authenticationlevel = resource.authenticationlevel
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationauthnprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationauthnprofile[] authenticationauthnprofileArray = new authenticationauthnprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationauthnprofileArray[index] = new authenticationauthnprofile();
          authenticationauthnprofileArray[index].name = resources[index].name;
          authenticationauthnprofileArray[index].authnvsname = resources[index].authnvsname;
          authenticationauthnprofileArray[index].authenticationhost = resources[index].authenticationhost;
          authenticationauthnprofileArray[index].authenticationdomain = resources[index].authenticationdomain;
          authenticationauthnprofileArray[index].authenticationlevel = resources[index].authenticationlevel;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationauthnprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationauthnprofile()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationauthnprofile resource,
      string[] args)
    {
      return new authenticationauthnprofile()
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
        authenticationauthnprofile[] authenticationauthnprofileArray = new authenticationauthnprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationauthnprofileArray[index] = new authenticationauthnprofile();
          authenticationauthnprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationauthnprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationauthnprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationauthnprofile[] authenticationauthnprofileArray = new authenticationauthnprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationauthnprofileArray[index] = new authenticationauthnprofile();
          authenticationauthnprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationauthnprofileArray, args);
      }
      return baseResponses;
    }

    public static authenticationauthnprofile[] get(nitro_service service) => (authenticationauthnprofile[]) new authenticationauthnprofile().get_resources(service, (options) null);

    public static authenticationauthnprofile[] get(
      nitro_service service,
      options option)
    {
      return (authenticationauthnprofile[]) new authenticationauthnprofile().get_resources(service, option);
    }

    public static authenticationauthnprofile get(
      nitro_service service,
      string name)
    {
      return (authenticationauthnprofile) new authenticationauthnprofile()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationauthnprofile[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationauthnprofile[]) null;
      authenticationauthnprofile[] authenticationauthnprofileArray1 = new authenticationauthnprofile[name.Length];
      authenticationauthnprofile[] authenticationauthnprofileArray2 = new authenticationauthnprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationauthnprofileArray2[index] = new authenticationauthnprofile();
        authenticationauthnprofileArray2[index].name = name[index];
        authenticationauthnprofileArray1[index] = (authenticationauthnprofile) authenticationauthnprofileArray2[index].get_resource(service);
      }
      return authenticationauthnprofileArray1;
    }

    public static authenticationauthnprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationauthnprofile authenticationauthnprofile = new authenticationauthnprofile();
      options option = new options();
      option.set_filter(filter);
      return (authenticationauthnprofile[]) authenticationauthnprofile.getfiltered(service, option);
    }

    public static authenticationauthnprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationauthnprofile authenticationauthnprofile = new authenticationauthnprofile();
      options option = new options();
      option.set_filter(filter);
      return (authenticationauthnprofile[]) authenticationauthnprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationauthnprofile authenticationauthnprofile = new authenticationauthnprofile();
      options option = new options();
      option.set_count(true);
      authenticationauthnprofile[] resources = (authenticationauthnprofile[]) authenticationauthnprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationauthnprofile authenticationauthnprofile = new authenticationauthnprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationauthnprofile[] authenticationauthnprofileArray = (authenticationauthnprofile[]) authenticationauthnprofile.getfiltered(service, option);
      return authenticationauthnprofileArray != null && authenticationauthnprofileArray.Length > 0 ? authenticationauthnprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationauthnprofile authenticationauthnprofile = new authenticationauthnprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationauthnprofile[] authenticationauthnprofileArray = (authenticationauthnprofile[]) authenticationauthnprofile.getfiltered(service, option);
      return authenticationauthnprofileArray != null && authenticationauthnprofileArray.Length > 0 ? authenticationauthnprofileArray[0].__count.Value : 0U;
    }

    private class authenticationauthnprofile_response : base_response
    {
      public authenticationauthnprofile[] authenticationauthnprofile = (authenticationauthnprofile[]) null;
    }
  }
}
