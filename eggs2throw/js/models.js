app.factory('ajaxService', function ($resource) {

    return {
        getEvent: function () {
            return $resource('/api/', {}, {
                jData: { method: 'get', params: {}, isArray: true }
            });
        }
    }
});