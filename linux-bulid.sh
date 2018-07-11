#!/bin/bash
path=`pwd`
dotnet --version
if [ $? -ne 0 ]; then
    echo "success"      
    export PATH=$PATH:$HOME/dotnet
    dotnet --version
    if [ $? -ne 0 ]; then
        wget https://download.microsoft.com/download/4/0/9/40920432-3302-47a8-b13c-bbc4848ad114/dotnet-sdk-2.1.302-linux-x64.tar.gz
        mv dotnet-sdk-2.1.302-linux-x64.tar.gz dotnet.tar.gz
        mkdir -p $HOME/dotnet && tar zxf dotnet.tar.gz -C $HOME/dotnet
        rm -rf dotnet.tar.gz
        dotnet --version
    fi
fi
version="2.1.1"
if [ ! -d "$HOME/dotnet/shared/Microsoft.NETCore.App/" ];then
	version=$(ls /usr/share/dotnet/shared/Microsoft.NETCore.App -l | awk '/^d/{print $NF}')
else
	version=$(ls $HOME/dotnet/shared/Microsoft.NETCore.App  -l | awk '/^d/{print $NF}')
fi
echo "===================================restore============================================"
dotnet msbuild JDCloudSDK.Linux.sln  /restore /p:TargetFramework=netstandard2.0 && \
dotnet msbuild ./src/Examples/Standard2/JDCloudSDK.Test.Standard2.csproj /restore /p:TargetFramework=netcoreapp2.0 && \
echo "===================================restore end============================================" && \
echo "===================================clean============================================" && \
dotnet msbuild JDCloudSDK.sln /t:Clean && \
echo "===================================clean end============================================" && \
echo "===================================build sdk============================================" && \
dotnet msbuild JDCloudSDK.Linux.sln  /p:TargetFramework=netstandard2.0 /p:Configuration=Release /p:outputpath=$HOME/jcloud-dotnet-sdk/release && \
echo "===================================build sdk end============================================" && \
echo "===================================build test project============================================" && \
dotnet msbuild ./src/Examples/Standard2/JDCloudSDK.Test.Standard2.csproj  /p:TargetFramework=netcoreapp2.0 /p:Configuration=Release /p:outputpath=$HOME/jcloud-dotnet-sdk/examples/release && \
echo "===================================build test project end============================================" && \
echo "===================================exec test project============================================" && \
cd ./src/Examples/Standard2 && \
cp -r $path/packages/Newtonsoft.Json.11.0.2/lib/netstandard2.0/* $path/src/Examples/Standard2/bin/Debug/netcoreapp2.0/
dotnet xunit  --fx-version $version -maxthreads 20 && \
echo "===================================exec end============================================"
#WINDOWS BUILD COMMAND MSBuild JDCloudSDK.sln /p:Configuration=Release
