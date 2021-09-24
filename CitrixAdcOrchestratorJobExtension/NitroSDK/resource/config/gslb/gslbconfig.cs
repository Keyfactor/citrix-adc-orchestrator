// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbconfig
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbconfig : base_resource
  {
    private bool? previewField = new bool?();
    private bool? debugField = new bool?();
    private string forcesyncField = (string) null;
    private bool? nowarnField = new bool?();
    private bool? saveconfigField = new bool?();
    private string commandField = (string) null;

    public bool? preview
    {
      get => this.previewField;
      set => this.previewField = value;
    }

    public bool? debug
    {
      get => this.debugField;
      set => this.debugField = value;
    }

    public string forcesync
    {
      get => this.forcesyncField;
      set => this.forcesyncField = value;
    }

    public bool? nowarn
    {
      get => this.nowarnField;
      set => this.nowarnField = value;
    }

    public bool? saveconfig
    {
      get => this.saveconfigField;
      set => this.saveconfigField = value;
    }

    public string command
    {
      get => this.commandField;
      set => this.commandField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbconfig[] gslbconfigArray = new gslbconfig[1];
      gslbconfig.gslbconfig_response gslbconfigResponse = new gslbconfig.gslbconfig_response();
      gslbconfig.gslbconfig_response resource = (gslbconfig.gslbconfig_response) service.get_payload_formatter().string_to_resource(gslbconfigResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      gslbconfigArray[0] = resource.gslbconfig;
      return (base_resource[]) gslbconfigArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response sync(nitro_service client, gslbconfig resource) => new gslbconfig()
    {
      preview = resource.preview,
      debug = resource.debug,
      forcesync = resource.forcesync,
      nowarn = resource.nowarn,
      saveconfig = resource.saveconfig,
      command = resource.command
    }.perform_operation_byaction(client, nameof (sync));

    private class gslbconfig_response : base_response
    {
      public gslbconfig gslbconfig = (gslbconfig) null;
    }
  }
}
