# SplaTu
An image conversion tool for Splatoon2/3 posts

This project was based on shinyquagsire23's Switch-FightStick Splatoon 2 Posts Project: github.com/shinyquagsire23/Switch-Fightstick 
The application SplaTu contains an image converter, which converts any image to a 320x120 monochrome bitmap, then converts the bitmap to image.c and eventually use shinyquagsire23's project to generate Joystick.h

Update 2022-09-20 Version 1.1:
The updated image converter now works with newer version of Switch-FightStick that speeded up the printing speed.
To support Splatoon3, need to import https://github.com/tarxf/Splatoon-3-Post-Printer/ instead of https://github.com/shinyquagsire23/Switch-Fightstick and put the files under Switch-Fightstick folder.

Folder Structure:

SplaTu|<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|SplaTu.exe<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|LUFA <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|LUFA<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|....<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|Switch-Fightstick<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|....<br />
		 
In \LUFA\LUFA\Drivers\USB\Core\Device.h Line 134, update **const uint8_t wIndex** to **const uint16_t wIndex**
 

Download: https://pan.baidu.com/s/1J8UiuhLlpKFEzNDKyLvKQg?pwd=eniy 
Download password: eniy
 


