// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netprofile_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.network.netprofile_srcportset_binding[] netprofile_srcportset_bindingField = (com.citrix.netscaler.nitro.resource.config.network.netprofile_srcportset_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.network.netprofile_natrule_binding[] netprofile_natrule_bindingField = (com.citrix.netscaler.nitro.resource.config.network.netprofile_natrule_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.netprofile_srcportset_binding[] netprofile_srcportset_binding
    {
      get => this.netprofile_srcportset_bindingField;
      private set => this.netprofile_srcportset_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.network.netprofile_natrule_binding[] netprofile_natrule_binding
    {
      get => this.netprofile_natrule_bindingField;
      private set => this.netprofile_natrule_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      netprofile_binding.netprofile_binding_response netprofileBindingResponse = new netprofile_binding.netprofile_binding_response();
      netprofile_binding.netprofile_binding_response resource = (netprofile_binding.netprofile_binding_response) service.get_payload_formatter().string_to_resource(netprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netprofile_binding;
    }

    internal override string get_object_name() => this.name;

    public static netprofile_binding get(nitro_service service, string name) => (netprofile_binding) new netprofile_binding()
    {
      name = name
    }.get_resource(service);

    public static netprofile_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (netprofile_binding[]) null;
      netprofile_binding[] netprofileBindingArray1 = new netprofile_binding[name.Length];
      netprofile_binding[] netprofileBindingArray2 = new netprofile_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        netprofileBindingArray2[index] = new netprofile_binding();
        netprofileBindingArray2[index].name = name[index];
        netprofileBindingArray1[index] = (netprofile_binding) netprofileBindingArray2[index].get_resource(service);
      }
      return netprofileBindingArray1;
    }

    private class netprofile_binding_response : base_response
    {
      public netprofile_binding[] netprofile_binding = (netprofile_binding[]) null;
    }
  }
}
