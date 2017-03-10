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
}