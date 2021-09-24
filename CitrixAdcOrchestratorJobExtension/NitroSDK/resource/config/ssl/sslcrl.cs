// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcrl
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcrl : base_resource
  {
    private string crlnameField = (string) null;
    private string crlpathField = (string) null;
    private string informField = (string) null;
    private string refreshField = (string) null;
    private string cacertField = (string) null;
    private string methodField = (string) null;
    private string serverField = (string) null;
    private string urlField = (string) null;
    private ushort? portField = new ushort?();
    private string basednField = (string) null;
    private string scopeField = (string) null;
    private string intervalField = (string) null;
    private int? dayField = new int?();
    private string timeField = (string) null;
    private string binddnField = (string) null;
    private string passwordField = (string) null;
    private string binaryField = (string) null;
    private string cacertfileField = (string) null;
    private string cakeyfileField = (string) null;
    private string indexfileField = (string) null;
    private string revokeField = (string) null;
    private string gencrlField = (string) null;
    private int? flagsField = new int?();
    private int? lastupdatetimeField = new int?();
    private int? versionField = new int?();
    private string signaturealgoField = (string) null;
    private string issuerField = (string) null;
    private string lastupdateField = (string) null;
    private string nextupdateField = (string) null;
    private int? daystoexpirationField = new int?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string crlname
    {
      get => this.crlnameField;
      set => this.crlnameField = value;
    }

    public string crlpath
    {
      get => this.crlpathField;
      set => this.crlpathField = value;
    }

    public string inform
    {
      get => this.informField;
      set => this.informField = value;
    }

    public string refresh
    {
      get => this.refreshField;
      set => this.refreshField = value;
    }

    public string cacert
    {
      get => this.cacertField;
      set => this.cacertField = value;
    }

    public string method
    {
      get => this.methodField;
      set => this.methodField = value;
    }

    public string server
    {
      get => this.serverField;
      set => this.serverField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string basedn
    {
      get => this.basednField;
      set => this.basednField = value;
    }

    public string scope
    {
      get => this.scopeField;
      set => this.scopeField = value;
    }

    public string interval
    {
      get => this.intervalField;
      set => this.intervalField = value;
    }

    public int? day
    {
      get => this.dayField;
      set => this.dayField = value;
    }

    public string time
    {
      get => this.timeField;
      set => this.timeField = value;
    }

    public string binddn
    {
      get => this.binddnField;
      set => this.binddnField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public string binary
    {
      get => this.binaryField;
      set => this.binaryField = value;
    }

    public string cacertfile
    {
      get => this.cacertfileField;
      set => this.cacertfileField = value;
    }

    public string cakeyfile
    {
      get => this.cakeyfileField;
      set => this.cakeyfileField = value;
    }

    public string indexfile
    {
      get => this.indexfileField;
      set => this.indexfileField = value;
    }

    public string revoke
    {
      get => this.revokeField;
      set => this.revokeField = value;
    }

    public string gencrl
    {
      get => this.gencrlField;
      set => this.gencrlField = value;
    }

    public int? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public int? lastupdatetime
    {
      get => this.lastupdatetimeField;
      private set => this.lastupdatetimeField = value;
    }

    public int? version
    {
      get => this.versionField;
      private set => this.versionField = value;
    }

    public string signaturealgo
    {
      get => this.signaturealgoField;
      private set => this.signaturealgoField = value;
    }

    public string issuer
    {
      get => this.issuerField;
      private set => this.issuerField = value;
    }

    public string lastupdate
    {
      get => this.lastupdateField;
      private set => this.lastupdateField = value;
    }

    public string nextupdate
    {
      get => this.nextupdateField;
      private set => this.nextupdateField = value;
    }

    public int? daystoexpiration
    {
      get => this.daystoexpirationField;
      private set => this.daystoexpirationField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcrl.sslcrl_response sslcrlResponse = new sslcrl.sslcrl_response();
      sslcrl.sslcrl_response resource = (sslcrl.sslcrl_response) service.get_payload_formatter().string_to_resource(sslcrlResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcrl;
    }

    internal override string get_object_name() => this.crlname;

    public static base_response add(nitro_service client, sslcrl resource) => new sslcrl()
    {
      crlname = resource.crlname,
      crlpath = resource.crlpath,
      inform = resource.inform,
      refresh = resource.refresh,
      cacert = resource.cacert,
      method = resource.method,
      server = resource.server,
      url = resource.url,
      port = resource.port,
      basedn = resource.basedn,
      scope = resource.scope,
      interval = resource.interval,
      day = resource.day,
      time = resource.time,
      binddn = resource.binddn,
      password = resource.password,
      binary = resource.binary
    }.add_resource(client);

    public static base_responses add(nitro_service client, sslcrl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcrl[] sslcrlArray = new sslcrl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcrlArray[index] = new sslcrl();
          sslcrlArray[index].crlname = resources[index].crlname;
          sslcrlArray[index].crlpath = resources[index].crlpath;
          sslcrlArray[index].inform = resources[index].inform;
          sslcrlArray[index].refresh = resources[index].refresh;
          sslcrlArray[index].cacert = resources[index].cacert;
          sslcrlArray[index].method = resources[index].method;
          sslcrlArray[index].server = resources[index].server;
          sslcrlArray[index].url = resources[index].url;
          sslcrlArray[index].port = resources[index].port;
          sslcrlArray[index].basedn = resources[index].basedn;
          sslcrlArray[index].scope = resources[index].scope;
          sslcrlArray[index].interval = resources[index].interval;
          sslcrlArray[index].day = resources[index].day;
          sslcrlArray[index].time = resources[index].time;
          sslcrlArray[index].binddn = resources[index].binddn;
          sslcrlArray[index].password = resources[index].password;
          sslcrlArray[index].binary = resources[index].binary;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslcrlArray);
      }
      return baseResponses;
    }

    public static base_response create(nitro_service client, sslcrl resource) => new sslcrl()
    {
      cacertfile = resource.cacertfile,
      cakeyfile = resource.cakeyfile,
      indexfile = resource.indexfile,
      revoke = resource.revoke,
      gencrl = resource.gencrl,
      password = resource.password
    }.perform_operation_byaction(client, nameof (create));

    public static base_responses create(nitro_service client, sslcrl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcrl[] sslcrlArray = new sslcrl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcrlArray[index] = new sslcrl();
          sslcrlArray[index].cacertfile = resources[index].cacertfile;
          sslcrlArray[index].cakeyfile = resources[index].cakeyfile;
          sslcrlArray[index].indexfile = resources[index].indexfile;
          sslcrlArray[index].revoke = resources[index].revoke;
          sslcrlArray[index].gencrl = resources[index].gencrl;
          sslcrlArray[index].password = resources[index].password;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslcrlArray, nameof (create));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string crlname) => new sslcrl()
    {
      crlname = crlname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslcrl resource) => new sslcrl()
    {
      crlname = resource.crlname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] crlname)
    {
      base_responses baseResponses = (base_responses) null;
      if (crlname != null && crlname.Length > 0)
      {
        sslcrl[] sslcrlArray = new sslcrl[crlname.Length];
        for (int index = 0; index < crlname.Length; ++index)
        {
          sslcrlArray[index] = new sslcrl();
          sslcrlArray[index].crlname = crlname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcrlArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslcrl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcrl[] sslcrlArray = new sslcrl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcrlArray[index] = new sslcrl();
          sslcrlArray[index].crlname = resources[index].crlname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcrlArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, sslcrl resource) => new sslcrl()
    {
      crlname = resource.crlname,
      refresh = resource.refresh,
      cacert = resource.cacert,
      server = resource.server,
      method = resource.method,
      url = resource.url,
      port = resource.port,
      basedn = resource.basedn,
      scope = resource.scope,
      interval = resource.interval,
      day = resource.day,
      time = resource.time,
      binddn = resource.binddn,
      password = resource.password,
      binary = resource.binary
    }.update_resource(client);

    public static base_responses update(nitro_service client, sslcrl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcrl[] sslcrlArray = new sslcrl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcrlArray[index] = new sslcrl();
          sslcrlArray[index].crlname = resources[index].crlname;
          sslcrlArray[index].refresh = resources[index].refresh;
          sslcrlArray[index].cacert = resources[index].cacert;
          sslcrlArray[index].server = resources[index].server;
          sslcrlArray[index].method = resources[index].method;
          sslcrlArray[index].url = resources[index].url;
          sslcrlArray[index].port = resources[index].port;
          sslcrlArray[index].basedn = resources[index].basedn;
          sslcrlArray[index].scope = resources[index].scope;
          sslcrlArray[index].interval = resources[index].interval;
          sslcrlArray[index].day = resources[index].day;
          sslcrlArray[index].time = resources[index].time;
          sslcrlArray[index].binddn = resources[index].binddn;
          sslcrlArray[index].password = resources[index].password;
          sslcrlArray[index].binary = resources[index].binary;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslcrlArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string crlname,
      string[] args)
    {
      return new sslcrl() { crlname = crlname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      sslcrl resource,
      string[] args)
    {
      return new sslcrl() { crlname = resource.crlname }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] crlname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (crlname != null && crlname.Length > 0)
      {
        sslcrl[] sslcrlArray = new sslcrl[crlname.Length];
        for (int index = 0; index < crlname.Length; ++index)
        {
          sslcrlArray[index] = new sslcrl();
          sslcrlArray[index].crlname = crlname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslcrlArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      sslcrl[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcrl[] sslcrlArray = new sslcrl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcrlArray[index] = new sslcrl();
          sslcrlArray[index].crlname = resources[index].crlname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslcrlArray, args);
      }
      return baseResponses;
    }

    public static sslcrl[] get(nitro_service service) => (sslcrl[]) new sslcrl().get_resources(service, (options) null);

    public static sslcrl[] get(nitro_service service, options option) => (sslcrl[]) new sslcrl().get_resources(service, option);

    public static sslcrl get(nitro_service service, string crlname) => (sslcrl) new sslcrl()
    {
      crlname = crlname
    }.get_resource(service);

    public static sslcrl[] get(nitro_service service, string[] crlname)
    {
      if (crlname == null || crlname.Length <= 0)
        return (sslcrl[]) null;
      sslcrl[] sslcrlArray1 = new sslcrl[crlname.Length];
      sslcrl[] sslcrlArray2 = new sslcrl[crlname.Length];
      for (int index = 0; index < crlname.Length; ++index)
      {
        sslcrlArray2[index] = new sslcrl();
        sslcrlArray2[index].crlname = crlname[index];
        sslcrlArray1[index] = (sslcrl) sslcrlArray2[index].get_resource(service);
      }
      return sslcrlArray1;
    }

    public static sslcrl[] get_filtered(nitro_service service, string filter)
    {
      sslcrl sslcrl = new sslcrl();
      options option = new options();
      option.set_filter(filter);
      return (sslcrl[]) sslcrl.getfiltered(service, option);
    }

    public static sslcrl[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcrl sslcrl = new sslcrl();
      options option = new options();
      option.set_filter(filter);
      return (sslcrl[]) sslcrl.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslcrl sslcrl = new sslcrl();
      options option = new options();
      option.set_count(true);
      sslcrl[] resources = (sslcrl[]) sslcrl.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslcrl sslcrl = new sslcrl();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcrl[] sslcrlArray = (sslcrl[]) sslcrl.getfiltered(service, option);
      return sslcrlArray != null && sslcrlArray.Length > 0 ? sslcrlArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcrl sslcrl = new sslcrl();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcrl[] sslcrlArray = (sslcrl[]) sslcrl.getfiltered(service, option);
      return sslcrlArray != null && sslcrlArray.Length > 0 ? sslcrlArray[0].__count.Value : 0U;
    }

    private class sslcrl_response : base_response
    {
      public sslcrl[] sslcrl = (sslcrl[]) null;
    }

    public static class refreshEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class scopeEnum
    {
      public const string Base = "Base";
      public const string One = "One";
    }

    public static class binaryEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class intervalEnum
    {
      public const string MONTHLY = "MONTHLY";
      public const string WEEKLY = "WEEKLY";
      public const string DAILY = "DAILY";
      public const string NONE = "NONE";
    }

    public static class methodEnum
    {
      public const string HTTP = "HTTP";
      public const string LDAP = "LDAP";
    }

    public static class informEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
    }
  }
}
