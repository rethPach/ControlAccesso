var angular = require('angular');

require('angular-chart.js');
require('ui-select');

module.exports = require('./core/ModuleFactory').create(angular, {

	name: 'app',

	dependencies: [
		require('angular-bootstrap-npm'),
		require('angular-ui-router'),
		require('angular-sanitize'),
		'ui.select',
		'chart.js'
	],

	directives: [
		require('./directives/welcome'),
		require('./directives/logo'),
		require('./directives/detallesEmpleado'),
		require('./directives/generarReporte'),
		require('./directives/graficoResultadoReporte'),
		require('./directives/nzDatapicker'),
		require('./directives/tableResultadoReporte'),
		require('./directives/tableResultadoCiclo'),
		require('./directives/graficoCiclo'),
		require('./directives/authProvider'),
		require('./directives/buscadorEmpleadosPorProyecto'),
		require('./directives/botonBack')
	],

	services: [
		require('./repositories/SupervisorAggregate'),
		require('./repositories/EmpleadoAggregate')
	],

	providers: [
		require('./providers/AuthService')
	],

	config: function($stateProvider, AuthServiceProvider) {

		var states = [
			require('./states/reportes/reporteHoras'),
			require('./states/reportes/reporteBuscador')
		];

		states.forEach(function(state) {
			state($stateProvider);
		});

	}

});
