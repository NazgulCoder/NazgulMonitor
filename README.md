# NazgulMonitor
Monitoring tool for Windows Systems Servers

# ***DISCLAIMER***
***Source code is pretty stable (beta testers have been using it for several days nonstop, draining minimal resources), however it may not be suitable for learners, a big code-refactoring is indeed needed to organize better resources, modules and classes in order to externalize them as most as possible when developing the Windows Service part.***

### Introduction
Inspired by the most known monitoring softwares like PRTG, HetrixTools, Zabbix, Nagios etc. I want to introduce my NazgulMonitor tool fully coded in .NET. The idea is to have a very simple, 100% portable and standalone tool that does not require any particular configuration nor installation, just copy and paste onto your Windows Server and you are ready to go

![tempsnip-1](https://user-images.githubusercontent.com/85739956/131316750-70304094-0c7a-4f4d-b5c4-9a5ffb00c022.png)

### Features
- Windows Version <br/>
- Internal IP <br/>
- Ping <br/>
- CPU Temperature (OpenHardwareMonitor Lib) <br/>
- GPU Temperature (OpenHardwareMonitor Lib) <br/>
- CPU Usage <br/>
- RAM Usage <br/>
- Download Speed Usage <br/>
- Upload Speed Usage <br/>
- Sends Logs to webserver (free webhosts are fine, no need of MySQL or SQLite) <br/>
- Sends Telegram Alerts <br/>
- Local CSV log file <br/>
- Online JavaScript Chart for history view (UNDER DEVELOPMENT) 




