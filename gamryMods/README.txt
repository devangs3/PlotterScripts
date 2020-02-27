Today, 12:49 PM
Sankhala, Devangsingh
Flag for follow up. Start by Tuesday, February 25, 2020. Due by Tuesday, February 25, 2020.
5 attachments (8 KB) 
Hi Devang,
 
Please see the notes below.  The scripts are attached.

Regards,
Jacob
 
Dr. Jacob Ketter
Instrumentation Specialist
Gamry Instruments
734 Louis Dr., Warminster, PA 18974, USA
Phone: +215.682.9330 x128
Toll-Free: 1.877.367.4267 x128 (US and Canada)
www.gamry.com
From: Abe Krebs <Akrebs@gamry.com>
Sent: Tuesday, February 25, 2020 1:47 PM
To: Jacob Ketter <JKetter@Gamry.com>
Subject: Scripts for UT Dallas
 
Hi Jacob,
 
Here are some custom steps for UT Dallas.
 
The INI file location should be the same as the GAMRY.INI location,
C:\ProgramData\Gamry Instruments\Framework
 
The other files all go into the scripts folder.
 
Basically there is a step that will read an INI file to get a data file group, either a precursor (TYPE = 1) or a directory (TYPE = 0).  And a NAME for the precursor or directory. 
 
The other step will set an INI FLAG of the user’s choice.  They can monitor this for knowing when something is DONE. 
 
They will need to save sequence as a script and then launch the Framework.exe with the script name as a command line argument.
 
Cheers,
Abe
 
Abram Krebs
Gamry Instruments, Inc.
734 Louis Dr, Warminster, PA 18974, USA
Direct: +215.682.9330, Ext 116
Toll-Free: 1.877.367.4267, Ext 116 (US and Canada)
www.gamry.com