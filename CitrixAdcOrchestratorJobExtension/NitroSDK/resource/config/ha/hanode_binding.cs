// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ha.hanode_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ha
{
  public class hanode_binding : base_resource
  {
    private uint? idField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.ha.hanode_partialfailureinterfaces_binding[] hanode_partialfailureinterfaces_bindingField = (com.citrix.netscaler.nitro.resource.config.ha.hanode_partialfailureinterfaces_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ha.hanode_routemonitor6_binding[] hanode_routemonitor6_bindingField = (com.citrix.netscaler.nitro.resource.config.ha.hanode_routemonitor6_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ha.hanode_ci_binding[] hanode_ci_bindingField = (com.citrix.netscaler.nitro.resource.config.ha.hanode_ci_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ha.hanode_routemonitor_binding[] hanode_routemonitor_bindingField = (com.citrix.netscaler.nitro.resource.config.ha.hanode_routemonitor_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ha.hanode_fis_binding[] hanode_fis_bindingField = (com.citrix.netscaler.nitro.resource.config.ha.hanode_fis_binding[]) null;

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ha.hanode_routemonitor_binding[] hanode_routemonitor_binding
    {
      get => this.hanode_routemonitor_bindingField;
      private set => this.hanode_routemonitor_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ha.hanode_partialfailureinterfaces_binding[] hanode_partialfailureinterfaces_binding
    {
      get => this.hanode_partialfailureinterfaces_bindingField;
      private set => this.hanode_partialfailureinterfaces_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ha.hanode_fis_binding[] hanode_fis_binding
    {
      get => this.hanode_fis_bindingField;
      private set => this.hanode_fis_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ha.hanode_routemonitor6_binding[] hanode_routemonitor6_binding
    {
      get => this.hanode_routemonitor6_bindingField;
      private set => this.hanode_routemonitor6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ha.hanode_ci_binding[] hanode_ci_binding
    {
      get => this.hanode_ci_bindingField;
      private set => this.hanode_ci_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      hanode_binding.hanode_binding_response hanodeBindingResponse = new hanode_binding.hanode_binding_response();
      hanode_binding.hanode_binding_response resource = (hanode_binding.hanode_binding_response) service.get_payload_formatter().string_to_resource(hanodeBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.hanode_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static hanode_binding get(nitro_service service, uint? id) => (hanode_binding) new hanode_binding()
    {
      id = id
    }.get_resource(service);

    public static hanode_binding[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (hanode_binding[]) null;
      hanode_binding[] hanodeBindingArray1 = new hanode_binding[id.Length];
      hanode_binding[] hanodeBindingArray2 = new hanode_binding[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        hanodeBindingArray2[index] = new hanode_binding();
        hanodeBindingArray2[index].id = id[index];
        hanodeBindingArray1[index] = (hanode_binding) hanodeBindingArray2[index].get_resource(service);
      }
      return hanodeBindingArray1;
    }

    private class hanode_binding_response : base_response
    {
      public hanode_binding[] hanode_binding = (hanode_binding[]) null;
    }
  }
}
