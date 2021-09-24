// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwarchive
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwarchive : base_resource
  {
    private string nameField = (string) null;
    private string targetField = (string) null;
    private string srcField = (string) null;
    private string commentField = (string) null;
    private string responseField = (string) null;

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

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwarchive[] appfwarchiveArray = new appfwarchive[1];
      appfwarchive.appfwarchive_response appfwarchiveResponse = new appfwarchive.appfwarchive_response();
      appfwarchive.appfwarchive_response resource = (appfwarchive.appfwarchive_response) service.get_payload_formatter().string_to_resource(appfwarchiveResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appfwarchiveArray[0] = resource.appfwarchive;
      return (base_resource[]) appfwarchiveArray;
    }

    internal override string get_object_name() => this.name;

    public static base_response export(nitro_service client, appfwarchive resource) => new appfwarchive()
    {
      name = resource.name,
      target = resource.target
    }.perform_operation_byaction(client, nameof (export));

    public static base_response Import(nitro_service client, appfwarchive resource) => new appfwarchive()
    {
      src = resource.src,
      name = resource.name,
      comment = resource.comment
    }.perform_operation_byaction(client, nameof (Import));

    public static base_response delete(nitro_service client, string name) => new appfwarchive()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appfwarchive resource) => new appfwarchive()
    {
      name = resource.name
    }.delete_resource(client);

    public static appfwarchive get(nitro_service service) => ((appfwarchive[]) new appfwarchive().get_resources(service, (options) null))[0];

    public static appfwarchive get(nitro_service service, options option) => ((appfwarchive[]) new appfwarchive().get_resources(service, option))[0];

    private class appfwarchive_response : base_response
    {
      public appfwarchive appfwarchive = (appfwarchive) null;
    }
  }
}
