#pragma checksum "C:\Users\inspi\OneDrive\Belgeler\GitHub\Projects\KendiCalişmalarım\MasterChef\MasterChef\Views\Home\Fastfood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ad3dc09c849354db7a87222bb8f5639c3177dd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Fastfood), @"mvc.1.0.view", @"/Views/Home/Fastfood.cshtml")]
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
#nullable restore
#line 1 "C:\Users\inspi\OneDrive\Belgeler\GitHub\Projects\KendiCalişmalarım\MasterChef\MasterChef\Views\_ViewImports.cshtml"
using MasterChef;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\inspi\OneDrive\Belgeler\GitHub\Projects\KendiCalişmalarım\MasterChef\MasterChef\Views\_ViewImports.cshtml"
using MasterChef.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\inspi\OneDrive\Belgeler\GitHub\Projects\KendiCalişmalarım\MasterChef\MasterChef\Views\Home\Fastfood.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ad3dc09c849354db7a87222bb8f5639c3177dd0", @"/Views/Home/Fastfood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5568b3a2fc241d44fc6b312b5f50630f51f0ef0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Fastfood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!--\r\n    Author: W3layouts\r\n    Author URL: http://w3layouts.com\r\n    License: Creative Commons Attribution 3.0 Unported\r\n    License URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n");
#nullable restore
#line 9 "C:\Users\inspi\OneDrive\Belgeler\GitHub\Projects\KendiCalişmalarım\MasterChef\MasterChef\Views\Home\Fastfood.cshtml"
  

    ViewData["Title"] = "FastFood Listesi";
    Layout = "~/Views/Shared/UserLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""/web/css/bootstrap.css"" rel='stylesheet' type='text/css' />
<link rel=""stylesheet"" href=""/web/css/single.css"">
<link href=""/web/css/style.css"" rel='stylesheet' type='text/css' />
<link href=""/web/css/fontawesome-all.css"" rel=""stylesheet"">
<link href=""//fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800""
      rel=""stylesheet"">

<section>
    <div class=""container"">
        <h3 class=""tittle"">FastFood</h3>
        <div class=""row my-2"">
            <!--left-->
            <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
                <div class=""row mb-4"">
                    <div class=""col-md-6 card"">
                        <a href=""single.html"">
                            <img src=""/web/images/1.jpg"" class=""card-img-top img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 1177, "\"", 1183, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body"">
                            <ul class=""blog-icons my-4"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> Feb 20 .2018
                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 21
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""fas fa-eye""></i> 2000
                                    </a>
                                </li>

                            </ul>
                            <h5 class=""card-title "">
                                <a ");
            WriteLiteral(@"href=""single.html"">Blog Post Title</a>
                            </h5>
                            <p class=""card-text mb-3"">Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt.. </p>
                            <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                        </div>
                    </div>
                    <div class=""col-md-6 card"">
                        <a href=""single.html"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ad3dc09c849354db7a87222bb8f5639c3177dd07642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </a>
                        <div class=""card-body"">
                            <ul class=""blog-icons my-4"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> Feb 22 .2018
                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 21
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <i class=""fas fa-eye""></i> 2000
                                    </a>
                                </li>

                            </ul>
                            <h5 class=""card-title "">
                                <a h");
            WriteLiteral(@"ref=""single.html"">Blog Post Title</a>
                            </h5>
                            <p class=""card-text mb-3"">Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt.. </p>
                            <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                        </div>
                    </div>
                </div>
            </div>
            <!--//left-->
            <!--right-->
            <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-left"">
                <div class=""right-blog-info text-left"">
                    <div class=""tech-btm widget_social text-left"">
                        <h4>Stay Connect</h4>
                        <ul>

                            <li>
                                <a class=""twitter"" href=""#"">
                                    <i class=""fab fa-twitter""></i>
                                    <span class=""count"">317K</span> Twitter Followers
           ");
            WriteLiteral(@"                     </a>
                            </li>
                            <li>
                                <a class=""facebook"" href=""#"">
                                    <i class=""fab fa-facebook-f""></i>
                                    <span class=""count"">218k</span> Twitter Followers
                                </a>
                            </li>
                            <li>
                                <a class=""dribble"" href=""#"">
                                    <i class=""fab fa-dribbble""></i>

                                    <span class=""count"">215k</span> Dribble Followers
                                </a>
                            </li>
                            <li>
                                <a class=""pin"" href=""#"">
                                    <i class=""fab fa-pinterest""></i>
                                    <span class=""count"">190k</span> Pinterest Followers
                                </a>
                  ");
            WriteLiteral(@"          </li>

                        </ul>
                    </div>
                    <div class=""tech-btm"">
                    </div>
                    <div class=""tech-btm"">

                        <div class=""blog-grids row mb-3"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""images/6.jpg"" class=""card-img-top img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6326, "\"", 6332, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">
                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Feb, 2018
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""tech-btm"">
                        <div class=""blog-grids row mb-3 text-left"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""images/5.jpg"" class=""card-img-top img-f");
            WriteLiteral("luid\"");
            BeginWriteAttribute("alt", " alt=\"", 7362, "\"", 7368, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""col-md-7 blog-grid-right"">

                                <h5>
                                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                                </h5>
                                <div class=""sub-meta"">
                                    <span>
                                        <i class=""far fa-clock""></i> 20 Jan, 2018
                                    </span>
                                </div>
                            </div>
                            <div class=""clearfix""> </div>
                        </div>
                        <div class=""blog-grids row mb-3 text-left"">
                            <div class=""col-md-5 blog-grid-left"">
                                <a href=""single.html"">
                                    <img src=""images/3.jpg"" class=""card-img-top img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 8387, "\"", 8393, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </aside>
            <!--//right-->
        </div>
    </div>
</section>

<!-- //Custom-JavaScript-File-Links -->
<script src=""/web/js/bootstrap.js""></script>



");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
