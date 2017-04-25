fis.hook('relative');
//让所有文件，都使用相对路径。 
fis.match('**', {
	relative: true
})

fis.match('include/**', {
	release: false
});

fis.set('project.ignore', ['.git/**', 'fis-conf.js', '*.bat']);

fis.match('assets/css/*.scss', {
	rExt: '.css',
	parser: fis.plugin('node-sass'),
	packTo: '/assets/app.min.css'
})

// 清除其他配置，只保留如下配置
fis.match('/assets/js/**.js', {
	// fis-optimizer-uglify-js 插件进行压缩，已内置
	optimizer: fis.plugin('uglify-js', {
		mangle: {},
		compress: {
			drop_console: true
		}
	}),
	packTo: '/assets/app.min.js'
});

fis.match('*.css', {
	// fis-optimizer-clean-css 插件进行压缩，已内置
	optimizer: fis.plugin('clean-css')
});

fis.match('*.png', {
	// fis-optimizer-png-compressor 插件进行压缩，已内置
	optimizer: fis.plugin('png-compressor')
});

fis.set('date', Date.now());
fis.match('*.js', {
	query: '?t=' + fis.get('date')
});


fis.media('debug').match('*.{js,css,png}', {
	useHash: false,
	useSprite: false,
	optimizer: null
})

//fis.match('**', {
//  deploy: fis.plugin('local-deliver', {
//      to: '../debug'
//  })
//})