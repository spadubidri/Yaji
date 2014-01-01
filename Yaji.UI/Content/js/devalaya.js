
//function showAddress() {
//    var address = "Janardhana Temple Yermal";
//    var map = new GMap2(document.getElementById("map"));
//    map.addControl(new GSmallMapControl());
//    map.addControl(new GMapTypeControl());
//    geocoder = new GClientGeocoder();

//    if (geocoder) {
//        geocoder.getLatLng(
//          address,
//          function (point) {
//              if (!point) {
//                  alert(address + " not found");
//              } else {
//                  map.clearOverlays()
//                  map.setCenter(point, 14);
//                  var marker = new GMarker(point, { draggable: true });
//                  map.addOverlay(marker);

//                  GEvent.addListener(marker, "dragend", function () {
//                      var pt = marker.getPoint();
//                      map.panTo(pt);
//                  });


//                  GEvent.addListener(map, "moveend", function () {
//                      map.clearOverlays();
//                      var center = map.getCenter();
//                      var marker = new GMarker(center, { draggable: true });
//                      map.addOverlay(marker);

//                      GEvent.addListener(marker, "dragend", function () {
//                          var pt = marker.getPoint();
//                          map.panTo(pt);
//                      });

//                  });

//              }
//          }
//        );
//    }
//}