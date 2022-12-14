#pragma checksum "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a64c0288f69e2c77e6f5be1c5da4cad17fbfdc4"
// <auto-generated/>
#pragma warning disable 1591
namespace ShuffleDeck.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using ShuffleDeck;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using ShuffleDeck.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\_Imports.razor"
using ShuffleDeck.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
using ShuffleDeck.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Shuffle Deck of Cards</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container floatLeft");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                           () => Shuffle()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Shuffle Cards");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                           () => GetDeck()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Order Cards");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                           () => DealDeck()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Deal Cards");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "\r\n            Choose Players:\r\n            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "radio");
            __builder.AddAttribute(22, "name", "players");
            __builder.AddAttribute(23, "checked", 
#nullable restore
#line 18 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                          _fourPlayers == false

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                                               () => _fourPlayers = false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "Two Players\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "radio");
            __builder.AddAttribute(28, "name", "players");
            __builder.AddAttribute(29, "checked", 
#nullable restore
#line 19 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                          @_fourPlayers == true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                                               () => _fourPlayers = true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "Four Players\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        <br>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "container");
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 25 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
         if (_deck != null)
        {
            foreach (var card in _deck)
            {
                ChangeSuitColor(card.Suit);


#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, ":key", 
#nullable restore
#line 31 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                            card.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "class", "card");
            __builder.AddAttribute(41, "style", "color:" + " " + (
#nullable restore
#line 31 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                 _color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "class", "card__suit card__suit--top");
            __builder.AddContent(45, 
#nullable restore
#line 32 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                              card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "class", "card__number");
            __builder.AddContent(49, " ");
            __builder.AddContent(50, 
#nullable restore
#line 33 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                 card.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "span");
            __builder.AddAttribute(54, "class", "card__suit card__suit--bottom");
            __builder.AddContent(55, " ");
            __builder.AddContent(56, 
#nullable restore
#line 34 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                  card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 36 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "container floatLeft");
            __builder.AddMarkupContent(64, "\r\n\r\n");
#nullable restore
#line 42 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
         if (_players != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "float-left");
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.AddMarkupContent(69, "<h4>Player One:</h4>\r\n");
#nullable restore
#line 46 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                 foreach (var card in _players.PlayerOne)
                {
                    ChangeSuitColor(card.Suit);


#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, ":key", 
#nullable restore
#line 50 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                card.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(73, "class", "card");
            __builder.AddAttribute(74, "style", "color:" + " " + (
#nullable restore
#line 50 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                     _color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "span");
            __builder.AddAttribute(77, "class", "card__suit card__suit--top");
            __builder.AddContent(78, 
#nullable restore
#line 51 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                  card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "span");
            __builder.AddAttribute(81, "class", "card__number");
            __builder.AddContent(82, " ");
            __builder.AddContent(83, 
#nullable restore
#line 52 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                     card.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(84, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "span");
            __builder.AddAttribute(87, "class", "card__suit card__suit--bottom");
            __builder.AddContent(88, " ");
            __builder.AddContent(89, 
#nullable restore
#line 53 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                      card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 55 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.AddContent(95, "            ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "float-left");
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.AddMarkupContent(99, "<h4>Player Two:</h4>\r\n");
#nullable restore
#line 60 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                 foreach (var card in _players.PlayerTwo)
                {
                    ChangeSuitColor(card.Suit);


#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                    ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, ":key", 
#nullable restore
#line 64 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                card.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(103, "class", "card");
            __builder.AddAttribute(104, "style", "color:" + " " + (
#nullable restore
#line 64 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                     _color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.OpenElement(106, "span");
            __builder.AddAttribute(107, "class", "card__suit card__suit--top");
            __builder.AddContent(108, 
#nullable restore
#line 65 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                  card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.OpenElement(110, "span");
            __builder.AddAttribute(111, "class", "card__number");
            __builder.AddContent(112, " ");
            __builder.AddContent(113, 
#nullable restore
#line 66 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                     card.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(114, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.OpenElement(116, "span");
            __builder.AddAttribute(117, "class", "card__suit card__suit--bottom");
            __builder.AddContent(118, " ");
            __builder.AddContent(119, 
#nullable restore
#line 67 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                      card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(120, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 69 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 71 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"

            if (_fourPlayers != false)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "                ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "float-left");
            __builder.AddMarkupContent(128, "\r\n                    ");
            __builder.AddMarkupContent(129, "<h4>Player Three:</h4>\r\n");
#nullable restore
#line 76 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                     foreach (var card in _players.PlayerThree)
                    {
                        ChangeSuitColor(card.Suit);


#line default
#line hidden
#nullable disable
            __builder.AddContent(130, "                        ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, ":key", 
#nullable restore
#line 80 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                    card.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(133, "class", "card");
            __builder.AddAttribute(134, "style", "color:" + " " + (
#nullable restore
#line 80 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                         _color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(135, "\r\n                            ");
            __builder.OpenElement(136, "span");
            __builder.AddAttribute(137, "class", "card__suit card__suit--top");
            __builder.AddContent(138, 
#nullable restore
#line 81 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                      card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                            ");
            __builder.OpenElement(140, "span");
            __builder.AddAttribute(141, "class", "card__number");
            __builder.AddContent(142, " ");
            __builder.AddContent(143, 
#nullable restore
#line 82 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                         card.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(144, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                            ");
            __builder.OpenElement(146, "span");
            __builder.AddAttribute(147, "class", "card__suit card__suit--bottom");
            __builder.AddContent(148, " ");
            __builder.AddContent(149, 
#nullable restore
#line 83 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                          card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(150, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
#nullable restore
#line 85 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(153, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
            __builder.AddContent(155, "                ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "float-left");
            __builder.AddMarkupContent(158, "\r\n                    ");
            __builder.AddMarkupContent(159, "<h4>Player Four:</h4>\r\n");
#nullable restore
#line 90 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                     foreach (var card in _players.PlayerFour)
                    {
                        ChangeSuitColor(card.Suit);


#line default
#line hidden
#nullable disable
            __builder.AddContent(160, "                        ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, ":key", 
#nullable restore
#line 94 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                    card.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(163, "class", "card");
            __builder.AddAttribute(164, "style", "color:" + " " + (
#nullable restore
#line 94 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                         _color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(165, "\r\n                            ");
            __builder.OpenElement(166, "span");
            __builder.AddAttribute(167, "class", "card__suit card__suit--top");
            __builder.AddContent(168, 
#nullable restore
#line 95 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                      card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n                            ");
            __builder.OpenElement(170, "span");
            __builder.AddAttribute(171, "class", "card__number");
            __builder.AddContent(172, " ");
            __builder.AddContent(173, 
#nullable restore
#line 96 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                         card.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(174, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                            ");
            __builder.OpenElement(176, "span");
            __builder.AddAttribute(177, "class", "card__suit card__suit--bottom");
            __builder.AddContent(178, " ");
            __builder.AddContent(179, 
#nullable restore
#line 97 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                                                                          card.Suit

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(180, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n");
#nullable restore
#line 99 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(183, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n");
#nullable restore
#line 101 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(185, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "container floatLeft");
            __builder.AddMarkupContent(189, "\r\n        ");
            __builder.OpenElement(190, "button");
            __builder.AddAttribute(191, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                           () => DealDeck()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(192, "Deal Cards");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n        ");
            __builder.OpenElement(194, "button");
            __builder.AddAttribute(195, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                           () => RemoveDeck()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(196, "Remove Cards");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n        ");
            __builder.OpenElement(198, "button");
            __builder.AddAttribute(199, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
                           () => RemovePlayersHands()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(200, "Remove Players Cards");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Users\lmoor\source\repos\Projects\ShuffleDeck\ShuffleDeck.Web\Pages\Index.razor"
       
    #region UI Logoc

    private string _color;
    private List<Card> _deck;
    private Players _players;
    private bool _fourPlayers;
    HttpClient http = new HttpClient();
    private static Random rnd = new Random();
    string baseUrl = "https://localhost:44301/";

    //protected override async Task OnInitializedAsync() => await GetDeck();

    //Get Deck of Cards
    private async Task GetDeck()
    {
        var response = await http.GetStringAsync(baseUrl + "deck/api");
        _deck = JsonConvert.DeserializeObject<List<Card>>(response);

        if (_players == null || _players.PlayerOne.Any() || _players.PlayerTwo.Any() || _players.PlayerThree.Any() || _players.PlayerFour.Any())
        {
            await RemovePlayersHands();
        }
    }

    //Shuffle Cards
    private async Task Shuffle()
    {
        var response = await http.GetStringAsync(baseUrl + "deck/api");
        _deck = JsonConvert.DeserializeObject<List<Card>>(response).OrderBy(x => rnd.Next()).ToList();

        if (_players == null || _players.PlayerOne.Any() || _players.PlayerTwo.Any() || _players.PlayerThree.Any() || _players.PlayerFour.Any())
        {
            await RemovePlayersHands();
        }
        #region Mentors Way

        //await Task.Run(() =>
        //{
        //    //Create a new list of numbers
        //    var numberList = new List<int>();

        //    while (numberList.Count < 52)
        //    {
        //        //Get new random number
        //        var newRandomNumber = rnd.Next(52);

        //        //Check if number list already contains the new random number
        //        if (numberList.Contains(newRandomNumber))
        //        {
        //            //If number list already contains new random number,
        //            //skip adding new random number
        //            continue;
        //        }

        //        //Add new random number
        //        numberList.Add(newRandomNumber);
        //    }

        //    var shuffledDeck = new List<Card>();
        //    foreach (var idx in numberList)
        //    {
        //        shuffledDeck.Add(_deck[idx]);
        //    }

        //    _deck = shuffledDeck;
        //});

        #endregion
    }

    private async Task RemoveDeck()
    {
        await Task.Run(() =>
        {
            _deck = null;
        });
    }

    private async Task RemovePlayersHands()
    {
        await Task.Run(() =>
        {
            _players = null;
        });
    }

    //Deal Deck
    private async Task DealDeck()
    {
        await Shuffle();

        _players = new Players();
        _players.PlayerOne = new List<Card>();
        _players.PlayerTwo = new List<Card>();
        _players.PlayerThree = new List<Card>();
        _players.PlayerFour = new List<Card>();

        if (_fourPlayers)
        {
            //foreach card in the deck,
            foreach (var card in _deck)
            {
                //Give each player 13 Cards if 4 players.
                if (_players.PlayerOne.Count() < 13)
                {
                    _players.PlayerOne.Add(card);
                }
                else if (_players.PlayerOne.Count() == 13 && _players.PlayerTwo.Count() < 13)
                {
                    _players.PlayerTwo.Add(card);
                }
                else if (_players.PlayerTwo.Count() == 13 && _players.PlayerThree.Count() < 13)
                {
                    _players.PlayerThree.Add(card);
                }
                else if (_players.PlayerThree.Count() == 13 && _players.PlayerFour.Count() < 13)
                {
                    _players.PlayerFour.Add(card);
                }
            }
        }
        else
        {
            //foreach card in the deck,
            foreach (var card in _deck)
            {
                //Give each player 26 Cards if 2 players.
                if (_players.PlayerOne.Count() < 26)
                {
                    _players.PlayerOne.Add(card);
                }
                else if (_players.PlayerOne.Count() == 26 && _players.PlayerTwo.Count() < 26)
                {
                    _players.PlayerTwo.Add(card);
                }
            }
        }


        await RemoveDeck();
    }

    private void ChangeSuitColor(char suit)
    {
        if (suit == '???' || suit == '???')
        {
            _color = "red";
        }
        else
        {
            _color = "black";
        }
    }

    #endregion

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
