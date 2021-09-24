// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmformssoaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmformssoaction : base_resource
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
      tmformssoaction.tmformssoaction_response tmformssoactionResponse = new tmformssoaction.tmformssoaction_response();
      tmformssoaction.tmformssoaction_response resource = (tmformssoaction.tmformssoaction_response) service.get_payload_formatter().string_to_resource(tmformssoactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmformssoaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, tmformssoaction resource) => new tmformssoaction()
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
      tmformssoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmformssoaction[] tmformssoactionArray = new tmformssoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmformssoactionArray[index] = new tmformssoaction();
          tmformssoactionArray[index].name = resources[index].name;
          tmformssoactionArray[index].actionurl = resources[index].actionurl;
          tmformssoactionArray[index].userfield = resources[index].userfield;
          tmformssoactionArray[index].passwdfield = resources[index].passwdfield;
          tmformssoactionArray[index].ssosuccessrule = resources[index].ssosuccessrule;
          tmformssoactionArray[index].namevaluepair = resources[index].namevaluepair;
          tmformssoactionArray[index].responsesize = resources[index].responsesize;
          tmformssoactionArray[index].nvtype = resources[index].nvtype;
          tmformssoactionArray[index].submitmethod = resources[index].submitmethod;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) tmformssoactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new tmformssoaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, tmformssoaction resource) => new tmformssoaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmformssoaction[] tmformssoactionArray = new tmformssoaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmformssoactionArray[index] = new tmformssoaction();
          tmformssoactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmformssoactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      tmformssoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmformssoaction[] tmformssoactionArray = new tmformssoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmformssoactionArray[index] = new tmformssoaction();
          tmformssoactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmformssoactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, tmformssoaction resource) => new tmformssoaction()
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
      tmformssoaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmformssoaction[] tmformssoactionArray = new tmformssoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmformssoactionArray[index] = new tmformssoaction();
          tmformssoactionArray[index].name = resources[index].name;
          tmformssoactionArray[index].actionurl = resources[index].actionurl;
          tmformssoactionArray[index].userfield = resources[index].userfield;
          tmformssoactionArray[index].passwdfield = resources[index].passwdfield;
          tmformssoactionArray[index].ssosuccessrule = resources[index].ssosuccessrule;
          tmformssoactionArray[index].responsesize = resources[index].responsesize;
          tmformssoactionArray[index].namevaluepair = resources[index].namevaluepair;
          tmformssoactionArray[index].nvtype = resources[index].nvtype;
          tmformssoactionArray[index].submitmethod = resources[index].submitmethod;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tmformssoactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new tmformssoaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      tmformssoaction resource,
      string[] args)
    {
      return new tmformssoaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmformssoaction[] tmformssoactionArray = new tmformssoaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmformssoactionArray[index] = new tmformssoaction();
          tmformssoactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmformssoactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      tmformssoaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmformssoaction[] tmformssoactionArray = new tmformssoaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmformssoactionArray[index] = new tmformssoaction();
          tmformssoactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmformssoactionArray, args);
      }
      return baseResponses;
    }

    public static tmformssoaction[] get(nitro_service service) => (tmformssoaction[]) new tmformssoaction().get_resources(service, (options) null);

    public static tmformssoaction[] get(nitro_service service, options option) => (tmformssoaction[]) new tmformssoaction().get_resources(service, option);

    public static tmformssoaction get(nitro_service service, string name) => (tmformssoaction) new tmformssoaction()
    {
      name = name
    }.get_resource(service);

    public static tmformssoaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tmformssoaction[]) null;
      tmformssoaction[] tmformssoactionArray1 = new tmformssoaction[name.Length];
      tmformssoaction[] tmformssoactionArray2 = new tmformssoaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tmformssoactionArray2[index] = new tmformssoaction();
        tmformssoactionArray2[index].name = name[index];
        tmformssoactionArray1[index] = (tmformssoaction) tmformssoactionArray2[index].get_resource(service);
      }
      return tmformssoactionArray1;
    }

    public static tmformssoaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      tmformssoaction tmformssoaction = new tmformssoaction();
      options option = new options();
      option.set_filter(filter);
      return (tmformssoaction[]) tmformssoaction.getfiltered(service, option);
    }

    public static tmformssoaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tmformssoaction tmformssoaction = new tmformssoaction();
      options option = new options();
      option.set_filter(filter);
      return (tmformssoaction[]) tmformssoaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tmformssoaction tmformssoaction = new tmformssoaction();
      options option = new options();
      option.set_count(true);
      tmformssoaction[] resources = (tmformssoaction[]) tmformssoaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tmformssoaction tmformssoaction = new tmformssoaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmformssoaction[] tmformssoactionArray = (tmformssoaction[]) tmformssoaction.getfiltered(service, option);
      return tmformssoactionArray != null && tmformssoactionArray.Length > 0 ? tmformssoactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tmformssoaction tmformssoaction = new tmformssoaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmformssoaction[] tmformssoactionArray = (tmformssoaction[]) tmformssoaction.getfiltered(service, option);
      return tmformssoactionArray != null && tmformssoactionArray.Length > 0 ? tmformssoactionArray[0].__count.Value : 0U;
    }

    private class tmformssoaction_response : base_response
    {
      public tmformssoaction[] tmformssoaction = (tmformssoaction[]) null;
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
