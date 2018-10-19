<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CustomerPage.aspx.cs" Inherits="Project_03.CustomerPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <section>

            <br />
            <br />
            <asp:GridView ID="GridViewRequest" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="No messages"></asp:Label>
            <br />
            <br />
            <br />

        </section>
    </div>
</asp:Content>
