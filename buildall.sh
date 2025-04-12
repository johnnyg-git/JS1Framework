#!/bin/bash

# Check if rebuild flag is provided
REBUILD_FLAG=""
if [ "$1" == "--rebuild" ] || [ "$1" == "-r" ]; then
    REBUILD_FLAG="--rebuild"
    echo "Running all build scripts with rebuild option..."
else
    echo "Running all build scripts normally... (use --rebuild or -r to force rebuild)"
fi

# Function to execute a build script
run_build_script() {
    local build_script="$1"
    local script_dir
    script_dir=$(dirname "$build_script")
    local script_name
    script_name=$(basename "$build_script")
    
    echo "Found $script_name in $script_dir"
    
    # Check if the script is executable
    if [ ! -x "$build_script" ]; then
        echo "Making $build_script executable..."
        chmod +x "$build_script"
    fi
    
    # Change to the script directory
    echo "Changing to directory: $script_dir"
    cd "$script_dir" || return
    
    # Run the build script with the rebuild flag if provided
    echo "Running $script_name $REBUILD_FLAG..."
    if [ -n "$REBUILD_FLAG" ]; then
        ./build.sh --rebuild
    else
        ./build.sh
    fi
    
    # Capture the exit status
    local exit_status=$?
    
    # Report the result
    if [ $exit_status -eq 0 ]; then
        echo "$script_name executed successfully"
    else
        echo "$script_name failed with exit status $exit_status"
    fi
    
    # Go back to the original directory
    cd - > /dev/null
    
    echo "----------------------------------------"
}

# Run JS1Framework-Mod/build.sh first
if [ -f "./JS1Framework-Mod/build.sh" ]; then
    echo "Running JS1Framework-Mod/build.sh first..."
    run_build_script "./JS1Framework-Mod/build.sh"
else
    echo "JS1Framework-Mod/build.sh not found, skipping..."
fi

# Find all other build.sh scripts in the current directory and subdirectories
find . -name "build.sh" -type f | grep -v "./JS1Framework-Mod/build.sh" | while read -r build_script; do
    run_build_script "$build_script"
done

echo "All build.sh scripts have been executed."