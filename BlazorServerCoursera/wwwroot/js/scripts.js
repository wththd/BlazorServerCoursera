var myApp = myApp || {};

myApp.triggerAlert = (message, customData) => {
    console.log(customData == null);
    alert("data = " + message + " " + customData.number);
}

myApp.showPrompt = () => {
    return prompt('What is your name?')
}

myApp.setName = (name) => {
    document.getElementById('myName').innerText = name;
}