// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nspartition_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nspartition_binding : base_resource
  {
    private string partitionnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ns.nspartition_bridgegroup_binding[] nspartition_bridgegroup_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nspartition_bridgegroup_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ns.nspartition_vlan_binding[] nspartition_vlan_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nspartition_vlan_binding[]) null;

    public string partitionname
    {
      get => this.partitionnameField;
      set => this.partitionnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nspartition_vlan_binding[] nspartition_vlan_binding
    {
      get => this.nspartition_vlan_bindingField;
      private set => this.nspartition_vlan_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nspartition_bridgegroup_binding[] nspartition_bridgegroup_binding
    {
      get => this.nspartition_bridgegroup_bindingField;
      private set => this.nspartition_bridgegroup_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nspartition_binding.nspartition_binding_response nspartitionBindingResponse = new nspartition_binding.nspartition_binding_response();
      nspartition_binding.nspartition_binding_response resource = (nspartition_binding.nspartition_binding_response) service.get_payload_formatter().string_to_resource(nspartitionBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nspartition_binding;
    }

    internal override string get_object_name() => this.partitionname;

    public static nspartition_binding get(
      nitro_service service,
      string partitionname)
    {
      return (nspartition_binding) new nspartition_binding()
      {
        partitionname = partitionname
      }.get_resource(service);
    }

    public static nspartition_binding[] get(
      nitro_service service,
      string[] partitionname)
    {
      if (partitionname == null || partitionname.Length <= 0)
        return (nspartition_binding[]) null;
      nspartition_binding[] nspartitionBindingArray1 = new nspartition_binding[partitionname.Length];
      nspartition_binding[] nspartitionBindingArray2 = new nspartition_binding[partitionname.Length];
      for (int index = 0; index < partitionname.Length; ++index)
      {
        nspartitionBindingArray2[index] = new nspartition_binding();
        nspartitionBindingArray2[index].partitionname = partitionname[index];
        nspartitionBindingArray1[index] = (nspartition_binding) nspartitionBindingArray2[index].get_resource(service);
      }
      return nspartitionBindingArray1;
    }

    private class nspartition_binding_response : base_response
    {
      public nspartition_binding[] nspartition_binding = (nspartition_binding[]) null;
    }
  }
}
