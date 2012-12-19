<%@ Page Title="Title" Language="C#" Inherits="System.Web.Mvc.ViewPage<Core.GetDemoData.GetDemoDataResult>"
    MasterPageFile="~/Views/Shared/Site.Master" %>

<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent">
</asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <% foreach (var review in Model.Reviews)
       {%>
        <div>
            <h3><%= review.Reviewer %></h3>
            <p><%= review.Stars%> stars</p>
            <p><%= review.Comment%></p>
        </div>
    <%} %>
</asp:Content>
