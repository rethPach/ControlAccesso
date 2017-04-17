function generarReporte() {
	return {
		scope: {
			onSubmit: '&'
		},
		controller: function($scope, $filter) {

			var formats = ['dd-MMMM-yyyy', 'yyyy/MM/dd', 'dd.MM.yyyy', 'shortDate'];

			function onCreate() {
				setDatePickerMin();
				setDatePickerMax();
				setCommand();

			} onCreate();

			function setCommand() {
				$scope.command = {
					minDate : new Date(),
					maxDate : new Date(),
				}
			}

			function setDatePickerMin() {
				$scope.datePickerMin = {
					format: formats[1],
					minDate: new Date(2014, 0, 1),
					maxDate: new Date(),
					label: 'Desde',
					closeText: 'Cerrar',
					opened: false,
					disabled: myDisabledDates,
					open: function() {
						this.opened = true;
					}
				};
			}

			function setDatePickerMax() {
				$scope.datePickerMax = {
					format: formats[1],
					minDate: new Date(2014, 0, 1),
					maxDate: new Date(),
					label: 'Hasta',
					closeText: 'Cerrar',
					opened: false,
					disabled: myDisabledDates,
					open: function() {
						this.opened = true;
					}
				};
			}

			function myDisabledDates(date, mode) {
        		return ( mode === 'day' && ( date.getDay() === 0 || date.getDay() === 6 ) );
    		}

    		function dateToFormatBacked(date) {
				return $filter('date')(date, "yyyy/M/d");	
			}


    		$scope.execute = function() {

    			var command = {
    				minDate: dateToFormatBacked($scope.command.minDate),
    				maxDate: dateToFormatBacked($scope.command.maxDate)
    			};

    			$scope.onSubmit({command: command});
    		}

    		$scope.$watch('command.minDate', function(newVal, oldVal) {
    			if(newVal == oldVal) return;
    			$scope.datePickerMax.minDate = newVal;
    			$scope.command.maxDate = "";
    		});


		},

		template: `
		<div class="panel panel-default">
			<div class="panel-heading">Generar Reportes:</div>
			<div class="panel-body">

				<div class="col-md-6">
	    			<nz-datapicker 
	    				config="datePickerMin" 
	    				model="command.minDate">
	    			</nz-datapicker>
     			</div>

		     	<div class="col-md-6">
			    	<nz-datapicker 
	    				config="datePickerMax" 
	    				model="command.maxDate">
	    			</nz-datapicker>
		     	</div>

		     	<div class="clearfix"></div>

				<div class="col-xs-12">
					<button
						ng-click="execute()" 
						type="submit" class="btn btn-primary btn-sm btn-block">
						<span>Visualizar</span>
					</button>
				</div>	

		  	</div>
		</div>
		`
	}
}

module.exports = {
	name: 'generarReporte',
	func: generarReporte
}