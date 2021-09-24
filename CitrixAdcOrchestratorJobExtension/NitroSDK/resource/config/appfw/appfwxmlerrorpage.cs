// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwxmlerrorpage
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwxmlerrorpage : base_resource
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
      appfwxmlerrorpage[] appfwxmlerrorpageArray = new appfwxmlerrorpage[1];
      appfwxmlerrorpage.appfwxmlerrorpage_response appfwxmlerrorpageResponse = new appfwxmlerrorpage.appfwxmlerrorpage_response();
      appfwxmlerrorpage.appfwxmlerrorpage_response resource = (appfwxmlerrorpage.appfwxmlerrorpage_response) service.get_payload_formatter().string_to_resource(appfwxmlerrorpageResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appfwxmlerrorpageArray[0] = resource.appfwxmlerrorpage;
      return (base_resource[]) appfwxmlerrorpageArray;
    }

    internal override string get_object_name() => this.name;

    public static base_response delete(nitro_service client, string name) => new appfwxmlerrorpage()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      appfwxmlerrorpage resource)
    {
      return new appfwxmlerrorpage()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_response Import(
      nitro_service client,
      appfwxmlerrorpage resource)
    {
      return new appfwxmlerrorpage()
      {
        src = resource.src,
        name = resource.name,
        comment = resource.comment,
        overwrite = resource.overwrite
      }.perform_operation_byaction(client, nameof (Import));
    }

    public static base_response change(
      nitro_service client,
      appfwxmlerrorpage resource)
    {
      return new appfwxmlerrorpage()
      {
        name = resource.name
      }.perform_operation_byaction(client, "update");
    }

    public static appfwxmlerrorpage get(nitro_service service) => ((appfwxmlerrorpage[]) new appfwxmlerrorpage().get_resources(service, (options) null))[0];

    public static appfwxmlerrorpage get(nitro_service service, options option) => ((appfwxmlerrorpage[]) new appfwxmlerrorpage().get_resources(service, option))[0];

    public static appfwxmlerrorpage get(nitro_service service, string name) => (appfwxmlerrorpage) new appfwxmlerrorpage()
    {
      name = name
    }.get_resource(service);

    private class appfwxmlerrorpage_response : base_response
    {
      public appfwxmlerrorpage appfwxmlerrorpage = (appfwxmlerrorpage) null;
    }
  }
}
