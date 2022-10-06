@ECHO OFF
ECHO Servis POM base


set testcategory=Login
set dllpath=C:\Users\hussamun\source\repos\ServisShoesProject\ServisShoesProject\bin\Debug\ServisShoesProject.dll
set SummaryReportPath=C:\Users\hussamun\source\repos\ServisShoesProject\ServisShoesProject\SummaryReportPath

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%SummaryReportPath%\muni.trx"

cd C:\Users\hussamun\source\repos\ServisShoesProject\ServisShoesProject\bin\Debug

TrxToHTML %SummaryReportPath%

PAUSE