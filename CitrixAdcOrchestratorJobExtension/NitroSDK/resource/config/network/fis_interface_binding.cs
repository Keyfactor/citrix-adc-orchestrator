// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.fis_interface_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class fis_interface_binding : base_resource
  {
    private string ifnumField = (string) null;
    private uint? ownernodeField = new uint?();
    private string nameField = (string) null;

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      fis_interface_binding.fis_interface_binding_response interfaceBindingResponse = new fis_interface_binding.fis_interface_binding_response();
      fis_interface_binding.fis_interface_binding_response resource = (fis_interface_binding.fis_interface_binding_response) service.get_payload_formatter().string_to_resource(interfaceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.fis_interface_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      fis_interface_binding resource)
    {
      return new fis_interface_binding()
      {
        name = resource.name,
        ifnum = resource.ifnum
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      fis_interface_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        fis_interface_binding[] interfaceBindingArray = new fis_interface_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceBindingArray[index] = new fis_interface_binding();
          interfaceBindingArray[index].name = resources[index].name;
          interfaceBindingArray[index].ifnum = resources[index].ifnum;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) interfaceBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      fis_interface_binding resource)
    {
      return new fis_interface_binding()
      {
        name = resource.name,
        ifnum = resource.ifnum
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      fis_interface_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        fis_interface_binding[] interfaceBindingArray = new fis_interface_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceBindingArray[index] = new fis_interface_binding();
          interfaceBindingArray[index].name = resources[index].name;
          interfaceBindingArray[index].ifnum = resources[index].ifnum;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) interfaceBindingArray);
      }
      return baseResponses;
    }

    private class fis_interface_binding_response : base_response
    {
      public fis_interface_binding[] fis_interface_binding = (fis_interface_binding[]) null;
    }
  }
}
