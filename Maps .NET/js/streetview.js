var panorama;
var YAW = 0;
var Pitch = 0;
var sv = new google.maps.StreetViewService();

function initialize() {
    var Ubicacion = new google.maps.LatLng(27.00, -106.00);

    var panoramaOptions =
        {
            position: Ubicacion,
            pov:
            {
                heading: 34,
                pitch: 10
            },
            visible: true
        };

    panorama = new google.maps.StreetViewPanorama(document.getElementById('divStreetView'), panoramaOptions);

    sv.getPanoramaByLocation(Ubicacion, 80, processSVData);
}

function processSVData(data, status) {
        panorama.setPano(data.location.pano);
}

function EstablecerUbicacion(Lat, Lon) {
    try {
        var Ubicacion = new google.maps.LatLng(Lat, Lon);
        sv.getPanoramaByLocation(Ubicacion, 80, processSVData);
    }
    catch (ex) {
    }
}
