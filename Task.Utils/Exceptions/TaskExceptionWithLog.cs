namespace Task.Utils.Exceptions;

public class TaskExceptionWithLog : Exception
{
    public TaskExceptionWithLog()
    {
    }

    public TaskExceptionWithLog(string message) : base(message)
    {
    }

    public TaskExceptionWithLog(string message, Exception inner)
        : base(message, inner)
    {
    }
}