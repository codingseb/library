using QuestPDF.Examples.Engine;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPDF.Examples
{
    public class ElementExamples : ExampleTestBase
    {
        //[ShowResult]
        [ImageSize(200, 150)]
        public void Placeholder(IContainer container)
        {
            container
                .Background("#FFF")
                .Padding(25)
                .Placeholder();
        }
        
        //[ShowResult]
        [ImageSize(300, 300)]
        public void Section(IContainer container)
        {
            container
                .Background("#FFF")
                .Padding(25)
                .Section(section =>
                {
                    section
                        .Header()
                        .Background("#888")
                        .Padding(10)
                        .Text("Notes", TextStyle.Default.Size(16).Color("#FFF"));
                    
                    section
                        .Content()
                        .Background("#DDD")
                        .Padding(10)
                        .ExtendVertical()
                        .Text(TextPlaceholder.LoremIpsum());
                });
        }
        
        //[ShowResult]
        [ImageSize(298, 421)]
        public void Page(IContainer container)
        {
            container
                .Background("#FFF")
                .Padding(15)
                .Page(page =>
                {
                    page.Header()
                        .Height(60)
                        .Background("#BBB")
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Header");
                    
                    page.Content()
                        .Background("#DDD")
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Content");
                        
                    page.Footer()
                        .Height(30)
                        .Background("#BBB")
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Footer");
                });
        }
        
        //[ShowResult]
        [ImageSize(740, 200)]
        public void Row(IContainer container)
        {
            container
                .Background("#FFF")
                .Padding(20)
                .Stack(stack =>
                {
                    stack.Element()
                        .PaddingBottom(10)
                        .AlignCenter()
                        .Text("This Row element is 700pt wide");

                    stack.Element().Row(row =>
                    {
                        row.ConstantColumn(100)
                            .Background("#DDD")
                            .Padding(10)
                            .ExtendVertical()
                            .Text("This column is 100 pt wide");

                        row.RelativeColumn()
                            .Background("#BBB")
                            .Padding(10)
                            .Text("This column takes 1/3 of the available space (200pt)");

                        row.RelativeColumn(2)
                            .Background("#DDD")
                            .Padding(10)
                            .Text("This column takes 2/3 of the available space (400pt)");
                    });
                });
        }
        
        //[ShowResult]
        [ImageSize(500, 350)]
        public void Column(IContainer container)
        {
            container
                .Background("#FFF")
                .Padding(15)
                .Stack(column =>
                {
                    column.Spacing(10);
                    
                    column
                        .Element()
                        .Background("#999")
                        .Height(50);
                    
                    column
                        .Element()
                        .Background("#BBB")
                        .Height(100);
                    
                    column
                        .Element()
                        .Background("#DDD")
                        .Height(150);
                });
        }
    }
}