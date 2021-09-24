// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsview
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsview : base_resource
  {
    private string viewnameField = (string) null;
    private uint? flagsField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string viewname
    {
      get => this.viewnameField;
      set => this.viewnameField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsview.dnsview_response dnsviewResponse = new dnsview.dnsview_response();
      dnsview.dnsview_response resource = (dnsview.dnsview_response) service.get_payload_formatter().string_to_resource(dnsviewResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsview;
    }

    internal override string get_object_name() => this.viewname;

    public static base_response add(nitro_service client, dnsview resource) => new dnsview()
    {
      viewname = resource.viewname
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsview[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsview[] dnsviewArray = new dnsview[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsviewArray[index] = new dnsview();
          dnsviewArray[index].viewname = resources[index].viewname;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsviewArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string viewname) => new dnsview()
    {
      viewname = viewname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsview resource) => new dnsview()
    {
      viewname = resource.viewname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] viewname)
    {
      base_responses baseResponses = (base_responses) null;
      if (viewname != null && viewname.Length > 0)
      {
        dnsview[] dnsviewArray = new dnsview[viewname.Length];
        for (int index = 0; index < viewname.Length; ++index)
        {
          dnsviewArray[index] = new dnsview();
          dnsviewArray[index].viewname = viewname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsviewArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsview[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsview[] dnsviewArray = new dnsview[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsviewArray[index] = new dnsview();
          dnsviewArray[index].viewname = resources[index].viewname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsviewArray);
      }
      return baseResponses;
    }

    public static dnsview[] get(nitro_service service) => (dnsview[]) new dnsview().get_resources(service, (options) null);

    public static dnsview[] get(nitro_service service, options option) => (dnsview[]) new dnsview().get_resources(service, option);

    public static dnsview get(nitro_service service, string viewname) => (dnsview) new dnsview()
    {
      viewname = viewname
    }.get_resource(service);

    public static dnsview[] get(nitro_service service, string[] viewname)
    {
      if (viewname == null || viewname.Length <= 0)
        return (dnsview[]) null;
      dnsview[] dnsviewArray1 = new dnsview[viewname.Length];
      dnsview[] dnsviewArray2 = new dnsview[viewname.Length];
      for (int index = 0; index < viewname.Length; ++index)
      {
        dnsviewArray2[index] = new dnsview();
        dnsviewArray2[index].viewname = viewname[index];
        dnsviewArray1[index] = (dnsview) dnsviewArray2[index].get_resource(service);
      }
      return dnsviewArray1;
    }

    public static dnsview[] get_filtered(nitro_service service, string filter)
    {
      dnsview dnsview = new dnsview();
      options option = new options();
      option.set_filter(filter);
      return (dnsview[]) dnsview.getfiltered(service, option);
    }

    public static dnsview[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsview dnsview = new dnsview();
      options option = new options();
      option.set_filter(filter);
      return (dnsview[]) dnsview.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsview dnsview = new dnsview();
      options option = new options();
      option.set_count(true);
      dnsview[] resources = (dnsview[]) dnsview.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsview dnsview = new dnsview();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsview[] dnsviewArray = (dnsview[]) dnsview.getfiltered(service, option);
      return dnsviewArray != null && dnsviewArray.Length > 0 ? dnsviewArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsview dnsview = new dnsview();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsview[] dnsviewArray = (dnsview[]) dnsview.getfiltered(service, option);
      return dnsviewArray != null && dnsviewArray.Length > 0 ? dnsviewArray[0].__count.Value : 0U;
    }

    private class dnsview_response : base_response
    {
      public dnsview[] dnsview = (dnsview[]) null;
    }
  }
}
