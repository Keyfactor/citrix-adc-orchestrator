// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.servicegroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class servicegroup_binding : base_resource
  {
    private string servicegroupnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.basic.servicegroup_servicegroupentitymonbindings_binding[] servicegroup_servicegroupentitymonbindings_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.servicegroup_servicegroupentitymonbindings_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.basic.servicegroup_lbmonitor_binding[] servicegroup_lbmonitor_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.servicegroup_lbmonitor_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.basic.servicegroup_servicegroupmember_binding[] servicegroup_servicegroupmember_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.servicegroup_servicegroupmember_binding[]) null;

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.servicegroup_lbmonitor_binding[] servicegroup_lbmonitor_binding
    {
      get => this.servicegroup_lbmonitor_bindingField;
      private set => this.servicegroup_lbmonitor_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.servicegroup_servicegroupmember_binding[] servicegroup_servicegroupmember_binding
    {
      get => this.servicegroup_servicegroupmember_bindingField;
      private set => this.servicegroup_servicegroupmember_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.servicegroup_servicegroupentitymonbindings_binding[] servicegroup_servicegroupentitymonbindings_binding
    {
      get => this.servicegroup_servicegroupentitymonbindings_bindingField;
      private set => this.servicegroup_servicegroupentitymonbindings_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      servicegroup_binding.servicegroup_binding_response servicegroupBindingResponse = new servicegroup_binding.servicegroup_binding_response();
      servicegroup_binding.servicegroup_binding_response resource = (servicegroup_binding.servicegroup_binding_response) service.get_payload_formatter().string_to_resource(servicegroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.servicegroup_binding;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static servicegroup_binding get(
      nitro_service service,
      string servicegroupname)
    {
      return (servicegroup_binding) new servicegroup_binding()
      {
        servicegroupname = servicegroupname
      }.get_resource(service);
    }

    public static servicegroup_binding[] get(
      nitro_service service,
      string[] servicegroupname)
    {
      if (servicegroupname == null || servicegroupname.Length <= 0)
        return (servicegroup_binding[]) null;
      servicegroup_binding[] servicegroupBindingArray1 = new servicegroup_binding[servicegroupname.Length];
      servicegroup_binding[] servicegroupBindingArray2 = new servicegroup_binding[servicegroupname.Length];
      for (int index = 0; index < servicegroupname.Length; ++index)
      {
        servicegroupBindingArray2[index] = new servicegroup_binding();
        servicegroupBindingArray2[index].servicegroupname = servicegroupname[index];
        servicegroupBindingArray1[index] = (servicegroup_binding) servicegroupBindingArray2[index].get_resource(service);
      }
      return servicegroupBindingArray1;
    }

    private class servicegroup_binding_response : base_response
    {
      public servicegroup_binding[] servicegroup_binding = (servicegroup_binding[]) null;
    }
  }
}
