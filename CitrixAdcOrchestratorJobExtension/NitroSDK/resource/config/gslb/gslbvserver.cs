// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbvserver : base_resource
  {
    private string nameField = (string) null;
    private string servicetypeField = (string) null;
    private string iptypeField = (string) null;
    private string dnsrecordtypeField = (string) null;
    private string lbmethodField = (string) null;
    private uint? backupsessiontimeoutField = new uint?();
    private string backuplbmethodField = (string) null;
    private string netmaskField = (string) null;
    private uint? v6netmasklenField = new uint?();
    private uint? toleranceField = new uint?();
    private string persistencetypeField = (string) null;
    private uint? persistenceidField = new uint?();
    private string persistmaskField = (string) null;
    private uint? v6persistmasklenField = new uint?();
    private uint? timeoutField = new uint?();
    private string edrField = (string) null;
    private string mirField = (string) null;
    private string disableprimaryondownField = (string) null;
    private string dynamicweightField = (string) null;
    private string stateField = (string) null;
    private string considereffectivestateField = (string) null;
    private string commentField = (string) null;
    private string somethodField = (string) null;
    private string sopersistenceField = (string) null;
    private uint? sopersistencetimeoutField = new uint?();
    private uint? sothresholdField = new uint?();
    private string sobackupactionField = (string) null;
    private string appflowlogField = (string) null;
    private string backupvserverField = (string) null;
    private string servicenameField = (string) null;
    private uint? weightField = new uint?();
    private string domainnameField = (string) null;
    private long? ttlField = new long?();
    private string backupipField = (string) null;
    private string cookie_domainField = (string) null;
    private uint? cookietimeoutField = new uint?();
    private long? sitedomainttlField = new long?();
    private string newnameField = (string) null;
    private string curstateField = (string) null;
    private int? statusField = new int?();
    private int? lbrrreasonField = new int?();
    private string iscnameField = (string) null;
    private string sitepersistenceField = (string) null;
    private uint? totalservicesField = new uint?();
    private uint? activeservicesField = new uint?();
    private string statechangetimesecField = (string) null;
    private uint? statechangetimemsecField = new uint?();
    private uint? tickssincelaststatechangeField = new uint?();
    private uint? healthField = new uint?();
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string typeField = (string) null;
    private string vsvrbindsvcipField = (string) null;
    private ushort? vsvrbindsvcportField = new ushort?();
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

    public string servicetype
    {
      get => this.servicetypeField;
      set => this.servicetypeField = value;
    }

    public string iptype
    {
      get => this.iptypeField;
      set => this.iptypeField = value;
    }

    public string dnsrecordtype
    {
      get => this.dnsrecordtypeField;
      set => this.dnsrecordtypeField = value;
    }

    public string lbmethod
    {
      get => this.lbmethodField;
      set => this.lbmethodField = value;
    }

    public uint? backupsessiontimeout
    {
      get => this.backupsessiontimeoutField;
      set => this.backupsessiontimeoutField = value;
    }

    public string backuplbmethod
    {
      get => this.backuplbmethodField;
      set => this.backuplbmethodField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public uint? v6netmasklen
    {
      get => this.v6netmasklenField;
      set => this.v6netmasklenField = value;
    }

    public uint? tolerance
    {
      get => this.toleranceField;
      set => this.toleranceField = value;
    }

    public string persistencetype
    {
      get => this.persistencetypeField;
      set => this.persistencetypeField = value;
    }

    public uint? persistenceid
    {
      get => this.persistenceidField;
      set => this.persistenceidField = value;
    }

    public string persistmask
    {
      get => this.persistmaskField;
      set => this.persistmaskField = value;
    }

    public uint? v6persistmasklen
    {
      get => this.v6persistmasklenField;
      set => this.v6persistmasklenField = value;
    }

    public uint? timeout
    {
      get => this.timeoutField;
      set => this.timeoutField = value;
    }

    public string edr
    {
      get => this.edrField;
      set => this.edrField = value;
    }

    public string mir
    {
      get => this.mirField;
      set => this.mirField = value;
    }

    public string disableprimaryondown
    {
      get => this.disableprimaryondownField;
      set => this.disableprimaryondownField = value;
    }

    public string dynamicweight
    {
      get => this.dynamicweightField;
      set => this.dynamicweightField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string considereffectivestate
    {
      get => this.considereffectivestateField;
      set => this.considereffectivestateField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string somethod
    {
      get => this.somethodField;
      set => this.somethodField = value;
    }

    public string sopersistence
    {
      get => this.sopersistenceField;
      set => this.sopersistenceField = value;
    }

    public uint? sopersistencetimeout
    {
      get => this.sopersistencetimeoutField;
      set => this.sopersistencetimeoutField = value;
    }

    public uint? sothreshold
    {
      get => this.sothresholdField;
      set => this.sothresholdField = value;
    }

    public string sobackupaction
    {
      get => this.sobackupactionField;
      set => this.sobackupactionField = value;
    }

    public string appflowlog
    {
      get => this.appflowlogField;
      set => this.appflowlogField = value;
    }

    public string backupvserver
    {
      get => this.backupvserverField;
      set => this.backupvserverField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public string domainname
    {
      get => this.domainnameField;
      set => this.domainnameField = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public string backupip
    {
      get => this.backupipField;
      set => this.backupipField = value;
    }

    public string cookie_domain
    {
      get => this.cookie_domainField;
      set => this.cookie_domainField = value;
    }

    public uint? cookietimeout
    {
      get => this.cookietimeoutField;
      set => this.cookietimeoutField = value;
    }

    public long? sitedomainttl
    {
      get => this.sitedomainttlField;
      set => this.sitedomainttlField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public string curstate
    {
      get => this.curstateField;
      private set => this.curstateField = value;
    }

    public int? status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public int? lbrrreason
    {
      get => this.lbrrreasonField;
      private set => this.lbrrreasonField = value;
    }

    public string iscname
    {
      get => this.iscnameField;
      private set => this.iscnameField = value;
    }

    public string sitepersistence
    {
      get => this.sitepersistenceField;
      private set => this.sitepersistenceField = value;
    }

    public uint? totalservices
    {
      get => this.totalservicesField;
      private set => this.totalservicesField = value;
    }

    public uint? activeservices
    {
      get => this.activeservicesField;
      private set => this.activeservicesField = value;
    }

    public string statechangetimesec
    {
      get => this.statechangetimesecField;
      private set => this.statechangetimesecField = value;
    }

    public uint? statechangetimemsec
    {
      get => this.statechangetimemsecField;
      private set => this.statechangetimemsecField = value;
    }

    public uint? tickssincelaststatechange
    {
      get => this.tickssincelaststatechangeField;
      private set => this.tickssincelaststatechangeField = value;
    }

    public uint? health
    {
      get => this.healthField;
      private set => this.healthField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      private set => this.policynameField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public string vsvrbindsvcip
    {
      get => this.vsvrbindsvcipField;
      private set => this.vsvrbindsvcipField = value;
    }

    public ushort? vsvrbindsvcport
    {
      get => this.vsvrbindsvcportField;
      private set => this.vsvrbindsvcportField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbvserver.gslbvserver_response gslbvserverResponse = new gslbvserver.gslbvserver_response();
      gslbvserver.gslbvserver_response resource = (gslbvserver.gslbvserver_response) service.get_payload_formatter().string_to_resource(gslbvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbvserver;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, gslbvserver resource) => new gslbvserver()
    {
      name = resource.name,
      servicetype = resource.servicetype,
      iptype = resource.iptype,
      dnsrecordtype = resource.dnsrecordtype,
      lbmethod = resource.lbmethod,
      backupsessiontimeout = resource.backupsessiontimeout,
      backuplbmethod = resource.backuplbmethod,
      netmask = resource.netmask,
      v6netmasklen = resource.v6netmasklen,
      tolerance = resource.tolerance,
      persistencetype = resource.persistencetype,
      persistenceid = resource.persistenceid,
      persistmask = resource.persistmask,
      v6persistmasklen = resource.v6persistmasklen,
      timeout = resource.timeout,
      edr = resource.edr,
      mir = resource.mir,
      disableprimaryondown = resource.disableprimaryondown,
      dynamicweight = resource.dynamicweight,
      state = resource.state,
      considereffectivestate = resource.considereffectivestate,
      comment = resource.comment,
      somethod = resource.somethod,
      sopersistence = resource.sopersistence,
      sopersistencetimeout = resource.sopersistencetimeout,
      sothreshold = resource.sothreshold,
      sobackupaction = resource.sobackupaction,
      appflowlog = resource.appflowlog
    }.add_resource(client);

    public static base_responses add(nitro_service client, gslbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = resources[index].name;
          gslbvserverArray[index].servicetype = resources[index].servicetype;
          gslbvserverArray[index].iptype = resources[index].iptype;
          gslbvserverArray[index].dnsrecordtype = resources[index].dnsrecordtype;
          gslbvserverArray[index].lbmethod = resources[index].lbmethod;
          gslbvserverArray[index].backupsessiontimeout = resources[index].backupsessiontimeout;
          gslbvserverArray[index].backuplbmethod = resources[index].backuplbmethod;
          gslbvserverArray[index].netmask = resources[index].netmask;
          gslbvserverArray[index].v6netmasklen = resources[index].v6netmasklen;
          gslbvserverArray[index].tolerance = resources[index].tolerance;
          gslbvserverArray[index].persistencetype = resources[index].persistencetype;
          gslbvserverArray[index].persistenceid = resources[index].persistenceid;
          gslbvserverArray[index].persistmask = resources[index].persistmask;
          gslbvserverArray[index].v6persistmasklen = resources[index].v6persistmasklen;
          gslbvserverArray[index].timeout = resources[index].timeout;
          gslbvserverArray[index].edr = resources[index].edr;
          gslbvserverArray[index].mir = resources[index].mir;
          gslbvserverArray[index].disableprimaryondown = resources[index].disableprimaryondown;
          gslbvserverArray[index].dynamicweight = resources[index].dynamicweight;
          gslbvserverArray[index].state = resources[index].state;
          gslbvserverArray[index].considereffectivestate = resources[index].considereffectivestate;
          gslbvserverArray[index].comment = resources[index].comment;
          gslbvserverArray[index].somethod = resources[index].somethod;
          gslbvserverArray[index].sopersistence = resources[index].sopersistence;
          gslbvserverArray[index].sopersistencetimeout = resources[index].sopersistencetimeout;
          gslbvserverArray[index].sothreshold = resources[index].sothreshold;
          gslbvserverArray[index].sobackupaction = resources[index].sobackupaction;
          gslbvserverArray[index].appflowlog = resources[index].appflowlog;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) gslbvserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new gslbvserver()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, gslbvserver resource) => new gslbvserver()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbvserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, gslbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) gslbvserverArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, gslbvserver resource) => new gslbvserver()
    {
      name = resource.name,
      iptype = resource.iptype,
      dnsrecordtype = resource.dnsrecordtype,
      backupvserver = resource.backupvserver,
      backupsessiontimeout = resource.backupsessiontimeout,
      lbmethod = resource.lbmethod,
      backuplbmethod = resource.backuplbmethod,
      netmask = resource.netmask,
      v6netmasklen = resource.v6netmasklen,
      tolerance = resource.tolerance,
      persistencetype = resource.persistencetype,
      persistenceid = resource.persistenceid,
      persistmask = resource.persistmask,
      v6persistmasklen = resource.v6persistmasklen,
      timeout = resource.timeout,
      edr = resource.edr,
      mir = resource.mir,
      disableprimaryondown = resource.disableprimaryondown,
      dynamicweight = resource.dynamicweight,
      considereffectivestate = resource.considereffectivestate,
      somethod = resource.somethod,
      sopersistence = resource.sopersistence,
      sopersistencetimeout = resource.sopersistencetimeout,
      sothreshold = resource.sothreshold,
      sobackupaction = resource.sobackupaction,
      servicename = resource.servicename,
      weight = resource.weight,
      domainname = resource.domainname,
      ttl = resource.ttl,
      backupip = resource.backupip,
      cookie_domain = resource.cookie_domain,
      cookietimeout = resource.cookietimeout,
      sitedomainttl = resource.sitedomainttl,
      comment = resource.comment,
      appflowlog = resource.appflowlog
    }.update_resource(client);

    public static base_responses update(nitro_service client, gslbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = resources[index].name;
          gslbvserverArray[index].iptype = resources[index].iptype;
          gslbvserverArray[index].dnsrecordtype = resources[index].dnsrecordtype;
          gslbvserverArray[index].backupvserver = resources[index].backupvserver;
          gslbvserverArray[index].backupsessiontimeout = resources[index].backupsessiontimeout;
          gslbvserverArray[index].lbmethod = resources[index].lbmethod;
          gslbvserverArray[index].backuplbmethod = resources[index].backuplbmethod;
          gslbvserverArray[index].netmask = resources[index].netmask;
          gslbvserverArray[index].v6netmasklen = resources[index].v6netmasklen;
          gslbvserverArray[index].tolerance = resources[index].tolerance;
          gslbvserverArray[index].persistencetype = resources[index].persistencetype;
          gslbvserverArray[index].persistenceid = resources[index].persistenceid;
          gslbvserverArray[index].persistmask = resources[index].persistmask;
          gslbvserverArray[index].v6persistmasklen = resources[index].v6persistmasklen;
          gslbvserverArray[index].timeout = resources[index].timeout;
          gslbvserverArray[index].edr = resources[index].edr;
          gslbvserverArray[index].mir = resources[index].mir;
          gslbvserverArray[index].disableprimaryondown = resources[index].disableprimaryondown;
          gslbvserverArray[index].dynamicweight = resources[index].dynamicweight;
          gslbvserverArray[index].considereffectivestate = resources[index].considereffectivestate;
          gslbvserverArray[index].somethod = resources[index].somethod;
          gslbvserverArray[index].sopersistence = resources[index].sopersistence;
          gslbvserverArray[index].sopersistencetimeout = resources[index].sopersistencetimeout;
          gslbvserverArray[index].sothreshold = resources[index].sothreshold;
          gslbvserverArray[index].sobackupaction = resources[index].sobackupaction;
          gslbvserverArray[index].servicename = resources[index].servicename;
          gslbvserverArray[index].weight = resources[index].weight;
          gslbvserverArray[index].domainname = resources[index].domainname;
          gslbvserverArray[index].ttl = resources[index].ttl;
          gslbvserverArray[index].backupip = resources[index].backupip;
          gslbvserverArray[index].cookie_domain = resources[index].cookie_domain;
          gslbvserverArray[index].cookietimeout = resources[index].cookietimeout;
          gslbvserverArray[index].sitedomainttl = resources[index].sitedomainttl;
          gslbvserverArray[index].comment = resources[index].comment;
          gslbvserverArray[index].appflowlog = resources[index].appflowlog;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) gslbvserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new gslbvserver() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      gslbvserver resource,
      string[] args)
    {
      return new gslbvserver() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) gslbvserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      gslbvserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) gslbvserverArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new gslbvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, gslbvserver resource) => new gslbvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) gslbvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, gslbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) gslbvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new gslbvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, gslbvserver resource) => new gslbvserver()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) gslbvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(
      nitro_service client,
      gslbvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbvserver[] gslbvserverArray = new gslbvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          gslbvserverArray[index] = new gslbvserver();
          gslbvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) gslbvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      gslbvserver resource,
      string new_name)
    {
      return new gslbvserver()
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
      return new gslbvserver()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static gslbvserver[] get(nitro_service service) => (gslbvserver[]) new gslbvserver().get_resources(service, (options) null);

    public static gslbvserver[] get(nitro_service service, options option) => (gslbvserver[]) new gslbvserver().get_resources(service, option);

    public static gslbvserver get(nitro_service service, string name) => (gslbvserver) new gslbvserver()
    {
      name = name
    }.get_resource(service);

    public static gslbvserver[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (gslbvserver[]) null;
      gslbvserver[] gslbvserverArray1 = new gslbvserver[name.Length];
      gslbvserver[] gslbvserverArray2 = new gslbvserver[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        gslbvserverArray2[index] = new gslbvserver();
        gslbvserverArray2[index].name = name[index];
        gslbvserverArray1[index] = (gslbvserver) gslbvserverArray2[index].get_resource(service);
      }
      return gslbvserverArray1;
    }

    public static gslbvserver[] get_filtered(nitro_service service, string filter)
    {
      gslbvserver gslbvserver = new gslbvserver();
      options option = new options();
      option.set_filter(filter);
      return (gslbvserver[]) gslbvserver.getfiltered(service, option);
    }

    public static gslbvserver[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbvserver gslbvserver = new gslbvserver();
      options option = new options();
      option.set_filter(filter);
      return (gslbvserver[]) gslbvserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      gslbvserver gslbvserver = new gslbvserver();
      options option = new options();
      option.set_count(true);
      gslbvserver[] resources = (gslbvserver[]) gslbvserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      gslbvserver gslbvserver = new gslbvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbvserver[] gslbvserverArray = (gslbvserver[]) gslbvserver.getfiltered(service, option);
      return gslbvserverArray != null && gslbvserverArray.Length > 0 ? gslbvserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbvserver gslbvserver = new gslbvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbvserver[] gslbvserverArray = (gslbvserver[]) gslbvserver.getfiltered(service, option);
      return gslbvserverArray != null && gslbvserverArray.Length > 0 ? gslbvserverArray[0].__count.Value : 0U;
    }

    private class gslbvserver_response : base_response
    {
      public gslbvserver[] gslbvserver = (gslbvserver[]) null;
    }

    public static class backuplbmethodEnum
    {
      public const string ROUNDROBIN = "ROUNDROBIN";
      public const string LEASTCONNECTION = "LEASTCONNECTION";
      public const string LEASTRESPONSETIME = "LEASTRESPONSETIME";
      public const string SOURCEIPHASH = "SOURCEIPHASH";
      public const string LEASTBANDWIDTH = "LEASTBANDWIDTH";
      public const string LEASTPACKETS = "LEASTPACKETS";
      public const string STATICPROXIMITY = "STATICPROXIMITY";
      public const string RTT = "RTT";
      public const string CUSTOMLOAD = "CUSTOMLOAD";
    }

    public static class iptypeEnum
    {
      public const string IPV4 = "IPV4";
      public const string IPV6 = "IPV6";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dnsrecordtypeEnum
    {
      public const string A = "A";
      public const string AAAA = "AAAA";
      public const string CNAME = "CNAME";
      public const string NAPTR = "NAPTR";
    }

    public static class servicetypeEnum
    {
      public const string HTTP = "HTTP";
      public const string FTP = "FTP";
      public const string TCP = "TCP";
      public const string UDP = "UDP";
      public const string SSL = "SSL";
      public const string SSL_BRIDGE = "SSL_BRIDGE";
      public const string SSL_TCP = "SSL_TCP";
      public const string NNTP = "NNTP";
      public const string ANY = "ANY";
      public const string SIP_UDP = "SIP_UDP";
      public const string SIP_TCP = "SIP_TCP";
      public const string SIP_SSL = "SIP_SSL";
      public const string RADIUS = "RADIUS";
      public const string RDP = "RDP";
      public const string RTSP = "RTSP";
      public const string MYSQL = "MYSQL";
      public const string MSSQL = "MSSQL";
      public const string ORACLE = "ORACLE";
    }

    public static class sobackupactionEnum
    {
      public const string DROP = "DROP";
      public const string ACCEPT = "ACCEPT";
      public const string REDIRECT = "REDIRECT";
    }

    public static class typeEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
    }

    public static class disableprimaryondownEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mirEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class somethodEnum
    {
      public const string CONNECTION = "CONNECTION";
      public const string DYNAMICCONNECTION = "DYNAMICCONNECTION";
      public const string BANDWIDTH = "BANDWIDTH";
      public const string HEALTH = "HEALTH";
      public const string NONE = "NONE";
    }

    public static class sopersistenceEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class edrEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class lbmethodEnum
    {
      public const string ROUNDROBIN = "ROUNDROBIN";
      public const string LEASTCONNECTION = "LEASTCONNECTION";
      public const string LEASTRESPONSETIME = "LEASTRESPONSETIME";
      public const string SOURCEIPHASH = "SOURCEIPHASH";
      public const string LEASTBANDWIDTH = "LEASTBANDWIDTH";
      public const string LEASTPACKETS = "LEASTPACKETS";
      public const string STATICPROXIMITY = "STATICPROXIMITY";
      public const string RTT = "RTT";
      public const string CUSTOMLOAD = "CUSTOMLOAD";
    }

    public static class sitepersistenceEnum
    {
      public const string ConnectionProxy = "ConnectionProxy";
      public const string HTTPRedirect = "HTTPRedirect";
      public const string NONE = "NONE";
    }

    public static class considereffectivestateEnum
    {
      public const string NONE = "NONE";
      public const string STATE_ONLY = "STATE_ONLY";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class iscnameEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class curstateEnum
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

    public static class persistencetypeEnum
    {
      public const string SOURCEIP = "SOURCEIP";
      public const string NONE = "NONE";
    }

    public static class dynamicweightEnum
    {
      public const string SERVICECOUNT = "SERVICECOUNT";
      public const string SERVICEWEIGHT = "SERVICEWEIGHT";
      public const string DISABLED = "DISABLED";
    }
  }
}
