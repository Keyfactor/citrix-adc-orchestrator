// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ica.icaaccessprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ica
{
  public class icaaccessprofile : base_resource
  {
    private string nameField = (string) null;
    private string connectclientlptportsField = (string) null;
    private string clientaudioredirectionField = (string) null;
    private string localremotedatasharingField = (string) null;
    private string clientclipboardredirectionField = (string) null;
    private string clientcomportredirectionField = (string) null;
    private string clientdriveredirectionField = (string) null;
    private string clientprinterredirectionField = (string) null;
    private string multistreamField = (string) null;
    private string clientusbdriveredirectionField = (string) null;
    private uint? refcntField = new uint?();
    private string[] builtinField = (string[]) null;
    private bool? isdefaultField = new bool?();
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

    public string connectclientlptports
    {
      get => this.connectclientlptportsField;
      set => this.connectclientlptportsField = value;
    }

    public string clientaudioredirection
    {
      get => this.clientaudioredirectionField;
      set => this.clientaudioredirectionField = value;
    }

    public string localremotedatasharing
    {
      get => this.localremotedatasharingField;
      set => this.localremotedatasharingField = value;
    }

    public string clientclipboardredirection
    {
      get => this.clientclipboardredirectionField;
      set => this.clientclipboardredirectionField = value;
    }

    public string clientcomportredirection
    {
      get => this.clientcomportredirectionField;
      set => this.clientcomportredirectionField = value;
    }

    public string clientdriveredirection
    {
      get => this.clientdriveredirectionField;
      set => this.clientdriveredirectionField = value;
    }

    public string clientprinterredirection
    {
      get => this.clientprinterredirectionField;
      set => this.clientprinterredirectionField = value;
    }

    public string multistream
    {
      get => this.multistreamField;
      set => this.multistreamField = value;
    }

    public string clientusbdriveredirection
    {
      get => this.clientusbdriveredirectionField;
      set => this.clientusbdriveredirectionField = value;
    }

    public uint? refcnt
    {
      get => this.refcntField;
      private set => this.refcntField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      icaaccessprofile.icaaccessprofile_response icaaccessprofileResponse = new icaaccessprofile.icaaccessprofile_response();
      icaaccessprofile.icaaccessprofile_response resource = (icaaccessprofile.icaaccessprofile_response) service.get_payload_formatter().string_to_resource(icaaccessprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.icaaccessprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, icaaccessprofile resource) => new icaaccessprofile()
    {
      name = resource.name,
      connectclientlptports = resource.connectclientlptports,
      clientaudioredirection = resource.clientaudioredirection,
      localremotedatasharing = resource.localremotedatasharing,
      clientclipboardredirection = resource.clientclipboardredirection,
      clientcomportredirection = resource.clientcomportredirection,
      clientdriveredirection = resource.clientdriveredirection,
      clientprinterredirection = resource.clientprinterredirection,
      multistream = resource.multistream,
      clientusbdriveredirection = resource.clientusbdriveredirection
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      icaaccessprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaaccessprofile[] icaaccessprofileArray = new icaaccessprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icaaccessprofileArray[index] = new icaaccessprofile();
          icaaccessprofileArray[index].name = resources[index].name;
          icaaccessprofileArray[index].connectclientlptports = resources[index].connectclientlptports;
          icaaccessprofileArray[index].clientaudioredirection = resources[index].clientaudioredirection;
          icaaccessprofileArray[index].localremotedatasharing = resources[index].localremotedatasharing;
          icaaccessprofileArray[index].clientclipboardredirection = resources[index].clientclipboardredirection;
          icaaccessprofileArray[index].clientcomportredirection = resources[index].clientcomportredirection;
          icaaccessprofileArray[index].clientdriveredirection = resources[index].clientdriveredirection;
          icaaccessprofileArray[index].clientprinterredirection = resources[index].clientprinterredirection;
          icaaccessprofileArray[index].multistream = resources[index].multistream;
          icaaccessprofileArray[index].clientusbdriveredirection = resources[index].clientusbdriveredirection;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) icaaccessprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new icaaccessprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, icaaccessprofile resource) => new icaaccessprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        icaaccessprofile[] icaaccessprofileArray = new icaaccessprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          icaaccessprofileArray[index] = new icaaccessprofile();
          icaaccessprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) icaaccessprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      icaaccessprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaaccessprofile[] icaaccessprofileArray = new icaaccessprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icaaccessprofileArray[index] = new icaaccessprofile();
          icaaccessprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) icaaccessprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, icaaccessprofile resource) => new icaaccessprofile()
    {
      name = resource.name,
      connectclientlptports = resource.connectclientlptports,
      clientaudioredirection = resource.clientaudioredirection,
      localremotedatasharing = resource.localremotedatasharing,
      clientclipboardredirection = resource.clientclipboardredirection,
      clientcomportredirection = resource.clientcomportredirection,
      clientdriveredirection = resource.clientdriveredirection,
      clientprinterredirection = resource.clientprinterredirection,
      multistream = resource.multistream,
      clientusbdriveredirection = resource.clientusbdriveredirection
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      icaaccessprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaaccessprofile[] icaaccessprofileArray = new icaaccessprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icaaccessprofileArray[index] = new icaaccessprofile();
          icaaccessprofileArray[index].name = resources[index].name;
          icaaccessprofileArray[index].connectclientlptports = resources[index].connectclientlptports;
          icaaccessprofileArray[index].clientaudioredirection = resources[index].clientaudioredirection;
          icaaccessprofileArray[index].localremotedatasharing = resources[index].localremotedatasharing;
          icaaccessprofileArray[index].clientclipboardredirection = resources[index].clientclipboardredirection;
          icaaccessprofileArray[index].clientcomportredirection = resources[index].clientcomportredirection;
          icaaccessprofileArray[index].clientdriveredirection = resources[index].clientdriveredirection;
          icaaccessprofileArray[index].clientprinterredirection = resources[index].clientprinterredirection;
          icaaccessprofileArray[index].multistream = resources[index].multistream;
          icaaccessprofileArray[index].clientusbdriveredirection = resources[index].clientusbdriveredirection;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) icaaccessprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new icaaccessprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      icaaccessprofile resource,
      string[] args)
    {
      return new icaaccessprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        icaaccessprofile[] icaaccessprofileArray = new icaaccessprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          icaaccessprofileArray[index] = new icaaccessprofile();
          icaaccessprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) icaaccessprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      icaaccessprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        icaaccessprofile[] icaaccessprofileArray = new icaaccessprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          icaaccessprofileArray[index] = new icaaccessprofile();
          icaaccessprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) icaaccessprofileArray, args);
      }
      return baseResponses;
    }

    public static icaaccessprofile[] get(nitro_service service) => (icaaccessprofile[]) new icaaccessprofile().get_resources(service, (options) null);

    public static icaaccessprofile[] get(nitro_service service, options option) => (icaaccessprofile[]) new icaaccessprofile().get_resources(service, option);

    public static icaaccessprofile get(nitro_service service, string name) => (icaaccessprofile) new icaaccessprofile()
    {
      name = name
    }.get_resource(service);

    public static icaaccessprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (icaaccessprofile[]) null;
      icaaccessprofile[] icaaccessprofileArray1 = new icaaccessprofile[name.Length];
      icaaccessprofile[] icaaccessprofileArray2 = new icaaccessprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        icaaccessprofileArray2[index] = new icaaccessprofile();
        icaaccessprofileArray2[index].name = name[index];
        icaaccessprofileArray1[index] = (icaaccessprofile) icaaccessprofileArray2[index].get_resource(service);
      }
      return icaaccessprofileArray1;
    }

    public static icaaccessprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      icaaccessprofile icaaccessprofile = new icaaccessprofile();
      options option = new options();
      option.set_filter(filter);
      return (icaaccessprofile[]) icaaccessprofile.getfiltered(service, option);
    }

    public static icaaccessprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      icaaccessprofile icaaccessprofile = new icaaccessprofile();
      options option = new options();
      option.set_filter(filter);
      return (icaaccessprofile[]) icaaccessprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      icaaccessprofile icaaccessprofile = new icaaccessprofile();
      options option = new options();
      option.set_count(true);
      icaaccessprofile[] resources = (icaaccessprofile[]) icaaccessprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      icaaccessprofile icaaccessprofile = new icaaccessprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icaaccessprofile[] icaaccessprofileArray = (icaaccessprofile[]) icaaccessprofile.getfiltered(service, option);
      return icaaccessprofileArray != null && icaaccessprofileArray.Length > 0 ? icaaccessprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      icaaccessprofile icaaccessprofile = new icaaccessprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      icaaccessprofile[] icaaccessprofileArray = (icaaccessprofile[]) icaaccessprofile.getfiltered(service, option);
      return icaaccessprofileArray != null && icaaccessprofileArray.Length > 0 ? icaaccessprofileArray[0].__count.Value : 0U;
    }

    private class icaaccessprofile_response : base_response
    {
      public icaaccessprofile[] icaaccessprofile = (icaaccessprofile[]) null;
    }

    public static class localremotedatasharingEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }

    public static class clientprinterredirectionEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class clientclipboardredirectionEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }

    public static class clientcomportredirectionEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }

    public static class clientusbdriveredirectionEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }

    public static class connectclientlptportsEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }

    public static class clientaudioredirectionEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }

    public static class multistreamEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }

    public static class clientdriveredirectionEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string DISABLED = "DISABLED";
    }
  }
}
