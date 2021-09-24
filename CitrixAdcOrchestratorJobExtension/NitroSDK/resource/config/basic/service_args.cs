// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.service_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class service_args
  {
    private bool? allField = new bool?();
    private bool? InternalField = new bool?();

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    public bool? Internal
    {
      get => this.InternalField;
      set => this.InternalField = value;
    }
  }
}
