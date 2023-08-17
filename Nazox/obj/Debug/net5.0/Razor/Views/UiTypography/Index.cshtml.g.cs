#pragma checksum "d:\nazos-aps-net-web\Nazox_Asp.net_v1.0.0\Nazox Asp.net Core\Nazox\Views\UiTypography\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b58de9e1987aa7674cead716236bf6a1abc6cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UiTypography_Index), @"mvc.1.0.view", @"/Views/UiTypography/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b58de9e1987aa7674cead716236bf6a1abc6cea", @"/Views/UiTypography/Index.cshtml")]
    #nullable restore
    public class Views_UiTypography_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/metismenu/metisMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/simplebar/simplebar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/node-waves/waves.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "d:\nazos-aps-net-web\Nazox_Asp.net_v1.0.0\Nazox Asp.net Core\Nazox\Views\UiTypography\Index.cshtml"
  
    ViewBag.Title = "Typography";
    ViewBag.pTitle = "Typography";
    ViewBag.pageTitle = "UI Elements";
    Layout = "~/Views/_Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex"">
                    <div class=""ms-3 me-4"">
                        <h1 class=""display-4 mb-0"">A</h1>
                    </div>
                    <div class=""flex-1 align-self-center"">
                        <p class=""mb-2"">Font Family</p>
                        <h5 class=""mb-0"">""Inter"", sans-serif</h5>
                    </div>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Headings</h4>
                <p class=""card-title-desc"">
                    All HTML headings, <code class=""highlighter-rouge"">&lt;h1&gt;</code> through <code class=""highlighter-rouge"">&lt;h6&gt;</code>, are available.
                </p>

                <h1 class=""mb-3"">h1. Bootstrap heading <small class=""text-muted"">Semibold 2.25rem (36px)</small></");
            WriteLiteral(@"h1>
                <h2 class=""mb-3"">h2. Bootstrap heading <small class=""text-muted"">Semibold 1.8rem (28.8px)</small></h2>
                <h3 class=""mb-3"">h3. Bootstrap heading <small class=""text-muted"">Semibold 1.575rem (25.2px)</small></h3>
                <h4 class=""mb-3"">h4. Bootstrap heading <small class=""text-muted"">Semibold 1.35rem (21.6px)</small></h4>
                <h5 class=""mb-3"">h5. Bootstrap heading <small class=""text-muted"">Semibold 1.125rem (18px)</small></h5>
                <h6 class=""mb-0"">h6. Bootstrap heading <small class=""text-muted"">Semibold 0.9rem (14.4px)</small></h6>
            </div>
        </div>
    </div>
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Display headings</h4>
                <p class=""card-title-desc"">Traditional heading elements are designed to work best in the meat of your page content. </p>

                <h1 class=""display-1"">Display 1</h1>
                <");
            WriteLiteral(@"h1 class=""display-2"">Display 2</h1>
                <h1 class=""display-3"">Display 3</h1>
                <h1 class=""display-4"">Display 4</h1>
                <h1 class=""display-5"">Display 5</h1>
                <h1 class=""display-6 mb-0"">Display 6</h1>

            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Inline text elements</h4>
                <p class=""card-title-desc"">Styling for common inline HTML5 elements.</p>

                <p class=""lead"">
                    Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.
                </p>
                <p>You can use the mark tag to <mark>highlight</mark> text.</p>
                <p><del>This line of text is meant to be treated as deleted text.</del></p>
                <p><s>This line of text is meant to be treated as no longer accurate.</s></p>
                <");
            WriteLiteral(@"p><ins>This line of text is meant to be treated as an addition to the document.</ins></p>
                <p><u>This line of text will render as underlined</u></p>
                <p><small>This line of text is meant to be treated as fine print.</small></p>
                <p><strong>This line rendered as bold text.</strong></p>
                <p class=""mb-0""><em>This line rendered as italicized text.</em></p>
            </div>
        </div>



    </div> <!-- end col -->

    <div class=""col-xl-6"">

        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Unstyled List</h4>
                <p class=""card-title-desc"">
                    Remove the default <code class=""highlighter-rouge"">list-style</code> and left margin on list
                    items (immediate children only). <strong>
                        This only applies to immediate
                        children list items
                    </strong>, meaning you will need");
            WriteLiteral(@" to add the class
                    for any nested lists as well.
                </p>

                <ul class=""list-unstyled mb-0"">
                    <li>Integer molestie lorem at massa</li>
                    <li>
                        Nulla volutpat aliquam velit
                        <ul>
                            <li>Phasellus iaculis neque</li>
                            <li>Purus sodales ultricies</li>
                            <li>Vestibulum laoreet porttitor sem</li>
                        </ul>
                    </li>
                    <li>Faucibus porta lacus fringilla vel</li>
                </ul>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Inline List</h4>
                <p class=""card-title-desc"">
                    Remove a list’s bullets and apply some
                    light <code class=""highlighter-rouge"">margin</code> with a combination
         ");
            WriteLiteral(@"           of two classes, <code class=""highlighter-rouge"">.list-inline</code> and
                    <code class=""highlighter-rouge"">.list-inline-item</code>.
                </p>

                <ul class=""list-inline mb-0"">
                    <li class=""list-inline-item"">Lorem ipsum</li>
                    <li class=""list-inline-item"">Phasellus iaculis</li>
                    <li class=""list-inline-item"">Nulla volutpat</li>
                </ul>

            </div>
        </div>

    </div> <!-- end col -->
</div> <!-- end row -->

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Blockquotes</h4>
                <p class=""card-title-desc"">
                    For quoting blocks of content from
                    another source within your document. Wrap <code class=""highlighter-rouge"">
                        &lt;blockquote
                        class=""blockquote""&gt;
    ");
            WriteLiteral(@"                </code> around any <abbr title=""HyperText Markup Language"">HTML</abbr> as the quote.
                </p>

                <div class=""row"">
                    <div class=""col-xl-6"">
                        <div>
                            <blockquote class=""blockquote font-size-16 mb-0"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                                <footer class=""blockquote-footer m-0"">Someone famous in <cite title=""Source Title"">Source Title</cite></footer>
                            </blockquote>
                        </div>
                    </div>
                    <div class=""col-xl-6"">
                        <div class=""mt-4 mt-lg-0"">
                            <blockquote class=""blockquote  blockquote-reverse font-size-16 mb-0"">
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
              ");
            WriteLiteral(@"                  <footer class=""blockquote-footer m-0"">Someone famous in <cite title=""Source Title"">Source Title</cite></footer>
                            </blockquote>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-12"">

        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Description list alignment</h4>
                <p class=""card-title-desc"">
                    Align terms and descriptions
                    horizontally by using our grid system’s predefined classes (or semantic
                    mixins). For longer terms, you can optionally add a <code class=""highlighter-rouge"">.text-truncate</code> class to
                    truncate the text with an ellipsis.
                </p>

                <dl class=""row mb-0"">
                    <dt class=""col-sm-3"">Description lists");
            WriteLiteral(@"</dt>
                    <dd class=""col-sm-9"">A description list is perfect for defining terms.</dd>

                    <dt class=""col-sm-3"">Euismod</dt>
                    <dd class=""col-sm-9"">Vestibulum id ligula porta felis euismod semper eget lacinia odio sem nec elit.</dd>
                    <dd class=""col-sm-9 offset-sm-3"">Donec id elit non mi porta gravida at eget metus.</dd>

                    <dt class=""col-sm-3"">Malesuada porta</dt>
                    <dd class=""col-sm-9"">Etiam porta sem malesuada magna mollis euismod.</dd>

                    <dt class=""col-sm-3 text-truncate"">Truncated term is truncated</dt>
                    <dd class=""col-sm-9"">Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</dd>

                    <dt class=""col-sm-3"">Nesting</dt>
                    <dd class=""col-sm-9 mb-0"">
                        <dl class=""row mb-0"">
                            <dt class=""col-sm-4"">Nested definit");
            WriteLiteral(@"ion list</dt>
                            <dd class=""col-sm-8"">Aenean posuere, tortor sed cursus feugiat, nunc augue blandit nunc.</dd>
                        </dl>
                    </dd>
                </dl>

            </div>
        </div>

    </div> <!-- end col -->
</div> <!-- end row -->

<!-- JAVASCRIPT -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b58de9e1987aa7674cead716236bf6a1abc6cea15297", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b58de9e1987aa7674cead716236bf6a1abc6cea16337", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b58de9e1987aa7674cead716236bf6a1abc6cea17377", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b58de9e1987aa7674cead716236bf6a1abc6cea18417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b58de9e1987aa7674cead716236bf6a1abc6cea19457", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b58de9e1987aa7674cead716236bf6a1abc6cea20501", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
