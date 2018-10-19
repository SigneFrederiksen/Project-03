<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ExterminatorPage.aspx.cs" Inherits="Project_03.ExterminatorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <section>

            <br />
            <br />
            <asp:GridView ID="GridViewPest" runat="server" OnSelectedIndexChanged="GridViewPest_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="No message"></asp:Label>

        </section>
    </div>
</asp:Content>
