# Citrix Netscaler Universal Orchestrator
## Orchestrator

Orchestrator to manage certificates and keys on one to many VServers in Netscaler.  The integration supports Enrollment, Renewal, Inventory and Remove from Store.

<!-- add integration specific information below -->
*** 
**IIS Binding Orchestrator Configuration**

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
Name	|Descriptive name for the Store Type
Virtual Server	| When Enrolling, this can be a single or comma separated list of VServers in Netscaler to replace.
Key Pair| When Enrolling, this is the name of the Certificate that will be installed on Netscaler
