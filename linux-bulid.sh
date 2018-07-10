#!/bin/sh
echo "此脚本只能在linux 下编译netstandard2.0 版本的sdk,编译前需要安装dotnetcore sdk 2.0以上的兼容版本,使用时请注意"
echo "===================================restore============================================"
dotnet msbuild JDCloudSDK.Linux.sln  /restore /p:TargetFramework=netstandard2.0 && \
dotnet msbuild ./src/Examples/Standard2/JDCloudSDK.Test.Standard2.csproj /restore /p:TargetFramework=netcoreapp2.0 && \
echo "===================================restore end============================================" && \
echo "===================================clean============================================" && \
dotnet msbuild JDCloudSDK.sln /t:Clean && \
echo "===================================clean end============================================" && \
echo "===================================build sdk============================================" && \
dotnet msbuild JDCloudSDK.Linux.sln  /p:TargetFramework=netstandard2.0 /p:Configuration=Release /p:outputpath=$HOME/jdcloud-dotnet-sdk/release && \
echo "===================================build sdk end============================================" && \
echo "===================================build test project============================================" && \
dotnet msbuild ./src/Examples/Standard2/JDCloudSDK.Test.Standard2.csproj  /p:TargetFramework=netcoreapp2.0 /p:Configuration=Release /p:outputpath=$HOME/jdcloud-dotnet-sdk/examples/release && \
echo "===================================build test project end============================================" && \
#执行测试项目脚本，因sdk 为配置accessKeyId 与 secretAccessKey 无法跑通测试因此注释
#echo "===================================exec test project============================================" && \
#cd ./src/Examples/Standard2 && \
#dotnet xunit  --fx-version 2.1.1 -maxthreads 20 && \
#echo "===================================exec end============================================"
