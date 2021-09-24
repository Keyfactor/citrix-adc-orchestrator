// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsextension
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsextension : base_resource
  {
    private string srcField = (string) null;
    private string nameField = (string) null;
    private string commentField = (string) null;
    private bool? overwriteField = new bool?();
    private string traceField = (string) null;
    private string tracefunctionsField = (string) null;
    private string tracevariablesField = (string) null;
    private string detailField = (string) null;
    private string typeField = (string) null;
    private long? functionhitsField = new long?();
    private long? functionundefhitsField = new long?();
    private long? functionhaltcountField = new long?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string src
    {
      get => this.srcField;
      set => this.srcField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public bool? overwrite
    {
      get => this.overwriteField;
      set => this.overwriteField = value;
    }

    public string trace
    {
      get => this.traceField;
      set => this.traceField = value;
    }

    public string tracefunctions
    {
      get => this.tracefunctionsField;
      set => this.tracefunctionsField = value;
    }

    public string tracevariables
    {
      get => this.tracevariablesField;
      set => this.tracevariablesField = value;
    }

    public string detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public long? functionhits
    {
      get => this.functionhitsField;
      private set => this.functionhitsField = value;
    }

    public long? functionundefhits
    {
      get => this.functionundefhitsField;
      private set => this.functionundefhitsField = value;
    }

    public long? functionhaltcount
    {
      get => this.functionhaltcountField;
      private set => this.functionhaltcountField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsextension.nsextension_response nsextensionResponse = new nsextension.nsextension_response();
      nsextension.nsextension_response resource = (nsextension.nsextension_response) service.get_payload_formatter().string_to_resource(nsextensionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsextension;
    }

    internal override string get_object_name() => this.name;

    public static base_response Import(nitro_service client, nsextension resource) => new nsextension()
    {
      src = resource.src,
      name = resource.name,
      comment = resource.comment,
      overwrite = resource.overwrite
    }.perform_operation_byaction(client, nameof (Import));

    public static base_responses Import(nitro_service client, nsextension[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsextension[] nsextensionArray = new nsextension[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsextensionArray[index] = new nsextension();
          nsextensionArray[index].src = resources[index].src;
          nsextensionArray[index].name = resources[index].name;
          nsextensionArray[index].comment = resources[index].comment;
          nsextensionArray[index].overwrite = resources[index].overwrite;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsextensionArray, nameof (Import));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nsextension()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsextension resource) => new nsextension()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nsextension[] nsextensionArray = new nsextension[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nsextensionArray[index] = new nsextension();
          nsextensionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsextensionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nsextension[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsextension[] nsextensionArray = new nsextension[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsextensionArray[index] = new nsextension();
          nsextensionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsextensionArray);
      }
      return baseResponses;
    }

    public static base_response add(nitro_service client, nsextension resource) => new nsextension()
    {
      name = resource.name,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsextension[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsextension[] nsextensionArray = new nsextension[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsextensionArray[index] = new nsextension();
          nsextensionArray[index].name = resources[index].name;
          nsextensionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsextensionArray);
      }
      return baseResponses;
    }

    public static base_response change(nitro_service client, nsextension resource) => new nsextension()
    {
      name = resource.name
    }.perform_operation_byaction(client, "update");

    public static base_responses change(nitro_service client, nsextension[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsextension[] nsextensionArray = new nsextension[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsextensionArray[index] = new nsextension();
          nsextensionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nsextensionArray, "update");
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nsextension resource) => new nsextension()
    {
      name = resource.name,
      trace = resource.trace,
      tracefunctions = resource.tracefunctions,
      tracevariables = resource.tracevariables,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(nitro_service client, nsextension[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsextension[] nsextensionArray = new nsextension[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsextensionArray[index] = new nsextension();
          nsextensionArray[index].name = resources[index].name;
          nsextensionArray[index].trace = resources[index].trace;
          nsextensionArray[index].tracefunctions = resources[index].tracefunctions;
          nsextensionArray[index].tracevariables = resources[index].tracevariables;
          nsextensionArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsextensionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nsextension() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsextension resource,
      string[] args)
    {
      return new nsextension() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nsextension[] nsextensionArray = new nsextension[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nsextensionArray[index] = new nsextension();
          nsextensionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsextensionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsextension[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsextension[] nsextensionArray = new nsextension[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsextensionArray[index] = new nsextension();
          nsextensionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsextensionArray, args);
      }
      return baseResponses;
    }

    public static nsextension[] get(nitro_service service) => (nsextension[]) new nsextension().get_resources(service, (options) null);

    public static nsextension[] get(nitro_service service, options option) => (nsextension[]) new nsextension().get_resources(service, option);

    public static nsextension[] get(nitro_service service, nsextension_args args)
    {
      nsextension nsextension = new nsextension();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (nsextension[]) nsextension.get_resources(service, option);
    }

    public static nsextension get(nitro_service service, string name) => (nsextension) new nsextension()
    {
      name = name
    }.get_resource(service);

    public static nsextension[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nsextension[]) null;
      nsextension[] nsextensionArray1 = new nsextension[name.Length];
      nsextension[] nsextensionArray2 = new nsextension[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nsextensionArray2[index] = new nsextension();
        nsextensionArray2[index].name = name[index];
        nsextensionArray1[index] = (nsextension) nsextensionArray2[index].get_resource(service);
      }
      return nsextensionArray1;
    }

    public static nsextension[] get_filtered(nitro_service service, string filter)
    {
      nsextension nsextension = new nsextension();
      options option = new options();
      option.set_filter(filter);
      return (nsextension[]) nsextension.getfiltered(service, option);
    }

    public static nsextension[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nsextension nsextension = new nsextension();
      options option = new options();
      option.set_filter(filter);
      return (nsextension[]) nsextension.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsextension nsextension = new nsextension();
      options option = new options();
      option.set_count(true);
      nsextension[] resources = (nsextension[]) nsextension.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsextension nsextension = new nsextension();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsextension[] nsextensionArray = (nsextension[]) nsextension.getfiltered(service, option);
      return nsextensionArray != null && nsextensionArray.Length > 0 ? nsextensionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsextension nsextension = new nsextension();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsextension[] nsextensionArray = (nsextension[]) nsextension.getfiltered(service, option);
      return nsextensionArray != null && nsextensionArray.Length > 0 ? nsextensionArray[0].__count.Value : 0U;
    }

    private class nsextension_response : base_response
    {
      public nsextension[] nsextension = (nsextension[]) null;
    }

    public static class traceEnum
    {
      public const string off = "off";
      public const string calls = "calls";
      public const string lines = "lines";
      public const string all = "all";
    }

    public static class typeEnum
    {
      public const string WSDL = "WSDL";
      public const string CustomSettings = "CustomSettings";
      public const string XMLSchema = "XMLSchema";
      public const string XMLErrorPage = "XMLErrorPage";
      public const string htmlpage = "htmlpage";
      public const string CustomResp = "CustomResp";
      public const string Extension = "Extension";
    }

    public static class detailEnum
    {
      public const string brief = "brief";
      public const string all = "all";
    }
  }
}
