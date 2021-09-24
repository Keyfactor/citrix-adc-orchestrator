// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertkey : base_resource
  {
    private string certkeyField = (string) null;
    private string certField = (string) null;
    private string keyField = (string) null;
    private bool? passwordField = new bool?();
    private string fipskeyField = (string) null;
    private string hsmkeyField = (string) null;
    private string informField = (string) null;
    private string passplainField = (string) null;
    private string expirymonitorField = (string) null;
    private uint? notificationperiodField = new uint?();
    private string bundleField = (string) null;
    private string linkcertkeynameField = (string) null;
    private bool? nodomaincheckField = new bool?();
    private string signaturealgField = (string) null;
    private string serialField = (string) null;
    private string issuerField = (string) null;
    private string clientcertnotbeforeField = (string) null;
    private string clientcertnotafterField = (string) null;
    private int? daystoexpirationField = new int?();
    private string subjectField = (string) null;
    private string publickeyField = (string) null;
    private int? publickeysizeField = new int?();
    private int? versionField = new int?();
    private uint? priorityField = new uint?();
    private string statusField = (string) null;
    private string passcryptField = (string) null;
    private uint? dataField = new uint?();
    private string servicenameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string certkey
    {
      get => this.certkeyField;
      set => this.certkeyField = value;
    }

    public string cert
    {
      get => this.certField;
      set => this.certField = value;
    }

    public string key
    {
      get => this.keyField;
      set => this.keyField = value;
    }

    public bool? password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public string fipskey
    {
      get => this.fipskeyField;
      set => this.fipskeyField = value;
    }

    public string hsmkey
    {
      get => this.hsmkeyField;
      set => this.hsmkeyField = value;
    }

    public string inform
    {
      get => this.informField;
      set => this.informField = value;
    }

    public string passplain
    {
      get => this.passplainField;
      set => this.passplainField = value;
    }

    public string expirymonitor
    {
      get => this.expirymonitorField;
      set => this.expirymonitorField = value;
    }

    public uint? notificationperiod
    {
      get => this.notificationperiodField;
      set => this.notificationperiodField = value;
    }

    public string bundle
    {
      get => this.bundleField;
      set => this.bundleField = value;
    }

    public string linkcertkeyname
    {
      get => this.linkcertkeynameField;
      set => this.linkcertkeynameField = value;
    }

    public bool? nodomaincheck
    {
      get => this.nodomaincheckField;
      set => this.nodomaincheckField = value;
    }

    public string signaturealg
    {
      get => this.signaturealgField;
      private set => this.signaturealgField = value;
    }

    public string serial
    {
      get => this.serialField;
      private set => this.serialField = value;
    }

    public string issuer
    {
      get => this.issuerField;
      private set => this.issuerField = value;
    }

    public string clientcertnotbefore
    {
      get => this.clientcertnotbeforeField;
      private set => this.clientcertnotbeforeField = value;
    }

    public string clientcertnotafter
    {
      get => this.clientcertnotafterField;
      private set => this.clientcertnotafterField = value;
    }

    public int? daystoexpiration
    {
      get => this.daystoexpirationField;
      private set => this.daystoexpirationField = value;
    }

    public string subject
    {
      get => this.subjectField;
      private set => this.subjectField = value;
    }

    public string publickey
    {
      get => this.publickeyField;
      private set => this.publickeyField = value;
    }

    public int? publickeysize
    {
      get => this.publickeysizeField;
      private set => this.publickeysizeField = value;
    }

    public int? version
    {
      get => this.versionField;
      private set => this.versionField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public string passcrypt
    {
      get => this.passcryptField;
      private set => this.passcryptField = value;
    }

    public uint? data
    {
      get => this.dataField;
      private set => this.dataField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      private set => this.servicenameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertkey.sslcertkey_response sslcertkeyResponse = new sslcertkey.sslcertkey_response();
      sslcertkey.sslcertkey_response resource = (sslcertkey.sslcertkey_response) service.get_payload_formatter().string_to_resource(sslcertkeyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertkey;
    }

    internal override string get_object_name() => this.certkey;

    public static base_response add(nitro_service client, sslcertkey resource) => new sslcertkey()
    {
      certkey = resource.certkey,
      cert = resource.cert,
      key = resource.key,
      password = resource.password,
      fipskey = resource.fipskey,
      hsmkey = resource.hsmkey,
      inform = resource.inform,
      passplain = resource.passplain,
      expirymonitor = resource.expirymonitor,
      notificationperiod = resource.notificationperiod,
      bundle = resource.bundle
    }.add_resource(client);

    public static base_responses add(nitro_service client, sslcertkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = resources[index].certkey;
          sslcertkeyArray[index].cert = resources[index].cert;
          sslcertkeyArray[index].key = resources[index].key;
          sslcertkeyArray[index].password = resources[index].password;
          sslcertkeyArray[index].fipskey = resources[index].fipskey;
          sslcertkeyArray[index].hsmkey = resources[index].hsmkey;
          sslcertkeyArray[index].inform = resources[index].inform;
          sslcertkeyArray[index].passplain = resources[index].passplain;
          sslcertkeyArray[index].expirymonitor = resources[index].expirymonitor;
          sslcertkeyArray[index].notificationperiod = resources[index].notificationperiod;
          sslcertkeyArray[index].bundle = resources[index].bundle;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslcertkeyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string certkey) => new sslcertkey()
    {
      certkey = certkey
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslcertkey resource) => new sslcertkey()
    {
      certkey = resource.certkey
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] certkey)
    {
      base_responses baseResponses = (base_responses) null;
      if (certkey != null && certkey.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[certkey.Length];
        for (int index = 0; index < certkey.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = certkey[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcertkeyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslcertkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = resources[index].certkey;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcertkeyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, sslcertkey resource) => new sslcertkey()
    {
      certkey = resource.certkey,
      expirymonitor = resource.expirymonitor,
      notificationperiod = resource.notificationperiod
    }.update_resource(client);

    public static base_responses update(nitro_service client, sslcertkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = resources[index].certkey;
          sslcertkeyArray[index].expirymonitor = resources[index].expirymonitor;
          sslcertkeyArray[index].notificationperiod = resources[index].notificationperiod;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslcertkeyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string certkey,
      string[] args)
    {
      return new sslcertkey() { certkey = certkey }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      sslcertkey resource,
      string[] args)
    {
      return new sslcertkey() { certkey = resource.certkey }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] certkey,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (certkey != null && certkey.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[certkey.Length];
        for (int index = 0; index < certkey.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = certkey[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslcertkeyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      sslcertkey[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = resources[index].certkey;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslcertkeyArray, args);
      }
      return baseResponses;
    }

    public static base_response link(nitro_service client, sslcertkey resource) => new sslcertkey()
    {
      certkey = resource.certkey,
      linkcertkeyname = resource.linkcertkeyname
    }.perform_operation_byaction(client, nameof (link));

    public static base_responses link(nitro_service client, sslcertkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = resources[index].certkey;
          sslcertkeyArray[index].linkcertkeyname = resources[index].linkcertkeyname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslcertkeyArray, nameof (link));
      }
      return baseResponses;
    }

    public static base_response unlink(nitro_service client, sslcertkey resource) => new sslcertkey()
    {
      certkey = resource.certkey
    }.perform_operation_byaction(client, nameof (unlink));

    public static base_responses unlink(nitro_service client, sslcertkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = resources[index].certkey;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslcertkeyArray, nameof (unlink));
      }
      return baseResponses;
    }

    public static base_response change(nitro_service client, sslcertkey resource) => new sslcertkey()
    {
      certkey = resource.certkey,
      cert = resource.cert,
      key = resource.key,
      password = resource.password,
      fipskey = resource.fipskey,
      inform = resource.inform,
      passplain = resource.passplain,
      nodomaincheck = resource.nodomaincheck
    }.perform_operation_byaction(client, "update");

    public static base_responses change(nitro_service client, sslcertkey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey[] sslcertkeyArray = new sslcertkey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyArray[index] = new sslcertkey();
          sslcertkeyArray[index].certkey = resources[index].certkey;
          sslcertkeyArray[index].cert = resources[index].cert;
          sslcertkeyArray[index].key = resources[index].key;
          sslcertkeyArray[index].password = resources[index].password;
          sslcertkeyArray[index].fipskey = resources[index].fipskey;
          sslcertkeyArray[index].inform = resources[index].inform;
          sslcertkeyArray[index].passplain = resources[index].passplain;
          sslcertkeyArray[index].nodomaincheck = resources[index].nodomaincheck;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslcertkeyArray, "update");
      }
      return baseResponses;
    }

    public static sslcertkey[] get(nitro_service service) => (sslcertkey[]) new sslcertkey().get_resources(service, (options) null);

    public static sslcertkey[] get(nitro_service service, options option) => (sslcertkey[]) new sslcertkey().get_resources(service, option);

    public static sslcertkey get(nitro_service service, string certkey) => (sslcertkey) new sslcertkey()
    {
      certkey = certkey
    }.get_resource(service);

    public static sslcertkey[] get(nitro_service service, string[] certkey)
    {
      if (certkey == null || certkey.Length <= 0)
        return (sslcertkey[]) null;
      sslcertkey[] sslcertkeyArray1 = new sslcertkey[certkey.Length];
      sslcertkey[] sslcertkeyArray2 = new sslcertkey[certkey.Length];
      for (int index = 0; index < certkey.Length; ++index)
      {
        sslcertkeyArray2[index] = new sslcertkey();
        sslcertkeyArray2[index].certkey = certkey[index];
        sslcertkeyArray1[index] = (sslcertkey) sslcertkeyArray2[index].get_resource(service);
      }
      return sslcertkeyArray1;
    }

    public static sslcertkey[] get_filtered(nitro_service service, string filter)
    {
      sslcertkey sslcertkey = new sslcertkey();
      options option = new options();
      option.set_filter(filter);
      return (sslcertkey[]) sslcertkey.getfiltered(service, option);
    }

    public static sslcertkey[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcertkey sslcertkey = new sslcertkey();
      options option = new options();
      option.set_filter(filter);
      return (sslcertkey[]) sslcertkey.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslcertkey sslcertkey = new sslcertkey();
      options option = new options();
      option.set_count(true);
      sslcertkey[] resources = (sslcertkey[]) sslcertkey.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslcertkey sslcertkey = new sslcertkey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertkey[] sslcertkeyArray = (sslcertkey[]) sslcertkey.getfiltered(service, option);
      return sslcertkeyArray != null && sslcertkeyArray.Length > 0 ? sslcertkeyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcertkey sslcertkey = new sslcertkey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertkey[] sslcertkeyArray = (sslcertkey[]) sslcertkey.getfiltered(service, option);
      return sslcertkeyArray != null && sslcertkeyArray.Length > 0 ? sslcertkeyArray[0].__count.Value : 0U;
    }

    private class sslcertkey_response : base_response
    {
      public sslcertkey[] sslcertkey = (sslcertkey[]) null;
    }

    public static class bundleEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class expirymonitorEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class statusEnum
    {
      public const string Valid = "Valid";
      public const string Not_yet_valid = "Not yet valid";
      public const string Expired = "Expired";
    }

    public static class informEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
      public const string PFX = "PFX";
    }
  }
}
