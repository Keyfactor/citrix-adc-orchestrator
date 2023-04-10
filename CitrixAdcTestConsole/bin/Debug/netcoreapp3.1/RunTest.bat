@echo off

cd C:\Users\bhill\source\repos\citrix-adc-orchestrator\CitrixAdcTestConsole\bin\Debug\netcoreapp3.1
set Machine=52.255.196.18
set ApiUser=bhill
set ApiPassword=Keyfactor2019!


echo ***********************************
echo Starting Single Firewall Test Cases
echo ***********************************

set clientmachine=%Machine%
set password=%ApiPassword%
set user=%ApiUser%
set storepath=/nsconfig/ssl/

echo ***********************************
echo Starting Management Test Cases
echo ***********************************
set casename=Management


set cert=%random%
set casename=Management
set mgt=add
set overwrite=false

goto bindingscenario
echo ************************************************************************************************************************
echo TC1 %mgt% add unbound certificate.  Should do the %mgt% and not bind the certificate to any virtual servers
echo ************************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername= -keypairname= -overwrite=%overwrite%


set cert=%random%
set casename=Management
set mgt=add
set overwrite=false

echo ************************************************************************************************************************
echo TC2 %mgt% add unbound certificate with Keypair Name.  Should do the %mgt% and not bind the certificate to any virtual servers
echo ************************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername= -overwrite=%overwrite%

set cert=%random%
set casename=Management
set mgt=add
set overwrite=false

echo ************************************************************************************************************************
echo TC3 %mgt% add bound certificate with Keypair Name.  Should do the %mgt% and not bind the certificate to any virtual servers
echo ************************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=TestVServer -overwrite=%overwrite%

:bindingscenario
set cert=%random%
set casename=Management
set mgt=add
set overwrite=true

echo ************************************************************************************************************************
echo TC3 %mgt% add bound certificate with Keypair Name.  Should do the %mgt% and not bind the certificate to any virtual servers
echo ************************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias="My Cert Lives on Netscaler in a test too" -virtualservername=TestVServer -overwrite=%overwrite%

set mgt=remove
set overwrite=false

echo:
echo *******************************************************************************************************
echo TC2 %mgt% remove unbound certificate.  Should %mgt% the cert.
echo *******************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=  -overwrite=%overwrite%

@pause
