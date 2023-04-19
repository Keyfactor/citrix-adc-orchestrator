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

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername= -overwrite=%overwrite% -isrenew=false -snicert=false -domain=citrixadc.boingy.com
set mgt=remove
set overwrite=false

echo ************************************************************************************************************************
echo TC2 %mgt% unbound cert.  Should %mgt% the cert in Test Case 1 with no issues because it is not bound
echo ************************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername= -overwrite=%overwrite% -isrenew=false -snicert=false -domain=citrixadc.boingy.com

set cert=%random%
set mgt=add
set overwrite=false

echo ************************************************************************************************************************
echo TC3 %mgt% add bound certificate with Alias.  Should do the %mgt% and bind the certificate to one virtual server
echo ************************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=TestVServer -overwrite=%overwrite% -isrenew=false -snicert=false -domain=citrixadc.boingy.com

set cert=%random%
set casename=Management
set mgt=add
set overwrite=true

echo ************************************************************************************************************************
echo TC4 %mgt% add multiple bound certificate with Alias.  Should do the %mgt% and bind the certificate to many virtual servers
echo ************************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=TestVServer,TestVServer2 -overwrite=%overwrite% -isrenew=false -snicert=false -domain=citrixadc.boingy.com

set mgt=remove
set overwrite=false

echo:
echo *******************************************************************************************************
echo TC5 %mgt% remove bound certificate.  Should not %mgt% the cert and give error, b/c it is bound.
echo *******************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=  -overwrite=%overwrite% -isrenew=false -snicert=false -domain=citrixadc.boingy.com

set mgt=add
set overwrite=true

echo:
echo *******************************************************************************************************
echo TC6 %mgt% renew bound certificate.  Should %mgt% the cert and renew it to the two bindings in TC4
echo *******************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=  -overwrite=%overwrite% -isrenew=true -snicert=false -domain=citrixadc.boingy.com

set mgt=add
set overwrite=false

echo:
echo *******************************************************************************************************
echo TC7 %mgt% replace cert without overwrite flag, should warn you to use overwrite flag.
echo *******************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=  -overwrite=%overwrite% -isrenew=false -snicert=false -domain=citrixadc.boingy.com

set mgt=add
set overwrite=true

echo:
echo *******************************************************************************************************
echo TC8 %mgt% replace cert with overwrite flag, should replace the certificate.
echo *******************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=  -overwrite=%overwrite% -isrenew=false -snicert=false -domain=citrixadc.boingy.com

:bindingscenario
set mgt=add
set overwrite=false
set cert=%random%

echo ************************************************************************************************************************
echo TC9 %mgt% add bound certificate with Alias Sni.  Should do the %mgt% and bind the sni certificate to one virtual server
echo ************************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=TestVServer2 -overwrite=%overwrite% -isrenew=false -snicert=true -domain=sni.boingy.com

set mgt=add
set overwrite=true

echo ***********************************************************************************************************************
echo TC10 %mgt% renew bound cert with Alias Sni.  Should do the %mgt% and bind the sni certificate to one virtual server
echo ***********************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=TestVServer2 -overwrite=%overwrite% -isrenew=true -snicert=true -domain=sni.boingy.com

set mgt=add
set overwrite=true

echo ***********************************************************************************************************************
echo TC11 %mgt% replace bound cert with Alias Sni.  Should do the %mgt% and bind the sni certificate to one virtual server
echo ***********************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=TestVServer2 -overwrite=%overwrite% -isrenew=false -snicert=true -domain=sni.boingy.com

set mgt=remove
set overwrite=true

echo ***********************************************************************************************************************
echo TC12 %mgt% remove bound cert with Alias Sni.  Should not allow the %mgt% since it is bound
echo ***********************************************************************************************************************
echo overwrite: %overwrite%
echo cert name: %cert%

CitrixAdcTestConsole.exe -clientmachine=%clientmachine% -casename=%casename% -user=%user% -password=%password% -storepath=%storepath% -managementtype=%mgt% -certalias=%cert% -virtualservername=TestVServer2 -overwrite=%overwrite% -isrenew=false -snicert=true -domain=sni.boingy.com
@pause
