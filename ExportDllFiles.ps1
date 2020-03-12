param([string]$SourceDll,
      [string]$TargetDll)

Write-Host "Source DLL: $SourceDll"
Write-Host "Target DLL: $TargetDll"
Copy-Item -Path "$SourceDll" -Destination "$TargetDll" -Force