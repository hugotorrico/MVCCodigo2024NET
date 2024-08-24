$(document).ready(function () {
 
    $('#contactForm').submit(function (event) {
        
        // Evitar que el formulario se envíe automáticamente
        event.preventDefault();

        // Variables para controlar si el formulario es válido
        let isValid = true;

        // Validar el campo de nombre
        const name = $('#name').val().trim();
       
        if (name === '') {
            $('#nameError').text('El nombre es obligatorio.');
            isValid = false;
        } else {

            if (name.length < 5) {
                $('#nameError').text('El nombre debe tener al menos 5 caracteres.');
                isValid = false;
            }
            else {
                $('#nameError').text('');
            }           
        }

        const password = $('#password').val().trim();
        if (password === '') {
            $('#passwordError').text('El password es obligatorio.');
            isValid = false;
        } else {
            if (password.length < 8) {
                $('#passwordError').text('El password debe tener al menos 8 caracteres.');
                isValid = false;
            }
            else {
                $('#passwordError').text('');
            }           
            
        }

        const password2 = $('#password2').val().trim();
        if (password2 === '') {
            $('#password2Error').text('El password repetido es obligatorio.');
            isValid = false;
        } else {
            $('#password2Error').text('');
        }


        if (password != password2) {
            isValid = false;
            $('#password2Error').text('Los password no coinciden');         
        }
        else {
            $('#password2Error').text('');
        }


        // Validar el campo de correo electrónico
        const email = $('#email').val().trim();
        const emailPattern = /^[^@]+@[^@]+\.[a-zA-Z]{2,}$/;
        if (email === '') {
            $('#emailError').text('El correo electrónico es obligatorio.');
            isValid = false;
        } else if (!emailPattern.test(email)) {
            $('#emailError').text('Por favor, ingrese un correo electrónico válido.');
            isValid = false;
        } else {
            $('#emailError').text('');
        }

        // Si el formulario es válido, se puede enviar
        if (isValid) {
            alert('Formulario enviado con éxito.');
            // Aquí puedes enviar el formulario usando AJAX o simplemente dejar que se envíe normalmente
            /*this.submit();*/

            $.ajax({
                type: "POST",
                url: "/Home/SubmitForm",
                data: {
                    name: name,
                    email: email
                },
                success: function (response) {
                    //$('#message').text(response.message);
                    
                },
                error: function () {
                    //$('#message').text("Hubo un error al enviar el formulario.");
                    alert('Hubo un error al enviar el formulario.');

                }
            });

            
        }



    });
});