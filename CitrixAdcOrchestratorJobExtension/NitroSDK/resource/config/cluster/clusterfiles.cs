// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusterfiles
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusterfiles : base_resource
  {
    private string[] modeField = (string[]) null;

    public string[] mode
    {
      get => this.modeField;
      set => this.modeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusterfiles[] clusterfilesArray = new clusterfiles[1];
      clusterfiles.clusterfiles_response clusterfilesResponse = new clusterfiles.clusterfiles_response();
      clusterfiles.clusterfiles_response resource = (clusterfiles.clusterfiles_response) service.get_payload_formatter().string_to_resource(clusterfilesResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      clusterfilesArray[0] = resource.clusterfiles;
      return (base_resource[]) clusterfilesArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response sync(nitro_service client, clusterfiles resource) => new clusterfiles()
    {
      mode = resource.mode
    }.perform_operation_byaction(client, nameof (sync));

    private class clusterfiles_response : base_response
    {
      public clusterfiles clusterfiles = (clusterfiles) null;
    }

    public static class modeEnum
    {
      public const string all = "all";
      public const string bookmarks = "bookmarks";
      public const string ssl = "ssl";
      public const string htmlinjection = "htmlinjection";
      public const string imports = "imports";
      public const string misc = "misc";
      public const string dns = "dns";
      public const string krb = "krb";
      public const string all_plus_misc = "all_plus_misc";
      public const string all_minus_misc = "all_minus_misc";
    }
  }
}
