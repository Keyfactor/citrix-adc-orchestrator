// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.responder.responderpolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.responder
{
  public class responderpolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string policylabeltypeField = (string) null;
    private string commentField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string labeltypeField = (string) null;
    private string invoke_labelnameField = (string) null;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      responderpolicylabel.responderpolicylabel_response responderpolicylabelResponse = new responderpolicylabel.responderpolicylabel_response();
      responderpolicylabel.responderpolicylabel_response resource = (responderpolicylabel.responderpolicylabel_response) service.get_payload_formatter().string_to_resource(responderpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.responderpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(
      nitro_service client,
      responderpolicylabel resource)
    {
      return new responderpolicylabel()
      {
        labelname = resource.labelname,
        policylabeltype = resource.policylabeltype,
        comment = resource.comment
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      responderpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderpolicylabel[] responderpolicylabelArray = new responderpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderpolicylabelArray[index] = new responderpolicylabel();
          responderpolicylabelArray[index].labelname = resources[index].labelname;
          responderpolicylabelArray[index].policylabeltype = resources[index].policylabeltype;
          responderpolicylabelArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) responderpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new responderpolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      responderpolicylabel resource)
    {
      return new responderpolicylabel()
      {
        labelname = resource.labelname
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        responderpolicylabel[] responderpolicylabelArray = new responderpolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          responderpolicylabelArray[index] = new responderpolicylabel();
          responderpolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) responderpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      responderpolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        responderpolicylabel[] responderpolicylabelArray = new responderpolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          responderpolicylabelArray[index] = new responderpolicylabel();
          responderpolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) responderpolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      responderpolicylabel resource,
      string new_labelname)
    {
      return new responderpolicylabel()
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
      return new responderpolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static responderpolicylabel[] get(nitro_service service) => (responderpolicylabel[]) new responderpolicylabel().get_resources(service, (options) null);

    public static responderpolicylabel[] get(
      nitro_service service,
      options option)
    {
      return (responderpolicylabel[]) new responderpolicylabel().get_resources(service, option);
    }

    public static responderpolicylabel get(
      nitro_service service,
      string labelname)
    {
      return (responderpolicylabel) new responderpolicylabel()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static responderpolicylabel[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (responderpolicylabel[]) null;
      responderpolicylabel[] responderpolicylabelArray1 = new responderpolicylabel[labelname.Length];
      responderpolicylabel[] responderpolicylabelArray2 = new responderpolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        responderpolicylabelArray2[index] = new responderpolicylabel();
        responderpolicylabelArray2[index].labelname = labelname[index];
        responderpolicylabelArray1[index] = (responderpolicylabel) responderpolicylabelArray2[index].get_resource(service);
      }
      return responderpolicylabelArray1;
    }

    public static responderpolicylabel[] get_filtered(
      nitro_service service,
      string filter)
    {
      responderpolicylabel responderpolicylabel = new responderpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (responderpolicylabel[]) responderpolicylabel.getfiltered(service, option);
    }

    public static responderpolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      responderpolicylabel responderpolicylabel = new responderpolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (responderpolicylabel[]) responderpolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      responderpolicylabel responderpolicylabel = new responderpolicylabel();
      options option = new options();
      option.set_count(true);
      responderpolicylabel[] resources = (responderpolicylabel[]) responderpolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      responderpolicylabel responderpolicylabel = new responderpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      responderpolicylabel[] responderpolicylabelArray = (responderpolicylabel[]) responderpolicylabel.getfiltered(service, option);
      return responderpolicylabelArray != null && responderpolicylabelArray.Length > 0 ? responderpolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      responderpolicylabel responderpolicylabel = new responderpolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      responderpolicylabel[] responderpolicylabelArray = (responderpolicylabel[]) responderpolicylabel.getfiltered(service, option);
      return responderpolicylabelArray != null && responderpolicylabelArray.Length > 0 ? responderpolicylabelArray[0].__count.Value : 0U;
    }

    private class responderpolicylabel_response : base_response
    {
      public responderpolicylabel[] responderpolicylabel = (responderpolicylabel[]) null;
    }

    public static class policylabeltypeEnum
    {
      public const string HTTP = "HTTP";
      public const string OTHERTCP = "OTHERTCP";
      public const string SIP_UDP = "SIP_UDP";
      public const string SIP_TCP = "SIP_TCP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string NAT = "NAT";
      public const string DIAMETER = "DIAMETER";
      public const string RADIUS = "RADIUS";
      public const string DNS = "DNS";
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string policylabel = "policylabel";
    }
  }
}
