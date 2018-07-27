::京东云 .NET SDK publish 脚本
@echo off
title 京东云 .NET SDK  Nuget Publish
SET APIKEY= 
nuget setapikey %APIKEY% -Source https://www.nuget.org/api/v2/package
echo  setapikey end
cd ..\sdk\Release\nuget
for /r %cd% %%i in (*.nupkg) do (
echo "%%~i"
nuget push "%%~i" %APIKEY% -Source https://www.nuget.org/api/v2/package
)
pause