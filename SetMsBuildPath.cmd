@echo off

set msbuild=""

for %%F in (
	"%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MsBuild.exe"	
	"%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\MsBuild.exe"
	"%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MsBuild.exe"
	"%ProgramFiles(x86)%\Microsoft Visual Studio 15.0\MSBuild\15.0\Bin\MsBuild.exe"
	"%ProgramFiles(x86)%\MSBuild\15.0\bin\MsBuild.exe"
) do if exist %%F set msbuild=%%F && goto :eof