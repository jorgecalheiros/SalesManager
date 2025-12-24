namespace SalesManager.Presentation.WinForms.Extensions
{
    public static class ValidationExtensios
    {
        public static void ApplyValidationErrors(this Form form, FluentValidation.ValidationException validationException, ErrorProvider errorProvider, Func<string, Control?> findControlStrategy)
        {
            errorProvider.Clear();

            var failuresByProperty = validationException.Errors
            .GroupBy(e => e.PropertyName)
            .Select(g => new
            {
                PropertyName = g.Key,
                ErrorMessage = string.Join("\n", g.Select(x => x.ErrorMessage))
            });

            foreach (var error in failuresByProperty)
            {

                var control = findControlStrategy(error.PropertyName);
                if (control != null)
                {
                    errorProvider.SetError(control, error.ErrorMessage);
                }
            }
        }
    }
}
