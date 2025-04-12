#!/bin/bash

# Check if rebuild flag is provided
REBUILD_FLAG=""
if [ "$1" == "--rebuild" ] || [ "$1" == "-r" ]; then
    REBUILD_FLAG="--rebuild"
    echo "Running all build scripts with rebuild option..."
else
    echo "Running all build scripts normally... (use --rebuild or -r to force rebuild)"
fi

# Find all build.sh scripts in the current directory and subdirectories
find . -name "build.sh" -type f | while read -r build_script; do
    script_dir=$(dirname "$build_script")
    script_name=$(basename "$build_script")
    
    echo "Found $script_name in $script_dir"
    
    # Check if the script is executable
    if [ ! -x "$build_script" ]; then
        echo "Making $build_script executable..."
        chmod +x "$build_script"
    fi
    
    # Change to the script directory
    echo "Changing to directory: $script_dir"
    cd "$script_dir" || continue
    
    # Run the build script with the rebuild flag if provided
    echo "Running $script_name $REBUILD_FLAG..."
    if [ -n "$REBUILD_FLAG" ]; then
        ./build.sh --rebuild
    else
        ./build.sh
    fi
    
    # Capture the exit status
    exit_status=$?
    
    # Report the result
    if [ $exit_status -eq 0 ]; then
        echo "$script_name executed successfully"
    else
        echo "$script_name failed with exit status $exit_status"
    fi
    
    # Go back to the original directory
    cd - > /dev/null
    
    echo "----------------------------------------"
done

echo "All build.sh scripts have been executed."