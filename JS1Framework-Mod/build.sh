#!/bin/bash

msbuild /t:Rebuild  /p:TargetFramework=net472 /p:Configuration=Debug 
msbuild /t:Rebuild  /p:TargetFramework=net472 /p:Configuration=Release