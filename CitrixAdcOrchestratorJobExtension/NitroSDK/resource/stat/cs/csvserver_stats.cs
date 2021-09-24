﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.cs.csvserver_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.cs
{
  public class csvserver_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long establishedconnField = 0;
    private string primaryipaddressField = (string) null;
    private ushort primaryportField = 0;
    private string typeField = (string) null;
    private string stateField = (string) null;
    private long tothitsField = 0;
    private long hitsrateField = 0;
    private long totalrequestsField = 0;
    private long requestsrateField = 0;
    private long totalresponsesField = 0;
    private long responsesrateField = 0;
    private long totalrequestbytesField = 0;
    private long requestbytesrateField = 0;
    private long totalresponsebytesField = 0;
    private long responsebytesrateField = 0;
    private long totalpktsrecvdField = 0;
    private long pktsrecvdrateField = 0;
    private long totalpktssentField = 0;
    private long pktssentrateField = 0;
    private long curclntconnectionsField = 0;
    private long cursrvrconnectionsField = 0;
    private long sothresholdField = 0;
    private long totspilloversField = 0;
    private long labelledconnField = 0;
    private long pushlabelField = 0;
    private long deferredreqField = 0;
    private long deferredreqrateField = 0;
    private long invalidrequestresponseField = 0;
    private long invalidrequestresponsedroppedField = 0;
    private long totvserverdownbackuphitsField = 0;
    private long curmptcpsessionsField = 0;
    private long cursubflowconnField = 0;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long curclntconnections
    {
      get => this.curclntconnectionsField;
      private set => this.curclntconnectionsField = value;
    }

    public long establishedconn
    {
      get => this.establishedconnField;
      private set => this.establishedconnField = value;
    }

    public long totalpktssent
    {
      get => this.totalpktssentField;
      private set => this.totalpktssentField = value;
    }

    public long labelledconn
    {
      get => this.labelledconnField;
      private set => this.labelledconnField = value;
    }

    public long tothits
    {
      get => this.tothitsField;
      private set => this.tothitsField = value;
    }

    public long totalrequests
    {
      get => this.totalrequestsField;
      private set => this.totalrequestsField = value;
    }

    public long sothreshold
    {
      get => this.sothresholdField;
      private set => this.sothresholdField = value;
    }

    public long cursubflowconn
    {
      get => this.cursubflowconnField;
      private set => this.cursubflowconnField = value;
    }

    public long responsebytesrate
    {
      get => this.responsebytesrateField;
      private set => this.responsebytesrateField = value;
    }

    public long invalidrequestresponsedropped
    {
      get => this.invalidrequestresponsedroppedField;
      private set => this.invalidrequestresponsedroppedField = value;
    }

    public long totalresponses
    {
      get => this.totalresponsesField;
      private set => this.totalresponsesField = value;
    }

    public long requestbytesrate
    {
      get => this.requestbytesrateField;
      private set => this.requestbytesrateField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public long hitsrate
    {
      get => this.hitsrateField;
      private set => this.hitsrateField = value;
    }

    public long cursrvrconnections
    {
      get => this.cursrvrconnectionsField;
      private set => this.cursrvrconnectionsField = value;
    }

    public long pktsrecvdrate
    {
      get => this.pktsrecvdrateField;
      private set => this.pktsrecvdrateField = value;
    }

    public string primaryipaddress
    {
      get => this.primaryipaddressField;
      private set => this.primaryipaddressField = value;
    }

    public long pushlabel
    {
      get => this.pushlabelField;
      private set => this.pushlabelField = value;
    }

    public long responsesrate
    {
      get => this.responsesrateField;
      private set => this.responsesrateField = value;
    }

    public long deferredreq
    {
      get => this.deferredreqField;
      private set => this.deferredreqField = value;
    }

    public long curmptcpsessions
    {
      get => this.curmptcpsessionsField;
      private set => this.curmptcpsessionsField = value;
    }

    public long totspillovers
    {
      get => this.totspilloversField;
      private set => this.totspilloversField = value;
    }

    public long totalrequestbytes
    {
      get => this.totalrequestbytesField;
      private set => this.totalrequestbytesField = value;
    }

    public long invalidrequestresponse
    {
      get => this.invalidrequestresponseField;
      private set => this.invalidrequestresponseField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public long deferredreqrate
    {
      get => this.deferredreqrateField;
      private set => this.deferredreqrateField = value;
    }

    public long totalpktsrecvd
    {
      get => this.totalpktsrecvdField;
      private set => this.totalpktsrecvdField = value;
    }

    public long pktssentrate
    {
      get => this.pktssentrateField;
      private set => this.pktssentrateField = value;
    }

    public long totalresponsebytes
    {
      get => this.totalresponsebytesField;
      private set => this.totalresponsebytesField = value;
    }

    public ushort primaryport
    {
      get => this.primaryportField;
      private set => this.primaryportField = value;
    }

    public long requestsrate
    {
      get => this.requestsrateField;
      private set => this.requestsrateField = value;
    }

    public long totvserverdownbackuphits
    {
      get => this.totvserverdownbackuphitsField;
      private set => this.totvserverdownbackuphitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      csvserver_stats.csvserver_response csvserverResponse = new csvserver_stats.csvserver_response();
      csvserver_stats.csvserver_response resource = (csvserver_stats.csvserver_response) service.get_payload_formatter().string_to_resource(csvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.csvserver;
    }

    internal override string get_object_name() => this.name;

    public static csvserver_stats[] get(nitro_service service) => (csvserver_stats[]) new csvserver_stats().stat_resources(service, (options) null);

    public static csvserver_stats[] get(nitro_service service, options option) => (csvserver_stats[]) new csvserver_stats().stat_resources(service, option);

    public static csvserver_stats get(nitro_service service, string name) => (csvserver_stats) new csvserver_stats()
    {
      name = name
    }.stat_resource(service);

    private class csvserver_response : base_response
    {
      public csvserver_stats[] csvserver = (csvserver_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
