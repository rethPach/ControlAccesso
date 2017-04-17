function EmpleadoAggregate($http) {

	var env = require('./env');

	this.find = function(ssno) {
		var url = env.url('empleado')
		.concat('/')
		.concat(ssno);

		return $http.get(url).then(function(response) {
			return response.data;
		});
	}

	this.getReporte = function(ssno, command) {

		var url = env.url('empleado')
		.concat('/')
		.concat(ssno)
		.concat('/')
		.concat('reporte');

		return $http.get(url, {params: command}).then(function(response) {
			return response.data;
		});

	}

}

module.exports = {
	name: 'EmpleadoAggregate',
	func: EmpleadoAggregate
};