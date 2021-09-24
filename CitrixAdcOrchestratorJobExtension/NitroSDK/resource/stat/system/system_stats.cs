// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.system.system_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.system
{
  public class system_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private double voltagev12nField = 0.0;
    private double voltagev5nField = 0.0;
    private long cpuusageField = 0;
    private long rescpuusageField = 0;
    private long slavecpuusageField = 0;
    private long mastercpuusageField = 0;
    private double auxvolt7Field = 0.0;
    private double auxvolt6Field = 0.0;
    private double auxvolt5Field = 0.0;
    private double auxvolt4Field = 0.0;
    private double auxvolt3Field = 0.0;
    private double auxvolt2Field = 0.0;
    private double auxvolt1Field = 0.0;
    private double auxvolt0Field = 0.0;
    private double voltagevsen2Field = 0.0;
    private double voltagev5sbField = 0.0;
    private double voltagevttField = 0.0;
    private double voltagevbatField = 0.0;
    private double voltagev12pField = 0.0;
    private double voltagev5pField = 0.0;
    private double voltagev33stbyField = 0.0;
    private double voltagev33mainField = 0.0;
    private double voltagevcc1Field = 0.0;
    private double voltagevcc0Field = 0.0;
    private long numcpusField = 0;
    private double memusagepcntField = 0.0;
    private long memuseinmbField = 0;
    private double mgmtcpuusagepcntField = 0.0;
    private double pktcpuusagepcntField = 0.0;
    private double cpuusagepcntField = 0.0;
    private double rescpuusagepcntField = 0.0;
    private string starttimeField = (string) null;
    private long disk0perusageField = 0;
    private long disk1perusageField = 0;
    private long cpufan0speedField = 0;
    private long cpufan1speedField = 0;
    private long systemfanspeedField = 0;
    private long fan0speedField = 0;
    private long fanspeedField = 0;
    private long cpu0tempField = 0;
    private long cpu1tempField = 0;
    private long internaltempField = 0;
    private string powersupply1statusField = (string) null;
    private string powersupply2statusField = (string) null;
    private string powersupply3statusField = (string) null;
    private string powersupply4statusField = (string) null;
    private long disk0sizeField = 0;
    private long disk0usedField = 0;
    private long disk0availField = 0;
    private long disk1sizeField = 0;
    private long disk1usedField = 0;
    private long disk1availField = 0;
    private long fan2speedField = 0;
    private long fan3speedField = 0;
    private long fan4speedField = 0;
    private long fan5speedField = 0;
    private long auxtemp0Field = 0;
    private long auxtemp1Field = 0;
    private long auxtemp2Field = 0;
    private long auxtemp3Field = 0;
    private string timesincestartField = (string) null;
    private long memsizembField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public double voltagevbat
    {
      get => this.voltagevbatField;
      private set => this.voltagevbatField = value;
    }

    public double auxvolt2
    {
      get => this.auxvolt2Field;
      private set => this.auxvolt2Field = value;
    }

    public double voltagev5n
    {
      get => this.voltagev5nField;
      private set => this.voltagev5nField = value;
    }

    public double auxvolt7
    {
      get => this.auxvolt7Field;
      private set => this.auxvolt7Field = value;
    }

    public long cpu0temp
    {
      get => this.cpu0tempField;
      private set => this.cpu0tempField = value;
    }

    public long fan0speed
    {
      get => this.fan0speedField;
      private set => this.fan0speedField = value;
    }

    public long disk1perusage
    {
      get => this.disk1perusageField;
      private set => this.disk1perusageField = value;
    }

    public double rescpuusagepcnt
    {
      get => this.rescpuusagepcntField;
      private set => this.rescpuusagepcntField = value;
    }

    public long disk1used
    {
      get => this.disk1usedField;
      private set => this.disk1usedField = value;
    }

    public long disk1avail
    {
      get => this.disk1availField;
      private set => this.disk1availField = value;
    }

    public long fan4speed
    {
      get => this.fan4speedField;
      private set => this.fan4speedField = value;
    }

    public long rescpuusage
    {
      get => this.rescpuusageField;
      private set => this.rescpuusageField = value;
    }

    public string powersupply3status
    {
      get => this.powersupply3statusField;
      private set => this.powersupply3statusField = value;
    }

    public double auxvolt5
    {
      get => this.auxvolt5Field;
      private set => this.auxvolt5Field = value;
    }

    public double auxvolt3
    {
      get => this.auxvolt3Field;
      private set => this.auxvolt3Field = value;
    }

    public long disk0perusage
    {
      get => this.disk0perusageField;
      private set => this.disk0perusageField = value;
    }

    public long fan2speed
    {
      get => this.fan2speedField;
      private set => this.fan2speedField = value;
    }

    public string powersupply4status
    {
      get => this.powersupply4statusField;
      private set => this.powersupply4statusField = value;
    }

    public double auxvolt1
    {
      get => this.auxvolt1Field;
      private set => this.auxvolt1Field = value;
    }

    public long fanspeed
    {
      get => this.fanspeedField;
      private set => this.fanspeedField = value;
    }

    public long fan5speed
    {
      get => this.fan5speedField;
      private set => this.fan5speedField = value;
    }

    public long disk0size
    {
      get => this.disk0sizeField;
      private set => this.disk0sizeField = value;
    }

    public double mgmtcpuusagepcnt
    {
      get => this.mgmtcpuusagepcntField;
      private set => this.mgmtcpuusagepcntField = value;
    }

    public long cpuusage
    {
      get => this.cpuusageField;
      private set => this.cpuusageField = value;
    }

    public double voltagev5sb
    {
      get => this.voltagev5sbField;
      private set => this.voltagev5sbField = value;
    }

    public long disk0used
    {
      get => this.disk0usedField;
      private set => this.disk0usedField = value;
    }

    public string powersupply1status
    {
      get => this.powersupply1statusField;
      private set => this.powersupply1statusField = value;
    }

    public long cpufan0speed
    {
      get => this.cpufan0speedField;
      private set => this.cpufan0speedField = value;
    }

    public long disk1size
    {
      get => this.disk1sizeField;
      private set => this.disk1sizeField = value;
    }

    public long auxtemp1
    {
      get => this.auxtemp1Field;
      private set => this.auxtemp1Field = value;
    }

    public long numcpus
    {
      get => this.numcpusField;
      private set => this.numcpusField = value;
    }

    public double pktcpuusagepcnt
    {
      get => this.pktcpuusagepcntField;
      private set => this.pktcpuusagepcntField = value;
    }

    public double voltagev5p
    {
      get => this.voltagev5pField;
      private set => this.voltagev5pField = value;
    }

    public double voltagevsen2
    {
      get => this.voltagevsen2Field;
      private set => this.voltagevsen2Field = value;
    }

    public double auxvolt0
    {
      get => this.auxvolt0Field;
      private set => this.auxvolt0Field = value;
    }

    public long auxtemp2
    {
      get => this.auxtemp2Field;
      private set => this.auxtemp2Field = value;
    }

    public long memsizemb
    {
      get => this.memsizembField;
      private set => this.memsizembField = value;
    }

    public double voltagev33main
    {
      get => this.voltagev33mainField;
      private set => this.voltagev33mainField = value;
    }

    public long cpu1temp
    {
      get => this.cpu1tempField;
      private set => this.cpu1tempField = value;
    }

    public double voltagev12n
    {
      get => this.voltagev12nField;
      private set => this.voltagev12nField = value;
    }

    public long memuseinmb
    {
      get => this.memuseinmbField;
      private set => this.memuseinmbField = value;
    }

    public long auxtemp3
    {
      get => this.auxtemp3Field;
      private set => this.auxtemp3Field = value;
    }

    public long internaltemp
    {
      get => this.internaltempField;
      private set => this.internaltempField = value;
    }

    public double voltagev12p
    {
      get => this.voltagev12pField;
      private set => this.voltagev12pField = value;
    }

    public long disk0avail
    {
      get => this.disk0availField;
      private set => this.disk0availField = value;
    }

    public double voltagev33stby
    {
      get => this.voltagev33stbyField;
      private set => this.voltagev33stbyField = value;
    }

    public double voltagevcc1
    {
      get => this.voltagevcc1Field;
      private set => this.voltagevcc1Field = value;
    }

    public long fan3speed
    {
      get => this.fan3speedField;
      private set => this.fan3speedField = value;
    }

    public double voltagevtt
    {
      get => this.voltagevttField;
      private set => this.voltagevttField = value;
    }

    public long auxtemp0
    {
      get => this.auxtemp0Field;
      private set => this.auxtemp0Field = value;
    }

    public long cpufan1speed
    {
      get => this.cpufan1speedField;
      private set => this.cpufan1speedField = value;
    }

    public double voltagevcc0
    {
      get => this.voltagevcc0Field;
      private set => this.voltagevcc0Field = value;
    }

    public double auxvolt4
    {
      get => this.auxvolt4Field;
      private set => this.auxvolt4Field = value;
    }

    public string starttime
    {
      get => this.starttimeField;
      private set => this.starttimeField = value;
    }

    public long systemfanspeed
    {
      get => this.systemfanspeedField;
      private set => this.systemfanspeedField = value;
    }

    public double cpuusagepcnt
    {
      get => this.cpuusagepcntField;
      private set => this.cpuusagepcntField = value;
    }

    public long mastercpuusage
    {
      get => this.mastercpuusageField;
      private set => this.mastercpuusageField = value;
    }

    public string timesincestart
    {
      get => this.timesincestartField;
      private set => this.timesincestartField = value;
    }

    public double auxvolt6
    {
      get => this.auxvolt6Field;
      private set => this.auxvolt6Field = value;
    }

    public long slavecpuusage
    {
      get => this.slavecpuusageField;
      private set => this.slavecpuusageField = value;
    }

    public double memusagepcnt
    {
      get => this.memusagepcntField;
      private set => this.memusagepcntField = value;
    }

    public string powersupply2status
    {
      get => this.powersupply2statusField;
      private set => this.powersupply2statusField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      system_stats[] systemStatsArray = new system_stats[1];
      system_stats.system_response systemResponse = new system_stats.system_response();
      system_stats.system_response resource = (system_stats.system_response) service.get_payload_formatter().string_to_resource(systemResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemStatsArray[0] = resource.system;
      return (base_resource[]) systemStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static system_stats get(nitro_service service) => ((system_stats[]) new system_stats().stat_resources(service, (options) null))[0];

    public static system_stats get(nitro_service service, options option) => ((system_stats[]) new system_stats().stat_resources(service, option))[0];

    private class system_response : base_response
    {
      public system_stats system = (system_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
