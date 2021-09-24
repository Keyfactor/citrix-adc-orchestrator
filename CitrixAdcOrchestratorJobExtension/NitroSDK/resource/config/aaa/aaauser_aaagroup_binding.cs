// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaauser_aaagroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaauser_aaagroup_binding : base_resource
  {
    private string groupnameField = (string) null;
    private string usernameField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaauser_aaagroup_binding.aaauser_aaagroup_binding_response aaagroupBindingResponse = new aaauser_aaagroup_binding.aaauser_aaagroup_binding_response();
      aaauser_aaagroup_binding.aaauser_aaagroup_binding_response resource = (aaauser_aaagroup_binding.aaauser_aaagroup_binding_response) service.get_payload_formatter().string_to_resource(aaagroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaauser_aaagroup_binding;
    }

    internal override string get_object_name() => this.username;

    public static aaauser_aaagroup_binding[] get(
      nitro_service service,
      string username)
    {
      return (aaauser_aaagroup_binding[]) new aaauser_aaagroup_binding()
      {
        username = username
      }.get_resources(service, (options) null);
    }

    public static aaauser_aaagroup_binding[] get_filtered(
      nitro_service service,
      string username,
      string filter)
    {
      aaauser_aaagroup_binding aaauserAaagroupBinding = new aaauser_aaagroup_binding();
      aaauserAaagroupBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (aaauser_aaagroup_binding[]) aaauserAaagroupBinding.getfiltered(service, option);
    }

    public static aaauser_aaagroup_binding[] get_filtered(
      nitro_service service,
      string username,
      filtervalue[] filter)
    {
      aaauser_aaagroup_binding aaauserAaagroupBinding = new aaauser_aaagroup_binding();
      aaauserAaagroupBinding.username = username;
      options option = new options();
      option.set_filter(filter);
      return (aaauser_aaagroup_binding[]) aaauserAaagroupBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string username)
    {
      aaauser_aaagroup_binding aaauserAaagroupBinding = new aaauser_aaagroup_binding();
      aaauserAaagroupBinding.username = username;
      options option = new options();
      option.set_count(true);
      aaauser_aaagroup_binding[] resources = (aaauser_aaagroup_binding[]) aaauserAaagroupBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, string filter)
    {
      aaauser_aaagroup_binding aaauserAaagroupBinding = new aaauser_aaagroup_binding();
      aaauserAaagroupBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser_aaagroup_binding[] aaauserAaagroupBindingArray = (aaauser_aaagroup_binding[]) aaauserAaagroupBinding.getfiltered(service, option);
      return aaauserAaagroupBindingArray != null && aaauserAaagroupBindingArray.Length > 0 ? aaauserAaagroupBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string username, filtervalue[] filter)
    {
      aaauser_aaagroup_binding aaauserAaagroupBinding = new aaauser_aaagroup_binding();
      aaauserAaagroupBinding.username = username;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaauser_aaagroup_binding[] aaauserAaagroupBindingArray = (aaauser_aaagroup_binding[]) aaauserAaagroupBinding.getfiltered(service, option);
      return aaauserAaagroupBindingArray != null && aaauserAaagroupBindingArray.Length > 0 ? aaauserAaagroupBindingArray[0].__count.Value : 0U;
    }

    private class aaauser_aaagroup_binding_response : base_response
    {
      public aaauser_aaagroup_binding[] aaauser_aaagroup_binding = (aaauser_aaagroup_binding[]) null;
    }
  }
}
