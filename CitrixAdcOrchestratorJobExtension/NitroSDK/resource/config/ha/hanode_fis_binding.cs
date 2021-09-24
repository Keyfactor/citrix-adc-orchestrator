// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ha.hanode_fis_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ha
{
  public class hanode_fis_binding : base_resource
  {
    private string nameField = (string) null;
    private string enaifacesField = (string) null;
    private uint? idField = new uint?();
    private string routemonitorField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string routemonitor
    {
      get => this.routemonitorField;
      set => this.routemonitorField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string enaifaces
    {
      get => this.enaifacesField;
      private set => this.enaifacesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      hanode_fis_binding.hanode_fis_binding_response fisBindingResponse = new hanode_fis_binding.hanode_fis_binding_response();
      hanode_fis_binding.hanode_fis_binding_response resource = (hanode_fis_binding.hanode_fis_binding_response) service.get_payload_formatter().string_to_resource(fisBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.hanode_fis_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static hanode_fis_binding[] get(nitro_service service, uint? id) => (hanode_fis_binding[]) new hanode_fis_binding()
    {
      id = id
    }.get_resources(service, (options) null);

    public static hanode_fis_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      hanode_fis_binding hanodeFisBinding = new hanode_fis_binding();
      hanodeFisBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (hanode_fis_binding[]) hanodeFisBinding.getfiltered(service, option);
    }

    public static hanode_fis_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      hanode_fis_binding hanodeFisBinding = new hanode_fis_binding();
      hanodeFisBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (hanode_fis_binding[]) hanodeFisBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      hanode_fis_binding hanodeFisBinding = new hanode_fis_binding();
      hanodeFisBinding.id = id;
      options option = new options();
      option.set_count(true);
      hanode_fis_binding[] resources = (hanode_fis_binding[]) hanodeFisBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      hanode_fis_binding hanodeFisBinding = new hanode_fis_binding();
      hanodeFisBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      hanode_fis_binding[] hanodeFisBindingArray = (hanode_fis_binding[]) hanodeFisBinding.getfiltered(service, option);
      return hanodeFisBindingArray != null && hanodeFisBindingArray.Length > 0 ? hanodeFisBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      hanode_fis_binding hanodeFisBinding = new hanode_fis_binding();
      hanodeFisBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      hanode_fis_binding[] hanodeFisBindingArray = (hanode_fis_binding[]) hanodeFisBinding.getfiltered(service, option);
      return hanodeFisBindingArray != null && hanodeFisBindingArray.Length > 0 ? hanodeFisBindingArray[0].__count.Value : 0U;
    }

    private class hanode_fis_binding_response : base_response
    {
      public hanode_fis_binding[] hanode_fis_binding = (hanode_fis_binding[]) null;
    }
  }
}
