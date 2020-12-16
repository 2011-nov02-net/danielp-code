//done for use
//'use strict';
//specified in compile configuration.

import { Message } from './Message'
import { MessageFormatter } from './MessageFormatter'

//compile command:
//tsc --target ES6 /src/HelloTypeScript.ts --outDir /out/
//but a configureation file is much more convienient.

//instead use this to set the options
//tsc --init


document.addEventListener('DOMContentLoaded', () => {
    let msgformat = new MessageFormatter
    addMessage(msgformat.FormatMessage("Hello world."));
});


//if we left type out, this wouldn't complain until compile time
function addMessage(inmsg:Message  /*variable : type */) {
    document.body.innerHTML = inmsg.msg_txt;
}
