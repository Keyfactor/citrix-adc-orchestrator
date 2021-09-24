// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nspartition_vlan_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nspartition_vlan_binding : base_resource
  {
    private uint? vlanField = new uint?();
    private string partitionnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public string partitionname
    {
      get => this.partitionnameField;
      set => this.partitionnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nspartition_vlan_binding.nspartition_vlan_binding_response vlanBindingResponse = new nspartition_vlan_binding.nspartition_vlan_binding_response();
      nspartition_vlan_binding.nspartition_vlan_binding_response resource = (nspartition_vlan_binding.nspartition_vlan_binding_response) service.get_payload_formatter().string_to_resource(vlanBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nspartition_vlan_binding;
    }

    internal override string get_object_name() => this.partitionname;

    public static base_response add(
      nitro_service client,
      nspartition_vlan_binding resource)
    {
      return new nspartition_vlan_binding()
      {
        partitionname = resource.partitionname,
        vlan = resource.vlan
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      nspartition_vlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspartition_vlan_binding[] nspartitionVlanBindingArray = new nspartition_vlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionVlanBindingArray[index] = new nspartition_vlan_binding();
          nspartitionVlanBindingArray[index].partitionname = resources[index].partitionname;
          nspartitionVlanBindingArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nspartitionVlanBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      nspartition_vlan_binding resource)
    {
      return new nspartition_vlan_binding()
      {
        partitionname = resource.partitionname,
        vlan = resource.vlan
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      nspartition_vlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspartition_vlan_binding[] nspartitionVlanBindingArray = new nspartition_vlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionVlanBindingArray[index] = new nspartition_vlan_binding();
          nspartitionVlanBindingArray[index].partitionname = resources[index].partitionname;
          nspartitionVlanBindingArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nspartitionVlanBindingArray);
      }
      return baseResponses;
    }

    public static nspartition_vlan_binding[] get(
      nitro_service service,
      string partitionname)
    {
      return (nspartition_vlan_binding[]) new nspartition_vlan_binding()
      {
        partitionname = partitionname
      }.get_resources(service, (options) null);
    }

    public static nspartition_vlan_binding[] get_filtered(
      nitro_service service,
      string partitionname,
      string filter)
    {
      nspartition_vlan_binding nspartitionVlanBinding = new nspartition_vlan_binding();
      nspartitionVlanBinding.partitionname = partitionname;
      options option = new options();
      option.set_filter(filter);
      return (nspartition_vlan_binding[]) nspartitionVlanBinding.getfiltered(service, option);
    }

    public static nspartition_vlan_binding[] get_filtered(
      nitro_service service,
      string partitionname,
      filtervalue[] filter)
    {
      nspartition_vlan_binding nspartitionVlanBinding = new nspartition_vlan_binding();
      nspartitionVlanBinding.partitionname = partitionname;
      options option = new options();
      option.set_filter(filter);
      return (nspartition_vlan_binding[]) nspartitionVlanBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string partitionname)
    {
      nspartition_vlan_binding nspartitionVlanBinding = new nspartition_vlan_binding();
      nspartitionVlanBinding.partitionname = partitionname;
      options option = new options();
      option.set_count(true);
      nspartition_vlan_binding[] resources = (nspartition_vlan_binding[]) nspartitionVlanBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string partitionname, string filter)
    {
      nspartition_vlan_binding nspartitionVlanBinding = new nspartition_vlan_binding();
      nspartitionVlanBinding.partitionname = partitionname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nspartition_vlan_binding[] nspartitionVlanBindingArray = (nspartition_vlan_binding[]) nspartitionVlanBinding.getfiltered(service, option);
      return nspartitionVlanBindingArray != null && nspartitionVlanBindingArray.Length > 0 ? nspartitionVlanBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string partitionname,
      filtervalue[] filter)
    {
      nspartition_vlan_binding nspartitionVlanBinding = new nspartition_vlan_binding();
      nspartitionVlanBinding.partitionname = partitionname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nspartition_vlan_binding[] nspartitionVlanBindingArray = (nspartition_vlan_binding[]) nspartitionVlanBinding.getfiltered(service, option);
      return nspartitionVlanBindingArray != null && nspartitionVlanBindingArray.Length > 0 ? nspartitionVlanBindingArray[0].__count.Value : 0U;
    }

    private class nspartition_vlan_binding_response : base_response
    {
      public nspartition_vlan_binding[] nspartition_vlan_binding = (nspartition_vlan_binding[]) null;
    }
  }
}
