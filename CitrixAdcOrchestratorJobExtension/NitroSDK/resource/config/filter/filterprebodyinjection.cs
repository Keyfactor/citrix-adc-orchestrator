// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filterprebodyinjection
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filterprebodyinjection : base_resource
  {
    private string prebodyField = (string) null;
    private string systemiidField = (string) null;

    public string prebody
    {
      get => this.prebodyField;
      set => this.prebodyField = value;
    }

    public string systemiid
    {
      get => this.systemiidField;
      private set => this.systemiidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      filterprebodyinjection[] filterprebodyinjectionArray = new filterprebodyinjection[1];
      filterprebodyinjection.filterprebodyinjection_response filterprebodyinjectionResponse = new filterprebodyinjection.filterprebodyinjection_response();
      filterprebodyinjection.filterprebodyinjection_response resource = (filterprebodyinjection.filterprebodyinjection_response) service.get_payload_formatter().string_to_resource(filterprebodyinjectionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      filterprebodyinjectionArray[0] = resource.filterprebodyinjection;
      return (base_resource[]) filterprebodyinjectionArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      filterprebodyinjection resource)
    {
      return new filterprebodyinjection()
      {
        prebody = resource.prebody
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      filterprebodyinjection resource,
      string[] args)
    {
      return new filterprebodyinjection().unset_resource(client, args);
    }

    public static filterprebodyinjection get(nitro_service service) => ((filterprebodyinjection[]) new filterprebodyinjection().get_resources(service, (options) null))[0];

    public static filterprebodyinjection get(
      nitro_service service,
      options option)
    {
      return ((filterprebodyinjection[]) new filterprebodyinjection().get_resources(service, option))[0];
    }

    private class filterprebodyinjection_response : base_response
    {
      public filterprebodyinjection filterprebodyinjection = (filterprebodyinjection) null;
    }
  }
}
