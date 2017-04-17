function graficoCiclo() {
	return {
		controller: function($scope) {

			$scope.$watchCollection(
				'reporte.gruposCiclo.currentCiclo', 
				onCurrentCicloChange
			);

			function onCurrentCicloChange(newValue, oldValue) {
				var horasDiaLaboral = 8;
				var horasLaboradas = convertToHour(newValue.total.split(':'));
				var diferencia = (horasLaboradas-horasDiaLaboral).toFixed(2);
				
				var sobretiempo = diferencia>0?diferencia:0;
				var horasPedidas = diferencia<0?diferencia:0; 

				$scope.horasEfectivasCicloChart = {
					init: function() {
						this.setPorcentaje();
					},
					series: ['Sobretiempo', 'Perdidas'],
					labels: [horasDiaLaboral +" Horas"],
					data: [
						[sobretiempo],
						[horasPedidas]
					],
					colors: ['#0fff02', '#ff0101'],
					setPorcentaje: function() {
						var porcentaje = ((horasLaboradas * 100) / horasDiaLaboral).toFixed(2);
						this.porcentaje = porcentaje + "%";
					}
				}

				$scope.horasEfectivasCicloChart.init();


			}

			function convertToHour(hms) {
				var horas = +hms[0];
				var minutos = (+hms[1]) / 60;
				var segundos = (+hms[2]) / 3600;
				return (horas+minutos+segundos).toFixed(2);
			}
		},
		template: `
		<div class="col-xs-12">
			<div class="panel panel-default">
				<div class="panel-heading">
					<span>Efectividad: </span>
					<span>{{horasEfectivasCicloChart.porcentaje}}</span>
				</div>
			  	<div class="panel-body">
					<canvas id="bar" class="chart chart-bar"
					  chart-data="horasEfectivasCicloChart.data" 
					  chart-colors="horasEfectivasCicloChart.colors"
					  chart-series="horasEfectivasCicloChart.series"
					  chart-labels="horasEfectivasCicloChart.labels">
					</canvas    
			  	</div>
			</div>
		</div>
		`
	}
}

module.exports = {
	name: 'graficoCiclo',
	func: graficoCiclo
}