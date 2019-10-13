#pragma checksum "C:\myDev\Webapplication1\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33600f842eec7ae88e4a1b6eb81b7fe00b35498b"
// <auto-generated/>
#pragma warning disable 1591
namespace Webapplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\myDev\Webapplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\myDev\Webapplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\myDev\Webapplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\myDev\Webapplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\myDev\Webapplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\myDev\Webapplication1\_Imports.razor"
using Webapplication1;

#line default
#line hidden
#line 7 "C:\myDev\Webapplication1\_Imports.razor"
using Webapplication1.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "to-do (");
            __builder.AddContent(2, 
#line 3 "C:\myDev\Webapplication1\Pages\Todo.razor"
            todos.Count(todo => !todo.IsDone)

#line default
#line hidden
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "ul");
            __builder.AddMarkupContent(6, "\r\n");
#line 6 "C:\myDev\Webapplication1\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "li");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "checkbox");
            __builder.AddAttribute(12, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 9 "C:\myDev\Webapplication1\Pages\Todo.razor"
                                          todo.IsDone

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 10 "C:\myDev\Webapplication1\Pages\Todo.razor"
                          todo.Title

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 12 "C:\myDev\Webapplication1\Pages\Todo.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "placeholder", "Something todo");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 15 "C:\myDev\Webapplication1\Pages\Todo.razor"
                                           newTodo

#line default
#line hidden
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "C:\myDev\Webapplication1\Pages\Todo.razor"
                  AddTodo

#line default
#line hidden
            ));
            __builder.AddContent(28, "Add todo");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 18 "C:\myDev\Webapplication1\Pages\Todo.razor"
       
    private IList<ToDoItem> todos = new List<ToDoItem>();

    private string newTodo;

    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new ToDoItem { Title = newTodo });
        }
        // todo: Add the todo
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
