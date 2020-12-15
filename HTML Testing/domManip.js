'use strict';

/*
document.body.firstChild;

document.body.children[0].nextElementSibling;

//nieve way, wont work unless script loaded after the body.
document.body.children[0].href = "http://google.com";
alert("lonk changed to google!")
*/

Window.onload = function() {
    //now everything in here will be executed and interpreted after the window is done being loaded.

    //so now this would work even in the head.
    document.body.children[0].href = "http://google.com";
}


function start() {
    //now we've named the onload function, but the above shouldn't run.
    document.body.children[0].href = "http://google.com";

    let thing = document.getElementById('elem1');
    let item = document.createElement('h1');
    item.textContent = "item text!";
    thing.appendChild(item);
}

//PROBLEM: now we can only have one listener for this event, and lots of scripts may want to listen.
//window.onload = start();

//better and more flexable:
//window.addEventListener('load', start);

document.addEventListener('DOMContentLoaded', start);



// if you click on a list item, it will delete that item from the list.

//TODO: 1 list item already in the lest on start

// 2. whenever you click on a list item, insert a new onjust vellow that one




document.addEventListener('DOMContentLoaded', () => {
    //   document.getElementsByTagName('ul')[0];
    //   document.body.children[2];
    const list = document.getElementById('list');

    const button = document.createElement('button');
    button.textContent = 'click here';

    button.addEventListener('click', () => {
        const item = document.createElement('li');
        list.appendChild(item);
        // item.textContent = 'text';
        item.innerHTML = '<em>text</em>';
        item.addEventListener('click', deleteListItem);
    });

    document.body.appendChild(button);

    document.addEventListener('click', printEventDetails);
    // button.addEventListener('click', printEventDetails);
    // list.addEventListener('click', printEventDetails);
});


function deleteListItem(event) {
    if (event.target == event.currentTarget) {
        var elem = event.target;
        delete(event.target);
    }
}


function printEventDetails(event) {
    // console.log(event === mostRecentEvent); // always false
    // console.log(`type: ${event.type}`);
    console.log(`target:`); // the most specific element the event ran on
    console.log(event.target);
    console.log(`currentTarget:`); // the element this event handler was
    // registered on
    console.log(event.currentTarget);
    console.log('-------------------');
    // mostRecentEvent = event;
}