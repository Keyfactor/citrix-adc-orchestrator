// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lldp.lldpneighbors
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lldp
{
  public class lldpneighbors : base_resource
  {
    private string ifnumField = (string) null;
    private string chassisidsubtypeField = (string) null;
    private string chassisidField = (string) null;
    private string portidsubtypeField = (string) null;
    private string portidField = (string) null;
    private uint? ttlField = new uint?();
    private string portdescriptionField = (string) null;
    private string sysField = (string) null;
    private string sysdescField = (string) null;
    private string mgmtaddresssubtypeField = (string) null;
    private string mgmtaddressField = (string) null;
    private string iftypeField = (string) null;
    private uint? ifnumberField = new uint?();
    private string vlanField = (string) null;
    private uint? vlanidField = new uint?();
    private uint? portprotosupportedField = new uint?();
    private uint? portprotoenabledField = new uint?();
    private uint? portprotoidField = new uint?();
    private uint? portvlanidField = new uint?();
    private string protocolidField = (string) null;
    private string linkaggrcapableField = (string) null;
    private string linkaggrenabledField = (string) null;
    private uint? linkaggridField = new uint?();
    private uint? flagField = new uint?();
    private string syscapabilitiesField = (string) null;
    private string syscapenabledField = (string) null;
    private string autonegsupportField = (string) null;
    private string autonegenabledField = (string) null;
    private string autonegadvertisedField = (string) null;
    private string autonegmautypeField = (string) null;
    private uint? mtuField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    public string chassisidsubtype
    {
      get => this.chassisidsubtypeField;
      private set => this.chassisidsubtypeField = value;
    }

    public string chassisid
    {
      get => this.chassisidField;
      private set => this.chassisidField = value;
    }

    public string portidsubtype
    {
      get => this.portidsubtypeField;
      private set => this.portidsubtypeField = value;
    }

    public string portid
    {
      get => this.portidField;
      private set => this.portidField = value;
    }

    public uint? ttl
    {
      get => this.ttlField;
      private set => this.ttlField = value;
    }

    public string portdescription
    {
      get => this.portdescriptionField;
      private set => this.portdescriptionField = value;
    }

    public string sys
    {
      get => this.sysField;
      private set => this.sysField = value;
    }

    public string sysdesc
    {
      get => this.sysdescField;
      private set => this.sysdescField = value;
    }

    public string mgmtaddresssubtype
    {
      get => this.mgmtaddresssubtypeField;
      private set => this.mgmtaddresssubtypeField = value;
    }

    public string mgmtaddress
    {
      get => this.mgmtaddressField;
      private set => this.mgmtaddressField = value;
    }

    public string iftype
    {
      get => this.iftypeField;
      private set => this.iftypeField = value;
    }

    public uint? ifnumber
    {
      get => this.ifnumberField;
      private set => this.ifnumberField = value;
    }

    public string vlan
    {
      get => this.vlanField;
      private set => this.vlanField = value;
    }

    public uint? vlanid
    {
      get => this.vlanidField;
      private set => this.vlanidField = value;
    }

    public uint? portprotosupported
    {
      get => this.portprotosupportedField;
      private set => this.portprotosupportedField = value;
    }

    public uint? portprotoenabled
    {
      get => this.portprotoenabledField;
      private set => this.portprotoenabledField = value;
    }

    public uint? portprotoid
    {
      get => this.portprotoidField;
      private set => this.portprotoidField = value;
    }

    public uint? portvlanid
    {
      get => this.portvlanidField;
      private set => this.portvlanidField = value;
    }

    public string protocolid
    {
      get => this.protocolidField;
      private set => this.protocolidField = value;
    }

    public string linkaggrcapable
    {
      get => this.linkaggrcapableField;
      private set => this.linkaggrcapableField = value;
    }

    public string linkaggrenabled
    {
      get => this.linkaggrenabledField;
      private set => this.linkaggrenabledField = value;
    }

    public uint? linkaggrid
    {
      get => this.linkaggridField;
      private set => this.linkaggridField = value;
    }

    public uint? flag
    {
      get => this.flagField;
      private set => this.flagField = value;
    }

    public string syscapabilities
    {
      get => this.syscapabilitiesField;
      private set => this.syscapabilitiesField = value;
    }

    public string syscapenabled
    {
      get => this.syscapenabledField;
      private set => this.syscapenabledField = value;
    }

    public string autonegsupport
    {
      get => this.autonegsupportField;
      private set => this.autonegsupportField = value;
    }

    public string autonegenabled
    {
      get => this.autonegenabledField;
      private set => this.autonegenabledField = value;
    }

    public string autonegadvertised
    {
      get => this.autonegadvertisedField;
      private set => this.autonegadvertisedField = value;
    }

    public string autonegmautype
    {
      get => this.autonegmautypeField;
      private set => this.autonegmautypeField = value;
    }

    public uint? mtu
    {
      get => this.mtuField;
      private set => this.mtuField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lldpneighbors.lldpneighbors_response lldpneighborsResponse = new lldpneighbors.lldpneighbors_response();
      lldpneighbors.lldpneighbors_response resource = (lldpneighbors.lldpneighbors_response) service.get_payload_formatter().string_to_resource(lldpneighborsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lldpneighbors;
    }

    internal override string get_object_name() => this.ifnum;

    public static base_response clear(nitro_service client) => new lldpneighbors().perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(
      nitro_service client,
      lldpneighbors[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lldpneighbors[] lldpneighborsArray = new lldpneighbors[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          lldpneighborsArray[index] = new lldpneighbors();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) lldpneighborsArray, nameof (clear));
      }
      return baseResponses;
    }

    public static lldpneighbors[] get(nitro_service service) => (lldpneighbors[]) new lldpneighbors().get_resources(service, (options) null);

    public static lldpneighbors[] get(nitro_service service, options option) => (lldpneighbors[]) new lldpneighbors().get_resources(service, option);

    public static lldpneighbors get(nitro_service service, string ifnum) => (lldpneighbors) new lldpneighbors()
    {
      ifnum = ifnum
    }.get_resource(service);

    public static lldpneighbors[] get(nitro_service service, string[] ifnum)
    {
      if (ifnum == null || ifnum.Length <= 0)
        return (lldpneighbors[]) null;
      lldpneighbors[] lldpneighborsArray1 = new lldpneighbors[ifnum.Length];
      lldpneighbors[] lldpneighborsArray2 = new lldpneighbors[ifnum.Length];
      for (int index = 0; index < ifnum.Length; ++index)
      {
        lldpneighborsArray2[index] = new lldpneighbors();
        lldpneighborsArray2[index].ifnum = ifnum[index];
        lldpneighborsArray1[index] = (lldpneighbors) lldpneighborsArray2[index].get_resource(service);
      }
      return lldpneighborsArray1;
    }

    public static lldpneighbors[] get_filtered(nitro_service service, string filter)
    {
      lldpneighbors lldpneighbors = new lldpneighbors();
      options option = new options();
      option.set_filter(filter);
      return (lldpneighbors[]) lldpneighbors.getfiltered(service, option);
    }

    public static lldpneighbors[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lldpneighbors lldpneighbors = new lldpneighbors();
      options option = new options();
      option.set_filter(filter);
      return (lldpneighbors[]) lldpneighbors.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lldpneighbors lldpneighbors = new lldpneighbors();
      options option = new options();
      option.set_count(true);
      lldpneighbors[] resources = (lldpneighbors[]) lldpneighbors.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lldpneighbors lldpneighbors = new lldpneighbors();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lldpneighbors[] lldpneighborsArray = (lldpneighbors[]) lldpneighbors.getfiltered(service, option);
      return lldpneighborsArray != null && lldpneighborsArray.Length > 0 ? lldpneighborsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lldpneighbors lldpneighbors = new lldpneighbors();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lldpneighbors[] lldpneighborsArray = (lldpneighbors[]) lldpneighbors.getfiltered(service, option);
      return lldpneighborsArray != null && lldpneighborsArray.Length > 0 ? lldpneighborsArray[0].__count.Value : 0U;
    }

    private class lldpneighbors_response : base_response
    {
      public lldpneighbors[] lldpneighbors = (lldpneighbors[]) null;
    }

    public static class mgmtaddresssubtypeEnum
    {
      public const string OTHER = "OTHER";
      public const string IPv4 = "IPv4";
      public const string IPv6 = "IPv6";
    }

    public static class autonegmautypeEnum
    {
      public const string Not_Recieved = "Not Recieved";
      public const string AUI = "AUI";
      public const string _10Base5 = "10Base5";
      public const string Foirl = "Foirl";
      public const string _10Base2 = "10Base2";
      public const string _10BaseT = "10BaseT";
      public const string _10BaseFP = "10BaseFP";
      public const string _10BaseFB = "10BaseFB";
      public const string _10BaseFL = "10BaseFL";
      public const string _10Broad36 = "10Broad36";
      public const string _10BaseTHD = "10BaseTHD";
      public const string _10BaseTFD = "10BaseTFD";
      public const string _10BaseFLHD = "10BaseFLHD";
      public const string _10BaseFLDF = "10BaseFLDF";
      public const string _10BaseT4 = "10BaseT4";
      public const string _100BaseTXHD = "100BaseTXHD";
      public const string _100BaseTXFD = "100BaseTXFD";
      public const string _100BaseFXHD = "100BaseFXHD";
      public const string _100BaseFXFD = "100BaseFXFD";
      public const string _100BaseT2HD = "100BaseT2HD";
      public const string _100BaseT2DF = "100BaseT2DF";
      public const string _1000BaseXHD = "1000BaseXHD";
      public const string _1000BaseXFD = "1000BaseXFD";
      public const string _1000BaseLXHD = "1000BaseLXHD";
      public const string _1000BaseLXFD = "1000BaseLXFD";
      public const string _1000BaseSXHD = "1000BaseSXHD";
      public const string _1000BaseSXFD = "1000BaseSXFD";
      public const string _1000BaseCXHD = "1000BaseCXHD";
      public const string _1000BaseCXFD = "1000BaseCXFD";
      public const string _1000BaseTHD = "1000BaseTHD";
      public const string _1000BaseTFD = "1000BaseTFD";
      public const string _10GigBaseX = "10GigBaseX";
      public const string _10GigBaseLX4 = "10GigBaseLX4";
      public const string _10GigBaseR = "10GigBaseR";
      public const string _10GigBaseER = "10GigBaseER";
      public const string _10GigBaseLR = "10GigBaseLR";
      public const string _10GigBaseSR = "10GigBaseSR";
      public const string _10GigBaseW = "10GigBaseW";
      public const string _10GigBaseEW = "10GigBaseEW";
      public const string _10GigBaseLW = "10GigBaseLW";
      public const string _10GigBaseSW = "10GigBaseSW";
    }

    public static class linkaggrcapableEnum
    {
      public const string NO = "NO";
      public const string YES = "YES";
    }

    public static class autonegsupportEnum
    {
      public const string NO = "NO";
      public const string YES = "YES";
    }

    public static class chassisidsubtypeEnum
    {
      public const string NONE = "NONE";
      public const string Component = "Component";
      public const string Interface_Alias = "Interface Alias";
      public const string Port_Component = "Port Component";
      public const string MAC_Address = "MAC Address";
      public const string Network_Address = "Network Address";
      public const string Interface_Name = "Interface Name";
      public const string Locally_Assigned = "Locally Assigned";
    }

    public static class portidsubtypeEnum
    {
      public const string NONE = "NONE";
      public const string Interface_Alias = "Interface Alias";
      public const string Port_Component = "Port Component";
      public const string MAC_Address = "MAC Address";
      public const string Network_Address = "Network Address";
      public const string Interface_Name = "Interface Name";
      public const string Agent_Circuit_ID = "Agent Circuit ID";
      public const string Locally_Assigned = "Locally Assigned";
    }

    public static class autonegenabledEnum
    {
      public const string NO = "NO";
      public const string YES = "YES";
    }

    public static class iftypeEnum
    {
      public const string UNKNOWN = "UNKNOWN";
      public const string ifIndex = "ifIndex";
      public const string system_port_number = "system port number";
    }

    public static class linkaggrenabledEnum
    {
      public const string NO = "NO";
      public const string YES = "YES";
    }
  }
}
