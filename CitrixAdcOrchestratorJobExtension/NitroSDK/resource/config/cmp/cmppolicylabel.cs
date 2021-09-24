// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cmp.cmppolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cmp
{
  public class cmppolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string typeField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string invoke_labelnameField = (string) null;
    private uint? flowtypeField = new uint?();
    private string descriptionField = (string) null;
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

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cmppolicylabel.cmppolicylabel_response cmppolicylabelResponse = new cmppolicylabel.cmppolicylabel_response();
      cmppolicylabel.cmppolicylabel_response resource = (cmppolicylabel.cmppolicylabel_response) service.get_payload_formatter().string_to_resource(cmppolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cmppolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(nitro_service client, cmppolicylabel resource) => new cmppolicylabel()
    {
      labelname = resource.labelname,
      type = resource.type
    }.add_resource(client);

    public static base_responses add(nitro_service client, cmppolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmppolicylabel[] cmppolicylabelArray = new cmppolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmppolicylabelArray[index] = new cmppolicylabel();
          cmppolicylabelArray[index].labelname = resources[index].labelname;
          cmppolicylabelArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cmppolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new cmppolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, cmppolicylabel resource) => new cmppolicylabel()
    {
      labelname = resource.labelname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        cmppolicylabel[] cmppolicylabelArray = new cmppolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          cmppolicylabelArray[index] = new cmppolicylabel();
          cmppolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cmppolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      cmppolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cmppolicylabel[] cmppolicylabelArray = new cmppolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cmppolicylabelArray[index] = new cmppolicylabel();
          cmppolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cmppolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      cmppolicylabel resource,
      string new_labelname)
    {
      return new cmppolicylabel()
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
      return new cmppolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static cmppolicylabel[] get(nitro_service service) => (cmppolicylabel[]) new cmppolicylabel().get_resources(service, (options) null);

    public static cmppolicylabel[] get(nitro_service service, options option) => (cmppolicylabel[]) new cmppolicylabel().get_resources(service, option);

    public static cmppolicylabel get(nitro_service service, string labelname) => (cmppolicylabel) new cmppolicylabel()
    {
      labelname = labelname
    }.get_resource(service);

    public static cmppolicylabel[] get(nitro_service service, string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (cmppolicylabel[]) null;
      cmppolicylabel[] cmppolicylabelArray1 = new cmppolicylabel[labelname.Length];
      cmppolicylabel[] cmppolicylabelArray2 = new cmppolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        cmppolicylabelArray2[index] = new cmppolicylabel();
        cmppolicylabelArray2[index].labelname = labelname[index];
        cmppolicylabelArray1[index] = (cmppolicylabel) cmppolicylabelArray2[index].get_resource(service);
      }
      return cmppolicylabelArray1;
    }

    public static cmppolicylabel[] get_filtered(nitro_service service, string filter)
    {
      cmppolicylabel cmppolicylabel = new cmppolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (cmppolicylabel[]) cmppolicylabel.getfiltered(service, option);
    }

    public static cmppolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      cmppolicylabel cmppolicylabel = new cmppolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (cmppolicylabel[]) cmppolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cmppolicylabel cmppolicylabel = new cmppolicylabel();
      options option = new options();
      option.set_count(true);
      cmppolicylabel[] resources = (cmppolicylabel[]) cmppolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cmppolicylabel cmppolicylabel = new cmppolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cmppolicylabel[] cmppolicylabelArray = (cmppolicylabel[]) cmppolicylabel.getfiltered(service, option);
      return cmppolicylabelArray != null && cmppolicylabelArray.Length > 0 ? cmppolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cmppolicylabel cmppolicylabel = new cmppolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cmppolicylabel[] cmppolicylabelArray = (cmppolicylabel[]) cmppolicylabel.getfiltered(service, option);
      return cmppolicylabelArray != null && cmppolicylabelArray.Length > 0 ? cmppolicylabelArray[0].__count.Value : 0U;
    }

    private class cmppolicylabel_response : base_response
    {
      public cmppolicylabel[] cmppolicylabel = (cmppolicylabel[]) null;
    }

    public static class typeEnum
    {
      public const string REQ = "REQ";
      public const string RES = "RES";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
