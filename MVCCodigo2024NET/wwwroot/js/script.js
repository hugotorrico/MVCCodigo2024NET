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
            $('#nameError').text('');
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
            this.submit();
        }
    });
});