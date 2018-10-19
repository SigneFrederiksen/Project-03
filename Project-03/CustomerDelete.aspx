<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CustomerDelete.aspx.cs" Inherits="Project_03.CustomerDelete" %>


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
            <h4>Delete selected Request:</h4>
            <br />
            <asp:DropDownList ID="DropDownListDelete" runat="server" OnSelectedIndexChanged="DropDownListDelete_SelectedIndexChanged" CssClass="field">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="No message"></asp:Label>
            <br />
            <br />     
            <asp:Button ID="ButtonDelete" runat="server" Text="Delete selected request" OnClick="ButtonDelete_Click" CssClass="button-green-small" />
            <br />
            <br />

        </section>
    </div>
</asp:Content>
