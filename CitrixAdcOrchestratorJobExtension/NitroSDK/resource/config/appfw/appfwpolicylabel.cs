// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwpolicylabel : base_resource
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
    private string policytypeField = (string) null;
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

    public string policytype
    {
      get => this.policytypeField;
      private set => this.policytypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwpolicylabel.appfwpolicylabel_response appfwpolicylabelResponse = new appfwpolicylabel.appfwpolicylabel_response();
      appfwpolicylabel.appfwpolicylabel_response resource = (appfwpolicylabel.appfwpolicylabel_response) service.get_payload_formatter().string_to_resource(appfwpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(nitro_service client, appfwpolicylabel resource) => new appfwpolicylabel()
    {
      labelname = resource.labelname,
      policylabeltype = resource.policylabeltype
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      appfwpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwpolicylabel[] appfwpolicylabelArray = new appfwpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicylabelArray[index] = new appfwpolicylabel();
          appfwpolicylabelArray[index].labelname = resources[index].labelname;
          appfwpolicylabelArray[index].policylabeltype = resources[index].policylabeltype;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appfwpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new appfwpolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appfwpolicylabel resource) => new appfwpolicylabel()
    {
      labelname = resource.labelname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        appfwpolicylabel[] appfwpolicylabelArray = new appfwpolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          appfwpolicylabelArray[index] = new appfwpolicylabel();
          appfwpolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appfwpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwpolicylabel[] appfwpolicylabelArray = new appfwpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicylabelArray[index] = new appfwpolicylabel();
          appfwpolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      appfwpolicylabel resource,
      string new_labelname)
    {
      return new appfwpolicylabel()
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
      return new appfwpolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static appfwpolicylabel[] get(nitro_service service) => (appfwpolicylabel[]) new appfwpolicylabel().get_resources(service, (options) null);

    public static appfwpolicylabel[] get(nitro_service service, options option) => (appfwpolicylabel[]) new appfwpolicylabel().get_resources(service, option);

    public static appfwpolicylabel get(nitro_service service, string labelname) => (appfwpolicylabel) new appfwpolicylabel()
    {
      labelname = labelname
    }.get_resource(service);

    public static appfwpolicylabel[] get(nitro_service service, string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (appfwpolicylabel[]) null;
      appfwpolicylabel[] appfwpolicylabelArray1 = new appfwpolicylabel[labelname.Length];
      appfwpolicylabel[] appfwpolicylabelArray2 = new appfwpolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        appfwpolicylabelArray2[index] = new appfwpolicylabel();
        appfwpolicylabelArray2[index].labelname = labelname[index];
        appfwpolicylabelArray1[index] = (appfwpolicylabel) appfwpolicylabelArray2[index].get_resource(service);
      }
      return appfwpolicylabelArray1;
    }

    public static appfwpolicylabel[] get_filtered(
      nitro_service service,
      string filter)
    {
      appfwpolicylabel appfwpolicylabel = new appfwpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (appfwpolicylabel[]) appfwpolicylabel.getfiltered(service, option);
    }

    public static appfwpolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appfwpolicylabel appfwpolicylabel = new appfwpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (appfwpolicylabel[]) appfwpolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwpolicylabel appfwpolicylabel = new appfwpolicylabel();
      options option = new options();
      option.set_count(true);
      appfwpolicylabel[] resources = (appfwpolicylabel[]) appfwpolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwpolicylabel appfwpolicylabel = new appfwpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwpolicylabel[] appfwpolicylabelArray = (appfwpolicylabel[]) appfwpolicylabel.getfiltered(service, option);
      return appfwpolicylabelArray != null && appfwpolicylabelArray.Length > 0 ? appfwpolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwpolicylabel appfwpolicylabel = new appfwpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwpolicylabel[] appfwpolicylabelArray = (appfwpolicylabel[]) appfwpolicylabel.getfiltered(service, option);
      return appfwpolicylabelArray != null && appfwpolicylabelArray.Length > 0 ? appfwpolicylabelArray[0].__count.Value : 0U;
    }

    private class appfwpolicylabel_response : base_response
    {
      public appfwpolicylabel[] appfwpolicylabel = (appfwpolicylabel[]) null;
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

    public static class policytypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
    }
  }
}
