// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
    

    //document.getElementById("btnsubmit").addEventListener("click", val);


    function val() {
        let passwordHash = document.getElementById("passwordHash");
        let password2 = document.getElementById("password2");
        let lblValidation = document.getElementById("lblValidation");

        if (passwordHash.value != password2.value) {
            lblValidation.innerHTML = "The passwords you entered didn't match.";
            return false;
        }
        else {
            lblValidation.innerHTML = "";
        }

    }

