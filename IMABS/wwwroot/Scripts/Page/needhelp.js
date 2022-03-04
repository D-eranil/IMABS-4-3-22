﻿
// Get the input field
var input = document.getElementById("txtSearchPlaceholder");

// Execute a function when the user releases a key on the keyboard
input.addEventListener("keyup", function (event) {
    // Number 13 is the "Enter" key on the keyboard
    if (event.keyCode === 13) {
        // Cancel the default action, if needed
        event.preventDefault();
        // Trigger the button element with a click
        searchHelpContent();
    }
});


function searchHelpContent() {
    //console.log('search');
    //get search text
    let searchTerm = document.getElementById('txtSearchPlaceholder').value;
    searchTerm = searchTerm.toLowerCase();

    //reset search
    resetSearchHelpContent('NO');

    //get active tab
    var tabId = document.getElementsByClassName('active')[0].getAttribute('id');

    //get tab containt
    let nodes = document.querySelectorAll('#accordion-' + tabId + ' > .accordion-item');
    //let x = document.querySelectorAll('.accordion > .accordion-item'); -- search for all tabs

    //check value
    for (node = 0; node < nodes.length; node++) {
        if (!nodes[node].innerHTML.toLowerCase().includes(searchTerm)) {
            nodes[node].style.display = "none";
        }
        else {
            nodes[node].style.display = "accordion-item";
        }
    }
}

function resetSearchHelpContent(clear) {
    console.log(clear);

    if (clear == 'YES') {
        document.getElementById('txtSearchPlaceholder').value = '';
    }

    var nodes = document.querySelectorAll(".accordion > .accordion-item");
    for (node = 0; node < nodes.length; ++node) {
        nodes[node].style.display = "block";
    }
}