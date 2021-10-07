# NazgulMonitor
Monitoring tool for Windows Systems Servers

# ***DISCLAIMER***
***Source code is pretty stable (beta testers have been using it for several days nonstop, draining minimal resources), however it may not be suitable for learners, a big code-refactoring is indeed needed to organize better resources, modules and classes in order to externalize them as most as possible when developing the Windows Service part.***

### Introduction
Inspired by the most known monitoring softwares like PRTG, HetrixTools, Zabbix, Nagios etc. I want to introduce my NazgulMonitor tool fully coded in .NET. The idea is to have a very simple, 100% portable and standalone tool that does not require any particular configuration nor installation, just copy and paste onto your Windows Server and you are ready to go


<br/>

***pic below is old, I encountered many issues with a lot of Themes so I decided to re-do that in WinForms (simple and clean)***

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
- Online JavaScript Chart for history view <br/>

### Previews
Very simple showcase of the JS Chart showing GPU peaks when gaming

![tempsnip](https://user-images.githubusercontent.com/85739956/136430502-9273e504-1cf8-446f-a88d-b3968fbbcb0a.png)

Live view from Website (1sec delay only), errors reportage, graph with history

![Senza titolo](https://user-images.githubusercontent.com/85739956/136430996-073dd5b6-e13e-46c8-b89a-69566e4095fc.png)

### Credits
Me <br/>
OSK Soft for the big help simplifying the OpenHardwareMonitor lib usage and many other bug fixes <br/>
<a href="https://github.com/FrancescoBonizzi">Francesco Bonizzi</a> for general troubleshooting and fixing the WebRequest function <br/>
<a href="https://github.com/Steffen7792">Steffen7792</a> for helping me out with the JavaScript functions and charts <br/>

<a href="https://github.com/openhardwaremonitor/openhardwaremonitor">OpenHardwareMonitor</a> for the driver to read CPU and GPU Temperatures <br/>
<a href="https://dygraphs.com/">dygraphs</a> for their charts implementation <br/>

