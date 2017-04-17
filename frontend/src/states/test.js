function test($stateProvider) {
	$stateProvider.state('test', {
		url: '/test',
		controller: function($scope, AuthService) {
			$scope.mensaje = "Nuekvo Mensaje";
			$scope.username = AuthService.getAuthUser();
		},
		template: `
		<div>
			{{ username | json }}
		</div>
		`
	});
}

module.exports = test;