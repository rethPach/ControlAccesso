function reporteBuscador($stateProvider) {

	$stateProvider.state('reporte_buscador', {
		url: '/reporte_buscador/:supervisorId',
		resolve: {
			proyectosExternos: function(SupervisorAggregate, $stateParams) {
				return SupervisorAggregate
					.getProyectosExternos($stateParams.supervisorId);
			},
			proyectosFuncionales: function(SupervisorAggregate, $stateParams) {
				return SupervisorAggregate
					.getProyectosFuncionales($stateParams.supervisorId);
			},
			supervisorId: function($stateParams) {
				return $stateParams.supervisorId;
			}
		},

		controller: function($scope, 
			proyectosExternos, 
			proyectosFuncionales,
			$state, 
			SupervisorAggregate,
			supervisorId
		) {

			var proyectosFuncionales = proyectosFuncionales;
			var proyectosExternos = proyectosExternos;
			var supervisorId = supervisorId;

			$scope.proyectos = [];
			$scope.buscarEmpleados = buscarEmpleados;
			$scope.trasitionToReportes = trasitionToReportes;
			$scope.empleados = [];

			$scope.$watch('proyectoId', setProyectos);

			function trasitionToReportes(empleado) {
				$state.go('reportes_horas', {ssno: empleado.ssno});
			}

			function buscarEmpleados(proyectoSeleccionado) {
				//console.log(proyectoSeleccionado);
				//console.log('implementat el repositorie');
				SupervisorAggregate
					.getAllEmpleadosByProject(supervisorId, proyectoSeleccionado.id)
					.then(setEmpleados);
			}

			function setEmpleados(empleados) {
				$scope.empleados = empleados;
			}

			function setProyectos(nuevo, old) {
				if(nuevo == old) return;

				if(nuevo == 'FUNCIONAL')
					$scope.proyectos = proyectosFuncionales;

				if(nuevo == 'EXTERNO')
					$scope.proyectos = proyectosExternos;

			}



		},
		template:`
		<div class="row">
			<buscador-empleados-por-proyecto>
			</buscador-empleados-por-proyecto>
		</div>
		`
		
	});

}

module.exports = reporteBuscador;