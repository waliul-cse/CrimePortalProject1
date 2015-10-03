<%@ Page Title="Crime Case Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crime-case-details.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.crime_case_details" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter Crime Case Details.</h2>
    </hgroup>

    <p class="message-info">
        <span class="require">*</span> Require Field.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <p class="message-success">
        <asp:Literal runat="server" ID="SuccessMessage" />
    </p>
    <fieldset>
        <legend>Criminal Crime Case Details Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
           
            <li>
                <asp:Label runat="server" AssociatedControlID="txtCaseNo">Case No:</asp:Label>
                <asp:TextBox runat="server" ID="txtCaseNo" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDistrict">District:</asp:Label>
                <asp:TextBox runat="server" ID="txtDistrict" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtThana">Upozila:</asp:Label>
                <asp:TextBox runat="server" ID="txtThana" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDate">Date:</asp:Label>
                <asp:TextBox runat="server" TextMode="Date" ID="txtDate" /><span>DD-MM-YYYY</span>
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save & Continue" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>