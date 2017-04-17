function graficoResultadoReporte() {
	return {
		controller: function($scope) {

			setChart({
				totalHorasLaborables: 0,
				totalHorasLaboradas: 0
			});

			$scope.$watchCollection('reporte', setChart)

			function setChart(newValue, oldValue) {

				var reporte = newValue;

				var horasLaboradas = (
					reporte.totalHorasLaboradas - reporte.totalHorasLaborables 
				).toFixed(2);

				var horasSobretiempo = horasLaboradas>0?horasLaboradas:0;
				var horasPerdidas = horasLaboradas<0?horasLaboradas:0;

				$scope.horasEfectivasChart = {
					init: function() {
						this.setPorcentaje();
					},
					series: ['Sobretiempo', 'Horas Perdidas'],
					labels: [reporte.totalHorasLaborables +" Horas"],
					colors: ['#0fff02', '#ff0101'],
					data: [
						[horasSobretiempo],
						[horasPerdidas]
					],
					setPorcentaje: function() {
						var laboradas = reporte.totalHorasLaboradas;
						var laborables = reporte.totalHorasLaborables;
						var porcentaje = ((laboradas * 100) / laborables).toFixed(2);
						this.porcentaje = porcentaje + " %";
					}
				}

				$scope.horasEfectivasChart.init();
			}
		},
		template: `
		<div class="col-xs-12">
			<div class="panel panel-default">
				<div class="panel-heading">
					<span>Efectividad: </span>
					<span>{{horasEfectivasChart.porcentaje}}</span>
				</div>
			  	<div class="panel-body">
					<canvas id="bar" class="chart chart-bar"
						chart-colors="horasEfectivasChart.colors"
					  	chart-data="horasEfectivasChart.data" 
					  	chart-series="horasEfectivasChart.series"
					  	chart-labels="horasEfectivasChart.labels">
					</canvas    
			  	</div>
			</div>
		</div>
		`
	}
}

module.exports = {
	name: 'graficoResultadoReporte',
	func: graficoResultadoReporte
}