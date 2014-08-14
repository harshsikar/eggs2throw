eggs2throw.factory('ajaxService', function ($resource) {

    return {
        getEvent: function () {
            return $resource('/api/List', {}, {
                jData: { method: 'get', params: {}, isArray: true }
            });
        }
    }
});