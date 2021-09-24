// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwcustomsettings
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwcustomsettings : base_resource
  {
    private string nameField = (string) null;
    private string targetField = (string) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string target
    {
      get => this.targetField;
      set => this.targetField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwcustomsettings[] appfwcustomsettingsArray = new appfwcustomsettings[1];
      appfwcustomsettings.appfwcustomsettings_response appfwcustomsettingsResponse = new appfwcustomsettings.appfwcustomsettings_response();
      appfwcustomsettings.appfwcustomsettings_response resource = (appfwcustomsettings.appfwcustomsettings_response) service.get_payload_formatter().string_to_resource(appfwcustomsettingsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appfwcustomsettingsArray[0] = resource.appfwcustomsettings;
      return (base_resource[]) appfwcustomsettingsArray;
    }

    internal override string get_object_name() => this.name;

    public static base_response export(
      nitro_service client,
      appfwcustomsettings resource)
    {
      return new appfwcustomsettings()
      {
        name = resource.name,
        target = resource.target
      }.perform_operation_byaction(client, nameof (export));
    }

    private class appfwcustomsettings_response : base_response
    {
      public appfwcustomsettings appfwcustomsettings = (appfwcustomsettings) null;
    }
  }
}
