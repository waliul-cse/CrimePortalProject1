<%@ Page Title="Criminal Death Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="criminal-death-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.criminal_dead_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter address information.</h2>
    </hgroup>

    <p class="message-info">
        <span class="require">*</span> Require Field.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <fieldset>
        <legend>Criminal Address Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDeathTime">Time of Death:</asp:Label>
                <asp:TextBox runat="server" ID="txtDeathTime" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDate">Date of Death:</asp:Label>
                <asp:TextBox runat="server" ID="txtDate" /><span>DD-MM-YYYY</span>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDistrict">District:</asp:Label>
                <asp:TextBox runat="server" ID="txtDistrict" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtUplozila">Upozila/Thana:</asp:Label>
                <asp:TextBox runat="server" ID="txtUplozila" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtUnion">Union/Ward:</asp:Label>
                <asp:TextBox runat="server" ID="txtUnion" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtVillage">Village:</asp:Label>
                <asp:TextBox ID="txtVillage" runat="server" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtReason">Reason:</asp:Label>
                <asp:TextBox runat="server" ID="txtReason" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>
