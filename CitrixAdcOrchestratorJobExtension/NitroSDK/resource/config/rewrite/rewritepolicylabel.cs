// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rewrite
{
  public class rewritepolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string transformField = (string) null;
    private string commentField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string invoke_labelnameField = (string) null;
    private uint? flowtypeField = new uint?();
    private string descriptionField = (string) null;
    private bool? isdefaultField = new bool?();
    private string[] builtinField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public string transform
    {
      get => this.transformField;
      set => this.transformField = value;
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

    public uint? numpol
    {
      get => this.numpolField;
      private set => this.numpolField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public string invoke_labelname
    {
      get => this.invoke_labelnameField;
      private set => this.invoke_labelnameField = value;
    }

    public uint? flowtype
    {
      get => this.flowtypeField;
      private set => this.flowtypeField = value;
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
      rewritepolicylabel.rewritepolicylabel_response rewritepolicylabelResponse = new rewritepolicylabel.rewritepolicylabel_response();
      rewritepolicylabel.rewritepolicylabel_response resource = (rewritepolicylabel.rewritepolicylabel_response) service.get_payload_formatter().string_to_resource(rewritepolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rewritepolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(nitro_service client, rewritepolicylabel resource) => new rewritepolicylabel()
    {
      labelname = resource.labelname,
      transform = resource.transform,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      rewritepolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewritepolicylabel[] rewritepolicylabelArray = new rewritepolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewritepolicylabelArray[index] = new rewritepolicylabel();
          rewritepolicylabelArray[index].labelname = resources[index].labelname;
          rewritepolicylabelArray[index].transform = resources[index].transform;
          rewritepolicylabelArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) rewritepolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new rewritepolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      rewritepolicylabel resource)
    {
      return new rewritepolicylabel()
      {
        labelname = resource.labelname
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        rewritepolicylabel[] rewritepolicylabelArray = new rewritepolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          rewritepolicylabelArray[index] = new rewritepolicylabel();
          rewritepolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rewritepolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      rewritepolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rewritepolicylabel[] rewritepolicylabelArray = new rewritepolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rewritepolicylabelArray[index] = new rewritepolicylabel();
          rewritepolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rewritepolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      rewritepolicylabel resource,
      string new_labelname)
    {
      return new rewritepolicylabel()
      {
        labelname = resource.labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string labelname,
      string new_labelname)
    {
      return new rewritepolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static rewritepolicylabel[] get(nitro_service service) => (rewritepolicylabel[]) new rewritepolicylabel().get_resources(service, (options) null);

    public static rewritepolicylabel[] get(nitro_service service, options option) => (rewritepolicylabel[]) new rewritepolicylabel().get_resources(service, option);

    public static rewritepolicylabel get(nitro_service service, string labelname) => (rewritepolicylabel) new rewritepolicylabel()
    {
      labelname = labelname
    }.get_resource(service);

    public static rewritepolicylabel[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (rewritepolicylabel[]) null;
      rewritepolicylabel[] rewritepolicylabelArray1 = new rewritepolicylabel[labelname.Length];
      rewritepolicylabel[] rewritepolicylabelArray2 = new rewritepolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        rewritepolicylabelArray2[index] = new rewritepolicylabel();
        rewritepolicylabelArray2[index].labelname = labelname[index];
        rewritepolicylabelArray1[index] = (rewritepolicylabel) rewritepolicylabelArray2[index].get_resource(service);
      }
      return rewritepolicylabelArray1;
    }

    public static rewritepolicylabel[] get_filtered(
      nitro_service service,
      string filter)
    {
      rewritepolicylabel rewritepolicylabel = new rewritepolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (rewritepolicylabel[]) rewritepolicylabel.getfiltered(service, option);
    }

    public static rewritepolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      rewritepolicylabel rewritepolicylabel = new rewritepolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (rewritepolicylabel[]) rewritepolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rewritepolicylabel rewritepolicylabel = new rewritepolicylabel();
      options option = new options();
      option.set_count(true);
      rewritepolicylabel[] resources = (rewritepolicylabel[]) rewritepolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rewritepolicylabel rewritepolicylabel = new rewritepolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rewritepolicylabel[] rewritepolicylabelArray = (rewritepolicylabel[]) rewritepolicylabel.getfiltered(service, option);
      return rewritepolicylabelArray != null && rewritepolicylabelArray.Length > 0 ? rewritepolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rewritepolicylabel rewritepolicylabel = new rewritepolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rewritepolicylabel[] rewritepolicylabelArray = (rewritepolicylabel[]) rewritepolicylabel.getfiltered(service, option);
      return rewritepolicylabelArray != null && rewritepolicylabelArray.Length > 0 ? rewritepolicylabelArray[0].__count.Value : 0U;
    }

    private class rewritepolicylabel_response : base_response
    {
      public rewritepolicylabel[] rewritepolicylabel = (rewritepolicylabel[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }

    public static class transformEnum
    {
      public const string http_req = "http_req";
      public const string http_res = "http_res";
      public const string othertcp_req = "othertcp_req";
      public const string othertcp_res = "othertcp_res";
      public const string url = "url";
      public const string text = "text";
      public const string clientless_vpn_req = "clientless_vpn_req";
      public const string clientless_vpn_res = "clientless_vpn_res";
      public const string sipudp_req = "sipudp_req";
      public const string sipudp_res = "sipudp_res";
      public const string siptcp_req = "siptcp_req";
      public const string siptcp_res = "siptcp_res";
      public const string diameter_req = "diameter_req";
      public const string diameter_res = "diameter_res";
      public const string radius_req = "radius_req";
      public const string radius_res = "radius_res";
      public const string dns_req = "dns_req";
      public const string dns_res = "dns_res";
    }
  }
}
