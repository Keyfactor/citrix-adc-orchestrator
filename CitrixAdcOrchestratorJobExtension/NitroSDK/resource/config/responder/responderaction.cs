// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.responder.responderaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.responder
{
  public class responderaction : base_resource
  {
    private string nameField = (string) null;
    private string typeField = (string) null;
    private string targetField = (string) null;
    private string htmlpageField = (string) null;
    private string bypasssafetycheckField = (string) null;
    private string commentField = (string) null;
    private uint? responsestatuscodeField = new uint?();
    private string reasonphraseField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private uint? referencecountField = new uint?();
    private long? undefhitsField = new long?();
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

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string target
    {
      get => this.targetField;
      set => this.targetField = value;
    }

    public string htmlpage
    {
      get => this.htmlpageField;
      set => this.htmlpageField = value;
    }

    public string bypasssafetycheck
    {
      get => this.bypasssafetycheckField;
      set => this.bypasssafetycheckField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public uint? responsestatuscode
    {
      get => this.responsestatuscodeField;
      set => this.responsestatuscodeField = value;
    }

    public string reasonphrase
    {
      get => this.reasonphraseField;
      set => this.reasonphraseField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
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
      responderaction.responderaction_response responderactionResponse = new responderaction.responderaction_response();
      responderaction.responderaction_response resource = (responderaction.responderaction_response) service.get_payload_formatter().string_to_resource(responderactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.responderaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, responderaction resource) => new responderaction()
    {
      name = resource.name,
      type = resource.type,
      target = resource.target,
      htmlpage = resource.htmlpage,
      bypasssafetycheck = resource.bypasssafetycheck,
      comment = resource.comment,
      responsestatuscode = resource.responsestatuscode,
      reasonphrase = resource.reasonphrase
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      responderaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderaction[] responderactionArray = new responderaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderactionArray[index] = new responderaction();
          responderactionArray[index].name = resources[index].name;
          responderactionArray[index].type = resources[index].type;
          responderactionArray[index].target = resources[index].target;
          responderactionArray[index].htmlpage = resources[index].htmlpage;
          responderactionArray[index].bypasssafetycheck = resources[index].bypasssafetycheck;
          responderactionArray[index].comment = resources[index].comment;
          responderactionArray[index].responsestatuscode = resources[index].responsestatuscode;
          responderactionArray[index].reasonphrase = resources[index].reasonphrase;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) responderactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new responderaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, responderaction resource) => new responderaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        responderaction[] responderactionArray = new responderaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          responderactionArray[index] = new responderaction();
          responderactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) responderactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      responderaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderaction[] responderactionArray = new responderaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderactionArray[index] = new responderaction();
          responderactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) responderactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, responderaction resource) => new responderaction()
    {
      name = resource.name,
      target = resource.target,
      bypasssafetycheck = resource.bypasssafetycheck,
      htmlpage = resource.htmlpage,
      responsestatuscode = resource.responsestatuscode,
      reasonphrase = resource.reasonphrase,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      responderaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderaction[] responderactionArray = new responderaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderactionArray[index] = new responderaction();
          responderactionArray[index].name = resources[index].name;
          responderactionArray[index].target = resources[index].target;
          responderactionArray[index].bypasssafetycheck = resources[index].bypasssafetycheck;
          responderactionArray[index].htmlpage = resources[index].htmlpage;
          responderactionArray[index].responsestatuscode = resources[index].responsestatuscode;
          responderactionArray[index].reasonphrase = resources[index].reasonphrase;
          responderactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) responderactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new responderaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      responderaction resource,
      string[] args)
    {
      return new responderaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        responderaction[] responderactionArray = new responderaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          responderactionArray[index] = new responderaction();
          responderactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) responderactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      responderaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderaction[] responderactionArray = new responderaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderactionArray[index] = new responderaction();
          responderactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) responderactionArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      responderaction resource,
      string new_name)
    {
      return new responderaction()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new responderaction()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static responderaction[] get(nitro_service service) => (responderaction[]) new responderaction().get_resources(service, (options) null);

    public static responderaction[] get(nitro_service service, options option) => (responderaction[]) new responderaction().get_resources(service, option);

    public static responderaction get(nitro_service service, string name) => (responderaction) new responderaction()
    {
      name = name
    }.get_resource(service);

    public static responderaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (responderaction[]) null;
      responderaction[] responderactionArray1 = new responderaction[name.Length];
      responderaction[] responderactionArray2 = new responderaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        responderactionArray2[index] = new responderaction();
        responderactionArray2[index].name = name[index];
        responderactionArray1[index] = (responderaction) responderactionArray2[index].get_resource(service);
      }
      return responderactionArray1;
    }

    public static responderaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      responderaction responderaction = new responderaction();
      options option = new options();
      option.set_filter(filter);
      return (responderaction[]) responderaction.getfiltered(service, option);
    }

    public static responderaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      responderaction responderaction = new responderaction();
      options option = new options();
      option.set_filter(filter);
      return (responderaction[]) responderaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      responderaction responderaction = new responderaction();
      options option = new options();
      option.set_count(true);
      responderaction[] resources = (responderaction[]) responderaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      responderaction responderaction = new responderaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      responderaction[] responderactionArray = (responderaction[]) responderaction.getfiltered(service, option);
      return responderactionArray != null && responderactionArray.Length > 0 ? responderactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      responderaction responderaction = new responderaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      responderaction[] responderactionArray = (responderaction[]) responderaction.getfiltered(service, option);
      return responderactionArray != null && responderactionArray.Length > 0 ? responderactionArray[0].__count.Value : 0U;
    }

    private class responderaction_response : base_response
    {
      public responderaction[] responderaction = (responderaction[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class typeEnum
    {
      public const string noop = "noop";
      public const string respondwith = "respondwith";
      public const string redirect = "redirect";
      public const string respondwithhtmlpage = "respondwithhtmlpage";
      public const string sqlresponse_ok = "sqlresponse_ok";
      public const string sqlresponse_error = "sqlresponse_error";
    }

    public static class bypasssafetycheckEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
