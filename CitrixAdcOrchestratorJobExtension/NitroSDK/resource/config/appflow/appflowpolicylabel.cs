// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowpolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string policylabeltypeField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private string policynameField = (string) null;
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

    public string policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
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
      appflowpolicylabel.appflowpolicylabel_response appflowpolicylabelResponse = new appflowpolicylabel.appflowpolicylabel_response();
      appflowpolicylabel.appflowpolicylabel_response resource = (appflowpolicylabel.appflowpolicylabel_response) service.get_payload_formatter().string_to_resource(appflowpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appflowpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(nitro_service client, appflowpolicylabel resource) => new appflowpolicylabel()
    {
      labelname = resource.labelname,
      policylabeltype = resource.policylabeltype
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      appflowpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowpolicylabel[] appflowpolicylabelArray = new appflowpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowpolicylabelArray[index] = new appflowpolicylabel();
          appflowpolicylabelArray[index].labelname = resources[index].labelname;
          appflowpolicylabelArray[index].policylabeltype = resources[index].policylabeltype;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appflowpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new appflowpolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      appflowpolicylabel resource)
    {
      return new appflowpolicylabel()
      {
        labelname = resource.labelname
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        appflowpolicylabel[] appflowpolicylabelArray = new appflowpolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          appflowpolicylabelArray[index] = new appflowpolicylabel();
          appflowpolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appflowpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowpolicylabel[] appflowpolicylabelArray = new appflowpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowpolicylabelArray[index] = new appflowpolicylabel();
          appflowpolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      appflowpolicylabel resource,
      string new_labelname)
    {
      return new appflowpolicylabel()
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
      return new appflowpolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static appflowpolicylabel[] get(nitro_service service) => (appflowpolicylabel[]) new appflowpolicylabel().get_resources(service, (options) null);

    public static appflowpolicylabel[] get(nitro_service service, options option) => (appflowpolicylabel[]) new appflowpolicylabel().get_resources(service, option);

    public static appflowpolicylabel get(nitro_service service, string labelname) => (appflowpolicylabel) new appflowpolicylabel()
    {
      labelname = labelname
    }.get_resource(service);

    public static appflowpolicylabel[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (appflowpolicylabel[]) null;
      appflowpolicylabel[] appflowpolicylabelArray1 = new appflowpolicylabel[labelname.Length];
      appflowpolicylabel[] appflowpolicylabelArray2 = new appflowpolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        appflowpolicylabelArray2[index] = new appflowpolicylabel();
        appflowpolicylabelArray2[index].labelname = labelname[index];
        appflowpolicylabelArray1[index] = (appflowpolicylabel) appflowpolicylabelArray2[index].get_resource(service);
      }
      return appflowpolicylabelArray1;
    }

    public static appflowpolicylabel[] get_filtered(
      nitro_service service,
      string filter)
    {
      appflowpolicylabel appflowpolicylabel = new appflowpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (appflowpolicylabel[]) appflowpolicylabel.getfiltered(service, option);
    }

    public static appflowpolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appflowpolicylabel appflowpolicylabel = new appflowpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (appflowpolicylabel[]) appflowpolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appflowpolicylabel appflowpolicylabel = new appflowpolicylabel();
      options option = new options();
      option.set_count(true);
      appflowpolicylabel[] resources = (appflowpolicylabel[]) appflowpolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appflowpolicylabel appflowpolicylabel = new appflowpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowpolicylabel[] appflowpolicylabelArray = (appflowpolicylabel[]) appflowpolicylabel.getfiltered(service, option);
      return appflowpolicylabelArray != null && appflowpolicylabelArray.Length > 0 ? appflowpolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appflowpolicylabel appflowpolicylabel = new appflowpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowpolicylabel[] appflowpolicylabelArray = (appflowpolicylabel[]) appflowpolicylabel.getfiltered(service, option);
      return appflowpolicylabelArray != null && appflowpolicylabelArray.Length > 0 ? appflowpolicylabelArray[0].__count.Value : 0U;
    }

    private class appflowpolicylabel_response : base_response
    {
      public appflowpolicylabel[] appflowpolicylabel = (appflowpolicylabel[]) null;
    }

    public static class policylabeltypeEnum
    {
      public const string HTTP = "HTTP";
      public const string OTHERTCP = "OTHERTCP";
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string policylabel = "policylabel";
    }
  }
}
