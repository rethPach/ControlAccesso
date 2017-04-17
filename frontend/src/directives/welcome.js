function welcome() {
	return {

		controller: function($scope, AuthService, $rootScope) {
			$scope.user = $rootScope.userAuth;
		},

		template: `
		<div id="navbar" class="navbar-collapse collapse">
	        <ul class="nav navbar-nav navbar-right">
	            <li uib-dropdown>
				    <a uib-dropdown-toggle>
				    	<span>Bienvenido: </span>
				    	<span>{{  user.username }}</span>
				    	<span class="caret"></span>
			    	</a>
				    <ul uib-dropdown-menu>
				        <li><a href="http://localhost:1474/Account/LogOn">Logout</a></li>
				    </ul>
				</li>
          	</ul>
        </div>
		`
	}
}

module.exports = {
	name: 'welcome',
	func: welcome
};