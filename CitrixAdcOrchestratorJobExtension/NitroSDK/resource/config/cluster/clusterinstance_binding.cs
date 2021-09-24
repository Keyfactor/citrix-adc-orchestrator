// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusterinstance_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusterinstance_binding : base_resource
  {
    private uint? clidField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.cluster.clusterinstance_clusternode_binding[] clusterinstance_clusternode_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusterinstance_clusternode_binding[]) null;

    public uint? clid
    {
      get => this.clidField;
      set => this.clidField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusterinstance_clusternode_binding[] clusterinstance_clusternode_binding
    {
      get => this.clusterinstance_clusternode_bindingField;
      private set => this.clusterinstance_clusternode_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusterinstance_binding.clusterinstance_binding_response clusterinstanceBindingResponse = new clusterinstance_binding.clusterinstance_binding_response();
      clusterinstance_binding.clusterinstance_binding_response resource = (clusterinstance_binding.clusterinstance_binding_response) service.get_payload_formatter().string_to_resource(clusterinstanceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusterinstance_binding;
    }

    internal override string get_object_name() => this.clid.HasValue ? this.clid.ToString() : (string) null;

    public static clusterinstance_binding get(
      nitro_service service,
      uint? clid)
    {
      return (clusterinstance_binding) new clusterinstance_binding()
      {
        clid = clid
      }.get_resource(service);
    }

    public static clusterinstance_binding[] get(
      nitro_service service,
      uint?[] clid)
    {
      if (clid == null || clid.Length <= 0)
        return (clusterinstance_binding[]) null;
      clusterinstance_binding[] clusterinstanceBindingArray1 = new clusterinstance_binding[clid.Length];
      clusterinstance_binding[] clusterinstanceBindingArray2 = new clusterinstance_binding[clid.Length];
      for (int index = 0; index < clid.Length; ++index)
      {
        clusterinstanceBindingArray2[index] = new clusterinstance_binding();
        clusterinstanceBindingArray2[index].clid = clid[index];
        clusterinstanceBindingArray1[index] = (clusterinstance_binding) clusterinstanceBindingArray2[index].get_resource(service);
      }
      return clusterinstanceBindingArray1;
    }

    private class clusterinstance_binding_response : base_response
    {
      public clusterinstance_binding[] clusterinstance_binding = (clusterinstance_binding[]) null;
    }
  }
}
