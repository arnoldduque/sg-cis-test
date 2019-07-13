# Smart Grid CIS Test
## How To Run the Test
In order to run this test, you will need Visual Studio 2019 (Community Edition from [here](https://visualstudio.microsoft.com/vs/community/)).

### Testing the WCF
To test the WCF Service, you need to follow the next steps:
1. Right click the `WcfSGCISTest Proyect` and the select `Set As Startup Proyect`.
2. Open the subfolder from the proyect and right click the file `PersonService.svc`, then select `Set As Start Page`.
3. Rigth click the `WcfSGCISTest Proyect` and select `Debug`, and then `Start New Instance`. The WCF Test Client should be opened. Here you can test the Service.

Note: Once the service is running, you can call the Service Funcion `InitializeData`. This method will create some data on the data base, for testing purposes.

### Testing the Web Pages
To test the Web Pages, you need to follow the next steps:
1. Right click the `WebSGCISTest Proyect` and the select `Set As Startup Proyect`.
2. Open the subfolder from the proyect and right click the file `Page1.aspx`, then select `Set As Start Page`.
3. Start debbuging with F5 key.
