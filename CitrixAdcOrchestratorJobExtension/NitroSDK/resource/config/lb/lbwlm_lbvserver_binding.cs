// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbwlm_lbvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbwlm_lbvserver_binding : base_resource
  {
    private string vservernameField = (string) null;
    private string wlmnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string wlmname
    {
      get => this.wlmnameField;
      set => this.wlmnameField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbwlm_lbvserver_binding.lbwlm_lbvserver_binding_response lbvserverBindingResponse = new lbwlm_lbvserver_binding.lbwlm_lbvserver_binding_response();
      lbwlm_lbvserver_binding.lbwlm_lbvserver_binding_response resource = (lbwlm_lbvserver_binding.lbwlm_lbvserver_binding_response) service.get_payload_formatter().string_to_resource(lbvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbwlm_lbvserver_binding;
    }

    internal override string get_object_name() => this.wlmname;

    public static base_response add(
      nitro_service client,
      lbwlm_lbvserver_binding resource)
    {
      return new lbwlm_lbvserver_binding()
      {
        wlmname = resource.wlmname,
        vservername = resource.vservername
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lbwlm_lbvserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbwlm_lbvserver_binding[] lbvserverBindingArray = new lbwlm_lbvserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverBindingArray[index] = new lbwlm_lbvserver_binding();
          lbvserverBindingArray[index].wlmname = resources[index].wlmname;
          lbvserverBindingArray[index].vservername = resources[index].vservername;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbvserverBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      lbwlm_lbvserver_binding resource)
    {
      return new lbwlm_lbvserver_binding()
      {
        wlmname = resource.wlmname,
        vservername = resource.vservername
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      lbwlm_lbvserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbwlm_lbvserver_binding[] lbvserverBindingArray = new lbwlm_lbvserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbvserverBindingArray[index] = new lbwlm_lbvserver_binding();
          lbvserverBindingArray[index].wlmname = resources[index].wlmname;
          lbvserverBindingArray[index].vservername = resources[index].vservername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbvserverBindingArray);
      }
      return baseResponses;
    }

    public static lbwlm_lbvserver_binding[] get(
      nitro_service service,
      string wlmname)
    {
      return (lbwlm_lbvserver_binding[]) new lbwlm_lbvserver_binding()
      {
        wlmname = wlmname
      }.get_resources(service, (options) null);
    }

    public static lbwlm_lbvserver_binding[] get_filtered(
      nitro_service service,
      string wlmname,
      string filter)
    {
      lbwlm_lbvserver_binding lbvserverBinding = new lbwlm_lbvserver_binding();
      lbvserverBinding.wlmname = wlmname;
      options option = new options();
      option.set_filter(filter);
      return (lbwlm_lbvserver_binding[]) lbvserverBinding.getfiltered(service, option);
    }

    public static lbwlm_lbvserver_binding[] get_filtered(
      nitro_service service,
      string wlmname,
      filtervalue[] filter)
    {
      lbwlm_lbvserver_binding lbvserverBinding = new lbwlm_lbvserver_binding();
      lbvserverBinding.wlmname = wlmname;
      options option = new options();
      option.set_filter(filter);
      return (lbwlm_lbvserver_binding[]) lbvserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string wlmname)
    {
      lbwlm_lbvserver_binding lbvserverBinding = new lbwlm_lbvserver_binding();
      lbvserverBinding.wlmname = wlmname;
      options option = new options();
      option.set_count(true);
      lbwlm_lbvserver_binding[] resources = (lbwlm_lbvserver_binding[]) lbvserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string wlmname, string filter)
    {
      lbwlm_lbvserver_binding lbvserverBinding = new lbwlm_lbvserver_binding();
      lbvserverBinding.wlmname = wlmname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbwlm_lbvserver_binding[] lbvserverBindingArray = (lbwlm_lbvserver_binding[]) lbvserverBinding.getfiltered(service, option);
      return lbvserverBindingArray != null && lbvserverBindingArray.Length > 0 ? lbvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string wlmname, filtervalue[] filter)
    {
      lbwlm_lbvserver_binding lbvserverBinding = new lbwlm_lbvserver_binding();
      lbvserverBinding.wlmname = wlmname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbwlm_lbvserver_binding[] lbvserverBindingArray = (lbwlm_lbvserver_binding[]) lbvserverBinding.getfiltered(service, option);
      return lbvserverBindingArray != null && lbvserverBindingArray.Length > 0 ? lbvserverBindingArray[0].__count.Value : 0U;
    }

    private class lbwlm_lbvserver_binding_response : base_response
    {
      public lbwlm_lbvserver_binding[] lbwlm_lbvserver_binding = (lbwlm_lbvserver_binding[]) null;
    }
  }
}
