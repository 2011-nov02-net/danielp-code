'use strict';
/*
 * simple site, 2 pages, login and welcome
 * if user uses correct hardcoded credentials from js, send to welcome page
 *  then navigate the user automatically to the welcome page
 * otherwise display an error message on the welcome pagey wagey
 */


document.addEventListener('DOMContentLoaded', () => {
    const loginbutton = document.getElementById("login");

    loginbutton.addEventListener("submit", login)
});


function login(event) {
    console.log("login")
        //debugger

    var inputuser = document.getElementById("username").value
    var inputpass = document.getElementById("password").value
    console.log(inputuser)
    console.log(inputpass)

    if (inputpass == "password" && inputuser == "name") {
        console.log("sucsess!")

        window.location.href = "./welcomepage.html";

        //window.location.replace("./welcomepage.html");
    } else {
        const ErrorMessage = document.createElement("label")

        ErrorMessage.textContent = "ERROR: bad login information!"

        ErrorMessage.style.color = "red"


        document.getElementById("login").appendChild(ErrorMessage);
    }

    event.preventDefault();
    event.stopImmediatePropagation()
}