<%@ Page Title="Crime Criminal Activities" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crime-criminal-activities.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.crime_criminal_activities" %>
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
        <legend>Criminal Activities Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
           
            <li>
                <asp:Label runat="server" AssociatedControlID="txtpreviousAcitivity">Previous Acitivity:</asp:Label>
                <asp:TextBox runat="server" ID="txtpreviousAcitivity" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtCurrentActivity">Current Activity:</asp:Label>
                <asp:TextBox runat="server" ID="txtCurrentActivity" />
            </li>           
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>