﻿using NUnit.Framework;
using QuestPDF.Elements;
using QuestPDF.UnitTests.TestEngine;

namespace QuestPDF.UnitTests
{
    [TestFixture]
    public class DebugTests
    {
        [Test]
        public void Measure_ShouldHandleNullChild() => new Debug().MeasureWithoutChild();
    }
}