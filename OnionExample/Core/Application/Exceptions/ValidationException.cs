namespace Application.Exceptions
{
    public class ValidationException : Exception
    {
        public IDictionary<string, string[]> Errors { get; }
        public ValidationException(IDictionary<string, string[]> errors) : base("Doğrulama hatası")
        => Errors = errors;
    }
}
