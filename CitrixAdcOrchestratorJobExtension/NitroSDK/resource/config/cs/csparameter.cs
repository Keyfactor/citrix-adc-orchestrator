// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.csparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class csparameter : base_resource
  {
    private string stateupdateField = (string) null;

    public string stateupdate
    {
      get => this.stateupdateField;
      set => this.stateupdateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      csparameter[] csparameterArray = new csparameter[1];
      csparameter.csparameter_response csparameterResponse = new csparameter.csparameter_response();
      csparameter.csparameter_response resource = (csparameter.csparameter_response) service.get_payload_formatter().string_to_resource(csparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      csparameterArray[0] = resource.csparameter;
      return (base_resource[]) csparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, csparameter resource) => new csparameter()
    {
      stateupdate = resource.stateupdate
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      csparameter resource,
      string[] args)
    {
      return new csparameter().unset_resource(client, args);
    }

    public static csparameter get(nitro_service service) => ((csparameter[]) new csparameter().get_resources(service, (options) null))[0];

    public static csparameter get(nitro_service service, options option) => ((csparameter[]) new csparameter().get_resources(service, option))[0];

    private class csparameter_response : base_response
    {
      public csparameter csparameter = (csparameter) null;
    }

    public static class stateupdateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
