// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnspolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnspolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string transformField = (string) null;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnspolicylabel.dnspolicylabel_response dnspolicylabelResponse = new dnspolicylabel.dnspolicylabel_response();
      dnspolicylabel.dnspolicylabel_response resource = (dnspolicylabel.dnspolicylabel_response) service.get_payload_formatter().string_to_resource(dnspolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnspolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(nitro_service client, dnspolicylabel resource) => new dnspolicylabel()
    {
      labelname = resource.labelname,
      transform = resource.transform
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnspolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicylabel[] dnspolicylabelArray = new dnspolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicylabelArray[index] = new dnspolicylabel();
          dnspolicylabelArray[index].labelname = resources[index].labelname;
          dnspolicylabelArray[index].transform = resources[index].transform;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnspolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new dnspolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnspolicylabel resource) => new dnspolicylabel()
    {
      labelname = resource.labelname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        dnspolicylabel[] dnspolicylabelArray = new dnspolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          dnspolicylabelArray[index] = new dnspolicylabel();
          dnspolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnspolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      dnspolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicylabel[] dnspolicylabelArray = new dnspolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicylabelArray[index] = new dnspolicylabel();
          dnspolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnspolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      dnspolicylabel resource,
      string new_labelname)
    {
      return new dnspolicylabel()
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
      return new dnspolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static dnspolicylabel[] get(nitro_service service) => (dnspolicylabel[]) new dnspolicylabel().get_resources(service, (options) null);

    public static dnspolicylabel[] get(nitro_service service, options option) => (dnspolicylabel[]) new dnspolicylabel().get_resources(service, option);

    public static dnspolicylabel get(nitro_service service, string labelname) => (dnspolicylabel) new dnspolicylabel()
    {
      labelname = labelname
    }.get_resource(service);

    public static dnspolicylabel[] get(nitro_service service, string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (dnspolicylabel[]) null;
      dnspolicylabel[] dnspolicylabelArray1 = new dnspolicylabel[labelname.Length];
      dnspolicylabel[] dnspolicylabelArray2 = new dnspolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        dnspolicylabelArray2[index] = new dnspolicylabel();
        dnspolicylabelArray2[index].labelname = labelname[index];
        dnspolicylabelArray1[index] = (dnspolicylabel) dnspolicylabelArray2[index].get_resource(service);
      }
      return dnspolicylabelArray1;
    }

    public static dnspolicylabel[] get_filtered(nitro_service service, string filter)
    {
      dnspolicylabel dnspolicylabel = new dnspolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (dnspolicylabel[]) dnspolicylabel.getfiltered(service, option);
    }

    public static dnspolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      dnspolicylabel dnspolicylabel = new dnspolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (dnspolicylabel[]) dnspolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnspolicylabel dnspolicylabel = new dnspolicylabel();
      options option = new options();
      option.set_count(true);
      dnspolicylabel[] resources = (dnspolicylabel[]) dnspolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnspolicylabel dnspolicylabel = new dnspolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnspolicylabel[] dnspolicylabelArray = (dnspolicylabel[]) dnspolicylabel.getfiltered(service, option);
      return dnspolicylabelArray != null && dnspolicylabelArray.Length > 0 ? dnspolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnspolicylabel dnspolicylabel = new dnspolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnspolicylabel[] dnspolicylabelArray = (dnspolicylabel[]) dnspolicylabel.getfiltered(service, option);
      return dnspolicylabelArray != null && dnspolicylabelArray.Length > 0 ? dnspolicylabelArray[0].__count.Value : 0U;
    }

    private class dnspolicylabel_response : base_response
    {
      public dnspolicylabel[] dnspolicylabel = (dnspolicylabel[]) null;
    }

    public static class labeltypeEnum
    {
      public const string policylabel = "policylabel";
    }

    public static class transformEnum
    {
      public const string dns_req = "dns_req";
      public const string dns_res = "dns_res";
    }
  }
}
