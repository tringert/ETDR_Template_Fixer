@ECHO OFF

REM -- Copy binaries from VS project
xcopy ..\PlaceHolder_Fixer_Setup\Debug\* binaries\ /Y

REM -- Adding the "Run application after setup" option
scripts\EnableLaunchApplication.js binaries\PlaceHolder_Fixer_Setup.msi

REM -- Changing msi packages' language
wscript.exe scripts\wilangid.vbs binaries\PlaceHolder_Fixer_Setup.msi Package 1038
wscript.exe scripts\wilangid.vbs binaries\PlaceHolder_Fixer_Setup.msi Product 1038
wscript.exe scripts\wilangid.vbs binaries\PlaceHolder_Fixer_Setup.msi CodePage 1250

REM -- Adding summary info to msi package
scripts\wisuminf.vbs binaries\PlaceHolder_Fixer_Setup.msi Codepage=1250 Title="ÉTDR sablon helykitöltõ javító" Comments="ÉTDR sablon helykitöltõ javító"

REM -- Transform the msi to make hungarian locale
wscript.exe scripts\wiusexfm.vbs binaries\PlaceHolder_Fixer_Setup.msi Transform\Orca_Transform_Hu-hu_ETDR_helykitolto_with_run_after_install.mst

REM -- Adding setup binaries to a 7-zip archive package
"c:\Program Files\7-Zip\7z.exe" a -t7z installer.7z .\binaries\*

REM -- Create sfx self-extraction package
copy /b sfx\7zsd.sfx + sfx\config.txt + installer.7z ETDR_template_fixer.exe

REM -- Change sfx exe resources
"c:\Program Files (x86)\Resource Hacker\ResourceHacker.exe" -script scripts\Change_all_resources.txt

REM -- Clean up
del ETDR_template_fixer.exe
del installer.7z
