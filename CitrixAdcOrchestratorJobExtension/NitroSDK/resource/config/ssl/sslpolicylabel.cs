// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslpolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslpolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string typeField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private bool? invokeField = new bool?();
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

    public bool? invoke
    {
      get => this.invokeField;
      private set => this.invokeField = value;
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
      sslpolicylabel.sslpolicylabel_response sslpolicylabelResponse = new sslpolicylabel.sslpolicylabel_response();
      sslpolicylabel.sslpolicylabel_response resource = (sslpolicylabel.sslpolicylabel_response) service.get_payload_formatter().string_to_resource(sslpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(nitro_service client, sslpolicylabel resource) => new sslpolicylabel()
    {
      labelname = resource.labelname,
      type = resource.type
    }.add_resource(client);

    public static base_responses add(nitro_service client, sslpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslpolicylabel[] sslpolicylabelArray = new sslpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicylabelArray[index] = new sslpolicylabel();
          sslpolicylabelArray[index].labelname = resources[index].labelname;
          sslpolicylabelArray[index].type = resources[index].type;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new sslpolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslpolicylabel resource) => new sslpolicylabel()
    {
      labelname = resource.labelname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        sslpolicylabel[] sslpolicylabelArray = new sslpolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          sslpolicylabelArray[index] = new sslpolicylabel();
          sslpolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      sslpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslpolicylabel[] sslpolicylabelArray = new sslpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslpolicylabelArray[index] = new sslpolicylabel();
          sslpolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslpolicylabelArray);
      }
      return baseResponses;
    }

    public static sslpolicylabel[] get(nitro_service service) => (sslpolicylabel[]) new sslpolicylabel().get_resources(service, (options) null);

    public static sslpolicylabel[] get(nitro_service service, options option) => (sslpolicylabel[]) new sslpolicylabel().get_resources(service, option);

    public static sslpolicylabel get(nitro_service service, string labelname) => (sslpolicylabel) new sslpolicylabel()
    {
      labelname = labelname
    }.get_resource(service);

    public static sslpolicylabel[] get(nitro_service service, string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (sslpolicylabel[]) null;
      sslpolicylabel[] sslpolicylabelArray1 = new sslpolicylabel[labelname.Length];
      sslpolicylabel[] sslpolicylabelArray2 = new sslpolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        sslpolicylabelArray2[index] = new sslpolicylabel();
        sslpolicylabelArray2[index].labelname = labelname[index];
        sslpolicylabelArray1[index] = (sslpolicylabel) sslpolicylabelArray2[index].get_resource(service);
      }
      return sslpolicylabelArray1;
    }

    public static sslpolicylabel[] get_filtered(nitro_service service, string filter)
    {
      sslpolicylabel sslpolicylabel = new sslpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (sslpolicylabel[]) sslpolicylabel.getfiltered(service, option);
    }

    public static sslpolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      sslpolicylabel sslpolicylabel = new sslpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (sslpolicylabel[]) sslpolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslpolicylabel sslpolicylabel = new sslpolicylabel();
      options option = new options();
      option.set_count(true);
      sslpolicylabel[] resources = (sslpolicylabel[]) sslpolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslpolicylabel sslpolicylabel = new sslpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslpolicylabel[] sslpolicylabelArray = (sslpolicylabel[]) sslpolicylabel.getfiltered(service, option);
      return sslpolicylabelArray != null && sslpolicylabelArray.Length > 0 ? sslpolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslpolicylabel sslpolicylabel = new sslpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslpolicylabel[] sslpolicylabelArray = (sslpolicylabel[]) sslpolicylabel.getfiltered(service, option);
      return sslpolicylabelArray != null && sslpolicylabelArray.Length > 0 ? sslpolicylabelArray[0].__count.Value : 0U;
    }

    private class sslpolicylabel_response : base_response
    {
      public sslpolicylabel[] sslpolicylabel = (sslpolicylabel[]) null;
    }

    public static class typeEnum
    {
      public const string CONTROL = "CONTROL";
      public const string DATA = "DATA";
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string service = "service";
      public const string policylabel = "policylabel";
    }
  }
}
