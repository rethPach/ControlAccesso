function tableResultadoReporte() {
	return {
		controller: function($scope) {
			
			function onCreate() {
				setState();
			} onCreate();

			function setState() {
				$scope.state = 'success';
				$scope.simbol = '+';
				$scope.totalMensaje = 'Horas Sobretiempo';

				if($scope.reporte.totalHoras < 0) {
					$scope.state = 'danger';
					$scope.simbol = '';
					$scope.totalMensaje = 'Horas Perdidas';
				}

				if($scope.reporte.totalHoras == 0) {
					$scope.state = 'info';
					$scope.simbol = '';
					$scope.totalMensaje = 'Horas Cumplidas';
				}
			}
		},
		template: `
		<div class="panel panel-default">
		 	<div class="panel-heading">
		 		<span>Días Trabajados:</span>
		 		<span>{{reporte.totalDiasLaborados}}</span>
	 		</div>
	    	<table class="table table-bordered">
				<thead>
					<td>Descripción</td>
					<td>Horas</td>
				</thead>
				<tbody>
					<tr>
						<td>Horas Laborables</td>
						<td>{{reporte.totalHorasLaborables}}</td>
					</tr>
					<tr>
						<td>Horas Laboradas</td>
						<td>{{reporte.totalHorasLaboradas}}</td>
					</tr>
					<tr ng-class="state">
						<td>{{totalMensaje}}</td>
						<td>{{ simbol+""+reporte.totalHoras}}</td>
					</tr>
				</tbody>
			</table>
		</div>
		`
	}
}

module.exports = {
	name: 'tableResultadoReporte',
	func: tableResultadoReporte
}