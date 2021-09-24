// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwhtmlerrorpage
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwhtmlerrorpage : base_resource
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
      appfwhtmlerrorpage[] appfwhtmlerrorpageArray = new appfwhtmlerrorpage[1];
      appfwhtmlerrorpage.appfwhtmlerrorpage_response appfwhtmlerrorpageResponse = new appfwhtmlerrorpage.appfwhtmlerrorpage_response();
      appfwhtmlerrorpage.appfwhtmlerrorpage_response resource = (appfwhtmlerrorpage.appfwhtmlerrorpage_response) service.get_payload_formatter().string_to_resource(appfwhtmlerrorpageResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appfwhtmlerrorpageArray[0] = resource.appfwhtmlerrorpage;
      return (base_resource[]) appfwhtmlerrorpageArray;
    }

    internal override string get_object_name() => this.name;

    public static base_response delete(nitro_service client, string name) => new appfwhtmlerrorpage()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      appfwhtmlerrorpage resource)
    {
      return new appfwhtmlerrorpage()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_response Import(
      nitro_service client,
      appfwhtmlerrorpage resource)
    {
      return new appfwhtmlerrorpage()
      {
        src = resource.src,
        name = resource.name,
        comment = resource.comment,
        overwrite = resource.overwrite
      }.perform_operation_byaction(client, nameof (Import));
    }

    public static base_response change(
      nitro_service client,
      appfwhtmlerrorpage resource)
    {
      return new appfwhtmlerrorpage()
      {
        name = resource.name
      }.perform_operation_byaction(client, "update");
    }

    public static appfwhtmlerrorpage get(nitro_service service) => ((appfwhtmlerrorpage[]) new appfwhtmlerrorpage().get_resources(service, (options) null))[0];

    public static appfwhtmlerrorpage get(nitro_service service, options option) => ((appfwhtmlerrorpage[]) new appfwhtmlerrorpage().get_resources(service, option))[0];

    public static appfwhtmlerrorpage get(nitro_service service, string name) => (appfwhtmlerrorpage) new appfwhtmlerrorpage()
    {
      name = name
    }.get_resource(service);

    private class appfwhtmlerrorpage_response : base_response
    {
      public appfwhtmlerrorpage appfwhtmlerrorpage = (appfwhtmlerrorpage) null;
    }
  }
}
