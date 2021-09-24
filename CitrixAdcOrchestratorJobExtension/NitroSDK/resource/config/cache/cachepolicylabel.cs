// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cachepolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string evaluatesField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string invoke_labelnameField = (string) null;
    private uint? flowtypeField = new uint?();
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

    public string evaluates
    {
      get => this.evaluatesField;
      set => this.evaluatesField = value;
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

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cachepolicylabel.cachepolicylabel_response cachepolicylabelResponse = new cachepolicylabel.cachepolicylabel_response();
      cachepolicylabel.cachepolicylabel_response resource = (cachepolicylabel.cachepolicylabel_response) service.get_payload_formatter().string_to_resource(cachepolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cachepolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(nitro_service client, cachepolicylabel resource) => new cachepolicylabel()
    {
      labelname = resource.labelname,
      evaluates = resource.evaluates
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      cachepolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachepolicylabel[] cachepolicylabelArray = new cachepolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachepolicylabelArray[index] = new cachepolicylabel();
          cachepolicylabelArray[index].labelname = resources[index].labelname;
          cachepolicylabelArray[index].evaluates = resources[index].evaluates;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cachepolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new cachepolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, cachepolicylabel resource) => new cachepolicylabel()
    {
      labelname = resource.labelname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        cachepolicylabel[] cachepolicylabelArray = new cachepolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          cachepolicylabelArray[index] = new cachepolicylabel();
          cachepolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cachepolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      cachepolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachepolicylabel[] cachepolicylabelArray = new cachepolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachepolicylabelArray[index] = new cachepolicylabel();
          cachepolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cachepolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      cachepolicylabel resource,
      string new_labelname)
    {
      return new cachepolicylabel()
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
      return new cachepolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static cachepolicylabel[] get(nitro_service service) => (cachepolicylabel[]) new cachepolicylabel().get_resources(service, (options) null);

    public static cachepolicylabel[] get(nitro_service service, options option) => (cachepolicylabel[]) new cachepolicylabel().get_resources(service, option);

    public static cachepolicylabel get(nitro_service service, string labelname) => (cachepolicylabel) new cachepolicylabel()
    {
      labelname = labelname
    }.get_resource(service);

    public static cachepolicylabel[] get(nitro_service service, string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (cachepolicylabel[]) null;
      cachepolicylabel[] cachepolicylabelArray1 = new cachepolicylabel[labelname.Length];
      cachepolicylabel[] cachepolicylabelArray2 = new cachepolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        cachepolicylabelArray2[index] = new cachepolicylabel();
        cachepolicylabelArray2[index].labelname = labelname[index];
        cachepolicylabelArray1[index] = (cachepolicylabel) cachepolicylabelArray2[index].get_resource(service);
      }
      return cachepolicylabelArray1;
    }

    public static cachepolicylabel[] get_filtered(
      nitro_service service,
      string filter)
    {
      cachepolicylabel cachepolicylabel = new cachepolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (cachepolicylabel[]) cachepolicylabel.getfiltered(service, option);
    }

    public static cachepolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      cachepolicylabel cachepolicylabel = new cachepolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (cachepolicylabel[]) cachepolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cachepolicylabel cachepolicylabel = new cachepolicylabel();
      options option = new options();
      option.set_count(true);
      cachepolicylabel[] resources = (cachepolicylabel[]) cachepolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cachepolicylabel cachepolicylabel = new cachepolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachepolicylabel[] cachepolicylabelArray = (cachepolicylabel[]) cachepolicylabel.getfiltered(service, option);
      return cachepolicylabelArray != null && cachepolicylabelArray.Length > 0 ? cachepolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cachepolicylabel cachepolicylabel = new cachepolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachepolicylabel[] cachepolicylabelArray = (cachepolicylabel[]) cachepolicylabel.getfiltered(service, option);
      return cachepolicylabelArray != null && cachepolicylabelArray.Length > 0 ? cachepolicylabelArray[0].__count.Value : 0U;
    }

    private class cachepolicylabel_response : base_response
    {
      public cachepolicylabel[] cachepolicylabel = (cachepolicylabel[]) null;
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

    public static class evaluatesEnum
    {
      public const string REQ = "REQ";
      public const string RES = "RES";
      public const string MSSQL_REQ = "MSSQL_REQ";
      public const string MSSQL_RES = "MSSQL_RES";
      public const string MYSQL_REQ = "MYSQL_REQ";
      public const string MYSQL_RES = "MYSQL_RES";
    }
  }
}
