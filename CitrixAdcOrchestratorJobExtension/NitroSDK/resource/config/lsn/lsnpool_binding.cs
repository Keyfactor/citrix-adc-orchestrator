// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnpool_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnpool_binding : base_resource
  {
    private string poolnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnpool_lsnip_binding[] lsnpool_lsnip_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnpool_lsnip_binding[]) null;

    public string poolname
    {
      get => this.poolnameField;
      set => this.poolnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnpool_lsnip_binding[] lsnpool_lsnip_binding
    {
      get => this.lsnpool_lsnip_bindingField;
      private set => this.lsnpool_lsnip_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnpool_binding.lsnpool_binding_response lsnpoolBindingResponse = new lsnpool_binding.lsnpool_binding_response();
      lsnpool_binding.lsnpool_binding_response resource = (lsnpool_binding.lsnpool_binding_response) service.get_payload_formatter().string_to_resource(lsnpoolBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnpool_binding;
    }

    internal override string get_object_name() => this.poolname;

    public static lsnpool_binding get(nitro_service service, string poolname) => (lsnpool_binding) new lsnpool_binding()
    {
      poolname = poolname
    }.get_resource(service);

    public static lsnpool_binding[] get(nitro_service service, string[] poolname)
    {
      if (poolname == null || poolname.Length <= 0)
        return (lsnpool_binding[]) null;
      lsnpool_binding[] lsnpoolBindingArray1 = new lsnpool_binding[poolname.Length];
      lsnpool_binding[] lsnpoolBindingArray2 = new lsnpool_binding[poolname.Length];
      for (int index = 0; index < poolname.Length; ++index)
      {
        lsnpoolBindingArray2[index] = new lsnpool_binding();
        lsnpoolBindingArray2[index].poolname = poolname[index];
        lsnpoolBindingArray1[index] = (lsnpool_binding) lsnpoolBindingArray2[index].get_resource(service);
      }
      return lsnpoolBindingArray1;
    }

    private class lsnpool_binding_response : base_response
    {
      public lsnpool_binding[] lsnpool_binding = (lsnpool_binding[]) null;
    }
  }
}
