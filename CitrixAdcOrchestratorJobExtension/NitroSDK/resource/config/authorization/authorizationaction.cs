// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authorization.authorizationaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authorization
{
  public class authorizationaction : base_resource
  {
    private string nameField = (string) null;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authorizationaction.authorizationaction_response authorizationactionResponse = new authorizationaction.authorizationaction_response();
      authorizationaction.authorizationaction_response resource = (authorizationaction.authorizationaction_response) service.get_payload_formatter().string_to_resource(authorizationactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authorizationaction;
    }

    internal override string get_object_name() => this.name;

    public static authorizationaction[] get(nitro_service service) => (authorizationaction[]) new authorizationaction().get_resources(service, (options) null);

    public static authorizationaction[] get(
      nitro_service service,
      options option)
    {
      return (authorizationaction[]) new authorizationaction().get_resources(service, option);
    }

    public static authorizationaction get(nitro_service service, string name) => (authorizationaction) new authorizationaction()
    {
      name = name
    }.get_resource(service);

    public static authorizationaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authorizationaction[]) null;
      authorizationaction[] authorizationactionArray1 = new authorizationaction[name.Length];
      authorizationaction[] authorizationactionArray2 = new authorizationaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authorizationactionArray2[index] = new authorizationaction();
        authorizationactionArray2[index].name = name[index];
        authorizationactionArray1[index] = (authorizationaction) authorizationactionArray2[index].get_resource(service);
      }
      return authorizationactionArray1;
    }

    public static authorizationaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authorizationaction authorizationaction = new authorizationaction();
      options option = new options();
      option.set_filter(filter);
      return (authorizationaction[]) authorizationaction.getfiltered(service, option);
    }

    public static authorizationaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authorizationaction authorizationaction = new authorizationaction();
      options option = new options();
      option.set_filter(filter);
      return (authorizationaction[]) authorizationaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authorizationaction authorizationaction = new authorizationaction();
      options option = new options();
      option.set_count(true);
      authorizationaction[] resources = (authorizationaction[]) authorizationaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authorizationaction authorizationaction = new authorizationaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authorizationaction[] authorizationactionArray = (authorizationaction[]) authorizationaction.getfiltered(service, option);
      return authorizationactionArray != null && authorizationactionArray.Length > 0 ? authorizationactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authorizationaction authorizationaction = new authorizationaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authorizationaction[] authorizationactionArray = (authorizationaction[]) authorizationaction.getfiltered(service, option);
      return authorizationactionArray != null && authorizationactionArray.Length > 0 ? authorizationactionArray[0].__count.Value : 0U;
    }

    private class authorizationaction_response : base_response
    {
      public authorizationaction[] authorizationaction = (authorizationaction[]) null;
    }
  }
}
