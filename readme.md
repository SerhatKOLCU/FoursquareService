ASP.Net Web API 2
    • init
    • searchVenue
    
•init Service:
    /api/init
    
    Sample request JSON format:
    {
    "deviceInfo": {
        "ID": 1,
        "Manufacturer": "sample string 2",
        "Model": "sample string 3",
        "OS": "sample string 4",
        "OSVersion": "sample string 5"
    },
    "transactionInfo": {
        "ApplicationVersion": "sample string 1",
        "Mode": 1
        }
    }
    
    Response JSON format:
    {
        "needsUpdate": true
    }
    
    Note: Mode 1- Test
               2- Production
        if Mode is Test, then venue names returns with the "T-" prefix
        
    
•searchVenue Service:
    /api/searchVenue
    
    Sample request JSON format:
    {
    "searchKeyword": "sample string 1",
    "City": "sample string 2",
    "Location": {
        "Latitude": 1.1,
        "Longitude": 2.1
        }
    }
    
    Response JSON format:
    {
    "ID": 1,
    "Name": "sample string 2",
    "Country": "sample string 3",
    "City": "sample string 4",
    "Location": {
        "Latitude": 1.1,
        "Longitude": 2.1
        },
    "PeopleHereNow": 5,
    "URL": "sample string 6",
    "Likes": 7,
    "Like": true,
    "Dislike": true
    }
    
    Note: searchKeyword is required for request
          City or Location, one of two is required for request, not together!
