# Citrix Netscaler Universal Orchestrator
## Orchestrator

Orchestrator to manage certificates and keys on one to many VServers in Netscaler.  The integration supports Enrollment, Renewal, Inventory and Remove from Store.

## Development Ready

<!-- add integration specific information below -->
*** 
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
