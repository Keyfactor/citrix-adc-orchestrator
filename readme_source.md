# Citrix ADC Orchestrator Configuration
## Overview

The Citrix ADC Orchestrator remotely manages certificates on the NetScaler device.  Since the ADC supports services including: 
Load Balancing, Authentication/Authorization/Auditing (AAA), and Gateways, this orchestrator can bind to any of these virtual servers when using unique virtual server names for each service.

<details>
  <summary>Cert Store Type Settings</summary>
<br />

![](Images/CertStoreTypeSettings.gif)

**Basic Settings**

CONFIG ELEMENT	| VALUE | DESCRIPTION
----------------|-------|------------
Name  |Citrix ADC	|A descriptive name for the extension.  Example:  CitrixAdc
Short Name|CitrixADC|The short name that identifies the registered functionality of the orchestrator. Must be CitrixAdc.
Custom Capability|Unchecked|Store type name orchestrator will register with.
Supported Job Types|Inventory, Add, Remove	|Job types this extension supports
Needs Server | Checked | Determines if a target server name is required when creating store
Blueprint Allowed | Unchecked | Determines if store type may be included in an Orchestrator blueprint
Uses PowerShell | Unchecked | Determines if underlying implementation is PowerShell
Requires Store Password|Unchecked |Determines if a store password is required when configuring an individual store.
Supports Entry Password|Unchecked |Determined if an individual entry within a store can have a password.

**Advanced Settings**

CONFIG ELEMENT	| VALUE | DESCRIPTION
----------------|-------|------------
Store Path Type	|Freeform	|Determines what restrictions are applied to the store path field when configuring a new store.
Supports Custom	Alias		|Required	|Determines if an individual entry within a store can have a custom Alias.
Private Keys	|Required	|This determines if Keyfactor can send the private key associated with a certificate to the store.  This is required since Citrix ADC will need the private key material to establish TLS connections.
PFX Password Style			|Default or Custom	|This determines how the platform generate passwords to protect a PFX enrollment job that is delivered to the store.

**Custom Fields**

Name|Display Name|Type|Default Value|Required|Description
---|---|---|---|---|---
ServerUsername|Server Username|Secret||No|The username to log into the Server
ServerPassword|Server Password|Secret||No|The password that matches the username to log into the Server
ServerUseSsl|Use SSL|Bool|True|Yes|Determine whether the server uses SSL or not

**Entry Parameters**

Name|Display Name|Type|Default Value|Required|Description
---|---|---|---|---|---
virtualServerName|Virtual Server Name|String| |Leave All Unchecked|When Enrolling, this can be a single or comma separated list of VServers in NetScaler to replace. <br/>**NOTE:** When adding multiple VServers, each certificate will contain the same alias name.
sniCert|SNI Cert|String|false|On Add|When multiple VServers are used, a comma separated value must be accompanied with each VServer name.

</details>

<details>
  <summary>Cert Store Setup</summary>
<br />

![](Images/CertStore.gif)

#### STORE CONFIG
CONFIG ELEMENT	| DESCRIPTION
----------------|------------
Client Machine	| This is the IP Address of the NetScaler Appliance.
Store Path| This is the path of the NetScaler Appliance.  /nsconfig/ssl/.
User| This is the user that will be authenticated against the NetScaler Appliance
Password| This is the password that will be authenticated against the NetScaler Appliance
Use SSL| This should be set to True in Production when there is a valid certificate.
Inventory Schedule| Set this for the appropriate inventory interval needed.

</details>

<details>
  <Summary>Permissions</Summary>
  <br/>

The NetScaler user needs permission to perform the following API calls:

API Endpoint|Methods
---|---
/nitro/v1/config/login|post
/nitro/v1/config/lbvserver| get
/nitro/v1/config/sslcertkey| get, update, add, delete
/nitro/v1/config/sslcertkey_service_binding| get, update, add, delete
/nitro/v1/config/systemfile| get, add, delete
</details>

<details>
  <summary>Integration Notes and Limitations</summary>

