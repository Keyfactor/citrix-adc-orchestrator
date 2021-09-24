// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnskey
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnskey : base_resource
  {
    private string keynameField = (string) null;
    private string publickeyField = (string) null;
    private string privatekeyField = (string) null;
    private uint? expiresField = new uint?();
    private string units1Field = (string) null;
    private uint? notificationperiodField = new uint?();
    private string units2Field = (string) null;
    private long? ttlField = new long?();
    private string zonenameField = (string) null;
    private string keytypeField = (string) null;
    private string algorithmField = (string) null;
    private uint? keysizeField = new uint?();
    private string filenameprefixField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string keyname
    {
      get => this.keynameField;
      set => this.keynameField = value;
    }

    public string publickey
    {
      get => this.publickeyField;
      set => this.publickeyField = value;
    }

    public string privatekey
    {
      get => this.privatekeyField;
      set => this.privatekeyField = value;
    }

    public uint? expires
    {
      get => this.expiresField;
      set => this.expiresField = value;
    }

    public string units1
    {
      get => this.units1Field;
      set => this.units1Field = value;
    }

    public uint? notificationperiod
    {
      get => this.notificationperiodField;
      set => this.notificationperiodField = value;
    }

    public string units2
    {
      get => this.units2Field;
      set => this.units2Field = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public string zonename
    {
      get => this.zonenameField;
      set => this.zonenameField = value;
    }

    public string keytype
    {
      get => this.keytypeField;
      set => this.keytypeField = value;
    }

    public string algorithm
    {
      get => this.algorithmField;
      set => this.algorithmField = value;
    }

    public uint? keysize
    {
      get => this.keysizeField;
      set => this.keysizeField = value;
    }

    public string filenameprefix
    {
      get => this.filenameprefixField;
      set => this.filenameprefixField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnskey.dnskey_response dnskeyResponse = new dnskey.dnskey_response();
      dnskey.dnskey_response resource = (dnskey.dnskey_response) service.get_payload_formatter().string_to_resource(dnskeyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnskey;
    }

    internal override string get_object_name() => this.keyname;

    public static base_response add(nitro_service client, dnskey resource) => new dnskey()
    {
      keyname = resource.keyname,
      publickey = resource.publickey,
      privatekey = resource.privatekey,
      expires = resource.expires,
      units1 = resource.units1,
      notificationperiod = resource.notificationperiod,
      units2 = resource.units2,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnskey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnskey[] dnskeyArray = new dnskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnskeyArray[index] = new dnskey();
          dnskeyArray[index].keyname = resources[index].keyname;
          dnskeyArray[index].publickey = resources[index].publickey;
          dnskeyArray[index].privatekey = resources[index].privatekey;
          dnskeyArray[index].expires = resources[index].expires;
          dnskeyArray[index].units1 = resources[index].units1;
          dnskeyArray[index].notificationperiod = resources[index].notificationperiod;
          dnskeyArray[index].units2 = resources[index].units2;
          dnskeyArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnskeyArray);
      }
      return baseResponses;
    }

    public static base_response create(nitro_service client, dnskey resource) => new dnskey()
    {
      zonename = resource.zonename,
      keytype = resource.keytype,
      algorithm = resource.algorithm,
      keysize = resource.keysize,
      filenameprefix = resource.filenameprefix
    }.perform_operation_byaction(client, nameof (create));

    public static base_responses create(nitro_service client, dnskey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnskey[] dnskeyArray = new dnskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnskeyArray[index] = new dnskey();
          dnskeyArray[index].zonename = resources[index].zonename;
          dnskeyArray[index].keytype = resources[index].keytype;
          dnskeyArray[index].algorithm = resources[index].algorithm;
          dnskeyArray[index].keysize = resources[index].keysize;
          dnskeyArray[index].filenameprefix = resources[index].filenameprefix;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) dnskeyArray, nameof (create));
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnskey resource) => new dnskey()
    {
      keyname = resource.keyname,
      expires = resource.expires,
      units1 = resource.units1,
      notificationperiod = resource.notificationperiod,
      units2 = resource.units2,
      ttl = resource.ttl
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnskey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnskey[] dnskeyArray = new dnskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnskeyArray[index] = new dnskey();
          dnskeyArray[index].keyname = resources[index].keyname;
          dnskeyArray[index].expires = resources[index].expires;
          dnskeyArray[index].units1 = resources[index].units1;
          dnskeyArray[index].notificationperiod = resources[index].notificationperiod;
          dnskeyArray[index].units2 = resources[index].units2;
          dnskeyArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnskeyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string keyname,
      string[] args)
    {
      return new dnskey() { keyname = keyname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dnskey resource,
      string[] args)
    {
      return new dnskey() { keyname = resource.keyname }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] keyname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (keyname != null && keyname.Length > 0)
      {
        dnskey[] dnskeyArray = new dnskey[keyname.Length];
        for (int index = 0; index < keyname.Length; ++index)
        {
          dnskeyArray[index] = new dnskey();
          dnskeyArray[index].keyname = keyname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnskeyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dnskey[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnskey[] dnskeyArray = new dnskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnskeyArray[index] = new dnskey();
          dnskeyArray[index].keyname = resources[index].keyname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnskeyArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string keyname) => new dnskey()
    {
      keyname = keyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnskey resource) => new dnskey()
    {
      keyname = resource.keyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] keyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (keyname != null && keyname.Length > 0)
      {
        dnskey[] dnskeyArray = new dnskey[keyname.Length];
        for (int index = 0; index < keyname.Length; ++index)
        {
          dnskeyArray[index] = new dnskey();
          dnskeyArray[index].keyname = keyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnskeyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnskey[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnskey[] dnskeyArray = new dnskey[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnskeyArray[index] = new dnskey();
          dnskeyArray[index].keyname = resources[index].keyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnskeyArray);
      }
      return baseResponses;
    }

    public static dnskey[] get(nitro_service service) => (dnskey[]) new dnskey().get_resources(service, (options) null);

    public static dnskey[] get(nitro_service service, options option) => (dnskey[]) new dnskey().get_resources(service, option);

    public static dnskey get(nitro_service service, string keyname) => (dnskey) new dnskey()
    {
      keyname = keyname
    }.get_resource(service);

    public static dnskey[] get(nitro_service service, string[] keyname)
    {
      if (keyname == null || keyname.Length <= 0)
        return (dnskey[]) null;
      dnskey[] dnskeyArray1 = new dnskey[keyname.Length];
      dnskey[] dnskeyArray2 = new dnskey[keyname.Length];
      for (int index = 0; index < keyname.Length; ++index)
      {
        dnskeyArray2[index] = new dnskey();
        dnskeyArray2[index].keyname = keyname[index];
        dnskeyArray1[index] = (dnskey) dnskeyArray2[index].get_resource(service);
      }
      return dnskeyArray1;
    }

    public static dnskey[] get_filtered(nitro_service service, string filter)
    {
      dnskey dnskey = new dnskey();
      options option = new options();
      option.set_filter(filter);
      return (dnskey[]) dnskey.getfiltered(service, option);
    }

    public static dnskey[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnskey dnskey = new dnskey();
      options option = new options();
      option.set_filter(filter);
      return (dnskey[]) dnskey.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnskey dnskey = new dnskey();
      options option = new options();
      option.set_count(true);
      dnskey[] resources = (dnskey[]) dnskey.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnskey dnskey = new dnskey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnskey[] dnskeyArray = (dnskey[]) dnskey.getfiltered(service, option);
      return dnskeyArray != null && dnskeyArray.Length > 0 ? dnskeyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnskey dnskey = new dnskey();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnskey[] dnskeyArray = (dnskey[]) dnskey.getfiltered(service, option);
      return dnskeyArray != null && dnskeyArray.Length > 0 ? dnskeyArray[0].__count.Value : 0U;
    }

    private class dnskey_response : base_response
    {
      public dnskey[] dnskey = (dnskey[]) null;
    }

    public static class algorithmEnum
    {
      public const string RSASHA1 = "RSASHA1";
    }

    public static class keytypeEnum
    {
      public const string KSK = "KSK";
      public const string KeySigningKey = "KeySigningKey";
      public const string ZSK = "ZSK";
      public const string ZoneSigningKey = "ZoneSigningKey";
    }

    public static class units1Enum
    {
      public const string MINUTES = "MINUTES";
      public const string HOURS = "HOURS";
      public const string DAYS = "DAYS";
    }

    public static class units2Enum
    {
      public const string MINUTES = "MINUTES";
      public const string HOURS = "HOURS";
      public const string DAYS = "DAYS";
    }
  }
}
