// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filterpostbodyinjection
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filterpostbodyinjection : base_resource
  {
    private string postbodyField = (string) null;
    private string systemiidField = (string) null;

    public string postbody
    {
      get => this.postbodyField;
      set => this.postbodyField = value;
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
      filterpostbodyinjection[] filterpostbodyinjectionArray = new filterpostbodyinjection[1];
      filterpostbodyinjection.filterpostbodyinjection_response filterpostbodyinjectionResponse = new filterpostbodyinjection.filterpostbodyinjection_response();
      filterpostbodyinjection.filterpostbodyinjection_response resource = (filterpostbodyinjection.filterpostbodyinjection_response) service.get_payload_formatter().string_to_resource(filterpostbodyinjectionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      filterpostbodyinjectionArray[0] = resource.filterpostbodyinjection;
      return (base_resource[]) filterpostbodyinjectionArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      filterpostbodyinjection resource)
    {
      return new filterpostbodyinjection()
      {
        postbody = resource.postbody
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      filterpostbodyinjection resource,
      string[] args)
    {
      return new filterpostbodyinjection().unset_resource(client, args);
    }

    public static filterpostbodyinjection get(nitro_service service) => ((filterpostbodyinjection[]) new filterpostbodyinjection().get_resources(service, (options) null))[0];

    public static filterpostbodyinjection get(
      nitro_service service,
      options option)
    {
      return ((filterpostbodyinjection[]) new filterpostbodyinjection().get_resources(service, option))[0];
    }

    private class filterpostbodyinjection_response : base_response
    {
      public filterpostbodyinjection filterpostbodyinjection = (filterpostbodyinjection) null;
    }
  }
}
