﻿using FluentAssertions.AspNetCore.Mvc.Tests.Helpers;
using Xunit;

namespace FluentAssertions.AspNetCore.Mvc.Tests
{
    public class FileStreamResultAssertions_Tests
    {
        [Fact]
        public void FileStream_GivenFileStreamResult_ShouldHaveTheSameStream()
        {
            var result = TestDataGenerator.CreateFileStreamResult();

            result.Should()
                .BeFileStreamResult()
                .FileStream
                .Should().BeSameAs(result.FileStream);
        }
    }
}
