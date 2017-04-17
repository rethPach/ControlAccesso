function buscadorEmpleadosPorProyecto() {
	return {
		controller: function($scope) {
		},
		template:`
		<div class="panel panel-default" style="margin-top: 100px;">
			<div class="panel-heading">Seleccionar el Tipo de Proyecto</div>
			<div class="panel-body"  style="margin: 30px">
				<div class="col-xs-12" style="margin-bottom:35px;">
					<label>
				    	<input type="radio" ng-model="proyectoId" ng-value="'FUNCIONAL'">
				    	<span>Proyectos Funcionales.</span>
				  	</label><br/>
				  	<label>
				    	<input type="radio" ng-model="proyectoId" ng-value="'EXTERNO'">
				    	<span>Proyectos Internos/Externos/Ofertas.</span>
				  	</label>
				</div>

				<div class="col-xs-6">
					<ui-select ng-model="proyectoSeleccionado" 
						theme="bootstrap" ng-change="buscarEmpleados(proyectoSeleccionado)">
			            <ui-select-match 
			            	placeholder="Selecciona Proyecto">
			            	{{$select.selected.nombre}}
		            	</ui-select-match>
			            <ui-select-choices repeat="item in proyectos | filter: $select.search">
			              	<div ng-bind-html="item.nombre | highlight: $select.search"></div>
			              	<small ng-bind-html="item.code | highlight: $select.search"></small>
			            </ui-select-choices>
		          	</ui-select>
				</div>

				<div class="col-xs-6">
					<ui-select ng-model="empleadoSeleccionado" 
						theme="bootstrap" ng-change="trasitionToReportes(empleadoSeleccionado)">
			            <ui-select-match 
			            	placeholder="Selecciona Empleado">
			            	{{$select.selected.nombre}}
		            	</ui-select-match>
			            <ui-select-choices repeat="item in empleados | filter: $select.search">
			              	<div ng-bind-html="item.nombre | highlight: $select.search"></div>
			              	<small ng-bind-html="item.code | highlight: $select.search"></small>
			            </ui-select-choices>
		          	</ui-select>
				</div>			
			</div>
		</div>
		`
	}
}

module.exports = {
	name: 'buscadorEmpleadosPorProyecto',
	func: buscadorEmpleadosPorProyecto
}