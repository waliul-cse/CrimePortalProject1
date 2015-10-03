<%@ Page Title="crime zone information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crime-zone-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.crime_zone_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
    <script type="text/javascript">
        var geocoder = new google.maps.Geocoder();

        function geocodePosition(pos) {
            geocoder.geocode({
                latLng: pos
            }, function (responses) {
                if (responses && responses.length > 0) {
                    updateMarkerAddress(responses[0].formatted_address);
                } else {
                    updateMarkerAddress('Cannot determine address at this location.');
                }
            });
        }

        function updateMarkerStatus(str) {
            document.getElementById('markerStatus').innerHTML = str;
        }

        function updateMarkerPosition(latLng) {
            //document.getElementById('info').innerHTML = [
            //  latLng.lat(),
            //  latLng.lng()
            //].join(', ');
            document.getElementById('<%: txtlatitude.ClientID %>').value = latLng.lat();
            document.getElementById('<%: txtlongitude.ClientID %>').value = latLng.lng();
        }

        function updateMarkerAddress(str) {
            document.getElementById('address').innerHTML = str;
        }

        function initialize() {
            var latLng = new google.maps.LatLng(24.2444, 89.909);
            var map = new google.maps.Map(document.getElementById('mapCanvas'), {
                zoom: 8,
                center: latLng,
                mapTypeId: google.maps.MapTypeId.TERRAIN
            });
            var marker = new google.maps.Marker({
                position: latLng,
                title: 'Point A',
                map: map,
                draggable: true
            });

            // Update current position info.
            updateMarkerPosition(latLng);
            geocodePosition(latLng);

            // Add dragging event listeners.
            google.maps.event.addListener(marker, 'dragstart', function () {
                updateMarkerAddress('Dragging...');
            });

            google.maps.event.addListener(marker, 'drag', function () {
                updateMarkerStatus('Dragging...');
                updateMarkerPosition(marker.getPosition());
            });

            google.maps.event.addListener(marker, 'dragend', function () {
                updateMarkerStatus('Drag ended');
                geocodePosition(marker.getPosition());
            });
        }

        // Onload handler to fire off the app.
        google.maps.event.addDomListener(window, 'load', initialize);
    </script>
     <style>
        #mapCanvas {
            width: 500px;
            height: 400px;
            float: left;
        }

        #infoPanel {
            margin-left: 10px;
        }

            #infoPanel div {
                margin-bottom: 5px;
            }
    </style>
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
    <section id="loginForm">
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
                    <asp:Label runat="server" AssociatedControlID="txtBattalion">Battalion:</asp:Label>
                    <asp:TextBox runat="server" ID="txtBattalion" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="txtDistrict">District:</asp:Label>
                    <asp:TextBox runat="server" ID="txtDistrict" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="txtPoliceStation">Police Station:</asp:Label>
                    <asp:TextBox runat="server" ID="txtPoliceStation" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="txtVillage">Village:</asp:Label>
                    <asp:TextBox runat="server" ID="txtVillage" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="txtRemarks">Remarks:</asp:Label>
                    <asp:TextBox ID="txtRemarks" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="txtlatitude">Latitude:</asp:Label>
                    <asp:TextBox ID="txtlatitude" runat="server" />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="txtlongitude">Longitude:</asp:Label>
                    <asp:TextBox ID="txtlongitude" runat="server" />
                </li>
            </ol>
            <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
            <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
        </fieldset>
    </section>
    <section id="socialLoginForm">
        <div id="mapCanvas"></div>
        <div id="infoPanel">
            <b>Marker status:</b>
            <div id="markerStatus"><i>Click and drag the marker.</i></div>
                     
           </div>
    </section>
</asp:Content>
