// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.app.application
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.app
{
  public class application : base_resource
  {
    private string apptemplatefilenameField = (string) null;
    private string appnameField = (string) null;
    private string deploymentfilenameField = (string) null;

    public string apptemplatefilename
    {
      get => this.apptemplatefilenameField;
      set => this.apptemplatefilenameField = value;
    }

    public string appname
    {
      get => this.appnameField;
      set => this.appnameField = value;
    }

    public string deploymentfilename
    {
      get => this.deploymentfilenameField;
      set => this.deploymentfilenameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      application[] applicationArray = new application[1];
      application.application_response applicationResponse = new application.application_response();
      application.application_response resource = (application.application_response) service.get_payload_formatter().string_to_resource(applicationResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      applicationArray[0] = resource.application;
      return (base_resource[]) applicationArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Import(nitro_service client, application resource) => new application()
    {
      apptemplatefilename = resource.apptemplatefilename,
      appname = resource.appname,
      deploymentfilename = resource.deploymentfilename
    }.perform_operation_byaction(client, nameof (Import));

    public static base_response export(nitro_service client, application resource) => new application()
    {
      appname = resource.appname,
      apptemplatefilename = resource.apptemplatefilename,
      deploymentfilename = resource.deploymentfilename
    }.perform_operation_byaction(client, nameof (export));

    public static base_response delete(nitro_service client, application resource) => new application()
    {
      appname = resource.appname
    }.delete_resource(client);

    private class application_response : base_response
    {
      public application application = (application) null;
    }
  }
}
