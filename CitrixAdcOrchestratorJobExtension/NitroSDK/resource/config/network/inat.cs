// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.inat
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class inat : base_resource
  {
    private string nameField = (string) null;
    private string publicipField = (string) null;
    private string privateipField = (string) null;
    private string modeField = (string) null;
    private string tcpproxyField = (string) null;
    private string ftpField = (string) null;
    private string tftpField = (string) null;
    private string usipField = (string) null;
    private string usnipField = (string) null;
    private string proxyipField = (string) null;
    private string useproxyportField = (string) null;
    private uint? tdField = new uint?();
    private uint? flagsField = new uint?();
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

    public string publicip
    {
      get => this.publicipField;
      set => this.publicipField = value;
    }

    public string privateip
    {
      get => this.privateipField;
      set => this.privateipField = value;
    }

    public string mode
    {
      get => this.modeField;
      set => this.modeField = value;
    }

    public string tcpproxy
    {
      get => this.tcpproxyField;
      set => this.tcpproxyField = value;
    }

    public string ftp
    {
      get => this.ftpField;
      set => this.ftpField = value;
    }

    public string tftp
    {
      get => this.tftpField;
      set => this.tftpField = value;
    }

    public string usip
    {
      get => this.usipField;
      set => this.usipField = value;
    }

    public string usnip
    {
      get => this.usnipField;
      set => this.usnipField = value;
    }

    public string proxyip
    {
      get => this.proxyipField;
      set => this.proxyipField = value;
    }

    public string useproxyport
    {
      get => this.useproxyportField;
      set => this.useproxyportField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      inat.inat_response inatResponse = new inat.inat_response();
      inat.inat_response resource = (inat.inat_response) service.get_payload_formatter().string_to_resource(inatResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.inat;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, inat resource) => new inat()
    {
      name = resource.name,
      publicip = resource.publicip,
      privateip = resource.privateip,
      mode = resource.mode,
      tcpproxy = resource.tcpproxy,
      ftp = resource.ftp,
      tftp = resource.tftp,
      usip = resource.usip,
      usnip = resource.usnip,
      proxyip = resource.proxyip,
      useproxyport = resource.useproxyport,
      td = resource.td
    }.add_resource(client);

    public static base_responses add(nitro_service client, inat[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        inat[] inatArray = new inat[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          inatArray[index] = new inat();
          inatArray[index].name = resources[index].name;
          inatArray[index].publicip = resources[index].publicip;
          inatArray[index].privateip = resources[index].privateip;
          inatArray[index].mode = resources[index].mode;
          inatArray[index].tcpproxy = resources[index].tcpproxy;
          inatArray[index].ftp = resources[index].ftp;
          inatArray[index].tftp = resources[index].tftp;
          inatArray[index].usip = resources[index].usip;
          inatArray[index].usnip = resources[index].usnip;
          inatArray[index].proxyip = resources[index].proxyip;
          inatArray[index].useproxyport = resources[index].useproxyport;
          inatArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) inatArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new inat()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, inat resource) => new inat()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        inat[] inatArray = new inat[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          inatArray[index] = new inat();
          inatArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) inatArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, inat[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        inat[] inatArray = new inat[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          inatArray[index] = new inat();
          inatArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) inatArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, inat resource) => new inat()
    {
      name = resource.name,
      privateip = resource.privateip,
      tcpproxy = resource.tcpproxy,
      ftp = resource.ftp,
      tftp = resource.tftp,
      usip = resource.usip,
      usnip = resource.usnip,
      proxyip = resource.proxyip,
      useproxyport = resource.useproxyport,
      mode = resource.mode
    }.update_resource(client);

    public static base_responses update(nitro_service client, inat[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        inat[] inatArray = new inat[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          inatArray[index] = new inat();
          inatArray[index].name = resources[index].name;
          inatArray[index].privateip = resources[index].privateip;
          inatArray[index].tcpproxy = resources[index].tcpproxy;
          inatArray[index].ftp = resources[index].ftp;
          inatArray[index].tftp = resources[index].tftp;
          inatArray[index].usip = resources[index].usip;
          inatArray[index].usnip = resources[index].usnip;
          inatArray[index].proxyip = resources[index].proxyip;
          inatArray[index].useproxyport = resources[index].useproxyport;
          inatArray[index].mode = resources[index].mode;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) inatArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new inat() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      inat resource,
      string[] args)
    {
      return new inat() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        inat[] inatArray = new inat[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          inatArray[index] = new inat();
          inatArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) inatArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      inat[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        inat[] inatArray = new inat[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          inatArray[index] = new inat();
          inatArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) inatArray, args);
      }
      return baseResponses;
    }

    public static inat[] get(nitro_service service) => (inat[]) new inat().get_resources(service, (options) null);

    public static inat[] get(nitro_service service, options option) => (inat[]) new inat().get_resources(service, option);

    public static inat get(nitro_service service, string name) => (inat) new inat()
    {
      name = name
    }.get_resource(service);

    public static inat[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (inat[]) null;
      inat[] inatArray1 = new inat[name.Length];
      inat[] inatArray2 = new inat[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        inatArray2[index] = new inat();
        inatArray2[index].name = name[index];
        inatArray1[index] = (inat) inatArray2[index].get_resource(service);
      }
      return inatArray1;
    }

    public static inat[] get_filtered(nitro_service service, string filter)
    {
      inat inat = new inat();
      options option = new options();
      option.set_filter(filter);
      return (inat[]) inat.getfiltered(service, option);
    }

    public static inat[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      inat inat = new inat();
      options option = new options();
      option.set_filter(filter);
      return (inat[]) inat.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      inat inat = new inat();
      options option = new options();
      option.set_count(true);
      inat[] resources = (inat[]) inat.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      inat inat = new inat();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      inat[] inatArray = (inat[]) inat.getfiltered(service, option);
      return inatArray != null && inatArray.Length > 0 ? inatArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      inat inat = new inat();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      inat[] inatArray = (inat[]) inat.getfiltered(service, option);
      return inatArray != null && inatArray.Length > 0 ? inatArray[0].__count.Value : 0U;
    }

    private class inat_response : base_response
    {
      public inat[] inat = (inat[]) null;
    }

    public static class modeEnum
    {
      public const string STATELESS = "STATELESS";
    }

    public static class usnipEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class tftpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class tcpproxyEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class useproxyportEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class usipEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class ftpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
