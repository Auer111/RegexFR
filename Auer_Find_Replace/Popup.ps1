#From https://stackoverflow.com/questions/22761553/insert-credentials-into-the-windows-login-popup
$wshell = New-Object -com WScript.Shell
$wshell.Run("explorer.exe " + $Args[0])
Start-Sleep 4

echo $Args[0]
echo $Args[1]
echo $Args[2]

$wshell.sendkeys($Args[1])
$wshell.sendkeys("{TAB}")
$wshell.sendkeys($Args[2])
