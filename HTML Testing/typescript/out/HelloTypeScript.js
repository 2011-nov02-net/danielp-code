"use strict";
//done for use
//'use strict';
//specified in compile configuration.
Object.defineProperty(exports, "__esModule", { value: true });
const MessageFormatter_1 = require("./MessageFormatter");
//compile command:
//tsc --target ES6 /src/HelloTypeScript.ts --outDir /out/
//but a configureation file is much more convienient.
//instead use this to set the options
//tsc --init
document.addEventListener('DOMContentLoaded', () => {
    let msgformat = new MessageFormatter_1.MessageFormatter;
    addMessage(msgformat.FormatMessage("Hello world."));
});
//if we left type out, this wouldn't complain until compile time
function addMessage(inmsg /*variable : type */) {
    document.body.innerHTML = inmsg.msg_txt;
}
