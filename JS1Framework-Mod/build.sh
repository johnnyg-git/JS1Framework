#!/bin/bash

# Check for command line argument
REBUILD_FLAG=""
if [ "$1" == "--rebuild" ] || [ "$1" == "-r" ]; then
    REBUILD_FLAG="/t:Rebuild"
    echo "Performing a rebuild..."
else
    echo "Performing a regular build... (use --rebuild or -r to force rebuild)"
fi

# Check if project.assets.json exists
if [ ! -f "obj/project.assets.json" ] || [ "$REBUILD_FLAG" == "/t:Rebuild" ]; then
    echo "Restoring packages..."
    dotnet restore
else
    echo "Skipping package restore as project.assets.json exists..."
fi

# Build Debug configuration
echo "Building Debug configuration..."
msbuild $REBUILD_FLAG /p:TargetFramework=net472 /p:Configuration=Debug

# Build Release configuration
echo "Building Release configuration..."
msbuild $REBUILD_FLAG /p:TargetFramework=net472 /p:Configuration=Release

echo "Build completed."