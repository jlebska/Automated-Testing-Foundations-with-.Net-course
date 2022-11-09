

namespace dotNet_Automation_course.CustomExceptions
{
    public class InitializationException:Exception
    {
        public InitializationException() : base() { }
        public InitializationException(string message) : base(message) { }
        public InitializationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
