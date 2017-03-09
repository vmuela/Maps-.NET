var map;

function initMap() {
    map = new google.maps.Map(document.getElementById('divMap'), {
        center: { lat: 27.00, lng: -106.00 },
        scrollwheel: true,
        zoom: 5
    });
    
}