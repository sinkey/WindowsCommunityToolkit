﻿using Microsoft.Toolkit.Parsers.Markdown.Blocks;
using Microsoft.Toolkit.Parsers.Markdown.Inlines;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Markdown.Parse
{
    [TestClass]
    public class SubscriptTests : ParseTestBase
    {
        [TestMethod]
        [TestCategory("Parse - inline")]
        public void Superscript_Tag()
        {
            AssertEqual(
                "This is <sub>tag</sub> create test",
                new ParagraphBlock().AddChildren(
                    new TextRunInline { Text = "This is " },
                    new SubscriptTextInline().AddChildren(
                        new TextRunInline { Text = "tag" }),
                    new TextRunInline { Text = " create test" }));
        }

        [TestMethod]
        [TestCategory("Parse - inline")]
        public void Superscript_TagWithSup()
        {
            AssertEqual(
                "This is <sub>**tag**</sub> create test",
                new ParagraphBlock().AddChildren(
                    new TextRunInline { Text = "This is " },
                    new SubscriptTextInline().AddChildren(
                        new BoldTextInline().AddChildren(
                        new TextRunInline { Text = "tag" })),
                    new TextRunInline { Text = " create test" }));
        }
    }
}
