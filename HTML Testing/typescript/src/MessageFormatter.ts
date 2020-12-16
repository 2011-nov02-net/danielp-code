
import { Message } from './Message'

export class MessageFormatter{
    FormatMessage(text:string) : Message {
        return { msg_txt: text}
    }
   
}