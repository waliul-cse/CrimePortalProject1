<%@ Page Title="Crime Remand Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crime-remand-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.crime_remand_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter crime Remand information.</h2>
    </hgroup>

    <p class="message-info">
        <span class="require">*</span> Require Field.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <fieldset>
        <legend>Criminal Remand Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRemandNo">Remand No:</asp:Label>
                <asp:TextBox runat="server" ID="txtRemandNo" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDateofRemand">Date of Remand:</asp:Label>
                <asp:TextBox runat="server" TextMode="Date" ID="txtDateofRemand" /> <span>DD-MM-YYYY</span>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDuration">Duration:</asp:Label>
                <asp:TextBox runat="server" ID="txtDuration" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtReasonofRemand">Reason of Remand:</asp:Label>
                <asp:TextBox runat="server" ID="txtReasonofRemand" TextMode="MultiLine" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>
