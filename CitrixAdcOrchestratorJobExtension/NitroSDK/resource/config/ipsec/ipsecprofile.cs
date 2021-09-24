// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ipsec.ipsecprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ipsec
{
  public class ipsecprofile : base_resource
  {
    private string nameField = (string) null;
    private string ikeversionField = (string) null;
    private string[] encalgoField = (string[]) null;
    private string[] hashalgoField = (string[]) null;
    private uint? lifetimeField = new uint?();
    private string pskField = (string) null;
    private string publickeyField = (string) null;
    private string privatekeyField = (string) null;
    private string peerpublickeyField = (string) null;
    private uint? livenesscheckintervalField = new uint?();
    private uint? replaywindowsizeField = new uint?();
    private uint? ikeretryintervalField = new uint?();
    private uint? retransmissiontimeField = new uint?();
    private string perfectforwardsecrecyField = (string) null;
    private string[] builtinField = (string[]) null;
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

    public string ikeversion
    {
      get => this.ikeversionField;
      set => this.ikeversionField = value;
    }

    public string[] encalgo
    {
      get => this.encalgoField;
      set => this.encalgoField = value;
    }

    public string[] hashalgo
    {
      get => this.hashalgoField;
      set => this.hashalgoField = value;
    }

    public uint? lifetime
    {
      get => this.lifetimeField;
      set => this.lifetimeField = value;
    }

    public string psk
    {
      get => this.pskField;
      set => this.pskField = value;
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

    public string peerpublickey
    {
      get => this.peerpublickeyField;
      set => this.peerpublickeyField = value;
    }

    public uint? livenesscheckinterval
    {
      get => this.livenesscheckintervalField;
      set => this.livenesscheckintervalField = value;
    }

    public uint? replaywindowsize
    {
      get => this.replaywindowsizeField;
      set => this.replaywindowsizeField = value;
    }

    public uint? ikeretryinterval
    {
      get => this.ikeretryintervalField;
      set => this.ikeretryintervalField = value;
    }

    public uint? retransmissiontime
    {
      get => this.retransmissiontimeField;
      set => this.retransmissiontimeField = value;
    }

    public string perfectforwardsecrecy
    {
      get => this.perfectforwardsecrecyField;
      set => this.perfectforwardsecrecyField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ipsecprofile.ipsecprofile_response ipsecprofileResponse = new ipsecprofile.ipsecprofile_response();
      ipsecprofile.ipsecprofile_response resource = (ipsecprofile.ipsecprofile_response) service.get_payload_formatter().string_to_resource(ipsecprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ipsecprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, ipsecprofile resource) => new ipsecprofile()
    {
      name = resource.name,
      ikeversion = resource.ikeversion,
      encalgo = resource.encalgo,
      hashalgo = resource.hashalgo,
      lifetime = resource.lifetime,
      psk = resource.psk,
      publickey = resource.publickey,
      privatekey = resource.privatekey,
      peerpublickey = resource.peerpublickey,
      livenesscheckinterval = resource.livenesscheckinterval,
      replaywindowsize = resource.replaywindowsize,
      ikeretryinterval = resource.ikeretryinterval,
      retransmissiontime = resource.retransmissiontime,
      perfectforwardsecrecy = resource.perfectforwardsecrecy
    }.add_resource(client);

    public static base_responses add(nitro_service client, ipsecprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipsecprofile[] ipsecprofileArray = new ipsecprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipsecprofileArray[index] = new ipsecprofile();
          ipsecprofileArray[index].name = resources[index].name;
          ipsecprofileArray[index].ikeversion = resources[index].ikeversion;
          ipsecprofileArray[index].encalgo = resources[index].encalgo;
          ipsecprofileArray[index].hashalgo = resources[index].hashalgo;
          ipsecprofileArray[index].lifetime = resources[index].lifetime;
          ipsecprofileArray[index].psk = resources[index].psk;
          ipsecprofileArray[index].publickey = resources[index].publickey;
          ipsecprofileArray[index].privatekey = resources[index].privatekey;
          ipsecprofileArray[index].peerpublickey = resources[index].peerpublickey;
          ipsecprofileArray[index].livenesscheckinterval = resources[index].livenesscheckinterval;
          ipsecprofileArray[index].replaywindowsize = resources[index].replaywindowsize;
          ipsecprofileArray[index].ikeretryinterval = resources[index].ikeretryinterval;
          ipsecprofileArray[index].retransmissiontime = resources[index].retransmissiontime;
          ipsecprofileArray[index].perfectforwardsecrecy = resources[index].perfectforwardsecrecy;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) ipsecprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new ipsecprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, ipsecprofile resource) => new ipsecprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        ipsecprofile[] ipsecprofileArray = new ipsecprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          ipsecprofileArray[index] = new ipsecprofile();
          ipsecprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ipsecprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      ipsecprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipsecprofile[] ipsecprofileArray = new ipsecprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipsecprofileArray[index] = new ipsecprofile();
          ipsecprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ipsecprofileArray);
      }
      return baseResponses;
    }

    public static ipsecprofile[] get(nitro_service service) => (ipsecprofile[]) new ipsecprofile().get_resources(service, (options) null);

    public static ipsecprofile[] get(nitro_service service, options option) => (ipsecprofile[]) new ipsecprofile().get_resources(service, option);

    public static ipsecprofile get(nitro_service service, string name) => (ipsecprofile) new ipsecprofile()
    {
      name = name
    }.get_resource(service);

    public static ipsecprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (ipsecprofile[]) null;
      ipsecprofile[] ipsecprofileArray1 = new ipsecprofile[name.Length];
      ipsecprofile[] ipsecprofileArray2 = new ipsecprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        ipsecprofileArray2[index] = new ipsecprofile();
        ipsecprofileArray2[index].name = name[index];
        ipsecprofileArray1[index] = (ipsecprofile) ipsecprofileArray2[index].get_resource(service);
      }
      return ipsecprofileArray1;
    }

    public static ipsecprofile[] get_filtered(nitro_service service, string filter)
    {
      ipsecprofile ipsecprofile = new ipsecprofile();
      options option = new options();
      option.set_filter(filter);
      return (ipsecprofile[]) ipsecprofile.getfiltered(service, option);
    }

    public static ipsecprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      ipsecprofile ipsecprofile = new ipsecprofile();
      options option = new options();
      option.set_filter(filter);
      return (ipsecprofile[]) ipsecprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      ipsecprofile ipsecprofile = new ipsecprofile();
      options option = new options();
      option.set_count(true);
      ipsecprofile[] resources = (ipsecprofile[]) ipsecprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      ipsecprofile ipsecprofile = new ipsecprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipsecprofile[] ipsecprofileArray = (ipsecprofile[]) ipsecprofile.getfiltered(service, option);
      return ipsecprofileArray != null && ipsecprofileArray.Length > 0 ? ipsecprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      ipsecprofile ipsecprofile = new ipsecprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipsecprofile[] ipsecprofileArray = (ipsecprofile[]) ipsecprofile.getfiltered(service, option);
      return ipsecprofileArray != null && ipsecprofileArray.Length > 0 ? ipsecprofileArray[0].__count.Value : 0U;
    }

    private class ipsecprofile_response : base_response
    {
      public ipsecprofile[] ipsecprofile = (ipsecprofile[]) null;
    }

    public static class perfectforwardsecrecyEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class encalgoEnum
    {
      public const string AES = "AES";
      public const string _3DES = "3DES";
    }

    public static class ikeversionEnum
    {
      public const string V1 = "V1";
      public const string V2 = "V2";
    }

    public static class hashalgoEnum
    {
      public const string HMAC_SHA1 = "HMAC_SHA1";
      public const string HMAC_SHA256 = "HMAC_SHA256";
      public const string HMAC_SHA384 = "HMAC_SHA384";
      public const string HMAC_SHA512 = "HMAC_SHA512";
      public const string HMAC_MD5 = "HMAC_MD5";
    }
  }
}
