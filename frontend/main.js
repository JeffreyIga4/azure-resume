window.addEventListener('DOMContentLoaded', (event) => {
    fetch('/config.json')
        .then(response => response.json())
        .then(config => {
            if (!config.functionApiUrl) {
                throw new Error("API URL not found in config.json");
            }
            getVisitCount(config.functionApiUrl);
        })
        .catch(error => {
            console.error("Error loading config.json", error);
        });
});

const getVisitCount = (functionApiUrl) => {
    let count = 30;  // default count value
    fetch(functionApiUrl)
        .then(response => response.json())
        .then(response => {
            console.log("Website called function API.");
            count = response.count; // updates count value
            document.getElementById("counter").innerText = count; // updates webpage
        })
        .catch(error => console.log("Error fetching visit count:", error));
    
    return count;
};

