// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbsite
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbsite : base_resource
  {
    private string sitenameField = (string) null;
    private string sitetypeField = (string) null;
    private string siteipaddressField = (string) null;
    private string publicipField = (string) null;
    private string metricexchangeField = (string) null;
    private string nwmetricexchangeField = (string) null;
    private string sessionexchangeField = (string) null;
    private string triggermonitorField = (string) null;
    private string parentsiteField = (string) null;
    private string clipField = (string) null;
    private string publicclipField = (string) null;
    private string naptrreplacementsuffixField = (string) null;
    private string statusField = (string) null;
    private string persistencemepstatusField = (string) null;
    private uint? versionField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string sitename
    {
      get => this.sitenameField;
      set => this.sitenameField = value;
    }

    public string sitetype
    {
      get => this.sitetypeField;
      set => this.sitetypeField = value;
    }

    public string siteipaddress
    {
      get => this.siteipaddressField;
      set => this.siteipaddressField = value;
    }

    public string publicip
    {
      get => this.publicipField;
      set => this.publicipField = value;
    }

    public string metricexchange
    {
      get => this.metricexchangeField;
      set => this.metricexchangeField = value;
    }

    public string nwmetricexchange
    {
      get => this.nwmetricexchangeField;
      set => this.nwmetricexchangeField = value;
    }

    public string sessionexchange
    {
      get => this.sessionexchangeField;
      set => this.sessionexchangeField = value;
    }

    public string triggermonitor
    {
      get => this.triggermonitorField;
      set => this.triggermonitorField = value;
    }

    public string parentsite
    {
      get => this.parentsiteField;
      set => this.parentsiteField = value;
    }

    public string clip
    {
      get => this.clipField;
      set => this.clipField = value;
    }

    public string publicclip
    {
      get => this.publicclipField;
      set => this.publicclipField = value;
    }

    public string naptrreplacementsuffix
    {
      get => this.naptrreplacementsuffixField;
      set => this.naptrreplacementsuffixField = value;
    }

    public string status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public string persistencemepstatus
    {
      get => this.persistencemepstatusField;
      private set => this.persistencemepstatusField = value;
    }

    public uint? version
    {
      get => this.versionField;
      private set => this.versionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbsite.gslbsite_response gslbsiteResponse = new gslbsite.gslbsite_response();
      gslbsite.gslbsite_response resource = (gslbsite.gslbsite_response) service.get_payload_formatter().string_to_resource(gslbsiteResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbsite;
    }

    internal override string get_object_name() => this.sitename;

    public static base_response add(nitro_service client, gslbsite resource) => new gslbsite()
    {
      sitename = resource.sitename,
      sitetype = resource.sitetype,
      siteipaddress = resource.siteipaddress,
      publicip = resource.publicip,
      metricexchange = resource.metricexchange,
      nwmetricexchange = resource.nwmetricexchange,
      sessionexchange = resource.sessionexchange,
      triggermonitor = resource.triggermonitor,
      parentsite = resource.parentsite,
      clip = resource.clip,
      publicclip = resource.publicclip,
      naptrreplacementsuffix = resource.naptrreplacementsuffix
    }.add_resource(client);

    public static base_responses add(nitro_service client, gslbsite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbsite[] gslbsiteArray = new gslbsite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbsiteArray[index] = new gslbsite();
          gslbsiteArray[index].sitename = resources[index].sitename;
          gslbsiteArray[index].sitetype = resources[index].sitetype;
          gslbsiteArray[index].siteipaddress = resources[index].siteipaddress;
          gslbsiteArray[index].publicip = resources[index].publicip;
          gslbsiteArray[index].metricexchange = resources[index].metricexchange;
          gslbsiteArray[index].nwmetricexchange = resources[index].nwmetricexchange;
          gslbsiteArray[index].sessionexchange = resources[index].sessionexchange;
          gslbsiteArray[index].triggermonitor = resources[index].triggermonitor;
          gslbsiteArray[index].parentsite = resources[index].parentsite;
          gslbsiteArray[index].clip = resources[index].clip;
          gslbsiteArray[index].publicclip = resources[index].publicclip;
          gslbsiteArray[index].naptrreplacementsuffix = resources[index].naptrreplacementsuffix;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) gslbsiteArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string sitename) => new gslbsite()
    {
      sitename = sitename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, gslbsite resource) => new gslbsite()
    {
      sitename = resource.sitename
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] sitename)
    {
      base_responses baseResponses = (base_responses) null;
      if (sitename != null && sitename.Length > 0)
      {
        gslbsite[] gslbsiteArray = new gslbsite[sitename.Length];
        for (int index = 0; index < sitename.Length; ++index)
        {
          gslbsiteArray[index] = new gslbsite();
          gslbsiteArray[index].sitename = sitename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbsiteArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, gslbsite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbsite[] gslbsiteArray = new gslbsite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbsiteArray[index] = new gslbsite();
          gslbsiteArray[index].sitename = resources[index].sitename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbsiteArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, gslbsite resource) => new gslbsite()
    {
      sitename = resource.sitename,
      metricexchange = resource.metricexchange,
      nwmetricexchange = resource.nwmetricexchange,
      sessionexchange = resource.sessionexchange,
      triggermonitor = resource.triggermonitor,
      naptrreplacementsuffix = resource.naptrreplacementsuffix
    }.update_resource(client);

    public static base_responses update(nitro_service client, gslbsite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbsite[] gslbsiteArray = new gslbsite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbsiteArray[index] = new gslbsite();
          gslbsiteArray[index].sitename = resources[index].sitename;
          gslbsiteArray[index].metricexchange = resources[index].metricexchange;
          gslbsiteArray[index].nwmetricexchange = resources[index].nwmetricexchange;
          gslbsiteArray[index].sessionexchange = resources[index].sessionexchange;
          gslbsiteArray[index].triggermonitor = resources[index].triggermonitor;
          gslbsiteArray[index].naptrreplacementsuffix = resources[index].naptrreplacementsuffix;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) gslbsiteArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string sitename,
      string[] args)
    {
      return new gslbsite() { sitename = sitename }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      gslbsite resource,
      string[] args)
    {
      return new gslbsite() { sitename = resource.sitename }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] sitename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (sitename != null && sitename.Length > 0)
      {
        gslbsite[] gslbsiteArray = new gslbsite[sitename.Length];
        for (int index = 0; index < sitename.Length; ++index)
        {
          gslbsiteArray[index] = new gslbsite();
          gslbsiteArray[index].sitename = sitename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) gslbsiteArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      gslbsite[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbsite[] gslbsiteArray = new gslbsite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbsiteArray[index] = new gslbsite();
          gslbsiteArray[index].sitename = resources[index].sitename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) gslbsiteArray, args);
      }
      return baseResponses;
    }

    public static gslbsite[] get(nitro_service service) => (gslbsite[]) new gslbsite().get_resources(service, (options) null);

    public static gslbsite[] get(nitro_service service, options option) => (gslbsite[]) new gslbsite().get_resources(service, option);

    public static gslbsite get(nitro_service service, string sitename) => (gslbsite) new gslbsite()
    {
      sitename = sitename
    }.get_resource(service);

    public static gslbsite[] get(nitro_service service, string[] sitename)
    {
      if (sitename == null || sitename.Length <= 0)
        return (gslbsite[]) null;
      gslbsite[] gslbsiteArray1 = new gslbsite[sitename.Length];
      gslbsite[] gslbsiteArray2 = new gslbsite[sitename.Length];
      for (int index = 0; index < sitename.Length; ++index)
      {
        gslbsiteArray2[index] = new gslbsite();
        gslbsiteArray2[index].sitename = sitename[index];
        gslbsiteArray1[index] = (gslbsite) gslbsiteArray2[index].get_resource(service);
      }
      return gslbsiteArray1;
    }

    public static gslbsite[] get_filtered(nitro_service service, string filter)
    {
      gslbsite gslbsite = new gslbsite();
      options option = new options();
      option.set_filter(filter);
      return (gslbsite[]) gslbsite.getfiltered(service, option);
    }

    public static gslbsite[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbsite gslbsite = new gslbsite();
      options option = new options();
      option.set_filter(filter);
      return (gslbsite[]) gslbsite.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      gslbsite gslbsite = new gslbsite();
      options option = new options();
      option.set_count(true);
      gslbsite[] resources = (gslbsite[]) gslbsite.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      gslbsite gslbsite = new gslbsite();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbsite[] gslbsiteArray = (gslbsite[]) gslbsite.getfiltered(service, option);
      return gslbsiteArray != null && gslbsiteArray.Length > 0 ? gslbsiteArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbsite gslbsite = new gslbsite();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbsite[] gslbsiteArray = (gslbsite[]) gslbsite.getfiltered(service, option);
      return gslbsiteArray != null && gslbsiteArray.Length > 0 ? gslbsiteArray[0].__count.Value : 0U;
    }

    private class gslbsite_response : base_response
    {
      public gslbsite[] gslbsite = (gslbsite[]) null;
    }

    public static class sessionexchangeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class nwmetricexchangeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class statusEnum
    {
      public const string ACTIVE = "ACTIVE";
      public const string INACTIVE = "INACTIVE";
      public const string DOWN = "DOWN";
    }

    public static class triggermonitorEnum
    {
      public const string ALWAYS = "ALWAYS";
      public const string MEPDOWN = "MEPDOWN";
      public const string MEPDOWN_SVCDOWN = "MEPDOWN_SVCDOWN";
    }

    public static class persistencemepstatusEnum
    {
      public const string ACTIVE = "ACTIVE";
      public const string INACTIVE = "INACTIVE";
      public const string DOWN = "DOWN";
    }

    public static class metricexchangeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sitetypeEnum
    {
      public const string REMOTE = "REMOTE";
      public const string LOCAL = "LOCAL";
    }
  }
}
