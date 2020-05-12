@ECHO OFF
REM Clear Platform variable (might be have improper global default on environment variable)
cd %~dp0

SET Platform=

set msbuild=""
call SetMsBuildPath.cmd
if %msbuild%=="" ( 
	echo MsBuild.exe not found!
	pause
	exit 1
) else ( echo Using %msbuild% )

@ ECHO %msbuild%

REM
REM for MSBUILD command line syntax, see
REM	http://msdn.microsoft.com/en-us/library/ms164311.aspx
REM
REM M1DWAL, Sep-2012
REM

@ ECHO **************** BUILD : MTBServerNetCore.SLN **************************
@ ECHO ON
REM %msbuild% /t:Restore /p:RestoreConfigFile=".\RealtimeSystem\NuGet\nuget.config" MTBRTServer/MTBRTServerAll.sln
%msbuild% /t:Rebuild /p:Configuration=Debug /p:Platform="Any CPU" /verbosity:minimal  /maxcpucount C:\RMS_MTB\RMS_MTB\MTBServer\MTBServerNetCore.sln

pause
