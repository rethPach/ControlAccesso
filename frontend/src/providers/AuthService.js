function AuthService() {

	var _userAuth = {  };

	this.setUser = function(userAuth) {
		_userAuth = userAuth;
	}

	this.$get = [function() {
		return {
			getAuthUser: function() {
				return _userAuth;
			}
		}
	}];


}

module.exports = {
	name: 'AuthService',
	func: AuthService
}