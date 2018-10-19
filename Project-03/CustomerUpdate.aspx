<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CustomerUpdate.aspx.cs" Inherits="Project_03.CustomerUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <section>

            <br />
            <br />
            <asp:GridView ID="GridViewRequest" runat="server" OnSelectedIndexChanged="GridViewRequest_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <h4>Update selected Request:</h4>
            <br />
            <asp:Label ID="LabelPestID" runat="server" Text="PestID:" CssClass="label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPestID" runat="server" CssClass="field"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelDate" runat="server" Text="Date:" CssClass="label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxDate" runat="server" CssClass="field"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="No message"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update selected request" CssClass="button-green-small" />
            <br />
            <br />

        </section>
    </div>
</asp:Content>