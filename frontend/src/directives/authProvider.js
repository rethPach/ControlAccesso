function authProvider() {
	return {
		scope: {
			authUserBackend: '@',
			loginPath: '@'
		},
		controller: function($scope, $rootScope, $state) {

			var user = JSON.parse($scope.authUserBackend);

			$rootScope.userAuth = user;

			$rootScope.$state = $state;

			$state.go('reporte_buscador', {supervisorId: user.id});


		},
		template: ``
	}
}

module.exports = {
	name: 'authProvider',
	func: authProvider
};