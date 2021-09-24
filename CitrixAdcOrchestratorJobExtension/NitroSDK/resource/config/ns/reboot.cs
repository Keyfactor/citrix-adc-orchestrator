// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.reboot
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class reboot : base_resource
  {
    private bool? warmField = new bool?();

    public bool? warm
    {
      get => this.warmField;
      set => this.warmField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      reboot[] rebootArray = new reboot[1];
      reboot.reboot_response rebootResponse = new reboot.reboot_response();
      reboot.reboot_response resource = (reboot.reboot_response) service.get_payload_formatter().string_to_resource(rebootResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      rebootArray[0] = resource.reboot;
      return (base_resource[]) rebootArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Reboot(nitro_service client, reboot resource) => new reboot()
    {
      warm = resource.warm
    }.perform_operation(client);

    private class reboot_response : base_response
    {
      public reboot reboot = (reboot) null;
    }
  }
}
