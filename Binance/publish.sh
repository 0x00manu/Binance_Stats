#!/bin/bash
echo "if error NETSDK1031:"
echo "then add: <RuntimeIdentifier>linux-x64</RuntimeIdentifier>"
echo "below the line: <TargetFramework>net6.0</TargetFramework>"
echo "in .csproj file"
dotnet publish -c release -r linux-x64 --self-contained
ls -la ./bin/release/net6.0/linux-x64/publish/ | grep Binance$
