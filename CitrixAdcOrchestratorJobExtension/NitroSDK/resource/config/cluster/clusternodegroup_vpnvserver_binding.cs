// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_vpnvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusternodegroup_vpnvserver_binding : base_resource
  {
    private string vserverField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusternodegroup_vpnvserver_binding.clusternodegroup_vpnvserver_binding_response vpnvserverBindingResponse = new clusternodegroup_vpnvserver_binding.clusternodegroup_vpnvserver_binding_response();
      clusternodegroup_vpnvserver_binding.clusternodegroup_vpnvserver_binding_response resource = (clusternodegroup_vpnvserver_binding.clusternodegroup_vpnvserver_binding_response) service.get_payload_formatter().string_to_resource(vpnvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusternodegroup_vpnvserver_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      clusternodegroup_vpnvserver_binding resource)
    {
      return new clusternodegroup_vpnvserver_binding()
      {
        name = resource.name,
        vserver = resource.vserver
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      clusternodegroup_vpnvserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternodegroup_vpnvserver_binding[] vpnvserverBindingArray = new clusternodegroup_vpnvserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverBindingArray[index] = new clusternodegroup_vpnvserver_binding();
          vpnvserverBindingArray[index].name = resources[index].name;
          vpnvserverBindingArray[index].vserver = resources[index].vserver;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnvserverBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      clusternodegroup_vpnvserver_binding resource)
    {
      return new clusternodegroup_vpnvserver_binding()
      {
        name = resource.name,
        vserver = resource.vserver
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      clusternodegroup_vpnvserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternodegroup_vpnvserver_binding[] vpnvserverBindingArray = new clusternodegroup_vpnvserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnvserverBindingArray[index] = new clusternodegroup_vpnvserver_binding();
          vpnvserverBindingArray[index].name = resources[index].name;
          vpnvserverBindingArray[index].vserver = resources[index].vserver;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnvserverBindingArray);
      }
      return baseResponses;
    }

    public static clusternodegroup_vpnvserver_binding[] get_filtered(
      nitro_service service,
      clusternodegroup_vpnvserver_binding obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (clusternodegroup_vpnvserver_binding[]) obj.getfiltered(service, option);
    }

    public static clusternodegroup_vpnvserver_binding[] get_filtered(
      nitro_service service,
      clusternodegroup_vpnvserver_binding obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (clusternodegroup_vpnvserver_binding[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, clusternodegroup_vpnvserver_binding obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      clusternodegroup_vpnvserver_binding[] resources = (clusternodegroup_vpnvserver_binding[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      clusternodegroup_vpnvserver_binding obj,
      string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      clusternodegroup_vpnvserver_binding[] vpnvserverBindingArray = (clusternodegroup_vpnvserver_binding[]) obj.getfiltered(service, option);
      return vpnvserverBindingArray != null && vpnvserverBindingArray.Length > 0 ? vpnvserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      clusternodegroup_vpnvserver_binding obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      clusternodegroup_vpnvserver_binding[] vpnvserverBindingArray = (clusternodegroup_vpnvserver_binding[]) obj.getfiltered(service, option);
      return vpnvserverBindingArray != null && vpnvserverBindingArray.Length > 0 ? vpnvserverBindingArray[0].__count.Value : 0U;
    }

    private class clusternodegroup_vpnvserver_binding_response : base_response
    {
      public clusternodegroup_vpnvserver_binding[] clusternodegroup_vpnvserver_binding = (clusternodegroup_vpnvserver_binding[]) null;
    }
  }
}
