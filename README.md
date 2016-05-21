/==== About ====/
This is a .NET environment program developed in C# with persistent data storage through files. Microsoft (R) Visual Studio Community edition is used to develop it.

/==== Program Description & Requirements ====/
This is a small Windows desktop application for a local oil and gas company to keep track of their oil well production. The main domain entity is Facility which can be a Well Pad, an Oil Producing Well or a Steam Injection Well.  Most well pads contain both producing wells and injection wells.  Well Pads have a location and wells are associated with the well pad.

1. An MDI environment is required so multiple forms can be opened simultaneously.
2. Main Form is the mdi parent and it contains a main menu with menu items for File, View, Facilities, and Production.  Under File is “Exit”, under View is “Explorer”, under Facilities are “Add Well Pad”, “Add Production Well” and “Add Injection Well” and under Production is “Well Production”. 
3. The Explorer form is a TreeView/ListView display of data in the system.  The behavior of these two controls follows:
a. The Tree View: The root node displays “Facilities”.  Expand the root node and nodes display for each province (display province name).  Expand a province node and you see nodes for each well pad located in that province (display well pad location).  Expand a well pad node and you see the producing wells and injection wells associated with that well pad (display Spud Date).
b. The List View: When root node is active (default view) the list view will display columns for “Province”, “Well Pad Count”, “Producing Wells Count”, and “Injection Well Count”.  There will be one row of data displayed for each province.  When a province node is active, the list view will display columns for “Location”, “Producing Wells Count”, and “Injection Well Count”.  Each row represents a well pad located in that province.  When a well pad node is active, the list view will display columns for “Spud Date” and “Barrels Produced”.  Each record represents a producing well or injection well.  When a single well node is active, then the list view only displays the data for that one well (Production Date and Barrels Produced).  Of course, we know injection wells produce 0 barrels.
4. The Add Well Pad form is a small form used to enter a Well Pad in the system.  They have an Id as integer, Province as string and Location as string. 
5. The Add Production Well form is used to select a well pad and enter details about the well.  Wells have Id as integer and SpudDate as DateTime.
6. The Add Injection Well form is used to select a well pad and enter details about the injection well which is everything a production well has as well as the water type used for injection (e.g. Fresh, Brackish, Brine, and Saline).
7. The Well Production form is used to enter oil production for producing wells.  A well pad is selected from a combo box.  This loads associated production wells into a second combo box. Select a well from this combo box and enter number of barrels produced into a text field and submit.


