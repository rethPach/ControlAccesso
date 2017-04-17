function detallesEmpleado() {
	return {
		scope: {
			empleado: '='
		},
		controller: function($scope) {},
		template: `
		<div class="panel panel-default">
			<div class="panel-heading">Detalles de empleado:</div>
			<div class="panel-body">
		    	<div>
		    		<span>Nombre:</span>
		    		<span>{{ empleado.nombre }}</span>
		    	</div>
		    	<div>
		    		<span>Apellido:</span>
		    		<span>{{ empleado.apellido }}</span>
		    	</div>
		    	<div>
		    		<span>SSNO:</span>
		    		<span>{{ empleado.ssno }}</span>
		    	</div>
		    	<div>
		    		<span>Departameto:</span>
		    		<span>{{ empleado.departamento }}</span>
		    	</div>
		  	</div>
		</div>
		`
	}
}

module.exports = {
	name: 'detallesEmpleado',
	func: detallesEmpleado
};