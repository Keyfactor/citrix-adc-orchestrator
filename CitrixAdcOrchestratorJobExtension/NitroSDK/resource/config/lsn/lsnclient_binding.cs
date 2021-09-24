// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnclient_binding : base_resource
  {
    private string clientnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_network6_binding[] lsnclient_network6_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_network6_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_nsacl6_binding[] lsnclient_nsacl6_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_nsacl6_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_network_binding[] lsnclient_network_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_network_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_nsacl_binding[] lsnclient_nsacl_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_nsacl_binding[]) null;

    public string clientname
    {
      get => this.clientnameField;
      set => this.clientnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_nsacl6_binding[] lsnclient_nsacl6_binding
    {
      get => this.lsnclient_nsacl6_bindingField;
      private set => this.lsnclient_nsacl6_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_network_binding[] lsnclient_network_binding
    {
      get => this.lsnclient_network_bindingField;
      private set => this.lsnclient_network_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_nsacl_binding[] lsnclient_nsacl_binding
    {
      get => this.lsnclient_nsacl_bindingField;
      private set => this.lsnclient_nsacl_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnclient_network6_binding[] lsnclient_network6_binding
    {
      get => this.lsnclient_network6_bindingField;
      private set => this.lsnclient_network6_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnclient_binding.lsnclient_binding_response lsnclientBindingResponse = new lsnclient_binding.lsnclient_binding_response();
      lsnclient_binding.lsnclient_binding_response resource = (lsnclient_binding.lsnclient_binding_response) service.get_payload_formatter().string_to_resource(lsnclientBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnclient_binding;
    }

    internal override string get_object_name() => this.clientname;

    public static lsnclient_binding get(nitro_service service, string clientname) => (lsnclient_binding) new lsnclient_binding()
    {
      clientname = clientname
    }.get_resource(service);

    public static lsnclient_binding[] get(
      nitro_service service,
      string[] clientname)
    {
      if (clientname == null || clientname.Length <= 0)
        return (lsnclient_binding[]) null;
      lsnclient_binding[] lsnclientBindingArray1 = new lsnclient_binding[clientname.Length];
      lsnclient_binding[] lsnclientBindingArray2 = new lsnclient_binding[clientname.Length];
      for (int index = 0; index < clientname.Length; ++index)
      {
        lsnclientBindingArray2[index] = new lsnclient_binding();
        lsnclientBindingArray2[index].clientname = clientname[index];
        lsnclientBindingArray1[index] = (lsnclient_binding) lsnclientBindingArray2[index].get_resource(service);
      }
      return lsnclientBindingArray1;
    }

    private class lsnclient_binding_response : base_response
    {
      public lsnclient_binding[] lsnclient_binding = (lsnclient_binding[]) null;
    }
  }
}