* Direct PFX Binding Inventory
	* In NetScaler you can directly Bind a Pfx file to a Virtual Server.  Keyfactor cannot inventory these because it does not have access to the password.  The recommended way to Import PFX Files in NetScaler is descibed in this [NetScaler Documentation](https://docs.netscaler.com/en-us/citrix-adc/12-1/ssl/ssl-certificates/export-existing-certs-keys.html#convert-ssl-certificates-for-import-or-export)

* Specifiy Multiple VServers and Sni Flags
	* When Binding to Multiple VServers and using Multiple SniFlags, you must use a comma separated list of values as described in Test Case 13 in the Test Cases Section.  This will change in future version, so each binding is a store in Keyfactor.

* Down Time When Replacing Certs
	* The orchestrator uses [NetScaler recommended methods](https://docs.netscaler.com/en-us/citrix-adc/12-1/ssl/ssl-certificates/add-group-certs.html) to replace bound certs which creates a sub second blip of downtime.  There is currently no way around this if you want readable keypair names.

* Removing Certs from Store
	* As defined in Test Cases 5 and 13 below, certificates that are bound to a server will not be removed.  This was done to limit the possibility of bringing production servers down.  Users are currently required to manually unbind the certificate from the server and then remove the cert using Command.  This requirement may change in a future version.

* Renewals
	* The renewal process will find the thumbprint of the cert on all VServers and renew them in all places.  See test cases #6 and #10 in the Test Cases section.
	
* AutoSave Config
	* A new config.json file in the extension folder contains the 'AutoSaveConfig' flag with a default value of 'N'.  When this flag is set to 'Y', successful configuration changes made by a management job will be automatically saved to disk; no interaction with the Citrix ADC UI is necessary.
	
	**NOTE:** Any changes in-process through the Citrix ADC UI will also be persisted to disk when a management job is performed and the AutoSaveConfig flag is set to 'Y'.

* Support for Virtual Authentication Servers & Gateways
	* When performing management operations to either of services, Users may enter the specific VServer name to complete the operation.

	**NOTE:** If multiple VServers share the same Alias, all VServers that share that alias will be updated.
</details>

<details>
  <summary>Upgrade Procedures</summary>
<br />

* Upgrade From v1.0.2 to v2.0.0
	* In the Keyfactor Command Database, run the following SQL Script to update the store types and store information [Upgrade Script](https://github.com/Keyfactor/citrix-adc-orchestrator/blob/snipamupdates/UpgradeScript.sql)
	
</details>

<details>
  <summary>Test Cases</summary>
<br />

Case Number|Case Name|Enrollment Params|Expected Results|Passed|Screenshot
----|------------------------|------------------------------------|--------------|----------------|-------------------------
1	|Add Unbound Cert|**Alias:** TC1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Adds New Unbound Cert To Citrix ADC|True|![](Images/TC1.gif)
2	|Remove Unbound Cert|**Alias:** TC1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Removes Unbound Cert From Citrix ADC|True|![](Images/TC2.gif)
3	|Add Bound Cert|**Alias:** TC3.boingy.com<br/>**Virtual Server Name:** TestVServer<br/>**Sni Cert:** false|Adds a new bound cert to TestVServer Virtual Server|True|![](Images/TC3.gif)
4	|Add Bound Cert Multiple VServers|**Alias:** TC4.boingy.com<br/>**Virtual Server Name:** TestVServer,TestVServer2<br/>**Sni Cert:** false,false|Adds New Bound Cert To Both Servers in Citrix|True|![](Images/TC4.gif)
5	|Remove Bound Cert|**Alias:** TC4.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Will Not Remove because it is bound.  Must Unbind it First|True|![](Images/TC5.gif)
6	|Renew Bound Cert|**Alias:** TC4.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Renews Bound Cert on Both VServers|True|![](Images/TC6.gif)
7	|Replace Bound Cert No Overwrite |**Alias:** TC4.boingy.com<br/>**Virtual Server Name:** TestVServer,TestVServer2<br/>**Sni Cert:** false,false|Will Not replace, overwrite flag needed|True|![](Images/TC7.gif)
8	|Replace Bound Cert with Overwrite|**Alias:** 16934<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Will do the replace because overwrite was used|True|![](Images/TC8.gif)
9	|Add Sni Cert and Bind|**Alias:** TC9.boingy.com<br/>**Virtual Server Name:** TestVServer<br/>**Sni Cert:** false|Will bind an additional SNI Cert to a VServer|True|![](Images/TC9.gif)
10	|Renew bound Sni Cert|**Alias:** TC10.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Will Renew the Sni Cert Bound to the Site|True|![](Images/TC10.gif)
11	|Replace bound Sni Cert with Overwrite|**Alias:** TC9.boingy.com<br/>**Virtual Server Name:** TestVServer<br/>**Sni Cert:** true|Sni Cert Will Be Replaced and bound|True|![](Images/TC11.gif)
12	|Remove Bound Sni Cert|**Alias:** TC9.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Will Not Remove because it is bound.  Must Unbind it First|True|![](Images/TC12.gif)
13	|Add Sni Cert To Multiple VServers and bind|**Alias:** TC13.boingy.com<br/>**Virtual Server Name:** TestVServer,TestVServer2<br/>**Sni Cert:** false,true|Adds and binds Cert to TestVServer and adds and binds Sni Cert to TestVServer2|True|![](Images/TC13.gif)
14	|Inventory |No Params|Will Perform Inventory and pull down all Certs Tied to VServers|True|![](Images/TC14.gif)

</details>
