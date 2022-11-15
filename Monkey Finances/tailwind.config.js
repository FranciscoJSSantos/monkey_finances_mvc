/** @type {import('tailwindcss').Config} */

const colors = require('tailwindcss/colors');

module.exports = {
    purge: {
        enabled: true,
        content: [
            '!**/{bin,obj,node_modules}/**',
            '**/*.{cshtml,html}',
            './**/*.razor'
        ]
    },
    theme: {
        extend: {},
    },
    corePlugins: {
        preflight: false,
    },
    //prefix: 'tw-',
    plugins: [],
}