// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.cspolicylabel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class cspolicylabel : base_resource
  {
    private string labelnameField = (string) null;
    private string cspolicylabeltypeField = (string) null;
    private string newnameField = (string) null;
    private uint? numpolField = new uint?();
    private long? hitsField = new long?();
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string targetvserverField = (string) null;
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

    public string cspolicylabeltype
    {
      get => this.cspolicylabeltypeField;
      set => this.cspolicylabeltypeField = value;
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

    public string targetvserver
    {
      get => this.targetvserverField;
      private set => this.targetvserverField = value;
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
      cspolicylabel.cspolicylabel_response cspolicylabelResponse = new cspolicylabel.cspolicylabel_response();
      cspolicylabel.cspolicylabel_response resource = (cspolicylabel.cspolicylabel_response) service.get_payload_formatter().string_to_resource(cspolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cspolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static base_response add(nitro_service client, cspolicylabel resource) => new cspolicylabel()
    {
      labelname = resource.labelname,
      cspolicylabeltype = resource.cspolicylabeltype
    }.add_resource(client);

    public static base_responses add(nitro_service client, cspolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cspolicylabel[] cspolicylabelArray = new cspolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cspolicylabelArray[index] = new cspolicylabel();
          cspolicylabelArray[index].labelname = resources[index].labelname;
          cspolicylabelArray[index].cspolicylabeltype = resources[index].cspolicylabeltype;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cspolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string labelname) => new cspolicylabel()
    {
      labelname = labelname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, cspolicylabel resource) => new cspolicylabel()
    {
      labelname = resource.labelname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] labelname)
    {
      base_responses baseResponses = (base_responses) null;
      if (labelname != null && labelname.Length > 0)
      {
        cspolicylabel[] cspolicylabelArray = new cspolicylabel[labelname.Length];
        for (int index = 0; index < labelname.Length; ++index)
        {
          cspolicylabelArray[index] = new cspolicylabel();
          cspolicylabelArray[index].labelname = labelname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cspolicylabelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      cspolicylabel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cspolicylabel[] cspolicylabelArray = new cspolicylabel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cspolicylabelArray[index] = new cspolicylabel();
          cspolicylabelArray[index].labelname = resources[index].labelname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cspolicylabelArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      cspolicylabel resource,
      string new_labelname)
    {
      return new cspolicylabel()
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
      return new cspolicylabel()
      {
        labelname = labelname,
        newname = new_labelname
      }.rename_resource(client);
    }

    public static cspolicylabel[] get(nitro_service service) => (cspolicylabel[]) new cspolicylabel().get_resources(service, (options) null);

    public static cspolicylabel[] get(nitro_service service, options option) => (cspolicylabel[]) new cspolicylabel().get_resources(service, option);

    public static cspolicylabel get(nitro_service service, string labelname) => (cspolicylabel) new cspolicylabel()
    {
      labelname = labelname
    }.get_resource(service);

    public static cspolicylabel[] get(nitro_service service, string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (cspolicylabel[]) null;
      cspolicylabel[] cspolicylabelArray1 = new cspolicylabel[labelname.Length];
      cspolicylabel[] cspolicylabelArray2 = new cspolicylabel[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        cspolicylabelArray2[index] = new cspolicylabel();
        cspolicylabelArray2[index].labelname = labelname[index];
        cspolicylabelArray1[index] = (cspolicylabel) cspolicylabelArray2[index].get_resource(service);
      }
      return cspolicylabelArray1;
    }

    public static cspolicylabel[] get_filtered(nitro_service service, string filter)
    {
      cspolicylabel cspolicylabel = new cspolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (cspolicylabel[]) cspolicylabel.getfiltered(service, option);
    }

    public static cspolicylabel[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      cspolicylabel cspolicylabel = new cspolicylabel();
      options option = new options();
      option.set_filter(filter);
      return (cspolicylabel[]) cspolicylabel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cspolicylabel cspolicylabel = new cspolicylabel();
      options option = new options();
      option.set_count(true);
      cspolicylabel[] resources = (cspolicylabel[]) cspolicylabel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cspolicylabel cspolicylabel = new cspolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cspolicylabel[] cspolicylabelArray = (cspolicylabel[]) cspolicylabel.getfiltered(service, option);
      return cspolicylabelArray != null && cspolicylabelArray.Length > 0 ? cspolicylabelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cspolicylabel cspolicylabel = new cspolicylabel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cspolicylabel[] cspolicylabelArray = (cspolicylabel[]) cspolicylabel.getfiltered(service, option);
      return cspolicylabelArray != null && cspolicylabelArray.Length > 0 ? cspolicylabelArray[0].__count.Value : 0U;
    }

    private class cspolicylabel_response : base_response
    {
      public cspolicylabel[] cspolicylabel = (cspolicylabel[]) null;
    }

    public static class cspolicylabeltypeEnum
    {
      public const string HTTP = "HTTP";
      public const string TCP = "TCP";
      public const string RTSP = "RTSP";
      public const string SSL = "SSL";
      public const string SSL_TCP = "SSL_TCP";
      public const string UDP = "UDP";
      public const string DNS = "DNS";
      public const string SIP_UDP = "SIP_UDP";
      public const string SIP_TCP = "SIP_TCP";
      public const string ANY = "ANY";
      public const string RADIUS = "RADIUS";
      public const string RDP = "RDP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string ORACLE = "ORACLE";
      public const string DIAMETER = "DIAMETER";
      public const string SSL_DIAMETER = "SSL_DIAMETER";
      public const string FTP = "FTP";
      public const string DNS_TCP = "DNS_TCP";
      public const string SMPP = "SMPP";
    }

    public static class labeltypeEnum
    {
      public const string policylabel = "policylabel";
    }
  }
}
