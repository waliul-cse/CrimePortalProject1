<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crime-hot-zone.aspx.cs" Inherits="PoliceCrimePortal.Activities.Reports.crime_hot_zone" %>

<asp:Content ID="ddd" runat="server" ContentPlaceHolderID="HeadContent">
    <script src="https://maps.googleapis.com/maps/api/js?v=3.exp&signed_in=true"></script>
    <script>
        // The following example creates complex markers to indicate beaches near
        // Sydney, NSW, Australia. Note that the anchor is set to
        // (0,32) to correspond to the base of the flagpole.

        var beaches;

        function initialize() {
            var mapOptions = {
                zoom: 10,
                center: new google.maps.LatLng(24.2444, 89.909)
            }
            var map = new google.maps.Map(document.getElementById('map-canvas'),
                                          mapOptions);

            setMarkers(map, beaches);
        }


        var infowindow = new google.maps.InfoWindow({
            content: "docbbbbbb"
        });
        function setMarkers(map, locations) {
            var shape = {
                coords: [1, 1, 1, 20, 18, 20, 18, 1],
                type: 'poly'
            };
            for (var i = 0; i < locations.length; i++) {
                var beach = locations[i];                
                var myLatLng = new google.maps.LatLng(beach.lat, beach.long);
               // var myLatLng = new google.maps.LatLng(beach[1], beach[2]);
              //  alert(myLatLng);
                var marker = new google.maps.Marker({
                    position: myLatLng,
                    map: map,
                    shape: shape,
                    title: beach.crimetype,
                    zIndex: 1
                });

                google.maps.event.addListener(marker, 'click', function () {
                    // where I have added .html to the marker object.
                    infowindow.setContent(beach.crimetype +"\n"+ beach.description);
                    infowindow.open(map, this);
                });
            }
        }
        // google.maps.event.addDomListener(window, 'load', initialize);
        function searchMap() {
            var shipList = document.getElementById('<%=ddlCrimeType.ClientID%>');
            var shipCost = shipList.options[shipList.selectedIndex].value
            $.ajax({
                type: "POST",
                url: "/Activities/Reports/crime-hot-zone.aspx/GetData",
                data: "{'crimeType':'" + shipCost + "','fromDate':'12-02-2013','todate':'12-02-2016'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    alert(msg.d);
                    if (msg.d !== "Null") {
                        beaches = JSON.parse(msg.d);
                        
                        initialize();
                    }
                    else {
                        alert("No Data found!!!");
                    }
                        
                },
                error: function (result) {
                    alert("Error");
                }
            });
           
            // 
            return false;
        }
    </script>
    <style>
        #map-canvas {
            height: 100%;
            margin: 0px;
            padding: 0px;
        }
    </style>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to disply Crime spot.</h2>
    </hgroup>
    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <p class="message-success">
        <asp:Literal runat="server" ID="SuccessMessage" />
    </p>
    <fieldset>
        <legend></legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="ddlCrimeType">Crime Type:</asp:Label>
                <asp:DropDownList ID="ddlCrimeType" runat="server">
                    <asp:ListItem Text="All" Value="All"></asp:ListItem>
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
                <%--<select id="ddlCrimeType" name="ddlCrimeType">
                    <option value="All" selected="selected">All</option>
                    <option value="Muder for gain">Muder for gain</option>
                    <option value="Dacoity">Dacoity</option>
                    <option value="Prep &amp; Assembly for Dacoity">Prep &amp; Assembly for Dacoity</option>
                    <option value="Robbery">Robbery</option>
                    <option value="Burglary">Burglary</option>
                    <option value="Theft">Theft</option>
                    <option value="Murder">Murder</option>
                    <option value="Attempt to commit murder">Attempt to commit murder</option>
                    <option value="C.H.Not Amounting to murder">C.H.Not Amounting to murder</option>
                    <option value="Hurt/Grievous Hurt">Hurt/Grievous Hurt</option>
                    <option value="Roits">Roits</option>
                    <option value="Rape">Rape</option>
                    <option value="Dowry Death">Dowry Death</option>
                    <option value="Molestation">Molestation</option>
                    <option value="Sexual Harassment">Sexual Harassment</option>
                    <option value="Cruelty by Husband and her relatives">Cruelty by Husband and her relatives</option>
                    <option value="Kidnapping &amp; Abduction of others">Kidnapping &amp; Abduction of others</option>
                    <option value="Criminal Breach of Trust">Criminal Breach of Trust</option>
                    <option value="Arson">Arson</option>
                    <option value="Cheating">Cheating</option>
                    <option value="Counterfeiting">Counterfeiting</option>
                    <option value="other Crime">Other crime</option>

                </select>--%>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtfromdate">From Date:</asp:Label>
                <asp:TextBox runat="server" TextMode="Date" ID="txtfromdate" />
                <asp:Label runat="server" AssociatedControlID="txttodate">To Date:</asp:Label>
                <asp:TextBox runat="server" TextMode="Date" ID="txttodate" /><span>DD-MM-YYYY</span>
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Search" OnClientClick="return searchMap();" />
    </fieldset>
    <div style="width: 100%; height: 500px;">
        <div id="map-canvas"></div>
    </div>
</asp:Content>
