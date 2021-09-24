// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ha.hasync
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ha
{
  public class hasync : base_resource
  {
    private bool? forceField = new bool?();
    private string saveField = (string) null;

    public bool? force
    {
      get => this.forceField;
      set => this.forceField = value;
    }

    public string save
    {
      get => this.saveField;
      set => this.saveField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      hasync[] hasyncArray = new hasync[1];
      hasync.hasync_response hasyncResponse = new hasync.hasync_response();
      hasync.hasync_response resource = (hasync.hasync_response) service.get_payload_formatter().string_to_resource(hasyncResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      hasyncArray[0] = resource.hasync;
      return (base_resource[]) hasyncArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Force(nitro_service client, hasync resource) => new hasync()
    {
      force = resource.force,
      save = resource.save
    }.perform_operation_byaction(client, nameof (Force));

    private class hasync_response : base_response
    {
      public hasync hasync = (hasync) null;
    }

    public static class saveEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
