function tableResultadoCiclo() {
	return {
		controller: function($scope) {
			//console.log($scope.reporte.gruposCiclo.currentCiclo);
			$scope.state = 'info';
			$scope.$watch('reporte.gruposCiclo.currentCiclo.total', function(newValue, oldValue) {
				var horasLaboradas = convertToHour(newValue.split(':'));
				var diferencia = horasLaboradas - 8;

				if(diferencia > 0)
					$scope.state = 'success';

				if(diferencia < 0)
					 $scope.state = 'danger';

			});

			function convertToHour(hms) {
				var horas = +hms[0];
				var minutos = (+hms[1]) / 60;
				var segundos = (+hms[2]) / 3600;
				return (horas+minutos+segundos).toFixed(2);
			}
		},
		template: `
		<div>
			
		</div>
		<div class="panel panel-default">
		 	<div class="panel-heading">
		 		<span class="pull-left">
		 			<span>Día: </span>
		 			<span>{{reporte.gruposCiclo.currentCiclo.dia | date:yyyy/mm/dd }}</span>
		 		</span>
		 		<span class="pull-right">
		 			<ul uib-pager 
		 				style="margin: 0px"
		 				previous-text="&lt;"
		 				next-text="&gt;"
		 				ng-change="reporte.gruposCiclo.onPageChange()"
		 				items-per-page="reporte.gruposCiclo.totalItemPerPage"
		 				total-items="reporte.gruposCiclo.totalItems" 
		 				ng-model="reporte.gruposCiclo.currentPage">
	 				</ul>
		 		</span>
		 		<div class="clearfix"></div>
	 		</div>
	    	<table class="table table-bordered">
				<thead>
					<td>Ciclo</td>
					<td>Entrada</td>
					<td>Salida</td>
					<td>Duracion</td>
				</thead>
				<tbody>
					<tr ng-repeat="ciclo in reporte.gruposCiclo.currentCiclo.ciclos | orderBy: 'entrada' ">
						<td>{{$index + 1}}</td>
						<td>{{ciclo.entrada}}</td>
						<td>{{ciclo.salida}}</td>
						<td>{{ciclo.duracion}}</td>
					</tr>
					<tr ng-class="state">
						<td colspan="3">Total</td>
						<td>{{reporte.gruposCiclo.currentCiclo.total}}</td>
					</tr>
				</tbody>
			</table>
		</div>
		`
	}
}

module.exports = {
	name: 'tableResultadoCiclo',
	func: tableResultadoCiclo
}