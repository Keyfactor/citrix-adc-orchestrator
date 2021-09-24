// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ha.hafiles
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ha
{
  public class hafiles : base_resource
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
      hafiles[] hafilesArray = new hafiles[1];
      hafiles.hafiles_response hafilesResponse = new hafiles.hafiles_response();
      hafiles.hafiles_response resource = (hafiles.hafiles_response) service.get_payload_formatter().string_to_resource(hafilesResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      hafilesArray[0] = resource.hafiles;
      return (base_resource[]) hafilesArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response sync(nitro_service client, hafiles resource) => new hafiles()
    {
      mode = resource.mode
    }.perform_operation_byaction(client, nameof (sync));

    private class hafiles_response : base_response
    {
      public hafiles hafiles = (hafiles) null;
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
