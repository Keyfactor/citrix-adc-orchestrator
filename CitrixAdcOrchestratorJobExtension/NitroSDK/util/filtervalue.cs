// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.util.filtervalue
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.util
{
  public class filtervalue
  {
    private string name;
    private string value;

    public filtervalue(string name, string value)
    {
      this.name = name;
      this.value = value;
    }

    public string get_name() => this.name;

    public string get_value() => this.value;
  }
}
