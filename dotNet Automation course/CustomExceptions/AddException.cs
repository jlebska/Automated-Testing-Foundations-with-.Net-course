
namespace dotNet_Automation_course.CustomExceptions
{
    public class AddException : Exception
    {
        public AddException() : base() { }
        public AddException(string message) : base(message) { }
        public AddException(string message, Exception innerException) : base(message, innerException) { }
    }
}
