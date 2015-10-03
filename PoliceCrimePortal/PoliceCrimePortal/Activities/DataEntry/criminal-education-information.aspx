<%@ Page Title="Criminal Education Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="criminal-education-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.criminal_education_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter educational information.</h2>
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
        <legend>Criminal Physical Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtEducationalStatus">Educational Status:</asp:Label>
                <asp:TextBox runat="server" ID="txtEducationalStatus" />

            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtNameofInstitution">Name of Institution</asp:Label>
                <asp:TextBox runat="server" ID="txtNameofInstitution" />

            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPoliticalInvolvementinInstitution">Political Involvement in Institution:</asp:Label>
                <asp:TextBox runat="server" ID="txtPoliticalInvolvementinInstitution" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnAddmore" Text="Add More" OnClick="btnAddmore_Click" />
        <asp:Button runat="server" ID="btnSave" Text="Save & Continue" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>
