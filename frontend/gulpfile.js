var elixir = require('laravel-elixir');
/*
 |--------------------------------------------------------------------------
 | Elixir Asset Management
 |--------------------------------------------------------------------------
 |
 | Elixir provides a clean, fluent API for defining some basic Gulp tasks
 | for your Laravel application. By default, we are compiling the Sass
 | file for our application, as well as publishing vendor resources.
 |
 */
elixir(function(mix) {

	mix

		.browserify('app.js', 'dist/js/app.js', 'src')

    	/*.sass('src/styles/sass/app.sass', 'dist/build_app_sass.css')

    	.styles([
    		//'dist/build_app_sass.css',

		], 'dist/css/app.css')
		
		.browserSync({
        	proxy: 'project.app'
    	});*/


});