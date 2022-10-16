@ECHO OFF
ECHO ServisShoesProject


set dllpath=C:\Users\MUNIRHUSSAIN\source\repos\munirhussain14922\ServisShoesProject\ServisShoesProject\bin\Debug\ServisShoesProject.dll
set SummaryReportPath=C:\Users\MUNIRHUSSAIN\source\repos\munirhussain14922\ServisShoesProject\ServisShoesProject\SummaryReportPath

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%SummaryReportPath%\MsTestReportServisShoes.trx"

cd C:\Users\MUNIRHUSSAIN\source\repos\munirhussain14922\ServisShoesProject\ServisShoesProject\bin\Debug

TrxToHTML %SummaryReportPath%

PAUSE