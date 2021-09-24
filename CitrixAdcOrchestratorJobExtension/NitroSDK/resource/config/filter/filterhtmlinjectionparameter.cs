// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filterhtmlinjectionparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filterhtmlinjectionparameter : base_resource
  {
    private uint? rateField = new uint?();
    private uint? frequencyField = new uint?();
    private string strictField = (string) null;
    private uint? htmlsearchlenField = new uint?();

    public uint? rate
    {
      get => this.rateField;
      set => this.rateField = value;
    }

    public uint? frequency
    {
      get => this.frequencyField;
      set => this.frequencyField = value;
    }

    public string strict
    {
      get => this.strictField;
      set => this.strictField = value;
    }

    public uint? htmlsearchlen
    {
      get => this.htmlsearchlenField;
      set => this.htmlsearchlenField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      filterhtmlinjectionparameter[] filterhtmlinjectionparameterArray = new filterhtmlinjectionparameter[1];
      filterhtmlinjectionparameter.filterhtmlinjectionparameter_response filterhtmlinjectionparameterResponse = new filterhtmlinjectionparameter.filterhtmlinjectionparameter_response();
      filterhtmlinjectionparameter.filterhtmlinjectionparameter_response resource = (filterhtmlinjectionparameter.filterhtmlinjectionparameter_response) service.get_payload_formatter().string_to_resource(filterhtmlinjectionparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      filterhtmlinjectionparameterArray[0] = resource.filterhtmlinjectionparameter;
      return (base_resource[]) filterhtmlinjectionparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      filterhtmlinjectionparameter resource)
    {
      return new filterhtmlinjectionparameter()
      {
        rate = resource.rate,
        frequency = resource.frequency,
        strict = resource.strict,
        htmlsearchlen = resource.htmlsearchlen
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      filterhtmlinjectionparameter resource,
      string[] args)
    {
      return new filterhtmlinjectionparameter().unset_resource(client, args);
    }

    public static filterhtmlinjectionparameter get(nitro_service service) => ((filterhtmlinjectionparameter[]) new filterhtmlinjectionparameter().get_resources(service, (options) null))[0];

    public static filterhtmlinjectionparameter get(
      nitro_service service,
      options option)
    {
      return ((filterhtmlinjectionparameter[]) new filterhtmlinjectionparameter().get_resources(service, option))[0];
    }

    private class filterhtmlinjectionparameter_response : base_response
    {
      public filterhtmlinjectionparameter filterhtmlinjectionparameter = (filterhtmlinjectionparameter) null;
    }

    public static class strictEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
