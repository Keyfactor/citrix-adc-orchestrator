2.2.0
* Removed the ability to manage certificate/key file combinations uploaded but not yet installed on the Citrix ADC device.  This was done due to issues centered around inconsistent naming of uploaded certificate and key files.  From this release forward only installed certificate objects will be managed by this orchestrator extension.
* Modify process for renewing certificates to create new certificate/key files instead of deleting/re-adding existing so that no sub second outage occurs
* Modify process for linking certificates to existing issuing CA certificate to match all possible linkages
* Modify process for linking certificates to handle renewals of prior linked certificate when a new issuing certificate is used for the renewed certificate
* Modify README to use doctool

2.1.2
* Fix bug identifying private key entry when certificate and key file names differ

2.1.1
* Fix issue identifying whether inventoried certificate contains a private key.
* Renewing Unbound Certificates Causes The Job To Fail

2.1.0
* Added new Custom Field, Link To Issuer, to identify if Managment-Add jobs should attempt to link an added certificate to its issuing certificate if it resides in Netscaler.
  
2.0.1
* Fixed Issue with Inventory when VServer Cannot be retreived by Citrix API

2.0.0
* Added AutoSave Configuration (default set to false)
* Added PAM Support
* Added Sni Certificate Support
* Certificate Alias Changes (Use Alias From Keyfactor)
* Removed Nitro Library Source Code

1.0.2
* Initial Version
