﻿using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace QuestPDF.ReportSample
{
    public static class Typography
    {
        public static TextStyle Title => TextStyle.Default.FontType("Helvetica").Color("#000000").Size(20).Bold();
        public static TextStyle Headline => TextStyle.Default.FontType("Helvetica").Color("#047AED").Size(14);
        public static TextStyle Normal => TextStyle.Default.FontType("Helvetica").Color("#000000").Size(10).LineHeight(1.25f).AlignLeft();
    }
}