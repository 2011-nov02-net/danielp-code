//returns an iterator

//function that returns a number
//needs some way to store the data
function Counter() {
    let i = 0;
    yield i++;
}

function actualCounter() {
    let i = 0;

    return () => ++i;
}
//this works because language desing says that if u ref a local var from an inner function,
//that inner function will keep that variable alive as long as that inner function remains
//so, i is alive because of that inner function that was returned keeping it alive

const counter11 = Counter()
const counter12 = Counter()

const counter21 = actualCounter()
const counter22 = actualCounter()

console.log()