#pragma checksum "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a637c385df9ba788fccb1c27a29d524cd6a9f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InfoProduct), @"mvc.1.0.view", @"/Views/Home/InfoProduct.cshtml")]
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
#line 1 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\_ViewImports.cshtml"
using PizzaShopWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\_ViewImports.cshtml"
using PizzaShopWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a637c385df9ba788fccb1c27a29d524cd6a9f85", @"/Views/Home/InfoProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b1a7223415f6f87ed5ca3ba1749726f69aba51", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InfoProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaShopWebApp.Models.Pizza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/InfoProduct.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
  
    int index = (int)@ViewData["PizzaId"];
    //string pathPizza = "../" + $"{@Model.ElementAt(index).Image}";
    string pathPizza = $"{@Model.ElementAt(index).Image}";


    Pizza currentPizza = @Model.ElementAt(index);

    var pizzaIngredients = currentPizza.Ingredients;


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a637c385df9ba788fccb1c27a29d524cd6a9f855811", async() => {
                WriteLiteral("\r\n    <title> Shop Pizza</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a637c385df9ba788fccb1c27a29d524cd6a9f856107", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a637c385df9ba788fccb1c27a29d524cd6a9f858076", async() => {
                WriteLiteral(@"
    <div class=""commodity"">
        <div class=""conteiner"">
            <div class=""commodity-main"">
                <div class=""commodity-gallery desktop-only-fl"">
                    <div class=""commodity-gallery__img image-root"">
                        <div class=""image-containet"">
                            <img class=""main-image""");
                BeginWriteAttribute("src", " src=", 852, "", 867, 1);
#nullable restore
#line 29 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
WriteAttributeValue("", 857, pathPizza, 857, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                </div>
                <div class=""commodity-info"">
                    <div class=""commodity-info__base"">
                        <div class=""commodity-info__left"">
                            <div class=""commodity-info__title"">
                                <h1 class=""title"">");
#nullable restore
#line 37 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
                                             Write(currentPizza.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                            </div>\r\n                            <aside>\r\n                                <div class=\"price-container\">\r\n                                    <p>$ ");
#nullable restore
#line 41 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
                                    Write(currentPizza.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </p>

                                </div>
                                <div class=""components-block"">
                                    <div class=""components-block-header"">
                                        <h3 class=""desktop-only""> Description </h3>
                                    </div>
                                    <div class=""components-block-description"">
                                        ");
#nullable restore
#line 49 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
                                   Write(currentPizza.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n\r\n                                    <ul id=\"complement-list\">\r\n");
#nullable restore
#line 53 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
                                         foreach (var ingredient in pizzaIngredients)
                                         {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <li class=""complement-item"">
                                                <div class=""complement-img"">

                                                </div>
                                                <p class=""complement-caption"">
                                                    ");
#nullable restore
#line 60 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
                                               Write(ingredient.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </p>\r\n                                            </li>\r\n");
#nullable restore
#line 63 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
                                         }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </ul>\r\n\r\n                                    <div>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a637c385df9ba788fccb1c27a29d524cd6a9f8512605", async() => {
                    WriteLiteral("Buy");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2842, "~/Home/Buy/", 2842, 11, true);
#nullable restore
#line 67 "C:\Users\Bojc_tq19\Desktop\ASP.NET\PizzaShop\PizzaShopWebApp\PizzaShopWebApp\Views\Home\InfoProduct.cshtml"
AddHtmlAttributeValue("", 2853, currentPizza.Id, 2853, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>

                                </div>
                                
                            </aside>
                           
                            
                        </div>
                       
                    </div>
                   
                </div>
            </div>
           
        </div>
    </div>
   
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaShopWebApp.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
