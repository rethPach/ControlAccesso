module.exports = {

	basePath: 'http://localhost:1474/api/',
	url: function(endPoint) {
		return this.basePath.concat(endPoint);
	}

};