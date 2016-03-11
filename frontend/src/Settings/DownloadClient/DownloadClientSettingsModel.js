var SettingsModelBase = require('../SettingsModelBase');

module.exports = SettingsModelBase.extend({
  url: window.Sonarr.ApiRoot + '/config/downloadclient',
  successMessage: 'Download client settings saved',
  errorMessage: 'Failed to save download client settings'
});
