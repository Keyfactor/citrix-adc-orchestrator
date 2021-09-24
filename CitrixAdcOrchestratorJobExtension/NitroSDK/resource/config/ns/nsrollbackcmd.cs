// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsrollbackcmd
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsrollbackcmd : base_resource
  {
    private string filenameField = (string) null;
    private string outtypeField = (string) null;

    public string filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
    }

    public string outtype
    {
      get => this.outtypeField;
      set => this.outtypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsrollbackcmd[] nsrollbackcmdArray = new nsrollbackcmd[1];
      nsrollbackcmd.nsrollbackcmd_response nsrollbackcmdResponse = new nsrollbackcmd.nsrollbackcmd_response();
      nsrollbackcmd.nsrollbackcmd_response resource = (nsrollbackcmd.nsrollbackcmd_response) service.get_payload_formatter().string_to_resource(nsrollbackcmdResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsrollbackcmdArray[0] = resource.nsrollbackcmd;
      return (base_resource[]) nsrollbackcmdArray;
    }

    internal override string get_object_name() => (string) null;

    public static nsrollbackcmd get(nitro_service service) => ((nsrollbackcmd[]) new nsrollbackcmd().get_resources(service, (options) null))[0];

    public static nsrollbackcmd get(nitro_service service, options option) => ((nsrollbackcmd[]) new nsrollbackcmd().get_resources(service, option))[0];

    public static nsrollbackcmd[] get(nitro_service service, nsrollbackcmd_args args)
    {
      nsrollbackcmd nsrollbackcmd = new nsrollbackcmd();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nsrollbackcmd[]) nsrollbackcmd.get_resources(service, option);
    }

    private class nsrollbackcmd_response : base_response
    {
      public nsrollbackcmd nsrollbackcmd = (nsrollbackcmd) null;
    }

    public static class outtypeEnum
    {
      public const string cli = "cli";
      public const string xml = "xml";
    }
  }
}
