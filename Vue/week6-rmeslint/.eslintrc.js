module.exports = {
  root: true,
  env: {
    node: true
  },
  extends: [
    'plugin:vue/vue3-essential',
    '@vue/standard'
  ],
  parserOptions: {
    parser: '@babel/eslint-parser'
  },
  rules: {
    'no-console': process.env.NODE_ENV === 'production' ? 'warn' : 'off',
    'no-debugger': process.env.NODE_ENV === 'production' ? 'warn' : 'off',
    // 函數括號前的空格、後的空格
    // https://eslint.org/docs/rules/space-before-function-paren
    'space-before-function-paren': ['error', 'never'],
    'space-before-blocks': process.env.NODE_ENV === 'production' ? 'warn' : 'off',
    // 命名需要雙名稱 - 例外的名稱
    'vue/multi-word-component-names': ['error', { ignores: ['Form', 'Field'] }],
    // 縮排規格 - 關閉
    indent: 'off'
  }
}
