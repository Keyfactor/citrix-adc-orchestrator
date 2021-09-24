// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsassignment
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsassignment : base_resource
  {
    private string nameField = (string) null;
    private string variableField = (string) null;
    private string setField = (string) null;
    private string AddField = (string) null;
    private string subField = (string) null;
    private string appendField = (string) null;
    private bool? clearField = new bool?();
    private string commentField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private uint? referencecountField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string variable
    {
      get => this.variableField;
      set => this.variableField = value;
    }

    public string set
    {
      get => this.setField;
      set => this.setField = value;
    }

    public string Add
    {
      get => this.AddField;
      set => this.AddField = value;
    }

    public string sub
    {
      get => this.subField;
      set => this.subField = value;
    }

    public string append
    {
      get => this.appendField;
      set => this.appendField = value;
    }

    public bool? clear
    {
      get => this.clearField;
      set => this.clearField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsassignment.nsassignment_response nsassignmentResponse = new nsassignment.nsassignment_response();
      nsassignment.nsassignment_response resource = (nsassignment.nsassignment_response) service.get_payload_formatter().string_to_resource(nsassignmentResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsassignment;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nsassignment resource) => new nsassignment()
    {
      name = resource.name,
      variable = resource.variable,
      set = resource.set,
      Add = resource.Add,
      sub = resource.sub,
      append = resource.append,
      clear = resource.clear,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, nsassignment[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsassignment[] nsassignmentArray = new nsassignment[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsassignmentArray[index] = new nsassignment();
          nsassignmentArray[index].name = resources[index].name;
          nsassignmentArray[index].variable = resources[index].variable;
          nsassignmentArray[index].set = resources[index].set;
          nsassignmentArray[index].Add = resources[index].Add;
          nsassignmentArray[index].sub = resources[index].sub;
          nsassignmentArray[index].append = resources[index].append;
          nsassignmentArray[index].clear = resources[index].clear;
          nsassignmentArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsassignmentArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nsassignment resource) => new nsassignment()
    {
      name = resource.name,
      variable = resource.variable,
      set = resource.set,
      Add = resource.Add,
      sub = resource.sub,
      append = resource.append,
      clear = resource.clear,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      nsassignment[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsassignment[] nsassignmentArray = new nsassignment[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsassignmentArray[index] = new nsassignment();
          nsassignmentArray[index].name = resources[index].name;
          nsassignmentArray[index].variable = resources[index].variable;
          nsassignmentArray[index].set = resources[index].set;
          nsassignmentArray[index].Add = resources[index].Add;
          nsassignmentArray[index].sub = resources[index].sub;
          nsassignmentArray[index].append = resources[index].append;
          nsassignmentArray[index].clear = resources[index].clear;
          nsassignmentArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsassignmentArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nsassignment() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsassignment resource,
      string[] args)
    {
      return new nsassignment() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nsassignment[] nsassignmentArray = new nsassignment[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nsassignmentArray[index] = new nsassignment();
          nsassignmentArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsassignmentArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsassignment[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsassignment[] nsassignmentArray = new nsassignment[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsassignmentArray[index] = new nsassignment();
          nsassignmentArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsassignmentArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nsassignment()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nsassignment resource) => new nsassignment()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nsassignment[] nsassignmentArray = new nsassignment[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nsassignmentArray[index] = new nsassignment();
          nsassignmentArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsassignmentArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nsassignment[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsassignment[] nsassignmentArray = new nsassignment[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsassignmentArray[index] = new nsassignment();
          nsassignmentArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsassignmentArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      nsassignment resource,
      string new_name)
    {
      return new nsassignment()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new nsassignment()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static nsassignment[] get(nitro_service service) => (nsassignment[]) new nsassignment().get_resources(service, (options) null);

    public static nsassignment[] get(nitro_service service, options option) => (nsassignment[]) new nsassignment().get_resources(service, option);

    public static nsassignment get(nitro_service service, string name) => (nsassignment) new nsassignment()
    {
      name = name
    }.get_resource(service);

    public static nsassignment[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nsassignment[]) null;
      nsassignment[] nsassignmentArray1 = new nsassignment[name.Length];
      nsassignment[] nsassignmentArray2 = new nsassignment[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nsassignmentArray2[index] = new nsassignment();
        nsassignmentArray2[index].name = name[index];
        nsassignmentArray1[index] = (nsassignment) nsassignmentArray2[index].get_resource(service);
      }
      return nsassignmentArray1;
    }

    public static nsassignment[] get_filtered(nitro_service service, string filter)
    {
      nsassignment nsassignment = new nsassignment();
      options option = new options();
      option.set_filter(filter);
      return (nsassignment[]) nsassignment.getfiltered(service, option);
    }

    public static nsassignment[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nsassignment nsassignment = new nsassignment();
      options option = new options();
      option.set_filter(filter);
      return (nsassignment[]) nsassignment.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsassignment nsassignment = new nsassignment();
      options option = new options();
      option.set_count(true);
      nsassignment[] resources = (nsassignment[]) nsassignment.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsassignment nsassignment = new nsassignment();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsassignment[] nsassignmentArray = (nsassignment[]) nsassignment.getfiltered(service, option);
      return nsassignmentArray != null && nsassignmentArray.Length > 0 ? nsassignmentArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsassignment nsassignment = new nsassignment();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsassignment[] nsassignmentArray = (nsassignment[]) nsassignment.getfiltered(service, option);
      return nsassignmentArray != null && nsassignmentArray.Length > 0 ? nsassignmentArray[0].__count.Value : 0U;
    }

    private class nsassignment_response : base_response
    {
      public nsassignment[] nsassignment = (nsassignment[]) null;
    }
  }
}
