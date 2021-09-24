// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslaction : base_resource
  {
    private string nameField = (string) null;
    private string clientauthField = (string) null;
    private string clientcertField = (string) null;
    private string certheaderField = (string) null;
    private string clientcertserialnumberField = (string) null;
    private string certserialheaderField = (string) null;
    private string clientcertsubjectField = (string) null;
    private string certsubjectheaderField = (string) null;
    private string clientcerthashField = (string) null;
    private string certhashheaderField = (string) null;
    private string clientcertissuerField = (string) null;
    private string certissuerheaderField = (string) null;
    private string sessionidField = (string) null;
    private string sessionidheaderField = (string) null;
    private string cipherField = (string) null;
    private string cipherheaderField = (string) null;
    private string clientcertnotbeforeField = (string) null;
    private string certnotbeforeheaderField = (string) null;
    private string clientcertnotafterField = (string) null;
    private string certnotafterheaderField = (string) null;
    private string owasupportField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private uint? referencecountField = new uint?();
    private string descriptionField = (string) null;
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

    public string clientauth
    {
      get => this.clientauthField;
      set => this.clientauthField = value;
    }

    public string clientcert
    {
      get => this.clientcertField;
      set => this.clientcertField = value;
    }

    public string certheader
    {
      get => this.certheaderField;
      set => this.certheaderField = value;
    }

    public string clientcertserialnumber
    {
      get => this.clientcertserialnumberField;
      set => this.clientcertserialnumberField = value;
    }

    public string certserialheader
    {
      get => this.certserialheaderField;
      set => this.certserialheaderField = value;
    }

    public string clientcertsubject
    {
      get => this.clientcertsubjectField;
      set => this.clientcertsubjectField = value;
    }

    public string certsubjectheader
    {
      get => this.certsubjectheaderField;
      set => this.certsubjectheaderField = value;
    }

    public string clientcerthash
    {
      get => this.clientcerthashField;
      set => this.clientcerthashField = value;
    }

    public string certhashheader
    {
      get => this.certhashheaderField;
      set => this.certhashheaderField = value;
    }

    public string clientcertissuer
    {
      get => this.clientcertissuerField;
      set => this.clientcertissuerField = value;
    }

    public string certissuerheader
    {
      get => this.certissuerheaderField;
      set => this.certissuerheaderField = value;
    }

    public string sessionid
    {
      get => this.sessionidField;
      set => this.sessionidField = value;
    }

    public string sessionidheader
    {
      get => this.sessionidheaderField;
      set => this.sessionidheaderField = value;
    }

    public string cipher
    {
      get => this.cipherField;
      set => this.cipherField = value;
    }

    public string cipherheader
    {
      get => this.cipherheaderField;
      set => this.cipherheaderField = value;
    }

    public string clientcertnotbefore
    {
      get => this.clientcertnotbeforeField;
      set => this.clientcertnotbeforeField = value;
    }

    public string certnotbeforeheader
    {
      get => this.certnotbeforeheaderField;
      set => this.certnotbeforeheaderField = value;
    }

    public string clientcertnotafter
    {
      get => this.clientcertnotafterField;
      set => this.clientcertnotafterField = value;
    }

    public string certnotafterheader
    {
      get => this.certnotafterheaderField;
      set => this.certnotafterheaderField = value;
    }

    public string owasupport
    {
      get => this.owasupportField;
      set => this.owasupportField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
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
      sslaction.sslaction_response sslactionResponse = new sslaction.sslaction_response();
      sslaction.sslaction_response resource = (sslaction.sslaction_response) service.get_payload_formatter().string_to_resource(sslactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, sslaction resource) => new sslaction()
    {
      name = resource.name,
      clientauth = resource.clientauth,
      clientcert = resource.clientcert,
      certheader = resource.certheader,
      clientcertserialnumber = resource.clientcertserialnumber,
      certserialheader = resource.certserialheader,
      clientcertsubject = resource.clientcertsubject,
      certsubjectheader = resource.certsubjectheader,
      clientcerthash = resource.clientcerthash,
      certhashheader = resource.certhashheader,
      clientcertissuer = resource.clientcertissuer,
      certissuerheader = resource.certissuerheader,
      sessionid = resource.sessionid,
      sessionidheader = resource.sessionidheader,
      cipher = resource.cipher,
      cipherheader = resource.cipherheader,
      clientcertnotbefore = resource.clientcertnotbefore,
      certnotbeforeheader = resource.certnotbeforeheader,
      clientcertnotafter = resource.clientcertnotafter,
      certnotafterheader = resource.certnotafterheader,
      owasupport = resource.owasupport
    }.add_resource(client);

    public static base_responses add(nitro_service client, sslaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslaction[] sslactionArray = new sslaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslactionArray[index] = new sslaction();
          sslactionArray[index].name = resources[index].name;
          sslactionArray[index].clientauth = resources[index].clientauth;
          sslactionArray[index].clientcert = resources[index].clientcert;
          sslactionArray[index].certheader = resources[index].certheader;
          sslactionArray[index].clientcertserialnumber = resources[index].clientcertserialnumber;
          sslactionArray[index].certserialheader = resources[index].certserialheader;
          sslactionArray[index].clientcertsubject = resources[index].clientcertsubject;
          sslactionArray[index].certsubjectheader = resources[index].certsubjectheader;
          sslactionArray[index].clientcerthash = resources[index].clientcerthash;
          sslactionArray[index].certhashheader = resources[index].certhashheader;
          sslactionArray[index].clientcertissuer = resources[index].clientcertissuer;
          sslactionArray[index].certissuerheader = resources[index].certissuerheader;
          sslactionArray[index].sessionid = resources[index].sessionid;
          sslactionArray[index].sessionidheader = resources[index].sessionidheader;
          sslactionArray[index].cipher = resources[index].cipher;
          sslactionArray[index].cipherheader = resources[index].cipherheader;
          sslactionArray[index].clientcertnotbefore = resources[index].clientcertnotbefore;
          sslactionArray[index].certnotbeforeheader = resources[index].certnotbeforeheader;
          sslactionArray[index].clientcertnotafter = resources[index].clientcertnotafter;
          sslactionArray[index].certnotafterheader = resources[index].certnotafterheader;
          sslactionArray[index].owasupport = resources[index].owasupport;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new sslaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslaction resource) => new sslaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        sslaction[] sslactionArray = new sslaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          sslactionArray[index] = new sslaction();
          sslactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, sslaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslaction[] sslactionArray = new sslaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslactionArray[index] = new sslaction();
          sslactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslactionArray);
      }
      return baseResponses;
    }

    public static sslaction[] get(nitro_service service) => (sslaction[]) new sslaction().get_resources(service, (options) null);

    public static sslaction[] get(nitro_service service, options option) => (sslaction[]) new sslaction().get_resources(service, option);

    public static sslaction get(nitro_service service, string name) => (sslaction) new sslaction()
    {
      name = name
    }.get_resource(service);

    public static sslaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (sslaction[]) null;
      sslaction[] sslactionArray1 = new sslaction[name.Length];
      sslaction[] sslactionArray2 = new sslaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        sslactionArray2[index] = new sslaction();
        sslactionArray2[index].name = name[index];
        sslactionArray1[index] = (sslaction) sslactionArray2[index].get_resource(service);
      }
      return sslactionArray1;
    }

    public static sslaction[] get_filtered(nitro_service service, string filter)
    {
      sslaction sslaction = new sslaction();
      options option = new options();
      option.set_filter(filter);
      return (sslaction[]) sslaction.getfiltered(service, option);
    }

    public static sslaction[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslaction sslaction = new sslaction();
      options option = new options();
      option.set_filter(filter);
      return (sslaction[]) sslaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslaction sslaction = new sslaction();
      options option = new options();
      option.set_count(true);
      sslaction[] resources = (sslaction[]) sslaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslaction sslaction = new sslaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslaction[] sslactionArray = (sslaction[]) sslaction.getfiltered(service, option);
      return sslactionArray != null && sslactionArray.Length > 0 ? sslactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslaction sslaction = new sslaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslaction[] sslactionArray = (sslaction[]) sslaction.getfiltered(service, option);
      return sslactionArray != null && sslactionArray.Length > 0 ? sslactionArray[0].__count.Value : 0U;
    }

    private class sslaction_response : base_response
    {
      public sslaction[] sslaction = (sslaction[]) null;
    }

    public static class clientcertnotafterEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class owasupportEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientcertsubjectEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientcertissuerEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientcertnotbeforeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientcertserialnumberEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cipherEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientcertEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientcerthashEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clientauthEnum
    {
      public const string DOCLIENTAUTH = "DOCLIENTAUTH";
      public const string NOCLIENTAUTH = "NOCLIENTAUTH";
    }

    public static class sessionidEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
