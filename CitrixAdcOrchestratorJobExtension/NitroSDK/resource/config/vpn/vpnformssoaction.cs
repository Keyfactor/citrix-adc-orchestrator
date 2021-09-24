// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnformssoaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnformssoaction : base_resource
  {
    private string nameField = (string) null;
    private string actionurlField = (string) null;
    private string userfieldField = (string) null;
    private string passwdfieldField = (string) null;
    private string ssosuccessruleField = (string) null;
    private string namevaluepairField = (string) null;
    private uint? responsesizeField = new uint?();
    private string nvtypeField = (string) null;
    private string submitmethodField = (string) null;
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

    public string actionurl
    {
      get => this.actionurlField;
      set => this.actionurlField = value;
    }

    public string userfield
    {
      get => this.userfieldField;
      set => this.userfieldField = value;
    }

    public string passwdfield
    {
      get => this.passwdfieldField;
      set => this.passwdfieldField = value;
    }

    public string ssosuccessrule
    {
      get => this.ssosuccessruleField;
      set => this.ssosuccessruleField = value;
    }

    public string namevaluepair
    {
      get => this.namevaluepairField;
      set => this.namevaluepairField = value;
    }

    public uint? responsesize
    {
      get => this.responsesizeField;
      set => this.responsesizeField = value;
    }

    public string nvtype
    {
      get => this.nvtypeField;
      set => this.nvtypeField = value;
    }

    public string submitmethod
    {
      get => this.submitmethodField;
      set => this.submitmethodField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnformssoaction.vpnformssoaction_response vpnformssoactionResponse = new vpnformssoaction.vpnformssoaction_response();
      vpnformssoaction.vpnformssoaction_response resource = (vpnformssoaction.vpnformssoaction_response) service.get_payload_formatter().string_to_resource(vpnformssoactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnformssoaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpnformssoaction resource) => new vpnformssoaction()
    {
      name = resource.name,
      actionurl = resource.actionurl,
      userfield = resource.userfield,
      passwdfield = resource.passwdfield,
      ssosuccessrule = resource.ssosuccessrule,
      namevaluepair = resource.namevaluepair,
      responsesize = resource.responsesize,
      nvtype = resource.nvtype,
      submitmethod = resource.submitmethod
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      vpnformssoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnformssoaction[] vpnformssoactionArray = new vpnformssoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnformssoactionArray[index] = new vpnformssoaction();
          vpnformssoactionArray[index].name = resources[index].name;
          vpnformssoactionArray[index].actionurl = resources[index].actionurl;
          vpnformssoactionArray[index].userfield = resources[index].userfield;
          vpnformssoactionArray[index].passwdfield = resources[index].passwdfield;
          vpnformssoactionArray[index].ssosuccessrule = resources[index].ssosuccessrule;
          vpnformssoactionArray[index].namevaluepair = resources[index].namevaluepair;
          vpnformssoactionArray[index].responsesize = resources[index].responsesize;
          vpnformssoactionArray[index].nvtype = resources[index].nvtype;
          vpnformssoactionArray[index].submitmethod = resources[index].submitmethod;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnformssoactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpnformssoaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpnformssoaction resource) => new vpnformssoaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnformssoaction[] vpnformssoactionArray = new vpnformssoaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnformssoactionArray[index] = new vpnformssoaction();
          vpnformssoactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnformssoactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpnformssoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnformssoaction[] vpnformssoactionArray = new vpnformssoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnformssoactionArray[index] = new vpnformssoaction();
          vpnformssoactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnformssoactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vpnformssoaction resource) => new vpnformssoaction()
    {
      name = resource.name,
      actionurl = resource.actionurl,
      userfield = resource.userfield,
      passwdfield = resource.passwdfield,
      ssosuccessrule = resource.ssosuccessrule,
      responsesize = resource.responsesize,
      namevaluepair = resource.namevaluepair,
      nvtype = resource.nvtype,
      submitmethod = resource.submitmethod
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      vpnformssoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnformssoaction[] vpnformssoactionArray = new vpnformssoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnformssoactionArray[index] = new vpnformssoaction();
          vpnformssoactionArray[index].name = resources[index].name;
          vpnformssoactionArray[index].actionurl = resources[index].actionurl;
          vpnformssoactionArray[index].userfield = resources[index].userfield;
          vpnformssoactionArray[index].passwdfield = resources[index].passwdfield;
          vpnformssoactionArray[index].ssosuccessrule = resources[index].ssosuccessrule;
          vpnformssoactionArray[index].responsesize = resources[index].responsesize;
          vpnformssoactionArray[index].namevaluepair = resources[index].namevaluepair;
          vpnformssoactionArray[index].nvtype = resources[index].nvtype;
          vpnformssoactionArray[index].submitmethod = resources[index].submitmethod;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnformssoactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new vpnformssoaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      vpnformssoaction resource,
      string[] args)
    {
      return new vpnformssoaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnformssoaction[] vpnformssoactionArray = new vpnformssoaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnformssoactionArray[index] = new vpnformssoaction();
          vpnformssoactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnformssoactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vpnformssoaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnformssoaction[] vpnformssoactionArray = new vpnformssoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnformssoactionArray[index] = new vpnformssoaction();
          vpnformssoactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnformssoactionArray, args);
      }
      return baseResponses;
    }

    public static vpnformssoaction[] get(nitro_service service) => (vpnformssoaction[]) new vpnformssoaction().get_resources(service, (options) null);

    public static vpnformssoaction[] get(nitro_service service, options option) => (vpnformssoaction[]) new vpnformssoaction().get_resources(service, option);

    public static vpnformssoaction get(nitro_service service, string name) => (vpnformssoaction) new vpnformssoaction()
    {
      name = name
    }.get_resource(service);

    public static vpnformssoaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnformssoaction[]) null;
      vpnformssoaction[] vpnformssoactionArray1 = new vpnformssoaction[name.Length];
      vpnformssoaction[] vpnformssoactionArray2 = new vpnformssoaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnformssoactionArray2[index] = new vpnformssoaction();
        vpnformssoactionArray2[index].name = name[index];
        vpnformssoactionArray1[index] = (vpnformssoaction) vpnformssoactionArray2[index].get_resource(service);
      }
      return vpnformssoactionArray1;
    }

    public static vpnformssoaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnformssoaction vpnformssoaction = new vpnformssoaction();
      options option = new options();
      option.set_filter(filter);
      return (vpnformssoaction[]) vpnformssoaction.getfiltered(service, option);
    }

    public static vpnformssoaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnformssoaction vpnformssoaction = new vpnformssoaction();
      options option = new options();
      option.set_filter(filter);
      return (vpnformssoaction[]) vpnformssoaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnformssoaction vpnformssoaction = new vpnformssoaction();
      options option = new options();
      option.set_count(true);
      vpnformssoaction[] resources = (vpnformssoaction[]) vpnformssoaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnformssoaction vpnformssoaction = new vpnformssoaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnformssoaction[] vpnformssoactionArray = (vpnformssoaction[]) vpnformssoaction.getfiltered(service, option);
      return vpnformssoactionArray != null && vpnformssoactionArray.Length > 0 ? vpnformssoactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnformssoaction vpnformssoaction = new vpnformssoaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnformssoaction[] vpnformssoactionArray = (vpnformssoaction[]) vpnformssoaction.getfiltered(service, option);
      return vpnformssoactionArray != null && vpnformssoactionArray.Length > 0 ? vpnformssoactionArray[0].__count.Value : 0U;
    }

    private class vpnformssoaction_response : base_response
    {
      public vpnformssoaction[] vpnformssoaction = (vpnformssoaction[]) null;
    }

    public static class nvtypeEnum
    {
      public const string STATIC = "STATIC";
      public const string DYNAMIC = "DYNAMIC";
    }

    public static class submitmethodEnum
    {
      public const string GET = "GET";
      public const string POST = "POST";
    }
  }
}
