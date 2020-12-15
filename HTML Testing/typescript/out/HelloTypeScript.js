"use strict";
//done for use
//'use strict';
//compile command:
//tsc --target ES6 /src/HelloTypeScript.ts --outDir /out/
//but a configureation file is much more convienient.
//instead use this to set the options
//tsc --init
document.addEventListener('DOMContentLoaded', () => {
    let message = { msg_txt: "Hello world" };
    addMessage(message);
});
//if we left type out, this wouldn't complain until compile time
function addMessage(inmsg /*variable : type */) {
    document.body.innerHTML = inmsg.msg_txt;
}
