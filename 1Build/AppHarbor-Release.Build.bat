..\Tools\NAnt\NAnt.exe -buildfile:Scripts\AppHarbor-Release.build > Logs\appharbor-release.build.log

@echo **** done.  check build.log for errors ****
pause
start notepad.exe Logs\appharbor-release.build.log