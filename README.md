# Sitefinity Mail Server
Sitefinity Mail Server is Windws Forms application for testing, inspecting and simulating behavior of email campaigns with a large number of recipients.   
![SitefinityMailServer main window](https://raw.githubusercontent.com/alonrotem/SitefinityMailServer/master/Screenshots/Screenshot%20-%20Main%20window.png)

## Notable features
* Runs an SMTP server (listening on any configured port) and receives messages (in contrast to tools like <a href="https://smtp4dev.codeplex.com/" target="_blank">smtp4dev</a>, messages are not stored and are not displayed, but only counted). Does not store any messages, does not really send any messages anywhere
   
* SMTP messages are received regardless of their recipients' addresses.

* For specific configured email addresses, automatically produces bounce messages (the bounce reason is also configurable). Bounce messages are collected by POP3. If a message is sent to one of the bounced addresses, a fake bounced message is produced, which can be collected by Sitefinity later.   
![](https://raw.githubusercontent.com/alonrotem/SitefinityMailServer/master/Screenshots/Screenshot%20-%20Options%20dialog.png)

* Runs a POP3 server (The default port for the POP3 server is 995, same as the default one in Sitefinity, but any port can be set, as long as it matches Sitefinity's settings), through which bounced messages can be collected.  
The POP3 server accepts any user, with any password. If the POP3 username is of the Sitefinity Bounce POP3 Username, the bounced messages are released.    
The same username must be defined in Sitefinity as the Bounced messages POP3 user (with any password). Otherwise, if the POP3 session user is any other user, the POP3 server returns nothing.   
![](https://raw.githubusercontent.com/alonrotem/SitefinityMailServer/master/Screenshots/Screenshot%20-%20Notification%20Icon%20Messages%20Collected.png)

* Auto-detects whether <a href="https://www.hmailserver.com/" target="_blank">hMailServer</a> is already running on the machine and offers to stop its service for you, to avoid a port-collision.

* Shows statistics of the number of received messages and a list of all the recipients' addresses.

* UX features:
  - SitefinityMailServer allows only a single instance executing at a time.
  - Always on top option for main dialog.
  - Minimize to tray option   
  ![](https://raw.githubusercontent.com/alonrotem/SitefinityMailServer/master/Screenshots/Screenshot%20-%20Notification%20Icon%20Message%20Received.png)
  - Tray menu to stop/start the server, see recipients etc.    
  ![](https://raw.githubusercontent.com/alonrotem/SitefinityMailServer/master/Screenshots/Screenshot%20-%20Notification%20Icon%20Menu.png)

**Notes:** 
* The server runs and does everything in memory. If you restart the server, or the whole application, all the data of messages and bounced counters gets reset (user settings are saved).
* This application contains animated <a href="https://en.wikipedia.org/wiki/Nyan_Cat" target="_blank" title="NyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyanNyan">Nyan cats</a> (with no sound, thank God), in case you are allergic.

## Pending desired features ##

* Store the messages for real POP3 usage
* Simulate email campaigns:
 - Link clicks in message
 - Opening a message
* Add *Change port* » open options dialog, when <a href="https://www.hmailserver.com/" target="_blank">hMailServer</a> crashes the application
* shorten the balloon time when a message is received (or display in bulks)

## Embedded open source ##
This tool uses embedded source from open projects:
* SMTP server based on <a href="http://www.ericdaugherty.com/apps/simplemailprocessor/" target="_blank">Eric Daugherty's Simple Mail Processor</a>.
* POP3 server based on <a href="http://www.lumisoft.ee/lsWWW/ENG/Products/Mail_Server/mail_index_eng.aspx?type=info" target="_blank">LumiSoft Mail Server</a>.  
![About](https://raw.githubusercontent.com/alonrotem/SitefinityMailServer/master/Screenshots/Screenshot%20-%20About%20window.png)
