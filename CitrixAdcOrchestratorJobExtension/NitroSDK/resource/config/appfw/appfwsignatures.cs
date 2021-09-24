// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwsignatures
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwsignatures : base_resource
  {
    private string nameField = (string) null;
    private string srcField = (string) null;
    private string xsltField = (string) null;
    private string commentField = (string) null;
    private bool? overwriteField = new bool?();
    private bool? mergeField = new bool?();
    private string sha1Field = (string) null;
    private bool? mergedefaultField = new bool?();
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

    public string xslt
    {
      get => this.xsltField;
      set => this.xsltField = value;
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

    public bool? merge
    {
      get => this.mergeField;
      set => this.mergeField = value;
    }

    public string sha1
    {
      get => this.sha1Field;
      set => this.sha1Field = value;
    }

    public bool? mergedefault
    {
      get => this.mergedefaultField;
      set => this.mergedefaultField = value;
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
      appfwsignatures[] appfwsignaturesArray = new appfwsignatures[1];
      appfwsignatures.appfwsignatures_response appfwsignaturesResponse = new appfwsignatures.appfwsignatures_response();
      appfwsignatures.appfwsignatures_response resource = (appfwsignatures.appfwsignatures_response) service.get_payload_formatter().string_to_resource(appfwsignaturesResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appfwsignaturesArray[0] = resource.appfwsignatures;
      return (base_resource[]) appfwsignaturesArray;
    }

    internal override string get_object_name() => this.name;

    public static base_response delete(nitro_service client, string name) => new appfwsignatures()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appfwsignatures resource) => new appfwsignatures()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_response Import(nitro_service client, appfwsignatures resource) => new appfwsignatures()
    {
      src = resource.src,
      name = resource.name,
      xslt = resource.xslt,
      comment = resource.comment,
      overwrite = resource.overwrite,
      merge = resource.merge,
      sha1 = resource.sha1
    }.perform_operation_byaction(client, nameof (Import));

    public static base_response change(nitro_service client, appfwsignatures resource) => new appfwsignatures()
    {
      name = resource.name,
      mergedefault = resource.mergedefault
    }.perform_operation_byaction(client, "update");

    public static appfwsignatures get(nitro_service service) => ((appfwsignatures[]) new appfwsignatures().get_resources(service, (options) null))[0];

    public static appfwsignatures get(nitro_service service, options option) => ((appfwsignatures[]) new appfwsignatures().get_resources(service, option))[0];

    public static appfwsignatures get(nitro_service service, string name) => (appfwsignatures) new appfwsignatures()
    {
      name = name
    }.get_resource(service);

    private class appfwsignatures_response : base_response
    {
      public appfwsignatures appfwsignatures = (appfwsignatures) null;
    }
  }
}
