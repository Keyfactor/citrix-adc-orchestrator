// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwlearningsettings
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwlearningsettings : base_resource
  {
    private string profilenameField = (string) null;
    private uint? starturlminthresholdField = new uint?();
    private uint? starturlpercentthresholdField = new uint?();
    private uint? cookieconsistencyminthresholdField = new uint?();
    private uint? cookieconsistencypercentthresholdField = new uint?();
    private uint? csrftagminthresholdField = new uint?();
    private uint? csrftagpercentthresholdField = new uint?();
    private uint? fieldconsistencyminthresholdField = new uint?();
    private uint? fieldconsistencypercentthresholdField = new uint?();
    private uint? crosssitescriptingminthresholdField = new uint?();
    private uint? crosssitescriptingpercentthresholdField = new uint?();
    private uint? sqlinjectionminthresholdField = new uint?();
    private uint? sqlinjectionpercentthresholdField = new uint?();
    private uint? fieldformatminthresholdField = new uint?();
    private uint? fieldformatpercentthresholdField = new uint?();
    private uint? creditcardnumberminthresholdField = new uint?();
    private uint? creditcardnumberpercentthresholdField = new uint?();
    private uint? contenttypeminthresholdField = new uint?();
    private uint? contenttypepercentthresholdField = new uint?();
    private uint? xmlwsiminthresholdField = new uint?();
    private uint? xmlwsipercentthresholdField = new uint?();
    private uint? xmlattachmentminthresholdField = new uint?();
    private uint? xmlattachmentpercentthresholdField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public uint? starturlminthreshold
    {
      get => this.starturlminthresholdField;
      set => this.starturlminthresholdField = value;
    }

    public uint? starturlpercentthreshold
    {
      get => this.starturlpercentthresholdField;
      set => this.starturlpercentthresholdField = value;
    }

    public uint? cookieconsistencyminthreshold
    {
      get => this.cookieconsistencyminthresholdField;
      set => this.cookieconsistencyminthresholdField = value;
    }

    public uint? cookieconsistencypercentthreshold
    {
      get => this.cookieconsistencypercentthresholdField;
      set => this.cookieconsistencypercentthresholdField = value;
    }

    public uint? csrftagminthreshold
    {
      get => this.csrftagminthresholdField;
      set => this.csrftagminthresholdField = value;
    }

    public uint? csrftagpercentthreshold
    {
      get => this.csrftagpercentthresholdField;
      set => this.csrftagpercentthresholdField = value;
    }

    public uint? fieldconsistencyminthreshold
    {
      get => this.fieldconsistencyminthresholdField;
      set => this.fieldconsistencyminthresholdField = value;
    }

    public uint? fieldconsistencypercentthreshold
    {
      get => this.fieldconsistencypercentthresholdField;
      set => this.fieldconsistencypercentthresholdField = value;
    }

    public uint? crosssitescriptingminthreshold
    {
      get => this.crosssitescriptingminthresholdField;
      set => this.crosssitescriptingminthresholdField = value;
    }

    public uint? crosssitescriptingpercentthreshold
    {
      get => this.crosssitescriptingpercentthresholdField;
      set => this.crosssitescriptingpercentthresholdField = value;
    }

    public uint? sqlinjectionminthreshold
    {
      get => this.sqlinjectionminthresholdField;
      set => this.sqlinjectionminthresholdField = value;
    }

    public uint? sqlinjectionpercentthreshold
    {
      get => this.sqlinjectionpercentthresholdField;
      set => this.sqlinjectionpercentthresholdField = value;
    }

    public uint? fieldformatminthreshold
    {
      get => this.fieldformatminthresholdField;
      set => this.fieldformatminthresholdField = value;
    }

    public uint? fieldformatpercentthreshold
    {
      get => this.fieldformatpercentthresholdField;
      set => this.fieldformatpercentthresholdField = value;
    }

    public uint? creditcardnumberminthreshold
    {
      get => this.creditcardnumberminthresholdField;
      set => this.creditcardnumberminthresholdField = value;
    }

    public uint? creditcardnumberpercentthreshold
    {
      get => this.creditcardnumberpercentthresholdField;
      set => this.creditcardnumberpercentthresholdField = value;
    }

    public uint? contenttypeminthreshold
    {
      get => this.contenttypeminthresholdField;
      set => this.contenttypeminthresholdField = value;
    }

    public uint? contenttypepercentthreshold
    {
      get => this.contenttypepercentthresholdField;
      set => this.contenttypepercentthresholdField = value;
    }

    public uint? xmlwsiminthreshold
    {
      get => this.xmlwsiminthresholdField;
      set => this.xmlwsiminthresholdField = value;
    }

    public uint? xmlwsipercentthreshold
    {
      get => this.xmlwsipercentthresholdField;
      set => this.xmlwsipercentthresholdField = value;
    }

    public uint? xmlattachmentminthreshold
    {
      get => this.xmlattachmentminthresholdField;
      set => this.xmlattachmentminthresholdField = value;
    }

    public uint? xmlattachmentpercentthreshold
    {
      get => this.xmlattachmentpercentthresholdField;
      set => this.xmlattachmentpercentthresholdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwlearningsettings.appfwlearningsettings_response appfwlearningsettingsResponse = new appfwlearningsettings.appfwlearningsettings_response();
      appfwlearningsettings.appfwlearningsettings_response resource = (appfwlearningsettings.appfwlearningsettings_response) service.get_payload_formatter().string_to_resource(appfwlearningsettingsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwlearningsettings;
    }

    internal override string get_object_name() => this.profilename;

    public static base_response update(
      nitro_service client,
      appfwlearningsettings resource)
    {
      return new appfwlearningsettings()
      {
        profilename = resource.profilename,
        starturlminthreshold = resource.starturlminthreshold,
        starturlpercentthreshold = resource.starturlpercentthreshold,
        cookieconsistencyminthreshold = resource.cookieconsistencyminthreshold,
        cookieconsistencypercentthreshold = resource.cookieconsistencypercentthreshold,
        csrftagminthreshold = resource.csrftagminthreshold,
        csrftagpercentthreshold = resource.csrftagpercentthreshold,
        fieldconsistencyminthreshold = resource.fieldconsistencyminthreshold,
        fieldconsistencypercentthreshold = resource.fieldconsistencypercentthreshold,
        crosssitescriptingminthreshold = resource.crosssitescriptingminthreshold,
        crosssitescriptingpercentthreshold = resource.crosssitescriptingpercentthreshold,
        sqlinjectionminthreshold = resource.sqlinjectionminthreshold,
        sqlinjectionpercentthreshold = resource.sqlinjectionpercentthreshold,
        fieldformatminthreshold = resource.fieldformatminthreshold,
        fieldformatpercentthreshold = resource.fieldformatpercentthreshold,
        creditcardnumberminthreshold = resource.creditcardnumberminthreshold,
        creditcardnumberpercentthreshold = resource.creditcardnumberpercentthreshold,
        contenttypeminthreshold = resource.contenttypeminthreshold,
        contenttypepercentthreshold = resource.contenttypepercentthreshold,
        xmlwsiminthreshold = resource.xmlwsiminthreshold,
        xmlwsipercentthreshold = resource.xmlwsipercentthreshold,
        xmlattachmentminthreshold = resource.xmlattachmentminthreshold,
        xmlattachmentpercentthreshold = resource.xmlattachmentpercentthreshold
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      appfwlearningsettings[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwlearningsettings[] appfwlearningsettingsArray = new appfwlearningsettings[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwlearningsettingsArray[index] = new appfwlearningsettings();
          appfwlearningsettingsArray[index].profilename = resources[index].profilename;
          appfwlearningsettingsArray[index].starturlminthreshold = resources[index].starturlminthreshold;
          appfwlearningsettingsArray[index].starturlpercentthreshold = resources[index].starturlpercentthreshold;
          appfwlearningsettingsArray[index].cookieconsistencyminthreshold = resources[index].cookieconsistencyminthreshold;
          appfwlearningsettingsArray[index].cookieconsistencypercentthreshold = resources[index].cookieconsistencypercentthreshold;
          appfwlearningsettingsArray[index].csrftagminthreshold = resources[index].csrftagminthreshold;
          appfwlearningsettingsArray[index].csrftagpercentthreshold = resources[index].csrftagpercentthreshold;
          appfwlearningsettingsArray[index].fieldconsistencyminthreshold = resources[index].fieldconsistencyminthreshold;
          appfwlearningsettingsArray[index].fieldconsistencypercentthreshold = resources[index].fieldconsistencypercentthreshold;
          appfwlearningsettingsArray[index].crosssitescriptingminthreshold = resources[index].crosssitescriptingminthreshold;
          appfwlearningsettingsArray[index].crosssitescriptingpercentthreshold = resources[index].crosssitescriptingpercentthreshold;
          appfwlearningsettingsArray[index].sqlinjectionminthreshold = resources[index].sqlinjectionminthreshold;
          appfwlearningsettingsArray[index].sqlinjectionpercentthreshold = resources[index].sqlinjectionpercentthreshold;
          appfwlearningsettingsArray[index].fieldformatminthreshold = resources[index].fieldformatminthreshold;
          appfwlearningsettingsArray[index].fieldformatpercentthreshold = resources[index].fieldformatpercentthreshold;
          appfwlearningsettingsArray[index].creditcardnumberminthreshold = resources[index].creditcardnumberminthreshold;
          appfwlearningsettingsArray[index].creditcardnumberpercentthreshold = resources[index].creditcardnumberpercentthreshold;
          appfwlearningsettingsArray[index].contenttypeminthreshold = resources[index].contenttypeminthreshold;
          appfwlearningsettingsArray[index].contenttypepercentthreshold = resources[index].contenttypepercentthreshold;
          appfwlearningsettingsArray[index].xmlwsiminthreshold = resources[index].xmlwsiminthreshold;
          appfwlearningsettingsArray[index].xmlwsipercentthreshold = resources[index].xmlwsipercentthreshold;
          appfwlearningsettingsArray[index].xmlattachmentminthreshold = resources[index].xmlattachmentminthreshold;
          appfwlearningsettingsArray[index].xmlattachmentpercentthreshold = resources[index].xmlattachmentpercentthreshold;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appfwlearningsettingsArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string profilename,
      string[] args)
    {
      return new appfwlearningsettings()
      {
        profilename = profilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      appfwlearningsettings resource,
      string[] args)
    {
      return new appfwlearningsettings()
      {
        profilename = resource.profilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] profilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (profilename != null && profilename.Length > 0)
      {
        appfwlearningsettings[] appfwlearningsettingsArray = new appfwlearningsettings[profilename.Length];
        for (int index = 0; index < profilename.Length; ++index)
        {
          appfwlearningsettingsArray[index] = new appfwlearningsettings();
          appfwlearningsettingsArray[index].profilename = profilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appfwlearningsettingsArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      appfwlearningsettings[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwlearningsettings[] appfwlearningsettingsArray = new appfwlearningsettings[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwlearningsettingsArray[index] = new appfwlearningsettings();
          appfwlearningsettingsArray[index].profilename = resources[index].profilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appfwlearningsettingsArray, args);
      }
      return baseResponses;
    }

    public static appfwlearningsettings[] get(nitro_service service) => (appfwlearningsettings[]) new appfwlearningsettings().get_resources(service, (options) null);

    public static appfwlearningsettings[] get(
      nitro_service service,
      options option)
    {
      return (appfwlearningsettings[]) new appfwlearningsettings().get_resources(service, option);
    }

    public static appfwlearningsettings get(
      nitro_service service,
      string profilename)
    {
      return (appfwlearningsettings) new appfwlearningsettings()
      {
        profilename = profilename
      }.get_resource(service);
    }

    public static appfwlearningsettings[] get(
      nitro_service service,
      string[] profilename)
    {
      if (profilename == null || profilename.Length <= 0)
        return (appfwlearningsettings[]) null;
      appfwlearningsettings[] appfwlearningsettingsArray1 = new appfwlearningsettings[profilename.Length];
      appfwlearningsettings[] appfwlearningsettingsArray2 = new appfwlearningsettings[profilename.Length];
      for (int index = 0; index < profilename.Length; ++index)
      {
        appfwlearningsettingsArray2[index] = new appfwlearningsettings();
        appfwlearningsettingsArray2[index].profilename = profilename[index];
        appfwlearningsettingsArray1[index] = (appfwlearningsettings) appfwlearningsettingsArray2[index].get_resource(service);
      }
      return appfwlearningsettingsArray1;
    }

    public static appfwlearningsettings[] get_filtered(
      nitro_service service,
      string filter)
    {
      appfwlearningsettings appfwlearningsettings = new appfwlearningsettings();
      options option = new options();
      option.set_filter(filter);
      return (appfwlearningsettings[]) appfwlearningsettings.getfiltered(service, option);
    }

    public static appfwlearningsettings[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwlearningsettings appfwlearningsettings = new appfwlearningsettings();
      options option = new options();
      option.set_filter(filter);
      return (appfwlearningsettings[]) appfwlearningsettings.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwlearningsettings appfwlearningsettings = new appfwlearningsettings();
      options option = new options();
      option.set_count(true);
      appfwlearningsettings[] resources = (appfwlearningsettings[]) appfwlearningsettings.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwlearningsettings appfwlearningsettings = new appfwlearningsettings();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwlearningsettings[] appfwlearningsettingsArray = (appfwlearningsettings[]) appfwlearningsettings.getfiltered(service, option);
      return appfwlearningsettingsArray != null && appfwlearningsettingsArray.Length > 0 ? appfwlearningsettingsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwlearningsettings appfwlearningsettings = new appfwlearningsettings();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwlearningsettings[] appfwlearningsettingsArray = (appfwlearningsettings[]) appfwlearningsettings.getfiltered(service, option);
      return appfwlearningsettingsArray != null && appfwlearningsettingsArray.Length > 0 ? appfwlearningsettingsArray[0].__count.Value : 0U;
    }

    private class appfwlearningsettings_response : base_response
    {
      public appfwlearningsettings[] appfwlearningsettings = (appfwlearningsettings[]) null;
    }
  }
}
