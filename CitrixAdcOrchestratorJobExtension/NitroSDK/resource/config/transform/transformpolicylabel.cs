// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformpolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformpolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string policylabeltypeField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string invoke_labelnameField = (string) null;
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

    public string policylabeltype
    {
      get => this.policylabeltypeField;
      set => this.policylabeltypeField = value;
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

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformpolicylabel.transformpolicylabel_response transformpolicylabelResponse = new transformpolicylabel.transformpolicylabel_response();
      transformpolicylabel.transformpolicylabel_response resource = (transformpolicylabel.transformpolicylabel_response) service.get_payload_formatter().string_to_resource(transformpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(
      nitro_service client,
      transformpolicylabel resource)
    {
      return new transformpolicylabel()
      {
        labelname = resource.labelname,
        policylabeltype = resource.policylabeltype
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      transformpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformpolicylabel[] transformpolicylabelArray = new transformpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformpolicylabelArray[index] = new transformpolicylabel();
          transformpolicylabelArray[index].labelname = resources[index].labelname;
          transformpolicylabelArray[index].policylabeltype = resources[index].policylabeltype;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) transformpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new transformpolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      transformpolicylabel resource)
    {
      return new transformpolicylabel()
      {
        labelname = resource.labelname
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        transformpolicylabel[] transformpolicylabelArray = new transformpolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          transformpolicylabelArray[index] = new transformpolicylabel();
          transformpolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      transformpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        transformpolicylabel[] transformpolicylabelArray = new transformpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          transformpolicylabelArray[index] = new transformpolicylabel();
          transformpolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) transformpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      transformpolicylabel resource,
      string new_labelname)
    {
      return new transformpolicylabel()
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
      return new transformpolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static transformpolicylabel[] get(nitro_service service) => (transformpolicylabel[]) new transformpolicylabel().get_resources(service, (options) null);

    public static transformpolicylabel[] get(
      nitro_service service,
      options option)
    {
      return (transformpolicylabel[]) new transformpolicylabel().get_resources(service, option);
    }

    public static transformpolicylabel get(
      nitro_service service,
      string labelname)
    {
      return (transformpolicylabel) new transformpolicylabel()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static transformpolicylabel[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (transformpolicylabel[]) null;
      transformpolicylabel[] transformpolicylabelArray1 = new transformpolicylabel[labelname.Length];
      transformpolicylabel[] transformpolicylabelArray2 = new transformpolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        transformpolicylabelArray2[index] = new transformpolicylabel();
        transformpolicylabelArray2[index].labelname = labelname[index];
        transformpolicylabelArray1[index] = (transformpolicylabel) transformpolicylabelArray2[index].get_resource(service);
      }
      return transformpolicylabelArray1;
    }

    public static transformpolicylabel[] get_filtered(
      nitro_service service,
      string filter)
    {
      transformpolicylabel transformpolicylabel = new transformpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (transformpolicylabel[]) transformpolicylabel.getfiltered(service, option);
    }

    public static transformpolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      transformpolicylabel transformpolicylabel = new transformpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (transformpolicylabel[]) transformpolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      transformpolicylabel transformpolicylabel = new transformpolicylabel();
      options option = new options();
      option.set_count(true);
      transformpolicylabel[] resources = (transformpolicylabel[]) transformpolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      transformpolicylabel transformpolicylabel = new transformpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformpolicylabel[] transformpolicylabelArray = (transformpolicylabel[]) transformpolicylabel.getfiltered(service, option);
      return transformpolicylabelArray != null && transformpolicylabelArray.Length > 0 ? transformpolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      transformpolicylabel transformpolicylabel = new transformpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      transformpolicylabel[] transformpolicylabelArray = (transformpolicylabel[]) transformpolicylabel.getfiltered(service, option);
      return transformpolicylabelArray != null && transformpolicylabelArray.Length > 0 ? transformpolicylabelArray[0].__count.Value : 0U;
    }

    private class transformpolicylabel_response : base_response
    {
      public transformpolicylabel[] transformpolicylabel = (transformpolicylabel[]) null;
    }

    public static class policylabeltypeEnum
    {
      public const string http_req = "http_req";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string policylabel = "policylabel";
    }
  }
}
