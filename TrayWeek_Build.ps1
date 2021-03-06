properties {
  $base_dir = Resolve-Path .
  $build_dir = "$base_dir\build"
  $sln_file = "$base_dir\TrayWeek.sln"
  $debug_dir = "$build_dir\Debug"
  $release_dir = "$build_dir\Release"
}

task default -depends Test

task Test -depends Compile, Clean { 
  #$testMessage
}

task Compile -depends Init { 
  Write-Host 'Compile task'
  Write-Host msbuild $sln_file '/nologo' '/t:rebuild' '/p:Configuration=Debug' /p:OutDir="$debug_dir\"
  msbuild $sln_file '/nologo' '/t:rebuild' '/p:Configuration=Debug' /p:OutDir="$debug_dir\"
  msbuild $sln_file '/nologo' '/t:rebuild' '/p:Configuration=Release' /p:OutDir="$release_dir\"
}

task Init -depends Clean {
    new-item $debug_dir -itemType directory
    new-item $release_dir -itemType directory
}

task Clean { 
  remove-item -force -recurse $debug_dir -ErrorAction SilentlyContinue
  remove-item -force -recurse $release_dir -ErrorAction SilentlyContinue
}