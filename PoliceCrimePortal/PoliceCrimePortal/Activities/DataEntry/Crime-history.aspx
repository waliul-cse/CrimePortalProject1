<%@ Page Title="Crime History" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crime-history.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.Crime_history" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter Crime History.</h2>
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
        <legend>Criminal Crime History Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ddlCrimeType">Crime Type:</asp:Label>
                <asp:DropDownList ID="ddlCrimeType" runat="server">
                    <asp:ListItem Text="Muder for gain" Value="Muder for gain"></asp:ListItem>
                    <asp:ListItem Text="Dacoity" Value="Dacoity"></asp:ListItem>
                    <asp:ListItem Text="Prep & Assembly for Dacoity" Value="Prep & Assembly for Dacoity"></asp:ListItem>
                    <asp:ListItem Text="Robbery" Value="Robbery"></asp:ListItem>
                    <asp:ListItem Text="Burglary" Value="Burglary"></asp:ListItem>
                    <asp:ListItem Text="Theft" Value="Theft"></asp:ListItem>
                    <asp:ListItem Text="Murder" Value="Murder"></asp:ListItem>
                    <asp:ListItem Text="Attempt to commit murder" Value="Attempt to commit murder"></asp:ListItem>
                    <asp:ListItem Text="C.H.Not Amounting to murder" Value="C.H.Not Amounting to murder"></asp:ListItem>
                    <asp:ListItem Text="Hurt/Grievous Hurt" Value="Hurt/Grievous Hurt"></asp:ListItem>
                    <asp:ListItem Text="Roits" Value="Roits"></asp:ListItem>
                    <asp:ListItem Text="Rape" Value="Rape"></asp:ListItem>
                    <asp:ListItem Text="Dowry Death" Value="Dowry Death"></asp:ListItem>
                    <asp:ListItem Text="Molestation" Value="Molestation"></asp:ListItem>
                    <asp:ListItem Text="Sexual Harassment" Value="Sexual Harassment"></asp:ListItem>
                    <asp:ListItem Text="Cruelty by Husband and her relatives" Value="Cruelty by Husband and her relatives"></asp:ListItem>
                    <asp:ListItem Text="Kidnapping & Abduction of others" Value="Kidnapping & Abduction of others"></asp:ListItem>
                    <asp:ListItem Text="Criminal Breach of Trust" Value="Criminal Breach of Trust"></asp:ListItem>
                    <asp:ListItem Text="Arson" Value="Arson"></asp:ListItem>
                    <asp:ListItem Text="Cheating" Value="Cheating"></asp:ListItem>
                    <asp:ListItem Text="Counterfeiting" Value="Counterfeiting"></asp:ListItem>
                    <asp:ListItem Text="Other crime" Value="other Crime"></asp:ListItem>
                </asp:DropDownList>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDescription">Crime Description:</asp:Label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescription" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtCrimeCode">Crime Code:</asp:Label>
                <asp:TextBox runat="server" ID="txtCrimeCode" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtCrimeDate">Crime Date:</asp:Label>
                <asp:TextBox runat="server" TextMode="Date" ID="txtCrimeDate" /><span>DD-MM-YYYY</span>
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save & Continue" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>
