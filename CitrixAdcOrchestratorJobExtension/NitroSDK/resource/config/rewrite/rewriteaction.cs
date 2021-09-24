// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rewrite.rewriteaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rewrite
{
  public class rewriteaction : base_resource
  {
    private string nameField = (string) null;
    private string typeField = (string) null;
    private string targetField = (string) null;
    private string stringbuilderexprField = (string) null;
    private string patternField = (string) null;
    private string searchField = (string) null;
    private string bypasssafetycheckField = (string) null;
    private string refinesearchField = (string) null;
    private string commentField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private uint? referencecountField = new uint?();
    private string descriptionField = (string) null;
    private bool? isdefaultField = new bool?();
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

    public string stringbuilderexpr
    {
      get => this.stringbuilderexprField;
      set => this.stringbuilderexprField = value;
    }

    public string pattern
    {
      get => this.patternField;
      set => this.patternField = value;
    }

    public string search
    {
      get => this.searchField;
      set => this.searchField = value;
    }

    public string bypasssafetycheck
    {
      get => this.bypasssafetycheckField;
      set => this.bypasssafetycheckField = value;
    }

    public string refinesearch
    {
      get => this.refinesearchField;
      set => this.refinesearchField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
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

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
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
      rewriteaction.rewriteaction_response rewriteactionResponse = new rewriteaction.rewriteaction_response();
      rewriteaction.rewriteaction_response resource = (rewriteaction.rewriteaction_response) service.get_payload_formatter().string_to_resource(rewriteactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rewriteaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, rewriteaction resource) => new rewriteaction()
    {
      name = resource.name,
      type = resource.type,
      target = resource.target,
      stringbuilderexpr = resource.stringbuilderexpr,
      pattern = resource.pattern,
      search = resource.search,
      bypasssafetycheck = resource.bypasssafetycheck,
      refinesearch = resource.refinesearch,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, rewriteaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewriteaction[] rewriteactionArray = new rewriteaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewriteactionArray[index] = new rewriteaction();
          rewriteactionArray[index].name = resources[index].name;
          rewriteactionArray[index].type = resources[index].type;
          rewriteactionArray[index].target = resources[index].target;
          rewriteactionArray[index].stringbuilderexpr = resources[index].stringbuilderexpr;
          rewriteactionArray[index].pattern = resources[index].pattern;
          rewriteactionArray[index].search = resources[index].search;
          rewriteactionArray[index].bypasssafetycheck = resources[index].bypasssafetycheck;
          rewriteactionArray[index].refinesearch = resources[index].refinesearch;
          rewriteactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) rewriteactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new rewriteaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, rewriteaction resource) => new rewriteaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rewriteaction[] rewriteactionArray = new rewriteaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rewriteactionArray[index] = new rewriteaction();
          rewriteactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rewriteactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      rewriteaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewriteaction[] rewriteactionArray = new rewriteaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewriteactionArray[index] = new rewriteaction();
          rewriteactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rewriteactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, rewriteaction resource)
    {
      rewriteaction rewriteaction = new rewriteaction()
      {
        name = resource.name,
        target = resource.target,
        stringbuilderexpr = resource.stringbuilderexpr,
        bypasssafetycheck = resource.bypasssafetycheck,
        pattern = resource.pattern,
        search = resource.search
      };
      rewriteaction.bypasssafetycheck = resource.bypasssafetycheck;
      rewriteaction.refinesearch = resource.refinesearch;
      rewriteaction.comment = resource.comment;
      return rewriteaction.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      rewriteaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewriteaction[] rewriteactionArray = new rewriteaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewriteactionArray[index] = new rewriteaction();
          rewriteactionArray[index].name = resources[index].name;
          rewriteactionArray[index].target = resources[index].target;
          rewriteactionArray[index].stringbuilderexpr = resources[index].stringbuilderexpr;
          rewriteactionArray[index].bypasssafetycheck = resources[index].bypasssafetycheck;
          rewriteactionArray[index].pattern = resources[index].pattern;
          rewriteactionArray[index].search = resources[index].search;
          rewriteactionArray[index].bypasssafetycheck = resources[index].bypasssafetycheck;
          rewriteactionArray[index].refinesearch = resources[index].refinesearch;
          rewriteactionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) rewriteactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new rewriteaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      rewriteaction resource,
      string[] args)
    {
      return new rewriteaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rewriteaction[] rewriteactionArray = new rewriteaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rewriteactionArray[index] = new rewriteaction();
          rewriteactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rewriteactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      rewriteaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewriteaction[] rewriteactionArray = new rewriteaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewriteactionArray[index] = new rewriteaction();
          rewriteactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rewriteactionArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      rewriteaction resource,
      string new_name)
    {
      return new rewriteaction()
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
      return new rewriteaction()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static rewriteaction[] get(nitro_service service) => (rewriteaction[]) new rewriteaction().get_resources(service, (options) null);

    public static rewriteaction[] get(nitro_service service, options option) => (rewriteaction[]) new rewriteaction().get_resources(service, option);

    public static rewriteaction get(nitro_service service, string name) => (rewriteaction) new rewriteaction()
    {
      name = name
    }.get_resource(service);

    public static rewriteaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (rewriteaction[]) null;
      rewriteaction[] rewriteactionArray1 = new rewriteaction[name.Length];
      rewriteaction[] rewriteactionArray2 = new rewriteaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        rewriteactionArray2[index] = new rewriteaction();
        rewriteactionArray2[index].name = name[index];
        rewriteactionArray1[index] = (rewriteaction) rewriteactionArray2[index].get_resource(service);
      }
      return rewriteactionArray1;
    }

    public static rewriteaction[] get_filtered(nitro_service service, string filter)
    {
      rewriteaction rewriteaction = new rewriteaction();
      options option = new options();
      option.set_filter(filter);
      return (rewriteaction[]) rewriteaction.getfiltered(service, option);
    }

    public static rewriteaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      rewriteaction rewriteaction = new rewriteaction();
      options option = new options();
      option.set_filter(filter);
      return (rewriteaction[]) rewriteaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rewriteaction rewriteaction = new rewriteaction();
      options option = new options();
      option.set_count(true);
      rewriteaction[] resources = (rewriteaction[]) rewriteaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rewriteaction rewriteaction = new rewriteaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rewriteaction[] rewriteactionArray = (rewriteaction[]) rewriteaction.getfiltered(service, option);
      return rewriteactionArray != null && rewriteactionArray.Length > 0 ? rewriteactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rewriteaction rewriteaction = new rewriteaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rewriteaction[] rewriteactionArray = (rewriteaction[]) rewriteaction.getfiltered(service, option);
      return rewriteactionArray != null && rewriteactionArray.Length > 0 ? rewriteactionArray[0].__count.Value : 0U;
    }

    private class rewriteaction_response : base_response
    {
      public rewriteaction[] rewriteaction = (rewriteaction[]) null;
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
      public const string delete = "delete";
      public const string insert_http_header = "insert_http_header";
      public const string delete_http_header = "delete_http_header";
      public const string corrupt_http_header = "corrupt_http_header";
      public const string insert_before = "insert_before";
      public const string insert_after = "insert_after";
      public const string replace = "replace";
      public const string replace_http_res = "replace_http_res";
      public const string delete_all = "delete_all";
      public const string replace_all = "replace_all";
      public const string insert_before_all = "insert_before_all";
      public const string insert_after_all = "insert_after_all";
      public const string clientless_vpn_encode = "clientless_vpn_encode";
      public const string clientless_vpn_encode_all = "clientless_vpn_encode_all";
      public const string clientless_vpn_decode = "clientless_vpn_decode";
      public const string clientless_vpn_decode_all = "clientless_vpn_decode_all";
      public const string insert_sip_header = "insert_sip_header";
      public const string delete_sip_header = "delete_sip_header";
      public const string corrupt_sip_header = "corrupt_sip_header";
      public const string replace_sip_res = "replace_sip_res";
      public const string replace_diameter_header_field = "replace_diameter_header_field";
      public const string replace_dns_header_field = "replace_dns_header_field";
      public const string replace_dns_answer_section = "replace_dns_answer_section";
    }

    public static class bypasssafetycheckEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
