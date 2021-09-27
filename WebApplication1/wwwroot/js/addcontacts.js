function validateAddContactForm() {
    const fname = document.getElementById('fname');
    const lname = document.getElementById('lname');
    const email = document.getElementById('email');
    const phone = document.getElementById('phone');
    const fax = document.getElementById('fax');

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
        let pattern = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
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
        let ele = document.getElementById("radio_error");
        ele.innerText = "";
    }
    
    //validation of phone
    if (phone.value == "") {
        let ele = document.getElementById("phone_error");
        setError(ele, phone, "Phone number required");    
        return false;
    }
    else {
        let ele = document.getElementById("phone_error");
        let pattern = /^[+]*[(]{0,1}[0-9]{1,3}[)]{0,1}[-\s\./0-9]*$/;
        if (!phone.value.match(pattern)) {
            setError(ele, phone, "Please provide valid Contact number");
            return false;
        }
        else if (phone.value.length )
        ele.innerText = "";
    }

    if (fax.value == "") {
        let ele = document.getElementById("fax_error");
        setError(ele, fax, "Fax number required");
        return false;
    }
    else {
        let ele = document.getElementById("fax_error");
        let pattern = /^\+?[0-9]+$/;
        if (!fax.value.match(pattern)) {
            setError(ele, fax, "Please provide valid fax.");
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