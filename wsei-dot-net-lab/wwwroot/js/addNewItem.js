(function () {
    const alertSuccessElement = document.getElementById("success-alert");
    const alertFailureElement = document.getElementById("failure-alert");
    const formElement = document.forms[0];

    const addNewItem = async () => {
        const requestData = {
            name: formElement.elements.namedItem('Name').value,
            description: formElement.elements.namedItem('Description').value,
            isVisible: formElement.elements.namedItem('IsVisible').value
        };
        
        const response = await fetch('/api/ItemApi', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(requestData)
        });
        const responseJson = await response.json();

        if (responseJson.isSuccessful) {
            alertSuccessElement.style.display = 'block';
            alertFailureElement.style.display = 'none';
        } else {
            alertSuccessElement.style.display = 'none';
            alertFailureElement.style.display = 'block';
        }
    };
    
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();