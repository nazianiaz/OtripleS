﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace OtripleS.Web.Api.Models.ExamFees.Exceptions
{
    public class InvalidExamFeeException : Exception
    {
        public InvalidExamFeeException(string parameterName, object parameterValue)
           : base($"Invalid ExamFee, " +
                 $"ParameterName: {parameterName}, " +
                 $"ParameterValue: {parameterValue}.")
        { }
    }
}
