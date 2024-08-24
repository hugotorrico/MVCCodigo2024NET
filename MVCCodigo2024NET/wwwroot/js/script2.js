$(document).ready(function () {
    $('#contactForm').validate({
        rules: {
            name: {
                required: true,
                minlength: 2
            },
            email: {
                required: true,
                email: true
            },
            phone: {
                required: true,
                digits: true,
                minlength: 10,
                maxlength: 10
            }
        },
        messages: {
            name: {
                required: "Por favor, ingrese su nombre.",
                minlength: "El nombre debe tener al menos 2 caracteres."
            },
            email: {
                required: "Por favor, ingrese su correo electrónico.",
                email: "Por favor, ingrese un correo electrónico válido."
            },
            phone: {
                required: "Por favor, ingrese su número de teléfono.",
                digits: "El teléfono solo debe contener dígitos.",
                minlength: "El teléfono debe tener 10 dígitos.",
                maxlength: "El teléfono debe tener 10 dígitos."
            }
        },
        submitHandler: function (form) {
            alert('Formulario enviado con éxito.');
            form.submit();
        }
    });
});
