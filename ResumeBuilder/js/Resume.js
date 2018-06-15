$("#btnSave").on('click', function () {
    var errorCtr = 0;
    var Firstname = $('#txtFirstname').val();
    alert(Firstname);
   
    if (errorCtr == 0) 
        {
        alert(Firstname);
        $.ajax({
            type: "POST",
            url: UpdateInfoUrl,
            data: {
                Firstname: $("#txtFirstname").val(),
                Lastname: $("#txtLastname").val(),
                Address: $("#txtAddress").val(),
                City: $("txtCity").val(),
                Province: $("txtProvince").val(),
                Zipcode: $("txtZipcode").val(),
                EmailAdress: $("txtEmailAddress").val(),
                ContactNo: $("txtContactNo").val()
            },
            dataType: "json"

        });
        }
     
            
    })


function AuthenticationMessage(data) {
    if (data.access == true) {
        alert("User Access is Granted");
    }
    else {
        alert("User Access is Denied");

    }
}
