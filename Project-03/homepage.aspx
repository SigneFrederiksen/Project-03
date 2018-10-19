<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Project_03.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container container-green">
        <section>
            <div class="div-half">
                <h2>Exterminator Company</h2>
                <h3>Professional and fast moving team. <br /> We help both private and companies with pest control.</h3>
                <asp:Button ID="ButtonSignup" runat="server" Text="Sign up now!" CssClass="button" OnClick="ButtonSignup_Click" />
            </div>
        </section>
    </div>
    <div class="container">
        <section style="margin-top: 100px;">
            <!--<asp:Label ID="LabelMessage" runat="server" Text="No errors"></asp:Label>-->
            <asp:Repeater ID="RepeaterPestList" runat="server">
                <ItemTemplate>
                    <div class="Pestlist">
                        <img class="PestlistPic" src="Pictures/<%# Eval("Picture") %>" alt="pest" />
                        <div class="content">
                            <p class="p-small">ID NUMBER: <%# Eval("PestID") %></p>
                            <h4><%# Eval("Name") %></h4>
                            <p>Price: <%# Eval("Price") %>kr.</p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </section>
    </div>
</asp:Content>
