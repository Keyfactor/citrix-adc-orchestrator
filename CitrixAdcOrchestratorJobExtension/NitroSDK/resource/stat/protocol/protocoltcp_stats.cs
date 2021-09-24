// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.protocol.protocoltcp_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.protocol
{
  public class protocoltcp_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long tcpactiveserverconnField = 0;
    private long tcpcurserverconnopeningField = 0;
    private long tcpcurclientconnopeningField = 0;
    private long tcpcurclientconnestablishedField = 0;
    private long tcpcurserverconnestablishedField = 0;
    private long tcptotrxpktsField = 0;
    private long tcprxpktsrateField = 0;
    private long tcptotrxbytesField = 0;
    private long tcprxbytesrateField = 0;
    private long tcptottxpktsField = 0;
    private long tcptxpktsrateField = 0;
    private long tcptottxbytesField = 0;
    private long tcptxbytesrateField = 0;
    private long tcpcurclientconnField = 0;
    private long tcpcurclientconnclosingField = 0;
    private long tcptotclientconnopenedField = 0;
    private long tcpclientconnopenedrateField = 0;
    private long tcpcurserverconnField = 0;
    private long tcpcurserverconnclosingField = 0;
    private long tcptotserverconnopenedField = 0;
    private long tcpserverconnopenedrateField = 0;
    private long tcpsurgequeuelenField = 0;
    private long tcpspareconnField = 0;
    private long tcptotzombiecltconnflushedField = 0;
    private long tcpzombiecltconnflushedrateField = 0;
    private long tcptotzombiehalfopencltconnflushedField = 0;
    private long tcpzombiehalfopencltconnflushedrateField = 0;
    private long tcptotzombieactivehalfclosecltconnflushedField = 0;
    private long tcpzombieactivehalfclosecltconnflushedrateField = 0;
    private long tcptotzombiepassivehalfclosecltconnflushedField = 0;
    private long tcpzombiepassivehalfclosecltconnflushedrateField = 0;
    private long tcptotzombiesvrconnflushedField = 0;
    private long tcpzombiesvrconnflushedrateField = 0;
    private long tcptotzombiehalfopensvrconnflushedField = 0;
    private long tcpzombiehalfopensvrconnflushedrateField = 0;
    private long tcptotzombieactivehalfclosesvrconnflushedField = 0;
    private long tcpzombieactivehalfclosesvrconnflushedrateField = 0;
    private long tcptotzombiepassivehalfclosesrvconnflushedField = 0;
    private long tcpzombiepassivehalfclosesrvconnflushedrateField = 0;
    private long pcbtotzombiecallField = 0;
    private long pcbzombiecallrateField = 0;
    private long tcptotsynField = 0;
    private long tcpsynrateField = 0;
    private long tcptotsynprobeField = 0;
    private long tcpsynproberateField = 0;
    private long tcptotsvrfinField = 0;
    private long tcpsvrfinrateField = 0;
    private long tcptotcltfinField = 0;
    private long tcpcltfinrateField = 0;
    private long tcpwaittosynField = 0;
    private long tcpwaittosynrateField = 0;
    private long tcpwaittodataField = 0;
    private long tcpwaittodatarateField = 0;
    private long tcptotsynheldField = 0;
    private long tcpsynheldrateField = 0;
    private long tcptotsynflushField = 0;
    private long tcpsynflushrateField = 0;
    private long tcptotfinwaitclosedField = 0;
    private long tcpfinwaitclosedrateField = 0;
    private long tcperrbadchecksumField = 0;
    private long tcperrbadchecksumrateField = 0;
    private long tcperrdataafterfinField = 0;
    private long tcperrdataafterfinrateField = 0;
    private long tcperrsyninsynrcvdField = 0;
    private long tcperrsyninsynrcvdrateField = 0;
    private long tcperrsyninestField = 0;
    private long tcperrsyninestrateField = 0;
    private long tcperrsynsentbadackField = 0;
    private long tcperrsynsentbadackrateField = 0;
    private long tcperrrstField = 0;
    private long tcperrrstrateField = 0;
    private long tcperrrstnonestField = 0;
    private long tcperrrstnonestrateField = 0;
    private long tcperrrstoutofwindowField = 0;
    private long tcperrrstoutofwindowrateField = 0;
    private long tcperrrstintimewaitField = 0;
    private long tcperrrstintimewaitrateField = 0;
    private long tcperrsvroutoforderField = 0;
    private long tcperrsvroutoforderrateField = 0;
    private long tcperrcltoutoforderField = 0;
    private long tcperrcltoutoforderrateField = 0;
    private long tcperrcltholeField = 0;
    private long tcperrcltholerateField = 0;
    private long tcperrsvrholeField = 0;
    private long tcperrsvrholerateField = 0;
    private long tcperrcookiepktseqrejectField = 0;
    private long tcperrcookiepktseqrejectrateField = 0;
    private long tcperrcookiepktsigrejectField = 0;
    private long tcperrcookiepktsigrejectrateField = 0;
    private long tcperrcookiepktseqdropField = 0;
    private long tcperrcookiepktseqdroprateField = 0;
    private long tcperrcookiepktmssrejectField = 0;
    private long tcperrcookiepktmssrejectrateField = 0;
    private long tcperranyportfailField = 0;
    private long tcperranyportfailrateField = 0;
    private long tcperripportfailField = 0;
    private long tcperripportfailrateField = 0;
    private long tcperrstraypktField = 0;
    private long tcperrstraypktrateField = 0;
    private long tcperrsentrstField = 0;
    private long tcperrsentrstrateField = 0;
    private long tcperrbadstateconnField = 0;
    private long tcperrbadstateconnrateField = 0;
    private long tcperrrstthresholdField = 0;
    private long tcperrrstthresholdrateField = 0;
    private long tcperroutofwindowpktsField = 0;
    private long tcperroutofwindowpktsrateField = 0;
    private long tcperrsyndroppedcongestionField = 0;
    private long tcperrsyndroppedcongestionrateField = 0;
    private long tcperrcltretrasmitField = 0;
    private long tcperrcltretrasmitrateField = 0;
    private long tcperrfullretrasmitField = 0;
    private long tcperrfullretrasmitrateField = 0;
    private long tcperrsynretryField = 0;
    private long tcperrsynretryrateField = 0;
    private long tcperrsyngiveupField = 0;
    private long tcperrsyngiveuprateField = 0;
    private long tcperrretransmitField = 0;
    private long tcperrretransmitrateField = 0;
    private long tcperrfirstretransmissionsField = 0;
    private long tcperrfirstretransmissionsrateField = 0;
    private long tcperrthirdretransmissionsField = 0;
    private long tcperrthirdretransmissionsrateField = 0;
    private long tcperrfifthretransmissionsField = 0;
    private long tcperrfifthretransmissionsrateField = 0;
    private long tcperrseventhretransmissionsField = 0;
    private long tcperrseventhretransmissionsrateField = 0;
    private long tcperrfastretransmissionsField = 0;
    private long tcperrfastretransmissionsrateField = 0;
    private long tcperrsvrretrasmitField = 0;
    private long tcperrsvrretrasmitrateField = 0;
    private long tcperrpartialretrasmitField = 0;
    private long tcperrpartialretrasmitrateField = 0;
    private long tcperrfinretryField = 0;
    private long tcperrfinretryrateField = 0;
    private long tcperrfingiveupField = 0;
    private long tcperrfingiveuprateField = 0;
    private long tcperrsecondretransmissionsField = 0;
    private long tcperrsecondretransmissionsrateField = 0;
    private long tcperrforthretransmissionsField = 0;
    private long tcperrforthretransmissionsrateField = 0;
    private long tcperrsixthretransmissionsField = 0;
    private long tcperrsixthretransmissionsrateField = 0;
    private long tcperrretransmitgiveupField = 0;
    private long tcperrretransmitgiveuprateField = 0;
    private long tcperrcipallocField = 0;
    private long tcperrcipallocrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long tcperrfingiveuprate
    {
      get => this.tcperrfingiveuprateField;
      private set => this.tcperrfingiveuprateField = value;
    }

    public long tcperrretransmit
    {
      get => this.tcperrretransmitField;
      private set => this.tcperrretransmitField = value;
    }

    public long tcperrcookiepktmssreject
    {
      get => this.tcperrcookiepktmssrejectField;
      private set => this.tcperrcookiepktmssrejectField = value;
    }

    public long tcptotzombiehalfopencltconnflushed
    {
      get => this.tcptotzombiehalfopencltconnflushedField;
      private set => this.tcptotzombiehalfopencltconnflushedField = value;
    }

    public long tcperrsentrstrate
    {
      get => this.tcperrsentrstrateField;
      private set => this.tcperrsentrstrateField = value;
    }

    public long tcperrcltoutoforder
    {
      get => this.tcperrcltoutoforderField;
      private set => this.tcperrcltoutoforderField = value;
    }

    public long tcpsurgequeuelen
    {
      get => this.tcpsurgequeuelenField;
      private set => this.tcpsurgequeuelenField = value;
    }

    public long tcperrcookiepktseqrejectrate
    {
      get => this.tcperrcookiepktseqrejectrateField;
      private set => this.tcperrcookiepktseqrejectrateField = value;
    }

    public long tcperrrstoutofwindowrate
    {
      get => this.tcperrrstoutofwindowrateField;
      private set => this.tcperrrstoutofwindowrateField = value;
    }

    public long tcptotrxpkts
    {
      get => this.tcptotrxpktsField;
      private set => this.tcptotrxpktsField = value;
    }

    public long tcpcurclientconnopening
    {
      get => this.tcpcurclientconnopeningField;
      private set => this.tcpcurclientconnopeningField = value;
    }

    public long tcperrcookiepktseqreject
    {
      get => this.tcperrcookiepktseqrejectField;
      private set => this.tcperrcookiepktseqrejectField = value;
    }

    public long tcperrforthretransmissionsrate
    {
      get => this.tcperrforthretransmissionsrateField;
      private set => this.tcperrforthretransmissionsrateField = value;
    }

    public long tcperrrst
    {
      get => this.tcperrrstField;
      private set => this.tcperrrstField = value;
    }

    public long tcpsvrfinrate
    {
      get => this.tcpsvrfinrateField;
      private set => this.tcpsvrfinrateField = value;
    }

    public long tcptxbytesrate
    {
      get => this.tcptxbytesrateField;
      private set => this.tcptxbytesrateField = value;
    }

    public long tcptotsyn
    {
      get => this.tcptotsynField;
      private set => this.tcptotsynField = value;
    }

    public long tcpserverconnopenedrate
    {
      get => this.tcpserverconnopenedrateField;
      private set => this.tcpserverconnopenedrateField = value;
    }

    public long tcperrsyninsynrcvdrate
    {
      get => this.tcperrsyninsynrcvdrateField;
      private set => this.tcperrsyninsynrcvdrateField = value;
    }

    public long tcperrpartialretrasmitrate
    {
      get => this.tcperrpartialretrasmitrateField;
      private set => this.tcperrpartialretrasmitrateField = value;
    }

    public long tcpzombieactivehalfclosecltconnflushedrate
    {
      get => this.tcpzombieactivehalfclosecltconnflushedrateField;
      private set => this.tcpzombieactivehalfclosecltconnflushedrateField = value;
    }

    public long tcperrfinretry
    {
      get => this.tcperrfinretryField;
      private set => this.tcperrfinretryField = value;
    }

    public long tcperrsvroutoforderrate
    {
      get => this.tcperrsvroutoforderrateField;
      private set => this.tcperrsvroutoforderrateField = value;
    }

    public long pcbzombiecallrate
    {
      get => this.pcbzombiecallrateField;
      private set => this.pcbzombiecallrateField = value;
    }

    public long tcperrfirstretransmissionsrate
    {
      get => this.tcperrfirstretransmissionsrateField;
      private set => this.tcperrfirstretransmissionsrateField = value;
    }

    public long tcperrstraypkt
    {
      get => this.tcperrstraypktField;
      private set => this.tcperrstraypktField = value;
    }

    public long tcperrsyninsynrcvd
    {
      get => this.tcperrsyninsynrcvdField;
      private set => this.tcperrsyninsynrcvdField = value;
    }

    public long tcprxbytesrate
    {
      get => this.tcprxbytesrateField;
      private set => this.tcprxbytesrateField = value;
    }

    public long tcpcurserverconnestablished
    {
      get => this.tcpcurserverconnestablishedField;
      private set => this.tcpcurserverconnestablishedField = value;
    }

    public long tcperroutofwindowpktsrate
    {
      get => this.tcperroutofwindowpktsrateField;
      private set => this.tcperroutofwindowpktsrateField = value;
    }

    public long tcperranyportfailrate
    {
      get => this.tcperranyportfailrateField;
      private set => this.tcperranyportfailrateField = value;
    }

    public long tcpsynproberate
    {
      get => this.tcpsynproberateField;
      private set => this.tcpsynproberateField = value;
    }

    public long tcpzombiesvrconnflushedrate
    {
      get => this.tcpzombiesvrconnflushedrateField;
      private set => this.tcpzombiesvrconnflushedrateField = value;
    }

    public long tcpcurclientconn
    {
      get => this.tcpcurclientconnField;
      private set => this.tcpcurclientconnField = value;
    }

    public long tcperrsyninestrate
    {
      get => this.tcperrsyninestrateField;
      private set => this.tcperrsyninestrateField = value;
    }

    public long tcpcurserverconn
    {
      get => this.tcpcurserverconnField;
      private set => this.tcpcurserverconnField = value;
    }

    public long tcperripportfailrate
    {
      get => this.tcperripportfailrateField;
      private set => this.tcperripportfailrateField = value;
    }

    public long tcperrcookiepktsigrejectrate
    {
      get => this.tcperrcookiepktsigrejectrateField;
      private set => this.tcperrcookiepktsigrejectrateField = value;
    }

    public long tcperrforthretransmissions
    {
      get => this.tcperrforthretransmissionsField;
      private set => this.tcperrforthretransmissionsField = value;
    }

    public long tcpzombiehalfopensvrconnflushedrate
    {
      get => this.tcpzombiehalfopensvrconnflushedrateField;
      private set => this.tcpzombiehalfopensvrconnflushedrateField = value;
    }

    public long tcperrsixthretransmissions
    {
      get => this.tcperrsixthretransmissionsField;
      private set => this.tcperrsixthretransmissionsField = value;
    }

    public long tcpfinwaitclosedrate
    {
      get => this.tcpfinwaitclosedrateField;
      private set => this.tcpfinwaitclosedrateField = value;
    }

    public long tcperrbadchecksum
    {
      get => this.tcperrbadchecksumField;
      private set => this.tcperrbadchecksumField = value;
    }

    public long tcpsynflushrate
    {
      get => this.tcpsynflushrateField;
      private set => this.tcpsynflushrateField = value;
    }

    public long tcperrcipallocrate
    {
      get => this.tcperrcipallocrateField;
      private set => this.tcperrcipallocrateField = value;
    }

    public long tcperrrstthreshold
    {
      get => this.tcperrrstthresholdField;
      private set => this.tcperrrstthresholdField = value;
    }

    public long tcptotzombieactivehalfclosecltconnflushed
    {
      get => this.tcptotzombieactivehalfclosecltconnflushedField;
      private set => this.tcptotzombieactivehalfclosecltconnflushedField = value;
    }

    public long tcperrsynsentbadackrate
    {
      get => this.tcperrsynsentbadackrateField;
      private set => this.tcperrsynsentbadackrateField = value;
    }

    public long tcpwaittodatarate
    {
      get => this.tcpwaittodatarateField;
      private set => this.tcpwaittodatarateField = value;
    }

    public long tcperrseventhretransmissionsrate
    {
      get => this.tcperrseventhretransmissionsrateField;
      private set => this.tcperrseventhretransmissionsrateField = value;
    }

    public long tcperrretransmitrate
    {
      get => this.tcperrretransmitrateField;
      private set => this.tcperrretransmitrateField = value;
    }

    public long tcperrfullretrasmitrate
    {
      get => this.tcperrfullretrasmitrateField;
      private set => this.tcperrfullretrasmitrateField = value;
    }

    public long tcptotsynflush
    {
      get => this.tcptotsynflushField;
      private set => this.tcptotsynflushField = value;
    }

    public long tcperrsixthretransmissionsrate
    {
      get => this.tcperrsixthretransmissionsrateField;
      private set => this.tcperrsixthretransmissionsrateField = value;
    }

    public long tcperrfastretransmissions
    {
      get => this.tcperrfastretransmissionsField;
      private set => this.tcperrfastretransmissionsField = value;
    }

    public long tcperrsecondretransmissionsrate
    {
      get => this.tcperrsecondretransmissionsrateField;
      private set => this.tcperrsecondretransmissionsrateField = value;
    }

    public long tcpzombiepassivehalfclosecltconnflushedrate
    {
      get => this.tcpzombiepassivehalfclosecltconnflushedrateField;
      private set => this.tcpzombiepassivehalfclosecltconnflushedrateField = value;
    }

    public long tcpcltfinrate
    {
      get => this.tcpcltfinrateField;
      private set => this.tcpcltfinrateField = value;
    }

    public long tcpsynheldrate
    {
      get => this.tcpsynheldrateField;
      private set => this.tcpsynheldrateField = value;
    }

    public long tcperrrstnonestrate
    {
      get => this.tcperrrstnonestrateField;
      private set => this.tcperrrstnonestrateField = value;
    }

    public long tcperrcltretrasmit
    {
      get => this.tcperrcltretrasmitField;
      private set => this.tcperrcltretrasmitField = value;
    }

    public long tcptotsynprobe
    {
      get => this.tcptotsynprobeField;
      private set => this.tcptotsynprobeField = value;
    }

    public long tcptotfinwaitclosed
    {
      get => this.tcptotfinwaitclosedField;
      private set => this.tcptotfinwaitclosedField = value;
    }

    public long tcpzombiepassivehalfclosesrvconnflushedrate
    {
      get => this.tcpzombiepassivehalfclosesrvconnflushedrateField;
      private set => this.tcpzombiepassivehalfclosesrvconnflushedrateField = value;
    }

    public long tcperrsynsentbadack
    {
      get => this.tcperrsynsentbadackField;
      private set => this.tcperrsynsentbadackField = value;
    }

    public long tcptotsynheld
    {
      get => this.tcptotsynheldField;
      private set => this.tcptotsynheldField = value;
    }

    public long tcperrrstintimewaitrate
    {
      get => this.tcperrrstintimewaitrateField;
      private set => this.tcperrrstintimewaitrateField = value;
    }

    public long tcperrrstintimewait
    {
      get => this.tcperrrstintimewaitField;
      private set => this.tcperrrstintimewaitField = value;
    }

    public long tcperrthirdretransmissions
    {
      get => this.tcperrthirdretransmissionsField;
      private set => this.tcperrthirdretransmissionsField = value;
    }

    public long tcptotrxbytes
    {
      get => this.tcptotrxbytesField;
      private set => this.tcptotrxbytesField = value;
    }

    public long tcperrsvrretrasmit
    {
      get => this.tcperrsvrretrasmitField;
      private set => this.tcperrsvrretrasmitField = value;
    }

    public long tcperrfastretransmissionsrate
    {
      get => this.tcperrfastretransmissionsrateField;
      private set => this.tcperrfastretransmissionsrateField = value;
    }

    public long tcptotzombiepassivehalfclosecltconnflushed
    {
      get => this.tcptotzombiepassivehalfclosecltconnflushedField;
      private set => this.tcptotzombiepassivehalfclosecltconnflushedField = value;
    }

    public long tcperrcltholerate
    {
      get => this.tcperrcltholerateField;
      private set => this.tcperrcltholerateField = value;
    }

    public long tcperrsvroutoforder
    {
      get => this.tcperrsvroutoforderField;
      private set => this.tcperrsvroutoforderField = value;
    }

    public long tcprxpktsrate
    {
      get => this.tcprxpktsrateField;
      private set => this.tcprxpktsrateField = value;
    }

    public long tcptotclientconnopened
    {
      get => this.tcptotclientconnopenedField;
      private set => this.tcptotclientconnopenedField = value;
    }

    public long tcperrstraypktrate
    {
      get => this.tcperrstraypktrateField;
      private set => this.tcperrstraypktrateField = value;
    }

    public long tcperrfinretryrate
    {
      get => this.tcperrfinretryrateField;
      private set => this.tcperrfinretryrateField = value;
    }

    public long tcptotserverconnopened
    {
      get => this.tcptotserverconnopenedField;
      private set => this.tcptotserverconnopenedField = value;
    }

    public long tcperrretransmitgiveup
    {
      get => this.tcperrretransmitgiveupField;
      private set => this.tcperrretransmitgiveupField = value;
    }

    public long tcperrthirdretransmissionsrate
    {
      get => this.tcperrthirdretransmissionsrateField;
      private set => this.tcperrthirdretransmissionsrateField = value;
    }

    public long tcpwaittosyn
    {
      get => this.tcpwaittosynField;
      private set => this.tcpwaittosynField = value;
    }

    public long tcperrsyndroppedcongestion
    {
      get => this.tcperrsyndroppedcongestionField;
      private set => this.tcperrsyndroppedcongestionField = value;
    }

    public long tcperrfingiveup
    {
      get => this.tcperrfingiveupField;
      private set => this.tcperrfingiveupField = value;
    }

    public long tcptotsvrfin
    {
      get => this.tcptotsvrfinField;
      private set => this.tcptotsvrfinField = value;
    }

    public long tcperrcltretrasmitrate
    {
      get => this.tcperrcltretrasmitrateField;
      private set => this.tcperrcltretrasmitrateField = value;
    }

    public long tcperrcookiepktmssrejectrate
    {
      get => this.tcperrcookiepktmssrejectrateField;
      private set => this.tcperrcookiepktmssrejectrateField = value;
    }

    public long tcperrsvrretrasmitrate
    {
      get => this.tcperrsvrretrasmitrateField;
      private set => this.tcperrsvrretrasmitrateField = value;
    }

    public long tcpcurserverconnclosing
    {
      get => this.tcpcurserverconnclosingField;
      private set => this.tcpcurserverconnclosingField = value;
    }

    public long tcperrrstrate
    {
      get => this.tcperrrstrateField;
      private set => this.tcperrrstrateField = value;
    }

    public long tcperrfifthretransmissionsrate
    {
      get => this.tcperrfifthretransmissionsrateField;
      private set => this.tcperrfifthretransmissionsrateField = value;
    }

    public long tcperrdataafterfin
    {
      get => this.tcperrdataafterfinField;
      private set => this.tcperrdataafterfinField = value;
    }

    public long tcperrsvrhole
    {
      get => this.tcperrsvrholeField;
      private set => this.tcperrsvrholeField = value;
    }

    public long tcperrsyngiveup
    {
      get => this.tcperrsyngiveupField;
      private set => this.tcperrsyngiveupField = value;
    }

    public long tcperrfirstretransmissions
    {
      get => this.tcperrfirstretransmissionsField;
      private set => this.tcperrfirstretransmissionsField = value;
    }

    public long tcptotzombiesvrconnflushed
    {
      get => this.tcptotzombiesvrconnflushedField;
      private set => this.tcptotzombiesvrconnflushedField = value;
    }

    public long tcperrsynretryrate
    {
      get => this.tcperrsynretryrateField;
      private set => this.tcperrsynretryrateField = value;
    }

    public long tcperrcookiepktsigreject
    {
      get => this.tcperrcookiepktsigrejectField;
      private set => this.tcperrcookiepktsigrejectField = value;
    }

    public long tcperroutofwindowpkts
    {
      get => this.tcperroutofwindowpktsField;
      private set => this.tcperroutofwindowpktsField = value;
    }

    public long tcperrcookiepktseqdrop
    {
      get => this.tcperrcookiepktseqdropField;
      private set => this.tcperrcookiepktseqdropField = value;
    }

    public long tcperrbadstateconnrate
    {
      get => this.tcperrbadstateconnrateField;
      private set => this.tcperrbadstateconnrateField = value;
    }

    public long tcperrsyndroppedcongestionrate
    {
      get => this.tcperrsyndroppedcongestionrateField;
      private set => this.tcperrsyndroppedcongestionrateField = value;
    }

    public long tcperrsvrholerate
    {
      get => this.tcperrsvrholerateField;
      private set => this.tcperrsvrholerateField = value;
    }

    public long tcperrdataafterfinrate
    {
      get => this.tcperrdataafterfinrateField;
      private set => this.tcperrdataafterfinrateField = value;
    }

    public long tcperrcltoutoforderrate
    {
      get => this.tcperrcltoutoforderrateField;
      private set => this.tcperrcltoutoforderrateField = value;
    }

    public long tcptotzombiepassivehalfclosesrvconnflushed
    {
      get => this.tcptotzombiepassivehalfclosesrvconnflushedField;
      private set => this.tcptotzombiepassivehalfclosesrvconnflushedField = value;
    }

    public long tcperrsyninest
    {
      get => this.tcperrsyninestField;
      private set => this.tcperrsyninestField = value;
    }

    public long tcperrsecondretransmissions
    {
      get => this.tcperrsecondretransmissionsField;
      private set => this.tcperrsecondretransmissionsField = value;
    }

    public long tcperrbadstateconn
    {
      get => this.tcperrbadstateconnField;
      private set => this.tcperrbadstateconnField = value;
    }

    public long tcpspareconn
    {
      get => this.tcpspareconnField;
      private set => this.tcpspareconnField = value;
    }

    public long tcperrretransmitgiveuprate
    {
      get => this.tcperrretransmitgiveuprateField;
      private set => this.tcperrretransmitgiveuprateField = value;
    }

    public long tcptottxpkts
    {
      get => this.tcptottxpktsField;
      private set => this.tcptottxpktsField = value;
    }

    public long tcptotcltfin
    {
      get => this.tcptotcltfinField;
      private set => this.tcptotcltfinField = value;
    }

    public long tcpsynrate
    {
      get => this.tcpsynrateField;
      private set => this.tcpsynrateField = value;
    }

    public long tcpclientconnopenedrate
    {
      get => this.tcpclientconnopenedrateField;
      private set => this.tcpclientconnopenedrateField = value;
    }

    public long tcperranyportfail
    {
      get => this.tcperranyportfailField;
      private set => this.tcperranyportfailField = value;
    }

    public long tcpwaittosynrate
    {
      get => this.tcpwaittosynrateField;
      private set => this.tcpwaittosynrateField = value;
    }

    public long tcperrrstnonest
    {
      get => this.tcperrrstnonestField;
      private set => this.tcperrrstnonestField = value;
    }

    public long tcperripportfail
    {
      get => this.tcperripportfailField;
      private set => this.tcperripportfailField = value;
    }

    public long tcperrpartialretrasmit
    {
      get => this.tcperrpartialretrasmitField;
      private set => this.tcperrpartialretrasmitField = value;
    }

    public long tcpzombieactivehalfclosesvrconnflushedrate
    {
      get => this.tcpzombieactivehalfclosesvrconnflushedrateField;
      private set => this.tcpzombieactivehalfclosesvrconnflushedrateField = value;
    }

    public long tcperrclthole
    {
      get => this.tcperrcltholeField;
      private set => this.tcperrcltholeField = value;
    }

    public long tcpcurclientconnestablished
    {
      get => this.tcpcurclientconnestablishedField;
      private set => this.tcpcurclientconnestablishedField = value;
    }

    public long tcpwaittodata
    {
      get => this.tcpwaittodataField;
      private set => this.tcpwaittodataField = value;
    }

    public long tcperrsentrst
    {
      get => this.tcperrsentrstField;
      private set => this.tcperrsentrstField = value;
    }

    public long tcperrsyngiveuprate
    {
      get => this.tcperrsyngiveuprateField;
      private set => this.tcperrsyngiveuprateField = value;
    }

    public long tcperrbadchecksumrate
    {
      get => this.tcperrbadchecksumrateField;
      private set => this.tcperrbadchecksumrateField = value;
    }

    public long tcperrcookiepktseqdroprate
    {
      get => this.tcperrcookiepktseqdroprateField;
      private set => this.tcperrcookiepktseqdroprateField = value;
    }

    public long tcperrseventhretransmissions
    {
      get => this.tcperrseventhretransmissionsField;
      private set => this.tcperrseventhretransmissionsField = value;
    }

    public long tcperrrstoutofwindow
    {
      get => this.tcperrrstoutofwindowField;
      private set => this.tcperrrstoutofwindowField = value;
    }

    public long tcpcurserverconnopening
    {
      get => this.tcpcurserverconnopeningField;
      private set => this.tcpcurserverconnopeningField = value;
    }

    public long tcptotzombieactivehalfclosesvrconnflushed
    {
      get => this.tcptotzombieactivehalfclosesvrconnflushedField;
      private set => this.tcptotzombieactivehalfclosesvrconnflushedField = value;
    }

    public long tcperrfullretrasmit
    {
      get => this.tcperrfullretrasmitField;
      private set => this.tcperrfullretrasmitField = value;
    }

    public long tcperrcipalloc
    {
      get => this.tcperrcipallocField;
      private set => this.tcperrcipallocField = value;
    }

    public long tcptotzombiecltconnflushed
    {
      get => this.tcptotzombiecltconnflushedField;
      private set => this.tcptotzombiecltconnflushedField = value;
    }

    public long tcptotzombiehalfopensvrconnflushed
    {
      get => this.tcptotzombiehalfopensvrconnflushedField;
      private set => this.tcptotzombiehalfopensvrconnflushedField = value;
    }

    public long pcbtotzombiecall
    {
      get => this.pcbtotzombiecallField;
      private set => this.pcbtotzombiecallField = value;
    }

    public long tcpactiveserverconn
    {
      get => this.tcpactiveserverconnField;
      private set => this.tcpactiveserverconnField = value;
    }

    public long tcperrsynretry
    {
      get => this.tcperrsynretryField;
      private set => this.tcperrsynretryField = value;
    }

    public long tcptottxbytes
    {
      get => this.tcptottxbytesField;
      private set => this.tcptottxbytesField = value;
    }

    public long tcpcurclientconnclosing
    {
      get => this.tcpcurclientconnclosingField;
      private set => this.tcpcurclientconnclosingField = value;
    }

    public long tcperrrstthresholdrate
    {
      get => this.tcperrrstthresholdrateField;
      private set => this.tcperrrstthresholdrateField = value;
    }

    public long tcperrfifthretransmissions
    {
      get => this.tcperrfifthretransmissionsField;
      private set => this.tcperrfifthretransmissionsField = value;
    }

    public long tcpzombiehalfopencltconnflushedrate
    {
      get => this.tcpzombiehalfopencltconnflushedrateField;
      private set => this.tcpzombiehalfopencltconnflushedrateField = value;
    }

    public long tcpzombiecltconnflushedrate
    {
      get => this.tcpzombiecltconnflushedrateField;
      private set => this.tcpzombiecltconnflushedrateField = value;
    }

    public long tcptxpktsrate
    {
      get => this.tcptxpktsrateField;
      private set => this.tcptxpktsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      protocoltcp_stats[] protocoltcpStatsArray = new protocoltcp_stats[1];
      protocoltcp_stats.protocoltcp_response protocoltcpResponse = new protocoltcp_stats.protocoltcp_response();
      protocoltcp_stats.protocoltcp_response resource = (protocoltcp_stats.protocoltcp_response) service.get_payload_formatter().string_to_resource(protocoltcpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      protocoltcpStatsArray[0] = resource.protocoltcp;
      return (base_resource[]) protocoltcpStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static protocoltcp_stats get(nitro_service service) => ((protocoltcp_stats[]) new protocoltcp_stats().stat_resources(service, (options) null))[0];

    public static protocoltcp_stats get(nitro_service service, options option) => ((protocoltcp_stats[]) new protocoltcp_stats().stat_resources(service, option))[0];

    private class protocoltcp_response : base_response
    {
      public protocoltcp_stats protocoltcp = (protocoltcp_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
