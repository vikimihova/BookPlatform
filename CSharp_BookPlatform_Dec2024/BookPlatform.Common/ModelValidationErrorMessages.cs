﻿using static BookPlatform.Common.ApplicationConstants;

namespace BookPlatform.Common
{
    public static class ModelValidationErrorMessages
    {
        public static class DateTimeFormats
        {
            public const string WrongDateInputFormat = $"Date must be in format {DateInputFormat}";
            public const string DateInFuture = "Date cannot be in the future.";
        }
    }
}
