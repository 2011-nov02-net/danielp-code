//done for use
//'use strict';

//defines requirements to be a member of the set of objects
//that count as a message
interface Message{
    msg_txt: string;
}


//compile command:
//tsc --target ES6 /src/HelloTypeScript.ts --outDir /out/
//but a configureation file is much more convienient.

//instead use this to set the options
//tsc --init


document.addEventListener('DOMContentLoaded', () => {
    let message = {msg_txt: "Hello world"}
    addMessage(message);
});


//if we left type out, this wouldn't complain until compile time
function addMessage(inmsg:Message  /*variable : type */) {
    document.body.innerHTML = inmsg.msg_txt;
}
