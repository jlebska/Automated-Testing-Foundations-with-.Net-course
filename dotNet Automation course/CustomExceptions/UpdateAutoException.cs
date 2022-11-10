
namespace dotNet_Automation_course.CustomExceptions
{
    public class UpdateAutoException:Exception
    {
        public UpdateAutoException() : base() { }
        public UpdateAutoException(string message) : base(message) { }
        public UpdateAutoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
