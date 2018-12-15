using System;
using static AutoBrowseWebApp.Utilities.EnvironmentHelper;

namespace AutoBrowseWebApp.Utilities
{
    public static class ExceptionHelper
    {
        public static ExceptionResult RandomException()
        {
            switch (new Random().Next(1, 7))
            {
                case 1:
                    return ThrowException<NullReferenceException>();
                case 2:
                    return ThrowException<ArgumentException>();
                case 3:
                    return ThrowException<AggregateException>();
                case 4:
                    return ThrowException<FieldAccessException>();
                case 5:
                    return ThrowException<OutOfMemoryException>();
                case 6:
                    return ThrowException<StackOverflowException>();
                default:
                    return ThrowException<NotImplementedException>();
            }
        }

        public static ExceptionResult ThrowException<T>() where T : Exception
        {
            try
            {
                throw Activator.CreateInstance<T>();
            }
            catch (Exception e)
            {
                if (IsThrowOutException) throw e;

                return new ExceptionResult
                {
                    Name = typeof(T).FullName,
                    Message = e.Message
                };
            }
        }
    }

    public class ExceptionResult
    {
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
