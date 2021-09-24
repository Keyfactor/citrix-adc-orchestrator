// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rdp.rdpclientprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rdp
{
  public class rdpclientprofile : base_resource
  {
    private string nameField = (string) null;
    private string rdpurloverrideField = (string) null;
    private string redirectclipboardField = (string) null;
    private string redirectdrivesField = (string) null;
    private string redirectprintersField = (string) null;
    private string redirectcomportsField = (string) null;
    private string redirectpnpdevicesField = (string) null;
    private string keyboardhookField = (string) null;
    private string audiocapturemodeField = (string) null;
    private string videoplaybackmodeField = (string) null;
    private string multimonitorsupportField = (string) null;
    private uint? rdpcookievalidityField = new uint?();
    private string addusernameinrdpfileField = (string) null;
    private string rdpfilenameField = (string) null;
    private string rdphostField = (string) null;
    private string rdpcustomparamsField = (string) null;
    private string pskField = (string) null;
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

    public string rdpurloverride
    {
      get => this.rdpurloverrideField;
      set => this.rdpurloverrideField = value;
    }

    public string redirectclipboard
    {
      get => this.redirectclipboardField;
      set => this.redirectclipboardField = value;
    }

    public string redirectdrives
    {
      get => this.redirectdrivesField;
      set => this.redirectdrivesField = value;
    }

    public string redirectprinters
    {
      get => this.redirectprintersField;
      set => this.redirectprintersField = value;
    }

    public string redirectcomports
    {
      get => this.redirectcomportsField;
      set => this.redirectcomportsField = value;
    }

    public string redirectpnpdevices
    {
      get => this.redirectpnpdevicesField;
      set => this.redirectpnpdevicesField = value;
    }

    public string keyboardhook
    {
      get => this.keyboardhookField;
      set => this.keyboardhookField = value;
    }

    public string audiocapturemode
    {
      get => this.audiocapturemodeField;
      set => this.audiocapturemodeField = value;
    }

    public string videoplaybackmode
    {
      get => this.videoplaybackmodeField;
      set => this.videoplaybackmodeField = value;
    }

    public string multimonitorsupport
    {
      get => this.multimonitorsupportField;
      set => this.multimonitorsupportField = value;
    }

    public uint? rdpcookievalidity
    {
      get => this.rdpcookievalidityField;
      set => this.rdpcookievalidityField = value;
    }

    public string addusernameinrdpfile
    {
      get => this.addusernameinrdpfileField;
      set => this.addusernameinrdpfileField = value;
    }

    public string rdpfilename
    {
      get => this.rdpfilenameField;
      set => this.rdpfilenameField = value;
    }

    public string rdphost
    {
      get => this.rdphostField;
      set => this.rdphostField = value;
    }

    public string rdpcustomparams
    {
      get => this.rdpcustomparamsField;
      set => this.rdpcustomparamsField = value;
    }

    public string psk
    {
      get => this.pskField;
      set => this.pskField = value;
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
      rdpclientprofile.rdpclientprofile_response rdpclientprofileResponse = new rdpclientprofile.rdpclientprofile_response();
      rdpclientprofile.rdpclientprofile_response resource = (rdpclientprofile.rdpclientprofile_response) service.get_payload_formatter().string_to_resource(rdpclientprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rdpclientprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, rdpclientprofile resource) => new rdpclientprofile()
    {
      name = resource.name,
      rdpurloverride = resource.rdpurloverride,
      redirectclipboard = resource.redirectclipboard,
      redirectdrives = resource.redirectdrives,
      redirectprinters = resource.redirectprinters,
      redirectcomports = resource.redirectcomports,
      redirectpnpdevices = resource.redirectpnpdevices,
      keyboardhook = resource.keyboardhook,
      audiocapturemode = resource.audiocapturemode,
      videoplaybackmode = resource.videoplaybackmode,
      multimonitorsupport = resource.multimonitorsupport,
      rdpcookievalidity = resource.rdpcookievalidity,
      addusernameinrdpfile = resource.addusernameinrdpfile,
      rdpfilename = resource.rdpfilename,
      rdphost = resource.rdphost,
      rdpcustomparams = resource.rdpcustomparams,
      psk = resource.psk
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      rdpclientprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rdpclientprofile[] rdpclientprofileArray = new rdpclientprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rdpclientprofileArray[index] = new rdpclientprofile();
          rdpclientprofileArray[index].name = resources[index].name;
          rdpclientprofileArray[index].rdpurloverride = resources[index].rdpurloverride;
          rdpclientprofileArray[index].redirectclipboard = resources[index].redirectclipboard;
          rdpclientprofileArray[index].redirectdrives = resources[index].redirectdrives;
          rdpclientprofileArray[index].redirectprinters = resources[index].redirectprinters;
          rdpclientprofileArray[index].redirectcomports = resources[index].redirectcomports;
          rdpclientprofileArray[index].redirectpnpdevices = resources[index].redirectpnpdevices;
          rdpclientprofileArray[index].keyboardhook = resources[index].keyboardhook;
          rdpclientprofileArray[index].audiocapturemode = resources[index].audiocapturemode;
          rdpclientprofileArray[index].videoplaybackmode = resources[index].videoplaybackmode;
          rdpclientprofileArray[index].multimonitorsupport = resources[index].multimonitorsupport;
          rdpclientprofileArray[index].rdpcookievalidity = resources[index].rdpcookievalidity;
          rdpclientprofileArray[index].addusernameinrdpfile = resources[index].addusernameinrdpfile;
          rdpclientprofileArray[index].rdpfilename = resources[index].rdpfilename;
          rdpclientprofileArray[index].rdphost = resources[index].rdphost;
          rdpclientprofileArray[index].rdpcustomparams = resources[index].rdpcustomparams;
          rdpclientprofileArray[index].psk = resources[index].psk;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) rdpclientprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, rdpclientprofile resource) => new rdpclientprofile()
    {
      name = resource.name,
      rdpurloverride = resource.rdpurloverride,
      redirectclipboard = resource.redirectclipboard,
      redirectdrives = resource.redirectdrives,
      redirectprinters = resource.redirectprinters,
      redirectcomports = resource.redirectcomports,
      redirectpnpdevices = resource.redirectpnpdevices,
      keyboardhook = resource.keyboardhook,
      audiocapturemode = resource.audiocapturemode,
      videoplaybackmode = resource.videoplaybackmode,
      multimonitorsupport = resource.multimonitorsupport,
      rdpcookievalidity = resource.rdpcookievalidity,
      addusernameinrdpfile = resource.addusernameinrdpfile,
      rdpfilename = resource.rdpfilename,
      rdphost = resource.rdphost,
      rdpcustomparams = resource.rdpcustomparams,
      psk = resource.psk
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      rdpclientprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rdpclientprofile[] rdpclientprofileArray = new rdpclientprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rdpclientprofileArray[index] = new rdpclientprofile();
          rdpclientprofileArray[index].name = resources[index].name;
          rdpclientprofileArray[index].rdpurloverride = resources[index].rdpurloverride;
          rdpclientprofileArray[index].redirectclipboard = resources[index].redirectclipboard;
          rdpclientprofileArray[index].redirectdrives = resources[index].redirectdrives;
          rdpclientprofileArray[index].redirectprinters = resources[index].redirectprinters;
          rdpclientprofileArray[index].redirectcomports = resources[index].redirectcomports;
          rdpclientprofileArray[index].redirectpnpdevices = resources[index].redirectpnpdevices;
          rdpclientprofileArray[index].keyboardhook = resources[index].keyboardhook;
          rdpclientprofileArray[index].audiocapturemode = resources[index].audiocapturemode;
          rdpclientprofileArray[index].videoplaybackmode = resources[index].videoplaybackmode;
          rdpclientprofileArray[index].multimonitorsupport = resources[index].multimonitorsupport;
          rdpclientprofileArray[index].rdpcookievalidity = resources[index].rdpcookievalidity;
          rdpclientprofileArray[index].addusernameinrdpfile = resources[index].addusernameinrdpfile;
          rdpclientprofileArray[index].rdpfilename = resources[index].rdpfilename;
          rdpclientprofileArray[index].rdphost = resources[index].rdphost;
          rdpclientprofileArray[index].rdpcustomparams = resources[index].rdpcustomparams;
          rdpclientprofileArray[index].psk = resources[index].psk;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) rdpclientprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new rdpclientprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      rdpclientprofile resource,
      string[] args)
    {
      return new rdpclientprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rdpclientprofile[] rdpclientprofileArray = new rdpclientprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rdpclientprofileArray[index] = new rdpclientprofile();
          rdpclientprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rdpclientprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      rdpclientprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rdpclientprofile[] rdpclientprofileArray = new rdpclientprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rdpclientprofileArray[index] = new rdpclientprofile();
          rdpclientprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rdpclientprofileArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new rdpclientprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, rdpclientprofile resource) => new rdpclientprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rdpclientprofile[] rdpclientprofileArray = new rdpclientprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rdpclientprofileArray[index] = new rdpclientprofile();
          rdpclientprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rdpclientprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      rdpclientprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rdpclientprofile[] rdpclientprofileArray = new rdpclientprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rdpclientprofileArray[index] = new rdpclientprofile();
          rdpclientprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rdpclientprofileArray);
      }
      return baseResponses;
    }

    public static rdpclientprofile[] get(nitro_service service) => (rdpclientprofile[]) new rdpclientprofile().get_resources(service, (options) null);

    public static rdpclientprofile[] get(nitro_service service, options option) => (rdpclientprofile[]) new rdpclientprofile().get_resources(service, option);

    public static rdpclientprofile get(nitro_service service, string name) => (rdpclientprofile) new rdpclientprofile()
    {
      name = name
    }.get_resource(service);

    public static rdpclientprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (rdpclientprofile[]) null;
      rdpclientprofile[] rdpclientprofileArray1 = new rdpclientprofile[name.Length];
      rdpclientprofile[] rdpclientprofileArray2 = new rdpclientprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        rdpclientprofileArray2[index] = new rdpclientprofile();
        rdpclientprofileArray2[index].name = name[index];
        rdpclientprofileArray1[index] = (rdpclientprofile) rdpclientprofileArray2[index].get_resource(service);
      }
      return rdpclientprofileArray1;
    }

    public static rdpclientprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      rdpclientprofile rdpclientprofile = new rdpclientprofile();
      options option = new options();
      option.set_filter(filter);
      return (rdpclientprofile[]) rdpclientprofile.getfiltered(service, option);
    }

    public static rdpclientprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      rdpclientprofile rdpclientprofile = new rdpclientprofile();
      options option = new options();
      option.set_filter(filter);
      return (rdpclientprofile[]) rdpclientprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rdpclientprofile rdpclientprofile = new rdpclientprofile();
      options option = new options();
      option.set_count(true);
      rdpclientprofile[] resources = (rdpclientprofile[]) rdpclientprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rdpclientprofile rdpclientprofile = new rdpclientprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rdpclientprofile[] rdpclientprofileArray = (rdpclientprofile[]) rdpclientprofile.getfiltered(service, option);
      return rdpclientprofileArray != null && rdpclientprofileArray.Length > 0 ? rdpclientprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rdpclientprofile rdpclientprofile = new rdpclientprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rdpclientprofile[] rdpclientprofileArray = (rdpclientprofile[]) rdpclientprofile.getfiltered(service, option);
      return rdpclientprofileArray != null && rdpclientprofileArray.Length > 0 ? rdpclientprofileArray[0].__count.Value : 0U;
    }

    private class rdpclientprofile_response : base_response
    {
      public rdpclientprofile[] rdpclientprofile = (rdpclientprofile[]) null;
    }

    public static class rdpurloverrideEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class keyboardhookEnum
    {
      public const string OnLocal = "OnLocal";
      public const string OnRemote = "OnRemote";
      public const string InFullScreenMode = "InFullScreenMode";
    }

    public static class redirectcomportsEnum
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

    public static class multimonitorsupportEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class addusernameinrdpfileEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class videoplaybackmodeEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class redirectclipboardEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class redirectpnpdevicesEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class redirectprintersEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class audiocapturemodeEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class redirectdrivesEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }
  }
}
