// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiusaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationradiusaction : base_resource
  {
    private string nameField = (string) null;
    private string serveripField = (string) null;
    private string servernameField = (string) null;
    private ushort? serverportField = new ushort?();
    private uint? authtimeoutField = new uint?();
    private string radkeyField = (string) null;
    private string radnasipField = (string) null;
    private string radnasidField = (string) null;
    private uint? radvendoridField = new uint?();
    private uint? radattributetypeField = new uint?();
    private string radgroupsprefixField = (string) null;
    private string radgroupseparatorField = (string) null;
    private string passencodingField = (string) null;
    private uint? ipvendoridField = new uint?();
    private uint? ipattributetypeField = new uint?();
    private string accountingField = (string) null;
    private uint? pwdvendoridField = new uint?();
    private uint? pwdattributetypeField = new uint?();
    private string defaultauthenticationgroupField = (string) null;
    private string callingstationidField = (string) null;
    private string ipaddressField = (string) null;
    private long? successField = new long?();
    private long? failureField = new long?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string serverip
    {
      get => this.serveripField;
      set => this.serveripField = value;
    }

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
    }

    public ushort? serverport
    {
      get => this.serverportField;
      set => this.serverportField = value;
    }

    public uint? authtimeout
    {
      get => this.authtimeoutField;
      set => this.authtimeoutField = value;
    }

    public string radkey
    {
      get => this.radkeyField;
      set => this.radkeyField = value;
    }

    public string radnasip
    {
      get => this.radnasipField;
      set => this.radnasipField = value;
    }

    public string radnasid
    {
      get => this.radnasidField;
      set => this.radnasidField = value;
    }

    public uint? radvendorid
    {
      get => this.radvendoridField;
      set => this.radvendoridField = value;
    }

    public uint? radattributetype
    {
      get => this.radattributetypeField;
      set => this.radattributetypeField = value;
    }

    public string radgroupsprefix
    {
      get => this.radgroupsprefixField;
      set => this.radgroupsprefixField = value;
    }

    public string radgroupseparator
    {
      get => this.radgroupseparatorField;
      set => this.radgroupseparatorField = value;
    }

    public string passencoding
    {
      get => this.passencodingField;
      set => this.passencodingField = value;
    }

    public uint? ipvendorid
    {
      get => this.ipvendoridField;
      set => this.ipvendoridField = value;
    }

    public uint? ipattributetype
    {
      get => this.ipattributetypeField;
      set => this.ipattributetypeField = value;
    }

    public string accounting
    {
      get => this.accountingField;
      set => this.accountingField = value;
    }

    public uint? pwdvendorid
    {
      get => this.pwdvendoridField;
      set => this.pwdvendoridField = value;
    }

    public uint? pwdattributetype
    {
      get => this.pwdattributetypeField;
      set => this.pwdattributetypeField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    public string callingstationid
    {
      get => this.callingstationidField;
      set => this.callingstationidField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    public long? success
    {
      get => this.successField;
      private set => this.successField = value;
    }

    public long? failure
    {
      get => this.failureField;
      private set => this.failureField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationradiusaction.authenticationradiusaction_response authenticationradiusactionResponse = new authenticationradiusaction.authenticationradiusaction_response();
      authenticationradiusaction.authenticationradiusaction_response resource = (authenticationradiusaction.authenticationradiusaction_response) service.get_payload_formatter().string_to_resource(authenticationradiusactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationradiusaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationradiusaction resource)
    {
      return new authenticationradiusaction()
      {
        name = resource.name,
        serverip = resource.serverip,
        servername = resource.servername,
        serverport = resource.serverport,
        authtimeout = resource.authtimeout,
        radkey = resource.radkey,
        radnasip = resource.radnasip,
        radnasid = resource.radnasid,
        radvendorid = resource.radvendorid,
        radattributetype = resource.radattributetype,
        radgroupsprefix = resource.radgroupsprefix,
        radgroupseparator = resource.radgroupseparator,
        passencoding = resource.passencoding,
        ipvendorid = resource.ipvendorid,
        ipattributetype = resource.ipattributetype,
        accounting = resource.accounting,
        pwdvendorid = resource.pwdvendorid,
        pwdattributetype = resource.pwdattributetype,
        defaultauthenticationgroup = resource.defaultauthenticationgroup,
        callingstationid = resource.callingstationid
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationradiusaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationradiusaction[] authenticationradiusactionArray = new authenticationradiusaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationradiusactionArray[index] = new authenticationradiusaction();
          authenticationradiusactionArray[index].name = resources[index].name;
          authenticationradiusactionArray[index].serverip = resources[index].serverip;
          authenticationradiusactionArray[index].servername = resources[index].servername;
          authenticationradiusactionArray[index].serverport = resources[index].serverport;
          authenticationradiusactionArray[index].authtimeout = resources[index].authtimeout;
          authenticationradiusactionArray[index].radkey = resources[index].radkey;
          authenticationradiusactionArray[index].radnasip = resources[index].radnasip;
          authenticationradiusactionArray[index].radnasid = resources[index].radnasid;
          authenticationradiusactionArray[index].radvendorid = resources[index].radvendorid;
          authenticationradiusactionArray[index].radattributetype = resources[index].radattributetype;
          authenticationradiusactionArray[index].radgroupsprefix = resources[index].radgroupsprefix;
          authenticationradiusactionArray[index].radgroupseparator = resources[index].radgroupseparator;
          authenticationradiusactionArray[index].passencoding = resources[index].passencoding;
          authenticationradiusactionArray[index].ipvendorid = resources[index].ipvendorid;
          authenticationradiusactionArray[index].ipattributetype = resources[index].ipattributetype;
          authenticationradiusactionArray[index].accounting = resources[index].accounting;
          authenticationradiusactionArray[index].pwdvendorid = resources[index].pwdvendorid;
          authenticationradiusactionArray[index].pwdattributetype = resources[index].pwdattributetype;
          authenticationradiusactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationradiusactionArray[index].callingstationid = resources[index].callingstationid;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationradiusactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationradiusaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationradiusaction resource)
    {
      return new authenticationradiusaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationradiusaction[] authenticationradiusactionArray = new authenticationradiusaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationradiusactionArray[index] = new authenticationradiusaction();
          authenticationradiusactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationradiusactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationradiusaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationradiusaction[] authenticationradiusactionArray = new authenticationradiusaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationradiusactionArray[index] = new authenticationradiusaction();
          authenticationradiusactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationradiusactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationradiusaction resource)
    {
      return new authenticationradiusaction()
      {
        name = resource.name,
        serverip = resource.serverip,
        servername = resource.servername,
        serverport = resource.serverport,
        authtimeout = resource.authtimeout,
        radkey = resource.radkey,
        radnasip = resource.radnasip,
        radnasid = resource.radnasid,
        radvendorid = resource.radvendorid,
        radattributetype = resource.radattributetype,
        radgroupsprefix = resource.radgroupsprefix,
        radgroupseparator = resource.radgroupseparator,
        passencoding = resource.passencoding,
        ipvendorid = resource.ipvendorid,
        ipattributetype = resource.ipattributetype,
        accounting = resource.accounting,
        pwdvendorid = resource.pwdvendorid,
        pwdattributetype = resource.pwdattributetype,
        defaultauthenticationgroup = resource.defaultauthenticationgroup,
        callingstationid = resource.callingstationid
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationradiusaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationradiusaction[] authenticationradiusactionArray = new authenticationradiusaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationradiusactionArray[index] = new authenticationradiusaction();
          authenticationradiusactionArray[index].name = resources[index].name;
          authenticationradiusactionArray[index].serverip = resources[index].serverip;
          authenticationradiusactionArray[index].servername = resources[index].servername;
          authenticationradiusactionArray[index].serverport = resources[index].serverport;
          authenticationradiusactionArray[index].authtimeout = resources[index].authtimeout;
          authenticationradiusactionArray[index].radkey = resources[index].radkey;
          authenticationradiusactionArray[index].radnasip = resources[index].radnasip;
          authenticationradiusactionArray[index].radnasid = resources[index].radnasid;
          authenticationradiusactionArray[index].radvendorid = resources[index].radvendorid;
          authenticationradiusactionArray[index].radattributetype = resources[index].radattributetype;
          authenticationradiusactionArray[index].radgroupsprefix = resources[index].radgroupsprefix;
          authenticationradiusactionArray[index].radgroupseparator = resources[index].radgroupseparator;
          authenticationradiusactionArray[index].passencoding = resources[index].passencoding;
          authenticationradiusactionArray[index].ipvendorid = resources[index].ipvendorid;
          authenticationradiusactionArray[index].ipattributetype = resources[index].ipattributetype;
          authenticationradiusactionArray[index].accounting = resources[index].accounting;
          authenticationradiusactionArray[index].pwdvendorid = resources[index].pwdvendorid;
          authenticationradiusactionArray[index].pwdattributetype = resources[index].pwdattributetype;
          authenticationradiusactionArray[index].defaultauthenticationgroup = resources[index].defaultauthenticationgroup;
          authenticationradiusactionArray[index].callingstationid = resources[index].callingstationid;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationradiusactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationradiusaction()
      {
        name = name
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationradiusaction resource,
      string[] args)
    {
      return new authenticationradiusaction()
      {
        name = resource.name
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationradiusaction[] authenticationradiusactionArray = new authenticationradiusaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationradiusactionArray[index] = new authenticationradiusaction();
          authenticationradiusactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationradiusactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationradiusaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationradiusaction[] authenticationradiusactionArray = new authenticationradiusaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationradiusactionArray[index] = new authenticationradiusaction();
          authenticationradiusactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationradiusactionArray, args);
      }
      return baseResponses;
    }

    public static authenticationradiusaction[] get(nitro_service service) => (authenticationradiusaction[]) new authenticationradiusaction().get_resources(service, (options) null);

    public static authenticationradiusaction[] get(
      nitro_service service,
      options option)
    {
      return (authenticationradiusaction[]) new authenticationradiusaction().get_resources(service, option);
    }

    public static authenticationradiusaction get(
      nitro_service service,
      string name)
    {
      return (authenticationradiusaction) new authenticationradiusaction()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationradiusaction[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationradiusaction[]) null;
      authenticationradiusaction[] authenticationradiusactionArray1 = new authenticationradiusaction[name.Length];
      authenticationradiusaction[] authenticationradiusactionArray2 = new authenticationradiusaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationradiusactionArray2[index] = new authenticationradiusaction();
        authenticationradiusactionArray2[index].name = name[index];
        authenticationradiusactionArray1[index] = (authenticationradiusaction) authenticationradiusactionArray2[index].get_resource(service);
      }
      return authenticationradiusactionArray1;
    }

    public static authenticationradiusaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationradiusaction authenticationradiusaction = new authenticationradiusaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationradiusaction[]) authenticationradiusaction.getfiltered(service, option);
    }

    public static authenticationradiusaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationradiusaction authenticationradiusaction = new authenticationradiusaction();
      options option = new options();
      option.set_filter(filter);
      return (authenticationradiusaction[]) authenticationradiusaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationradiusaction authenticationradiusaction = new authenticationradiusaction();
      options option = new options();
      option.set_count(true);
      authenticationradiusaction[] resources = (authenticationradiusaction[]) authenticationradiusaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationradiusaction authenticationradiusaction = new authenticationradiusaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationradiusaction[] authenticationradiusactionArray = (authenticationradiusaction[]) authenticationradiusaction.getfiltered(service, option);
      return authenticationradiusactionArray != null && authenticationradiusactionArray.Length > 0 ? authenticationradiusactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationradiusaction authenticationradiusaction = new authenticationradiusaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationradiusaction[] authenticationradiusactionArray = (authenticationradiusaction[]) authenticationradiusaction.getfiltered(service, option);
      return authenticationradiusactionArray != null && authenticationradiusactionArray.Length > 0 ? authenticationradiusactionArray[0].__count.Value : 0U;
    }

    private class authenticationradiusaction_response : base_response
    {
      public authenticationradiusaction[] authenticationradiusaction = (authenticationradiusaction[]) null;
    }

    public static class passencodingEnum
    {
      public const string pap = "pap";
      public const string chap = "chap";
      public const string mschapv1 = "mschapv1";
      public const string mschapv2 = "mschapv2";
    }

    public static class callingstationidEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class accountingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class radnasipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
