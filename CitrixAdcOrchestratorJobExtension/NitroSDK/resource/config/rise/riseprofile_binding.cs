// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rise.riseprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.rise
{
  public class riseprofile_binding : base_resource
  {
    private string profilenameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.rise.riseprofile_interface_binding[] riseprofile_interface_bindingField = (com.citrix.netscaler.nitro.resource.config.rise.riseprofile_interface_binding[]) null;

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.rise.riseprofile_interface_binding[] riseprofile_interface_binding
    {
      get => this.riseprofile_interface_bindingField;
      private set => this.riseprofile_interface_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      riseprofile_binding.riseprofile_binding_response riseprofileBindingResponse = new riseprofile_binding.riseprofile_binding_response();
      riseprofile_binding.riseprofile_binding_response resource = (riseprofile_binding.riseprofile_binding_response) service.get_payload_formatter().string_to_resource(riseprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.riseprofile_binding;
    }

    internal override string get_object_name() => this.profilename;

    public static riseprofile_binding get(
      nitro_service service,
      string profilename)
    {
      return (riseprofile_binding) new riseprofile_binding()
      {
        profilename = profilename
      }.get_resource(service);
    }

    public static riseprofile_binding[] get(
      nitro_service service,
      string[] profilename)
    {
      if (profilename == null || profilename.Length <= 0)
        return (riseprofile_binding[]) null;
      riseprofile_binding[] riseprofileBindingArray1 = new riseprofile_binding[profilename.Length];
      riseprofile_binding[] riseprofileBindingArray2 = new riseprofile_binding[profilename.Length];
      for (int index = 0; index < profilename.Length; ++index)
      {
        riseprofileBindingArray2[index] = new riseprofile_binding();
        riseprofileBindingArray2[index].profilename = profilename[index];
        riseprofileBindingArray1[index] = (riseprofile_binding) riseprofileBindingArray2[index].get_resource(service);
      }
      return riseprofileBindingArray1;
    }

    private class riseprofile_binding_response : base_response
    {
      public riseprofile_binding[] riseprofile_binding = (riseprofile_binding[]) null;
    }
  }
}
