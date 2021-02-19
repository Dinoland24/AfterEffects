@ECHO OFF
Setlocal enabledelayedexpansion
REM SET /P Name=Enter project name: 

:: Looking for AERENDER.EXE in PROGRAM Files
pushd D:\"WindowsInstallations\Adobe"
for /F "delims=" %%I in ('dir /S /B "aerender.exe"') do (
 SET Command="%%I"
)
popd

:: Looking for WINRAR.EXE in PROGRAM Files
pushd C:\"Program Files"
for /F "delims=" %%H in ('dir /S /B "winrar.exe"') do (
 SET WinrarPath="%%H"
)
popd

REM SET Name=%~n1
SET Name="AAA"
SET DesktopPath=C:\Users\guyle\desktop\
MD %DesktopPath%\%Name%_Renders
SET RenderFolder=%DesktopPath%\%Name%_Renders\
REM SET RenderFolder="%~dp0"\Renders
SET vProjectPath="D:\Projects\TED\TED_V1.aep"
SET "Winrar=%WinrarPath% a -ep1 -idq -r -y"


%Command% -project %vProjectPath% -comp "Flach1Template2" -output %DesktopPath%\%Name%_Renders\\%Name%_TEST1.png
rem %Command% -project %vProjectPath% -comp "Flach1Template" -s 75 -e 75 -output %DesktopPath%\%Name%_Renders\\%Name%_TEST1

TIMEOUT 2 > NUL


REM %Winrar% %RenderFolder%\%Name%_GFX %RenderFolder%\*.*
PAUSE
REM EXIT


