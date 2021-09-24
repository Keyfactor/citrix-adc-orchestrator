// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwxmlschema
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwxmlschema : base_resource
  {
    private string nameField = (string) null;
    private string srcField = (string) null;
    private string commentField = (string) null;
    private bool? overwriteField = new bool?();
    private string responseField = (string) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string src
    {
      get => this.srcField;
      set => this.srcField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public bool? overwrite
    {
      get => this.overwriteField;
      set => this.overwriteField = value;
    }

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwxmlschema[] appfwxmlschemaArray = new appfwxmlschema[1];
      appfwxmlschema.appfwxmlschema_response appfwxmlschemaResponse = new appfwxmlschema.appfwxmlschema_response();
      appfwxmlschema.appfwxmlschema_response resource = (appfwxmlschema.appfwxmlschema_response) service.get_payload_formatter().string_to_resource(appfwxmlschemaResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appfwxmlschemaArray[0] = resource.appfwxmlschema;
      return (base_resource[]) appfwxmlschemaArray;
    }

    internal override string get_object_name() => this.name;

    public static base_response delete(nitro_service client, string name) => new appfwxmlschema()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appfwxmlschema resource) => new appfwxmlschema()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_response Import(nitro_service client, appfwxmlschema resource) => new appfwxmlschema()
    {
      src = resource.src,
      name = resource.name,
      comment = resource.comment,
      overwrite = resource.overwrite
    }.perform_operation_byaction(client, nameof (Import));

    public static appfwxmlschema get(nitro_service service) => ((appfwxmlschema[]) new appfwxmlschema().get_resources(service, (options) null))[0];

    public static appfwxmlschema get(nitro_service service, options option) => ((appfwxmlschema[]) new appfwxmlschema().get_resources(service, option))[0];

    public static appfwxmlschema get(nitro_service service, string name) => (appfwxmlschema) new appfwxmlschema()
    {
      name = name
    }.get_resource(service);

    private class appfwxmlschema_response : base_response
    {
      public appfwxmlschema appfwxmlschema = (appfwxmlschema) null;
    }
  }
}
