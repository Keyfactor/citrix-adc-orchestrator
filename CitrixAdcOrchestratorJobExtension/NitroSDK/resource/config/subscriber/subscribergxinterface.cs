// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.subscriber.subscribergxinterface
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.subscriber
{
  public class subscribergxinterface : base_resource
  {
    private string vserverField = (string) null;
    private string serviceField = (string) null;
    private string pcrfrealmField = (string) null;
    private string holdonsubscriberabsenceField = (string) null;
    private uint? requesttimeoutField = new uint?();
    private uint? requestretryattemptsField = new uint?();
    private uint? idlettlField = new uint?();
    private uint? revalidationtimeoutField = new uint?();
    private uint? negativettlField = new uint?();
    private uint?[] servicepathavpField = (uint?[]) null;
    private uint? servicepathvendoridField = new uint?();
    private string svrstateField = (string) null;
    private string identityField = (string) null;
    private string realmField = (string) null;
    private string statusField = (string) null;
    private string servicepathinfomodeField = (string) null;

    public string vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
    }

    public string service
    {
      get => this.serviceField;
      set => this.serviceField = value;
    }

    public string pcrfrealm
    {
      get => this.pcrfrealmField;
      set => this.pcrfrealmField = value;
    }

    public string holdonsubscriberabsence
    {
      get => this.holdonsubscriberabsenceField;
      set => this.holdonsubscriberabsenceField = value;
    }

    public uint? requesttimeout
    {
      get => this.requesttimeoutField;
      set => this.requesttimeoutField = value;
    }

    public uint? requestretryattempts
    {
      get => this.requestretryattemptsField;
      set => this.requestretryattemptsField = value;
    }

    public uint? idlettl
    {
      get => this.idlettlField;
      set => this.idlettlField = value;
    }

    public uint? revalidationtimeout
    {
      get => this.revalidationtimeoutField;
      set => this.revalidationtimeoutField = value;
    }

    public uint? negativettl
    {
      get => this.negativettlField;
      set => this.negativettlField = value;
    }

    public uint?[] servicepathavp
    {
      get => this.servicepathavpField;
      set => this.servicepathavpField = value;
    }

    public uint? servicepathvendorid
    {
      get => this.servicepathvendoridField;
      set => this.servicepathvendoridField = value;
    }

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    public string identity
    {
      get => this.identityField;
      private set => this.identityField = value;
    }

    public string realm
    {
      get => this.realmField;
      private set => this.realmField = value;
    }

    public string status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public string servicepathinfomode
    {
      get => this.servicepathinfomodeField;
      private set => this.servicepathinfomodeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      subscribergxinterface[] subscribergxinterfaceArray = new subscribergxinterface[1];
      subscribergxinterface.subscribergxinterface_response subscribergxinterfaceResponse = new subscribergxinterface.subscribergxinterface_response();
      subscribergxinterface.subscribergxinterface_response resource = (subscribergxinterface.subscribergxinterface_response) service.get_payload_formatter().string_to_resource(subscribergxinterfaceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      subscribergxinterfaceArray[0] = resource.subscribergxinterface;
      return (base_resource[]) subscribergxinterfaceArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      subscribergxinterface resource)
    {
      return new subscribergxinterface()
      {
        vserver = resource.vserver,
        service = resource.service,
        pcrfrealm = resource.pcrfrealm,
        holdonsubscriberabsence = resource.holdonsubscriberabsence,
        requesttimeout = resource.requesttimeout,
        requestretryattempts = resource.requestretryattempts,
        idlettl = resource.idlettl,
        revalidationtimeout = resource.revalidationtimeout,
        negativettl = resource.negativettl,
        servicepathavp = resource.servicepathavp,
        servicepathvendorid = resource.servicepathvendorid
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      subscribergxinterface resource,
      string[] args)
    {
      return new subscribergxinterface().unset_resource(client, args);
    }

    public static subscribergxinterface get(nitro_service service) => ((subscribergxinterface[]) new subscribergxinterface().get_resources(service, (options) null))[0];

    public static subscribergxinterface get(
      nitro_service service,
      options option)
    {
      return ((subscribergxinterface[]) new subscribergxinterface().get_resources(service, option))[0];
    }

    private class subscribergxinterface_response : base_response
    {
      public subscribergxinterface subscribergxinterface = (subscribergxinterface) null;
    }

    public static class servicepathinfomodeEnum
    {
      public const string SERVICEFUNCTIONS = "SERVICEFUNCTIONS";
      public const string SERVICEPATH = "SERVICEPATH";
    }

    public static class svrstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }

    public static class holdonsubscriberabsenceEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
