namespace dotNet_Automation_course.CustomExceptions
{
    public class RemoveAutoException: Exception
    {
        public RemoveAutoException() : base() { }
        public RemoveAutoException(string message) : base(message) { }
        public RemoveAutoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
