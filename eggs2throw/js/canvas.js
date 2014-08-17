var contexts = [];
var getCanvas = function () {
    $('canvas').each(function (i) {
        var c = document.getElementById('canvas' + (i+1));
        contexts[i] = c.getContext("2d");
    });
    for (var i = 0; i < contexts.length; i++) {
        var up = $('#up'+ (i+1)).text();
        var down = $('#down' + (i + 1)).text();
        var total = parseInt(up) + parseInt(down);
        var unit = 300/total;
        var x = up * unit || 0;
        contexts[i].fillStyle = 'rgb(210, 210, 20)';
        contexts[i].fillRect(0, 0, x, 150);
    }
}
setInterval(getCanvas, 1000);