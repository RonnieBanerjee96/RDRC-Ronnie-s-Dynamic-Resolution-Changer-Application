IF YOU JUST WANT TO USE THE APPLICATION YOU CAN FIND THE BINARIES TO __DOWNLOAD__ IN: RDRC/bin/x64/Debug

I DO NOT OWN A MULTI-MONITOR SETUP, I CANNOT GUARANTEE IF THE APPLICATION WORKS IN THAT CASE. UNDER DEVELOPMENT, USE AT YOUR OWN RISK!

RDRC enables the launching of application using custom resolutions you may have set up using NVidia Control Panel or AMD Adrenaline Software. RDRC is specially beneficial when you cannot change an application/game's display mode to "Exclusive Fullscreen" and thus cannot opt to use Custom Resolutions in-app or in-game without manually setting the desktop resolution every single time before launching the application or game, RDRC takes care of that, just select the resolution -> browse to the application/game you want to launch and RDRC will dynamically change the resolution when the application starts and default back to the previous resolution when the application is closed. 


RDRC is works on the reschange.dll library that I made to enable the development of this application.
reschange.dll interfaces with the windows runtime using winuser.h specified API's. If you want to develop using reschange.dll, The brief documentation of the API functions available to you are:

INT getScreenHeight() : Returns the Screen Height of the Current Dsiplay.

INT getScreenWidth() : Returns The Screen Width Of the Current Display.

FLOAT getScreenRefresh() : Returns The Refresh Rate of the current Display;

BOOL getMonitorInfo(int widths_param[60],  int heights_param[60], float freqs_param[60]) : takes in three containers(arrays) of size 60 each from the Frontend program, each for supported widths, heights and corresponding refresh rates and fills them with respective values (see Form1.cs for clarity), Returns True if function succeeds.

BOOL startProcess(LPCWSTR path) : Takes in the path of the Application to be executed and executes it, returns True if successful.

BOOL changeScreenResolution(width, height, freq) : Changes the windows resolution to a given width, height and freq. Returns True if successful.

BOOL LaunchWithResolution(int width, int height, float freq, int prevWidth, int prevHeight, float prevFreq) : Takes in the height, width and freq for the resolution to be changed to and the previous height width and frequncy of the display from the Frontend and manages the running status of the launched application. Returns False if Application is closed, Returns True if the Launched Application is running with the Changed Resolution. 

