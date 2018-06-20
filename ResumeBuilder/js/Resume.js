$("#btnSave").on('click', function () {
   
   
    var addr = $("txtCity").val();
    alert(addr);
        $.ajax({
            type: "POST",
            url: UpdateInfoUrl,
            data: {
                Firstname: $("#txtFirstname").val(),
                Lastname: $("#txtLastname").val(),
                StreetAddress: $("#txtAddress").val(),
                City: $("#txtCity").val(),
                StateProvince: $("#txtProvince").val(),
                ZipCode: $("#txtZipcode").val(),
                Number: $("#txtContactNo").val()
            },
            dataType: "json",


        });
      
     
            
    })


function AuthenticationMessage(data) {
    if (data.access == true) {
        alert("User Access is Granted");
    }
    else {
        alert("User Access is Denied");

    }
}
