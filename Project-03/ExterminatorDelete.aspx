<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ExterminatorDelete.aspx.cs" Inherits="Project_03.ExterminatorDelete" %>


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
            <h4>Delete selected Pest:</h4>
            <br />
            <asp:DropDownList ID="DropDownListPest" runat="server" OnSelectedIndexChanged="DropDownListPest_SelectedIndexChanged" CssClass="field">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="No message"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete selected pest" CssClass="button-green-small" />
            <br />
            <br />
            <br />

        </section>
    </div>
</asp:Content>