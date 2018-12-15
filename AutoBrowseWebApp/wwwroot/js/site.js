// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
(function () {
    var fetchApi = (api, method) => {
        return fetch(api, { method: method })
            .then(function (response) {
                return response.json();
            }).catch(function (err) {
                console.error(err);
            });
    };

    var method = {
        get: 'get',
        post: 'post'
    };

    fetchApi('api/RandomRedirect', method.get)
        .then(data => {
            console.log(data);
            setTimeout(_ => window.location = `${data.redirectTo}`, data.waiting);
        });
})();
