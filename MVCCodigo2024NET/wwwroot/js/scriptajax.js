$(document).ready(function () {

    $('#contactForm').submit(function (event) {

        // Evitar que el formulario se envíe automáticamente
        event.preventDefault();

        // Variables para controlar si el formulario es válido
        let isValid = true;

        // Validar el campo de nombre
        const nameinput = $('#name').val().trim();
        // Validar el campo de correo electrónico
        const emailinput = $('#email').val().trim();


        $.ajax({
            type: "POST",
            url: "/Home/SubmitForm",
            data: {
                name: nameinput,
                email: emailinput        
            },
            success: function (response) {
                //$('#message').text(response.message);
                $('#name').val(response.message);
                //alert(response.message);

            },
            error: function () {
                //$('#message').text("Hubo un error al enviar el formulario.");
                alert('Hubo un error al enviar el formulario.');

            }
        });

        //alert('Después de la llamada asíncrona');


    });
});


