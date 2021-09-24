// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslfipskey
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslfipskey : base_resource
  {
    private string fipskeynameField = (string) null;
    private uint? modulusField = new uint?();
    private string exponentField = (string) null;
    private string keyField = (string) null;
    private string informField = (string) null;
    private string wrapkeynameField = (string) null;
    private string ivField = (string) null;
    private uint? sizeField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string fipskeyname
    {
      get => this.fipskeynameField;
      set => this.fipskeynameField = value;
    }

    public uint? modulus
    {
      get => this.modulusField;
      set => this.modulusField = value;
    }

    public string exponent
    {
      get => this.exponentField;
      set => this.exponentField = value;
    }

    public string key
    {
      get => this.keyField;
      set => this.keyField = value;
    }

    public string inform
    {
      get => this.informField;
      set => this.informField = value;
    }

    public string wrapkeyname
    {
      get => this.wrapkeynameField;
      set => this.wrapkeynameField = value;
    }

    public string iv
    {
      get => this.ivField;
      set => this.ivField = value;
    }

    public uint? size
    {
      get => this.sizeField;
      private set => this.sizeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslfipskey.sslfipskey_response sslfipskeyResponse = new sslfipskey.sslfipskey_response();
      sslfipskey.sslfipskey_response resource = (sslfipskey.sslfipskey_response) service.get_payload_formatter().string_to_resource(sslfipskeyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslfipskey;
    }

    internal override string get_object_name() => this.fipskeyname;

    public static base_response create(nitro_service client, sslfipskey resource) => new sslfipskey()
    {
      fipskeyname = resource.fipskeyname,
      modulus = resource.modulus,
      exponent = resource.exponent
    }.perform_operation_byaction(client, nameof (create));

    public static base_responses create(nitro_service client, sslfipskey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslfipskey[] sslfipskeyArray = new sslfipskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslfipskeyArray[index] = new sslfipskey();
          sslfipskeyArray[index].fipskeyname = resources[index].fipskeyname;
          sslfipskeyArray[index].modulus = resources[index].modulus;
          sslfipskeyArray[index].exponent = resources[index].exponent;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslfipskeyArray, nameof (create));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string fipskeyname) => new sslfipskey()
    {
      fipskeyname = fipskeyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslfipskey resource) => new sslfipskey()
    {
      fipskeyname = resource.fipskeyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] fipskeyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (fipskeyname != null && fipskeyname.Length > 0)
      {
        sslfipskey[] sslfipskeyArray = new sslfipskey[fipskeyname.Length];
        for (int index = 0; index < fipskeyname.Length; ++index)
        {
          sslfipskeyArray[index] = new sslfipskey();
          sslfipskeyArray[index].fipskeyname = fipskeyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslfipskeyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslfipskey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslfipskey[] sslfipskeyArray = new sslfipskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslfipskeyArray[index] = new sslfipskey();
          sslfipskeyArray[index].fipskeyname = resources[index].fipskeyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslfipskeyArray);
      }
      return baseResponses;
    }

    public static base_response Import(nitro_service client, sslfipskey resource) => new sslfipskey()
    {
      fipskeyname = resource.fipskeyname,
      key = resource.key,
      inform = resource.inform,
      wrapkeyname = resource.wrapkeyname,
      iv = resource.iv,
      exponent = resource.exponent
    }.perform_operation_byaction(client, nameof (Import));

    public static base_responses Import(nitro_service client, sslfipskey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslfipskey[] sslfipskeyArray = new sslfipskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslfipskeyArray[index] = new sslfipskey();
          sslfipskeyArray[index].fipskeyname = resources[index].fipskeyname;
          sslfipskeyArray[index].key = resources[index].key;
          sslfipskeyArray[index].inform = resources[index].inform;
          sslfipskeyArray[index].wrapkeyname = resources[index].wrapkeyname;
          sslfipskeyArray[index].iv = resources[index].iv;
          sslfipskeyArray[index].exponent = resources[index].exponent;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslfipskeyArray, nameof (Import));
      }
      return baseResponses;
    }

    public static base_response export(nitro_service client, sslfipskey resource) => new sslfipskey()
    {
      fipskeyname = resource.fipskeyname,
      key = resource.key
    }.perform_operation_byaction(client, nameof (export));

    public static base_responses export(nitro_service client, sslfipskey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslfipskey[] sslfipskeyArray = new sslfipskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslfipskeyArray[index] = new sslfipskey();
          sslfipskeyArray[index].fipskeyname = resources[index].fipskeyname;
          sslfipskeyArray[index].key = resources[index].key;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslfipskeyArray, nameof (export));
      }
      return baseResponses;
    }

    public static sslfipskey[] get(nitro_service service) => (sslfipskey[]) new sslfipskey().get_resources(service, (options) null);

    public static sslfipskey[] get(nitro_service service, options option) => (sslfipskey[]) new sslfipskey().get_resources(service, option);

    public static sslfipskey get(nitro_service service, string fipskeyname) => (sslfipskey) new sslfipskey()
    {
      fipskeyname = fipskeyname
    }.get_resource(service);

    public static sslfipskey[] get(nitro_service service, string[] fipskeyname)
    {
      if (fipskeyname == null || fipskeyname.Length <= 0)
        return (sslfipskey[]) null;
      sslfipskey[] sslfipskeyArray1 = new sslfipskey[fipskeyname.Length];
      sslfipskey[] sslfipskeyArray2 = new sslfipskey[fipskeyname.Length];
      for (int index = 0; index < fipskeyname.Length; ++index)
      {
        sslfipskeyArray2[index] = new sslfipskey();
        sslfipskeyArray2[index].fipskeyname = fipskeyname[index];
        sslfipskeyArray1[index] = (sslfipskey) sslfipskeyArray2[index].get_resource(service);
      }
      return sslfipskeyArray1;
    }

    public static sslfipskey[] get_filtered(nitro_service service, string filter)
    {
      sslfipskey sslfipskey = new sslfipskey();
      options option = new options();
      option.set_filter(filter);
      return (sslfipskey[]) sslfipskey.getfiltered(service, option);
    }

    public static sslfipskey[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslfipskey sslfipskey = new sslfipskey();
      options option = new options();
      option.set_filter(filter);
      return (sslfipskey[]) sslfipskey.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslfipskey sslfipskey = new sslfipskey();
      options option = new options();
      option.set_count(true);
      sslfipskey[] resources = (sslfipskey[]) sslfipskey.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslfipskey sslfipskey = new sslfipskey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslfipskey[] sslfipskeyArray = (sslfipskey[]) sslfipskey.getfiltered(service, option);
      return sslfipskeyArray != null && sslfipskeyArray.Length > 0 ? sslfipskeyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslfipskey sslfipskey = new sslfipskey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslfipskey[] sslfipskeyArray = (sslfipskey[]) sslfipskey.getfiltered(service, option);
      return sslfipskeyArray != null && sslfipskeyArray.Length > 0 ? sslfipskeyArray[0].__count.Value : 0U;
    }

    private class sslfipskey_response : base_response
    {
      public sslfipskey[] sslfipskey = (sslfipskey[]) null;
    }

    public static class informEnum
    {
      public const string SIM = "SIM";
      public const string DER = "DER";
      public const string PEM = "PEM";
    }

    public static class exponentEnum
    {
      public const string _3 = "3";
      public const string F4 = "F4";
    }
  }
}
