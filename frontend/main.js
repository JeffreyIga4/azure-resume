window.addEventListener('DOMContentLoaded', (event) => {
    getVisitCount();
})

const functionApi = '';

const getVisitCount = () => {
    let count = 30;  // default count value
    fetch(functionApi).then(response => { // sends a request to the function API
        return response.json()  // parses the response as JSON
    }).then(response => {
        console.log("Website called function API.");
        count = response.count; // updates the count value
        document.getElementById("counter").innerText = count; // updates the webpage with the count value
    }).catch(function(error){
        console.log(error); // logs any errors if they occur
    });
    return count;
}

