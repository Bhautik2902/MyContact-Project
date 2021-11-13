function validateForm() {
    const fname = document.getElementById('fname');
    const lname = document.getElementById('lname');
    const email = document.getElementById('email');
    const pass = document.getElementById('pass');
    const repass = document.getElementById('repass');

    const radio_male = document.getElementById('male');
    const radio_female = document.getElementById('female');
    const radio_others = document.getElementById('Others');              
        
    // validation of Name
    if (fname.value == "") {
        let ele = document.getElementById("name_error");
        setError(ele, fname, "Name cannot be blank");
        return false;
    }
    else {
        let ele = document.getElementById("name_error");
        let pattern =  /^[a-zA-Z ]*$/;
        if (fname.value.length < 3) {
            setError(ele, fname, "Name is too short");
            return false;
        }
        else if (!fname.value.match(pattern)) {
            setError(ele, fname, "Only alphabets are allowed");
            return false;
        }
        ele.innerText = "";
    }

    if (lname.value == "") {
        let ele = document.getElementById("name_error");
        setError(ele, lname, "Name cannot be blank");
        return false;
    }
    else {
        let ele = document.getElementById("name_error");
        let pattern =  /^[a-zA-Z ]*$/;
        if (lname.value.length < 3) {
            setError(ele, lname, "Name is too short");
            return false;
        }
        else if (!lname.value.match(pattern)) {
            setError(ele, lname, "Only alphabets are allowed");
            return false;
        }
        ele.innerText = "";
    }

    //validation of email
    if (email.value == "") {
        let ele = document.getElementById("email_error");                
        setError(ele, email, "Email cannot be blank");   
        return false;           
    }
    else {
        let ele = document.getElementById("email_error");
        let pattern = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        if (!email.value.match(pattern)) {
            setError(ele, email, "Provide valid Email address");
            return false;
        }
        ele.innerText = "";
    }

    //validation of gender radio buttons
    
    if (!(radio_male.checked || radio_female.checked || radio_others.checked)) {
        let ele = document.getElementById("radio_error");
        setError(ele, null, "Please select your gender");
        return false;
    }
    else {
        // reset the error message.
        let ele = document.getElementById("radio_error");
        ele.innerText = "";
    }
    
    //validation of password
    if (pass.value == "") {
        let ele = document.getElementById("pass_error");
        setError(ele, pass, "Password cannot be blank");    
        return false;
    }
    else {
        let ele = document.getElementById("pass_error");
        if (pass.value.length < 6 || pass.value.length > 15) {
            setError(ele, pass, "Password must be 6 to 15 character long");
            return false;
        }
        ele.innerText = "";
    }

    if (repass.value == "") {
        let ele = document.getElementById("repass_error");
        setError(ele, pass, "Password didn't match. Try again!");
        return false;
    }
    else {
        let ele = document.getElementById("repass_error");
        if (pass.value != repass.value) {
            setError(ele, repass, "Password didn't match. Try again!");
            return false;
        }
        ele.innerText = "";
    }
    return true;
    
    function setError(e, field=null, msg) {
        e.className = "error";
        if (field != null)
            field.focus();
        e.innerText = msg;
    }
}

function btnstatus(terms) {
    if (terms.checked)
        document.getElementById('submit_btn').disabled = false;
    else 
        document.getElementById('submit_btn').disabled = true;          
}      