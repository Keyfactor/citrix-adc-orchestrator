// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.Base.statobjects
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.Base
{
  public class statobjects : base_resource
  {
    private string[] objectsField = (string[]) null;

    public string[] objects
    {
      get => this.objectsField;
      private set => this.objectsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      statobjects[] statobjectsArray = new statobjects[1];
      statobjects.statobjects_response statobjectsResponse = new statobjects.statobjects_response();
      statobjects.statobjects_response resource = (statobjects.statobjects_response) service.get_payload_formatter().string_to_resource(statobjectsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      statobjectsArray[0] = resource.statobjects;
      return (base_resource[]) statobjectsArray;
    }

    internal override string get_object_name() => (string) null;

    public static statobjects get(nitro_service service) => ((statobjects[]) new statobjects().get_resources(service, (options) null))[0];

    private class statobjects_response : base_response
    {
      public statobjects statobjects = (statobjects) null;
    }
  }
}
