var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('Boiler');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);