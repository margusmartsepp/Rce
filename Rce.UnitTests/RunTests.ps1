get-date > TestInfo.txt; 

$ErrorActionPreference="SilentlyContinue"
Stop-Transcript | out-null
$ErrorActionPreference = "Continue"
Start-Transcript -path TestInfo.txt -append
powershell "dnx test >TestResults.txt"
notepad.exe TestResults.txt
Stop-Transcript

notepad.exe TestResults.txt
