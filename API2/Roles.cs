namespace API2
{
    public static class ValidationHelper
    {

        public static UserValidationResult GetRole(string username, string password)
        {
            UserValidationResult validationResult = new UserValidationResult();

            // Aquí puedes realizar la lógica para validar el nombre de usuario y la contraseña
            // y asignar el rol correspondiente según la lógica de tu aplicación.

            // Ejemplo de validación básica:
            if (username == "admin" && password == "admin123")
            {
                validationResult.IsValid = true;
                validationResult.Role = "Administrator";
            }
            else if (username == "superuser" && password == "superuser123")
            {
                validationResult.IsValid = true;
                validationResult.Role = "SuperUser";
            }
            else if (username == "invited" && password == "invited123")
            {
                validationResult.IsValid = true;
                validationResult.Role = "Invited";
            }
            else
            {
                validationResult.IsValid = false;
                validationResult.Role = "User";
            }

            return validationResult;
        }

    }
}
