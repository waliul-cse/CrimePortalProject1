<%@ Page Title="Criminal Travel Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="criminal-travel-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.criminal_travel_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter travel information.</h2>
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
        <legend>Criminal Travel Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtCountryVisited">Country Visited</asp:Label>
                <asp:TextBox runat="server" ID="txtCountryVisited" />

            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtArrivalDate">Arrival Date</asp:Label>
                <asp:TextBox runat="server" ID="txtArrivalDate" />
                <span>DD-MM-YYYY</span>

            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDepartureDate">Departure Date:</asp:Label>
                <asp:TextBox runat="server" ID="txtDepartureDate" />
                <span>DD-MM-YYYY</span>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDuration">Duration:</asp:Label>
                <asp:TextBox runat="server" ID="txtDuration" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtAddressAbroad">Address Abroad:</asp:Label>
                <asp:TextBox runat="server" ID="txtAddressAbroad" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnAddmore" Text="Add More" OnClick="btnAddmore_Click" />
        <asp:Button runat="server" ID="btnSave" Text="Save & Continue" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>
