<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ExterminatorUpdate.aspx.cs" Inherits="Project_03.ExterminatorUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <section>

            <br />
            <br />
            <asp:GridView ID="GridViewPest" runat="server" OnSelectedIndexChanged="GridViewPest_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <h4>Update selected Pest:</h4>
            <br />
            <asp:Label ID="LabelName" runat="server" Text="Pest name:" CssClass="label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxName" runat="server" CssClass="field"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelPrice" runat="server" Text="Price:" CssClass="label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPrice" runat="server" CssClass="field"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelPicture" runat="server" Text="Picture:" CssClass="label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPicture" runat="server" CssClass="field"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="No message"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonUpdate" runat="server" Text="Update selected pest" OnClick="ButtonUpdate_Click" CssClass="button-green-small" />
            <br />
            <br />
            <br />

        </section>
    </div>
</asp:Content>