<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Criminal-mobile-track.aspx.cs" Inherits="PoliceCrimePortal.Activities.Reports.Criminal_mobile_track" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style>
        html, body, #map-canvas {
            height: 100%;
            margin: 0px;
            padding: 0px;
        }
    </style>
    <script src="https://maps.googleapis.com/maps/api/js?v=3.exp&signed_in=true"></script>
    <script>
        var locations;
        function initialize() {

            var mapOptions = {
                zoom: 10,
                center: new google.maps.LatLng(24.2444, 89.909)
            }
            var map = new google.maps.Map(document.getElementById('map-canvas'),
                                          mapOptions);

            var info_window = new google.maps.InfoWindow({
                content: 'loading'
            });

            for (var i = 0; i < locations.length; i++) {
                var beach = locations[i];
                var beach1 = locations[i + 1];

                var myLatLng = new google.maps.LatLng(beach.lan, beach.long);
                var myLatLng1 = new google.maps.LatLng(beach1.lan, beach1.long);
                var m = new google.maps.Marker({
                    map: map,
                    animation: google.maps.Animation.DROP,
                    title: beach.currentTime,
                    position: myLatLng,
                    html: "test"
                });

                google.maps.event.addListener(m, 'click', function () {
                    info_window.setContent(this.html);
                    info_window.open(map, this);
                });

                var line = new google.maps.Polyline({
                    path: [myLatLng, myLatLng1],
                    strokeColor: "#FF0000",
                    strokeOpacity: 1.0,
                    strokeWeight: 10,
                    map: map
                });
            }
            //  3, 8, 12, 14, 20, 23

        }


        function searchMap() {
            $.ajax({
                type: "POST",
                url: "/Default2.aspx/GetData",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    if (msg.d !== "Null") {
                        locations = JSON.parse(msg.d);
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
            return false;
        }
        google.maps.event.addDomListener(window, 'load', searchMap);

    </script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

</asp:Content>
