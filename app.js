document.querySelector(".contact-box").addEventListener("submit",
    submitForm);

function submitForm(e) {
    e.preventDefault();
    //console.log("submit");
    let name = document.querySelector(".name").value;
    let email = document.querySelector(".email").value;
    let message = document.querySelector(".message").value;
    console.log(name, email, message);

    sendEmail(name, email, message);
}


// password: lmqatdefdpvbmaen

function sendEmail(name, email, message) {
    Email.send({
        Host: "smtp.gmail.com",
        Username: 'leogoliath.alias@gmail.com',
        Password: "lmqatdefdpvbmaen",
        To: 'leogoliath.alias@gmail.com',
        From: 'leogoliath.alias@gmail.com',
        Subject: `${name} has sent a message`,
        Body: `Name: ${name} <br/> Email: ${email} <br/><br/> Message: ${message}`,
    }).then((message) => alert("mail sent successfully"))


}