yams-settings-tool
==================
This tool is meant for people who are running YAMS (Yet Another Minecraft Server) and need to make offline changes to their database file.

Due to a common bug in several Microsoft applications (including multiple versions of Visual Studio and SQL Server Managment Studio) it is not possible to load a SQLServer CE database file (.sdf) which has grown larger than 128MB. If writing your own software and using your own connection string, it is simple enough to add "Max Database Size=4000;", but this program provides a viable way to make changes to the YAMSSettings, MCSettings, and MCServers tables in the database.

Features:
-Review, update, and delete settings currently in the YAMSSettings table
-Review, update, and delete settings in the MCSettings table for a particular server
-Review and update values for a particular server in the MCServers table

How to use:
-If running, stop the YAMS service.
-Modify the YAMSDatabaseSettings.exe.config file (in the \bin folder) so that the YAMSDatabaseFile connection string so that the "Data Source" path value is pointing at the location of your own dbYAMS.sdf file.
-Start YAMSDatabaseSettings.exe (in the \bin folder.)
-Choose between editing YAMSSettings and MCSettings by choosing "YAMS Settings" and "Server Settings".
-Edit SettingValue values in the right column.
-Click Save Changes to make changes to the database file.
-Click the Table Settings button (on the "Server Settings" option) to see the Edit Server Table Settings dialog.
