using Kentico.PageBuilder.Web.Mvc;
using NW.CKEditor5_Wysiwyg.Kentico.MVC;

// Registers the Widget, pointing to the View that is actually compiled and located in the CKEditor5_Wysiwyg.View project.
[assembly: RegisterWidget("NW.CKEditor5_Wysiwyg", "Sample widget", typeof(CKEditor5_WysiwygWidgetModel), customViewName: "Widgets/_CKEditor5_Wysiwyg")]

// FOR TESTING
// You can change the registration to point to a local View (non compiled) in order to debug.  
// This particular view is on my MVC Project, NOT my compiled CKEditor5_Wysiwyg.View project
//[assembly: RegisterWidget("NW.CKEditor5_Wysiwyg", "Sample widget", typeof(CKEditor5_WysiwygWidgetModel), customViewName: "Widgets/_CKEditor5_Wysiwyg_Test")]
