var map;

function initMap() {
    map = new google.maps.Map(document.getElementById('divMap'), {
        center: { lat: 27.00, lng: -106.00 },
        scrollwheel: true,
        zoom: 5
    });

    //Evento de Mouse Over
    google.maps.event.addListener(map, 'mousemove', function (event) {
        window.external.mapPositionChange(event.latLng.lat(), event.latLng.lng(), map.getZoom(), map.getCenter().lat(), map.getCenter().lng());
    });
    //Evento de Zoom Changed
    google.maps.event.addListener(map, 'zoom_changed', function () {
        window.external.mapZoomChange(map.getZoom());
    });

    google.maps.event.addListener(map, 'click', function (event) {
        try {
            window.external.mapClicked(event.latLng.lat(), event.latLng.lng());
        }
        catch (ex1) {

        }
    });
}

function setCenterAndZoom(lat, lon, zoom) {
    try {
        map.panTo(new google.maps.LatLng(lat, lon))
        if (zoom != 0) {
            map.setZoom(zoom);
        }
    }
    catch (ex) {
    }
}