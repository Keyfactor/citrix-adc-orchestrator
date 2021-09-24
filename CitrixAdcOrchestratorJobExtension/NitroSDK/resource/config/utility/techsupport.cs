// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.utility.techsupport
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.utility
{
  public class techsupport : base_resource
  {
    private string scopeField = (string) null;
    private string partitionnameField = (string) null;
    private bool? uploadField = new bool?();
    private string proxyField = (string) null;
    private string casenumberField = (string) null;
    private string fileField = (string) null;
    private string descriptionField = (string) null;
    private string usernameField = (string) null;
    private string passwordField = (string) null;
    private string responseField = (string) null;
    private string servernameField = (string) null;

    public string scope
    {
      get => this.scopeField;
      set => this.scopeField = value;
    }

    public string partitionname
    {
      get => this.partitionnameField;
      set => this.partitionnameField = value;
    }

    public bool? upload
    {
      get => this.uploadField;
      set => this.uploadField = value;
    }

    public string proxy
    {
      get => this.proxyField;
      set => this.proxyField = value;
    }

    public string casenumber
    {
      get => this.casenumberField;
      set => this.casenumberField = value;
    }

    public string file
    {
      get => this.fileField;
      set => this.fileField = value;
    }

    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    public string servername
    {
      get => this.servernameField;
      private set => this.servernameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      techsupport[] techsupportArray = new techsupport[1];
      techsupport.techsupport_response techsupportResponse = new techsupport.techsupport_response();
      techsupport.techsupport_response resource = (techsupport.techsupport_response) service.get_payload_formatter().string_to_resource(techsupportResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      techsupportArray[0] = resource.techsupport;
      return (base_resource[]) techsupportArray;
    }

    internal override string get_object_name() => (string) null;

    public static techsupport get(nitro_service service) => ((techsupport[]) new techsupport().get_resources(service, (options) null))[0];

    public static techsupport get(nitro_service service, options option) => ((techsupport[]) new techsupport().get_resources(service, option))[0];

    public static techsupport[] get(nitro_service service, techsupport_args args)
    {
      techsupport techsupport = new techsupport();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (techsupport[]) techsupport.get_resources(service, option);
    }

    private class techsupport_response : base_response
    {
      public techsupport techsupport = (techsupport) null;
    }

    public static class scopeEnum
    {
      public const string NODE = "NODE";
      public const string CLUSTER = "CLUSTER";
      public const string PARTITION = "PARTITION";
    }
  }
}
