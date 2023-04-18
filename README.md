# Citrix Netscaler Universal Orchestrator

Orchestrator to manage certificates and keys on one to many VServers in Netscaler.  The integration supports Enrollment, Renewal, Inventory and Remove from Store.

#### Integration status: Production - Ready for use in production environments.

## About the Keyfactor Universal Orchestrator Extension

This repository contains a Universal Orchestrator Extension which is a plugin to the Keyfactor Universal Orchestrator. Within the Keyfactor Platform, Orchestrators are used to manage “certificate stores” &mdash; collections of certificates and roots of trust that are found within and used by various applications.

The Universal Orchestrator is part of the Keyfactor software distribution and is available via the Keyfactor customer portal. For general instructions on installing Extensions, see the “Keyfactor Command Orchestrator Installation and Configuration Guide” section of the Keyfactor documentation. For configuration details of this specific Extension see below in this readme.

The Universal Orchestrator is the successor to the Windows Orchestrator. This Orchestrator Extension plugin only works with the Universal Orchestrator and does not work with the Windows Orchestrator.



## Support for Citrix Netscaler Universal Orchestrator

Citrix Netscaler Universal Orchestrator is supported by Keyfactor for Keyfactor customers. If you have a support issue, please open a support ticket with your Keyfactor representative.

###### To report a problem or suggest a new feature, use the **[Issues](../../issues)** tab. If you want to contribute actual bug fixes or proposed enhancements, use the **[Pull requests](../../pulls)** tab.
___



---




---


**Netscaler Cert Store Type Setup**

*1. Cert Store Type Basic Settings*

![](Images/CertStoreType-Basic.gif)

*2. Cert Store Type Advanced Settings*
![](Images/CertStoreType-Advanced.gif)

*3. Cert Store Type Custom Fields*
![](Images/CertStoreType-CustomFields.gif)

*4. Cert Store Type Entry Params - Virtual Server*
![](Images/CertStoreType-VServerEntry.gif)

*5. Cert Store Type Entry Params - KPEntry*
![](Images/CertStoreType-KPEntry.gif)

#### STORE TYPE ENTRY PARAMS
CONFIG ELEMENT	| DESCRIPTION
------------------|------------------
Virtual Server	| When Enrolling, this can be a single or comma separated list of VServers in Netscaler to replace.
Key Pair| When Enrolling, this is the name of the Certificate that will be installed on Netscaler

**Netscaler Cert Store Setup**

*1. Cert Store Base Settings*

![](Images/CertStore-Base.gif)

*2. Cert Store Credential Setup*

![](Images/CertStore-Credentials.gif)

#### STORE CONFIG
CONFIG ELEMENT	| DESCRIPTION
------------------|------------------
Client Machine	| This is the IP Address of the Netscaler Appliance.
Store Path| This is the path of the Netscaler Appliance.  The value shown in the screenshot is the default path.
User| This is the user that will be authenticated against the Netscaler Appliance
Password| This is the password that will be authenticated against the Netscaler Appliance

**Netscaler permissions needed**

The Netscaler user needs permission to perform the following API calls:

API Endpoint|Methods
---|---
/nitro/v1/config/login|post
/nitro/v1/config/lbvserver| get
/nitro/v1/config/sslcertkey| get, update, add, delete
/nitro/v1/config/sslcertkey_service_binding| get, update, add, delete
/nitro/v1/config/systemfile| get, add, delete

**Enrollment Multiple Virtual Servers**

This will enroll the certificate and bind it to multiple VServers.  If you just want one VServer then include that one Server without commas.

*1. Comma Separate the VServers*

![](Images/EnrollMultipleVServers.gif)

![](Images/EnrollMultipleServersNetscaler.gif)

**Renewal**

This will renew the certificate and update all of the VServer Bindings on Netscaler that have that same thumbprint.

![](Images/Renewal.gif)

**Inventory**

This will inventory the certs on the Netscaler appliance and also update the entry parameters back into Keyfactor.

![](Images/Inventory.gif)

**Remove From Store**

This will remove it from the store on Keyfactor and deleted the associated certificate file on Netscaler.  It will leave the Key Pair and Key on Netscaler.
You should not need to specify a VServer or KPair for removal.  This can be setup in the configuration of Keyfactor to not be needed for removal.

![](Images/Remove.gif)

