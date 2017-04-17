function nzDatapicker() {
	return {
		scope: {
			config : '=',
			model: '='
		},
		controller: function($scope) {
			/**
			| ejemplo de datapicker:
			|	var formats = ['dd-MMMM-yyyy', 'yyyy/MM/dd', 'dd.MM.yyyy', 'shortDate']
			|   $scope.config = {
			|		format: formats[1],
			|		minDate: new Date(2000, 1, 1),
			|		maxDate: new Date(),
			|       closeText: 'Cerrar',
			|		label: '',
			|		opened: false,
			|		disabled: myDisabledDates,
			|		open: function() {
			|			this.opened = true;
			|		}
			|	};
			|	function myDisabledDates(date, mode) {
	        |		return ( mode === 'day' && ( date.getDay() === 0 || date.getDay() === 6 ) );
	    	|	}
			*/
		},
		template: `
		<label>{{config.label}}</label>
		<p class="input-group input-group-sm">
  			<input 
          		type="text" 
          		class="form-control" 
          		uib-datepicker-popup="{{config.format}}" 
          		ng-model="model" 
          		is-open="config.opened" 
          		datepicker-options="config.options"
          		min-date="config.minDate"
          		max-date="config.maxDate"
          		date-disabled="config.disabled(date, mode)"
          		close-text="config.closeText" 
          		readonly="readonly" />

          	<span class="input-group-btn">
            	<button 
            		type="button" 
            		class="btn btn-default" 
            		ng-click="config.open()">
        			<i class="glyphicon glyphicon-calendar"></i>
        		</button>
          	</span>
		</p>
		`
	}
}

module.exports = {
	name: 'nzDatapicker',
	func: nzDatapicker 
}