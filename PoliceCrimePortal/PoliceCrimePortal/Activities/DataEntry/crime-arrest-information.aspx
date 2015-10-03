<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crime-arrest-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.crime_arrest_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter crime zone information.</h2>
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
                <asp:Label runat="server" AssociatedControlID="txtDistrict">District:</asp:Label>
                <asp:TextBox runat="server" ID="txtDistrict" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtUpozila">Upozila:</asp:Label>
                <asp:TextBox runat="server" ID="txtUpozila" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDateofArrest">Date of Arrest:</asp:Label>
                <asp:TextBox runat="server" ID="txtDateofArrest" /><span>DD-MM-YYYY</span>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtArrestBy">Arrest By:</asp:Label>
                <asp:TextBox ID="txtArrestBy" runat="server" />
            </li>
             <li>
                <asp:Label runat="server" AssociatedControlID="txtDisposal">Disposal:</asp:Label>
                <asp:TextBox runat="server" ID="txtDisposal" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>
