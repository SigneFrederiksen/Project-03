<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Project_03.Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container container-bg">
        <section>
            <br />
            <div class="signup-wrapper">
                <div class="signupform">
                    <h2>SIGN UP</h2>
                    <p>Become our client today <br />and get a instant discount!</p>
                    <br />
                    <asp:Label ID="LabelFirstname" runat="server" Text="Firstname:" CssClass="align-left"></asp:Label>
                    <asp:TextBox ID="TextBoxFirstname" runat="server" CssClass="signup-field"></asp:TextBox>
                    <br />
                    <asp:Label ID="LabelLastname" runat="server" Text="Lastname:" CssClass="align-left"></asp:Label>
                    <asp:TextBox ID="TextBoxLastname" runat="server" CssClass="signup-field"></asp:TextBox>
                    <br />
                    <asp:Label ID="LabelStreet" runat="server" Text="Street:" CssClass="align-left"></asp:Label>
                    <asp:TextBox ID="TextBoxStreet" runat="server" CssClass="signup-field"></asp:TextBox>
                    <br />
                    <asp:Label ID="LabelZip" runat="server" Text="ZipcodeID:" CssClass="align-left"></asp:Label>
                    <asp:TextBox ID="TextBoxZip" runat="server" CssClass="signup-field"></asp:TextBox>
                    <!--<br />
                    <asp:DropDownList ID="DropDownListZip" runat="server">
                    </asp:DropDownList>
                    <br />-->
                    <asp:Label ID="LabelEmail" runat="server" Text="Email:" CssClass="align-left"></asp:Label>
                    <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="signup-field"></asp:TextBox>
                    <br />
                    <asp:Label ID="LabelPassword" runat="server" Text="Password:" CssClass="align-left"></asp:Label>
                    <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="signup-field"></asp:TextBox>
                    <asp:Button ID="ButtonSignup" runat="server" CssClass="button-green" Text="Sign Up" OnClick="ButtonSignup_Click" />
                    <br />
                    <asp:Label ID="LabelMessage" runat="server" Text="No messages"></asp:Label>
                </div>
            </div>
            <br />
            <br />
        </section>
    </div>
</asp:Content>
