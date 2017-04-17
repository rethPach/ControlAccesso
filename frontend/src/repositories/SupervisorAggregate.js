function SupervisorAggregate($q, $http) {

	var env = require('./env');

	this.getAllEmpleadosByProject = function(supervisorId, projectId) {

		var url = env.url('supervisor')
			.concat('/')
			.concat(supervisorId)
			.concat('/proyectos/')
			.concat(projectId);

		return $http.get(url).then(function(response) {
			return response.data;
		});
	};

	this.getProyectosFuncionales = getProyectos('proyectosFuncionales');

	this.getProyectosExternos = getProyectos('proyectosExternos'); 

	function getProyectos(proyectoType) {

		return function(supervisorId) {
			var url = env.url('supervisor')
			.concat('/')
			.concat(supervisorId)
			.concat('/')
			.concat(proyectoType);

			return $http.get(url).then(function(response) {
				return response.data;
			});
		}


	}

}

module.exports = {
	name: 'SupervisorAggregate',
	func: SupervisorAggregate
}