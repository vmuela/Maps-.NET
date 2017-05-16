var map;

function initMap() {
    map = new Microsoft.Maps.Map(document.getElementById('divMap'), {
        credentials: 'Your Bing Maps Key'
    });

    map.setView({
        center: new Microsoft.Maps.Location(27.00, -106.00),
        zoom: 5
    });

    Microsoft.Maps.Events.addHandler(map, 'mousemove', function (e) {
        var point = new Microsoft.Maps.Point(e.getX(), e.getY());
        var loc = e.target.tryPixelToLocation(point);

        window.external.mapPositionChange(loc.latitude, loc.longitude, map.getZoom(), map.getCenter().latitude, map.getCenter().longitude);
    });

    Microsoft.Maps.Events.addHandler(map, 'click', function (e) {
        var point = new Microsoft.Maps.Point(e.getX(), e.getY());
        var loc = e.target.tryPixelToLocation(point);

        window.external.mapClicked(loc.latitude, loc.longitude);
    });
    
}

function setCenterAndZoom(lat, lon, zoom) {
    try {
        map.setView({
            center: new Microsoft.Maps.Location(lat, lon)
        });

        if (zoom != 0) {
            map.setView({
                zoom: zoom
            });
        }
    }
    catch (ex) {
    }
}