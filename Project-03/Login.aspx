<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project_03.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container container-bg">
        <section>
            <br />
            <div class="signup-wrapper">
                <div class="signupform">
                    <h2>Login</h2>
                    <p>Login to your account!</p>
                    <br />
                    <asp:Label ID="LabelEmail" runat="server" Text="Email:" CssClass="align-left"></asp:Label>
                    <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="signup-field"></asp:TextBox>
                    <br />
                    <asp:Label ID="LabelPassword" runat="server" Text="Password:" CssClass="align-left"></asp:Label>
                    <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="signup-field"></asp:TextBox>
                    <asp:Button ID="ButtonLogin" runat="server" CssClass="button-green" Text="Login" OnClick="ButtonLogin_Click"/>
                    <br />
                    <asp:Label ID="LabelMessage" runat="server" Text="No messages"></asp:Label>
                </div>
            </div>
            <br />
            <br />
        </section>
    </div>
</asp:Content>
