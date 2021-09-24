﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemglobaldata_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemglobaldata_args
  {
    private string countersField = (string) null;
    private string countergroupField = (string) null;
    private string starttimeField = (string) null;
    private string endtimeField = (string) null;
    private int? lastField = new int?();
    private string unitField = (string) null;
    private string datasourceField = (string) null;
    private int? coreField = new int?();

    public string counters
    {
      get => this.countersField;
      set => this.countersField = value;
    }

    public string countergroup
    {
      get => this.countergroupField;
      set => this.countergroupField = value;
    }

    public string starttime
    {
      get => this.starttimeField;
      set => this.starttimeField = value;
    }

    public string endtime
    {
      get => this.endtimeField;
      set => this.endtimeField = value;
    }

    public int? last
    {
      get => this.lastField;
      set => this.lastField = value;
    }

    public string unit
    {
      get => this.unitField;
      set => this.unitField = value;
    }

    public string datasource
    {
      get => this.datasourceField;
      set => this.datasourceField = value;
    }

    public int? core
    {
      get => this.coreField;
      set => this.coreField = value;
    }

    public static class unitEnum
    {
      public const string HOURS = "HOURS";
      public const string DAYS = "DAYS";
      public const string MONTHS = "MONTHS";
    }
  }
}
