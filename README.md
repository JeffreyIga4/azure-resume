# azure-resume
My own azure resume following ACG project video 

## First Step

- Frontend folder contains website.
- main.js contains visitor counter code.

```js
window.addEventListener('DOMContentLoaded', (event) => {
    getVisitCount();
})
```
- loads up when the HTML document has been fully loaded and parsed.
- when loaded the getVisitCount function is called 

## Second step 
- Created a counter file that will call the counter from CosmosDb
- I then made a binding that will bind the function to CosmosDB
```js 
 [CosmosDB(databaseName: "AzureResume", containerName: "Counter", Connection = "AzureResumeConnectionString", Id = "1", PartitionKey = "1")] Counter counter,
 ```
 - This next binding writes back to CosmosDB each time the counter is updated
```js
  [CosmosDB(databaseName: "AzureResume", containerName: "Counter", Connection = "AzureResumeConnectionString", Id = "1", PartitionKey = "1")] out Counter updatedCounter,
  ```

  
