function reporteHoras($stateProvider) {

	$stateProvider.state('reportes_horas', {
		url: '/reportes_horas/:ssno',
		resolve: {
			empleado: function(EmpleadoAggregate, $stateParams) {
				return EmpleadoAggregate.find($stateParams.ssno);
			}
		},
		controller: function($scope, empleado, EmpleadoAggregate) {

			function onCreate() {
				$scope.generarReporte = generarReporte;
				setEmpleado();
				verResultados(false);
			} onCreate();

			function verResultados(mostrar) {
				$scope.verResultados = mostrar;
			}

			function setEmpleado() {
				$scope.empleado = empleado;
			}

			function generarReporte(command) {

				console.log(command);

				EmpleadoAggregate
					.getReporte(empleado.ssno, command)
					.then(setReporte);

			}

			function setReporte(reporte) {

				$scope.reporte = {
					init: function() {
						this.setTotalHoras();
						this.setGruposCiclo();
					},
					totalDiasLaborados: reporte.totalDiasLaborados,
					totalHorasLaborables: reporte.totalHorasLaborables,
					totalHorasLaboradas: reporte.totalHorasLaboradas.toFixed(2),
					setTotalHoras: function() {
						this.totalHoras = this.totalHorasLaboradas - this.totalHorasLaborables;
						this.totalHoras = this.totalHoras.toFixed(2);
					},
					setGruposCiclo: function() {
						this.gruposCiclo = {
							totalItems: reporte.ciclos.length,
							totalItemPerPage: 1,
							currentPage: 1,
							currentCiclo: reporte.ciclos[0],
							onPageChange: function() {
								var limit = this.totalItemPerPage;
								var offset = ((this.currentPage - 1) * limit);
								this.currentCiclo = reporte.ciclos.slice(
									offset, 
									(limit + offset)
								)[0];
							}
						};
					}
				};

				$scope.reporte.init();

				verResultados(true);
			}

		},
		template: `

		<style>
			.panel-body div span:first-child{
				font-weight: bold;
				margin-right: 2px;
			}
			.first-line {}
			.first-line__content {}
			.tab-wrapper {
				padding-top: 20px;
				padding-bottom: 20px;
			}
		</style>

		<div class="col xs-12 first-line">
			<div class="col-xs-5 first-line__content">
				<detalles-empleado 
					empleado="empleado">		
				</detalles-empleado>
			</div>
			<div class="col-xs-7 first-line__content">
				<generar-reporte 
					on-submit="generarReporte(command)">
				</generar-reporte>
			</div>
			<div class="clearfix"></div>
		</div>

		<div class="col xs-12 first-line" ng-if="verResultados">
			<div class="col-xs-12">
				<uib-tabset active="active">
			    	<uib-tab index="0" heading="Historico">
				    	<div class="tab-wrapper">
				    		<div class="col-xs-4">
					    		<table-resultado-reporte>
					    		</table-resultado-reporte>
				    		</div>
				    		<div class="col-xs-8">
				    			<grafico-resultado-reporte>
				    			</grafico-resultado-reporte>
				    		</div>
			    		</div>
			    	</uib-tab>
			    	<uib-tab index="1" heading="Detalles">
			    		<div class="tab-wrapper">
			    			<div class="col-xs-5">
					    		<table-resultado-ciclo>
					    		</table-resultado-ciclo>
				    		</div>
				    		<div class="col-xs-7">
				    			<grafico-ciclo>
				    			</grafico-ciclo>
				    		</div>
			    		</div>
			    	</uib-tab>
			  	</uib-tabset>

			</div>

		</div>

		`
	});

}

module.exports = reporteHoras;